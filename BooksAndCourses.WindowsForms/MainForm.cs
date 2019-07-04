using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Models;
using Models.AbstractClasses;
using Models.Interfaces;
using System.IO;
using System.Xml.Serialization;


namespace BooksAndCourses.WinForms
{
    public partial class MainForm : Form
    {
        private Library _currentLibrary;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            InitSources();
        }

        private void InitSources()
        {
            _currentLibrary = LibInitializer.InitLibrary();

            InitDgv();
            ReloadData();
        }

        private void InitDgv()
        {
            dgvResources.ColumnCount = 4;
            foreach (DataGridViewColumn column in dgvResources.Columns)
            {
                column.ReadOnly = true;
            }
            dgvResources.Columns[0].Name = "Тип";
            dgvResources.Columns[0].Width = 50;
            dgvResources.Columns[1].Name = "Год";
            dgvResources.Columns[1].Width = 50;
            dgvResources.Columns[2].Name = "Автор";
            dgvResources.Columns[2].Width = 150;
            dgvResources.Columns[3].Name = "Наименование";
            dgvResources.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvResources.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ReloadData()
        {
            statusLabel.Text = "Всего: " + _currentLibrary.Resources.Count + " объектов в библиотеке";
            ReloadDgv(_currentLibrary.Resources);
        }

        private void ReloadDgv(ICollection<LibResource> resources)
        {
            dgvResources.Rows.Clear();

            if (resources.Count > 0)
            {
                dgvResources.RowCount = resources.Count;

                for (int i = 0; i < resources.Count; i++)
                {
                    LibResource resource = resources.ElementAt(i);
                    dgvResources.Rows[i].HeaderCell.Value = i;

                    dgvResources.Rows[i].Cells[0].Value = resource.FindType();
                    dgvResources.Rows[i].Cells[1].Value = resource.Year;
                    dgvResources.Rows[i].Cells[2].Value = resource.FindAuthor();
                    dgvResources.Rows[i].Cells[3].Value = resource.Title;
                }
            }
        }

        private void ReloadTree(LibResource resource)
        {
            treeProperties.Nodes.Clear();

            Type myType = resource.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

            foreach (PropertyInfo property in props)
            {
                object value = property.GetValue(resource);
                if (value == null) continue;
                TreeNode node = CreateNode(property.Name, value);
                treeProperties.Nodes.Add(node);
            }
            
            TreeNode CreateNode(string name, object value)
            {
                TreeNode node = new TreeNode(name);
                switch (value)
                {
                    case IEnumerable<IOrdered> list:
                        node.Nodes.AddRange(CreateInnerNodes(list));
                        break;
                    case IEnumerable<Link> links:
                        foreach (Link link in links)
                        {
                            node.Nodes.Add(new TreeNode($"{link.Title} ({link.Path})"));
                        }
                        break;
                    case IEnumerable<string> strings:
                        foreach (string str in strings)
                        {
                            node.Nodes.Add(new TreeNode(str));
                        }
                        break;
                    default:
                        node.Text += " " + value;
                        break;
                }
                return node;
            }

            TreeNode[] CreateInnerNodes(IEnumerable<IOrdered> parts)
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var part in parts)
                {
                    TreeNode innerNode = new TreeNode(part.Order + ". " + (part as ITitled)?.Title);

                    List<IOrdered> subDivisions = new List<IOrdered>();
                    switch (part)
                    {
                        case Chapter chapter:
                            if (chapter.SubChapters != null)
                                subDivisions.AddRange(chapter.SubChapters);
                            break;
                        case VideoSection section:
                            if (section.Sections != null)
                                subDivisions.AddRange(section.Sections);
                            if (section.Fragments != null)
                                subDivisions.AddRange(section.Fragments);
                            break;
                    }

                    if (subDivisions.Count > 0)
                    {
                        TreeNode[] children = CreateInnerNodes(subDivisions);
                        innerNode.Nodes.AddRange(children);
                    }
                    nodes.Add(innerNode);
                    //innerNode.Text = innerNode.Name;
                }
                return nodes.ToArray();
            }
        }
        

        #region EventHandlers
        private void dgvResources_CurrentCellChanged(object sender, System.EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null || dgv.Rows.Count == 0) return;
            int rowIndex = CurrentRowIndex(dgv);
            LibResource currentResource = _currentLibrary.Resources[rowIndex];
            ReloadTree(currentResource);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EditLibResourceForm addForm = new EditLibResourceForm();
            addForm.Model = new Book();
            addForm.IsNew = true;
            addForm.Text = "Добавление ресурса";
            addForm.ShowDialog();
            _currentLibrary.Resources.Add(addForm.Model);
            ReloadData();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.dgvResources;
            int rowIndex = CurrentRowIndex(dgv);
            var model = _currentLibrary.Resources.ElementAt(rowIndex);
            _currentLibrary.Resources.RemoveAt(rowIndex);
            ReloadData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.dgvResources;
            int rowIndex = CurrentRowIndex(dgv);
            EditLibResourceForm addForm = new EditLibResourceForm();
            addForm.Model = _currentLibrary.Resources.ElementAt(rowIndex);
            addForm.ShowDialog();
            _currentLibrary.Resources.RemoveAt(rowIndex);
            _currentLibrary.Resources.Insert(rowIndex, addForm.Model);
            ReloadData();
        }
        #endregion

        private int CurrentRowIndex(DataGridView dgv)
        {
            DataGridViewRow currentRow = dgv.CurrentRow;
            int? rowIndex = currentRow?.HeaderCell.Value as int?;
            if (rowIndex == null) rowIndex = 0;
            return rowIndex.Value;
        }

        private void Unload_Click(object sender, EventArgs e)
        {
            long FileLength = 0;

            string Directory = "";

            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
               Directory = FBD.SelectedPath;
            }

            XmlSerializer formatter = new XmlSerializer(typeof(LibResource[]));

            
            using (FileStream fs = new FileStream(Directory +"\\unload.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _currentLibrary.Resources.ToArray());
                FileLength = fs.Length; 
            }


            MessageBox.Show("Выгружен файл, размер файла: " + FileLength + " байт");



        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "xml файл|*.xml";
            if (OFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OFD.FileName;


            XmlSerializer formatter = new XmlSerializer(typeof(LibResource[]));


            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                LibResource[] newlib = (LibResource[])formatter.Deserialize(fs);

                var library = Library.GetInstance();
                library.Resources = newlib.ToList<LibResource>();

                _currentLibrary = library;
                ReloadDgv(newlib);
                //foreach (LibResource lr in newlib)
                //{
                //    ReloadTree(lr);
                //}
            }



            

        }

       
    }
}