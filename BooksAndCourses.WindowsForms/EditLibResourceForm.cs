using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Models;
using Models.AbstractClasses;
using BooksAndCourses.Resources;

namespace BooksAndCourses.WinForms
{
    public partial class EditLibResourceForm : Form
    {
        private readonly string[] _resourceTypes = new []{ "Книга" , "Видеокурс", "Интернет-ресурс"};
        internal bool IsNew { private get; set; } = false;
        internal LibResource Model { get; set; }

        public EditLibResourceForm()
        {
            InitializeComponent();
            comboResourceTypes.DataSource = _resourceTypes;
            authorsAddBtn.Image = linksAddBtn.Image = Image.FromStream(ResourceHelper.GetResource("Pictures/Add_16x.png"));
            authorsRemoveBtn.Image = linksRemoveBtn.Image = Image.FromStream(ResourceHelper.GetResource("Pictures/Remove_16x.png"));
            authorsEditBtn.Image = Image.FromStream(ResourceHelper.GetResource("Pictures/Edit_16x.png"));
            pictureRefreshBtn.Image = descriptionRefreshBtn.Image = Image.FromStream(ResourceHelper.GetResource("Pictures/Refresh_16x.png"));
        }

        private void EditLibResourceForm_Load(object sender, EventArgs e)
        {
            if (Model == null)
            {
                IsNew = true;
                Model = new Book();
            }
            Init();
        }

        private void Init()
        {
            InitResource();
            InitByType();
        }

        private void InitResource()
        {
            listThemes.DataSource = LibInitializer.InitThemes();
            switch (Model)
            {
                case Book book: comboResourceTypes.Text = _resourceTypes[0]; break;
                case VideoCourse course: comboResourceTypes.Text = _resourceTypes[1]; break;
                case InternetResource resource: comboResourceTypes.Text = _resourceTypes[2]; break;
            }
            if (!IsNew) comboResourceTypes.Enabled = false;

            textBoxTitle.Text = Model.Title;
            SelectListItems(Model.Themes, listThemes);
            string[] authors = Model.Authors;
            if (authors != null)
            {
                listAuthors.Items.AddRange(authors);
            }
            dgvLinks.DataSource = Model.Links;
            numericYear.Text = Model.Year.ToString();

            textBoxCover.Text = Model.PathToCover;
            SetCover();
            textBoxDescriptionLink.Text = Model.PathToDescription;
            SetDescription();
        }

        private void InitByType()
        {
            switch (Model)
            {
                case Book book:
                    InitBookScreen();
                    InitBook();
                    break;
                case VideoCourse course:
                    InitVideoScreen();
                    InitVideo();
                    break;
                case InternetResource resource:
                    InitInternetResourceScreen();
                    InitInternetResource();
                    break;
            }
        }

        private void InitBookScreen()
        {
            HideVideo();
            HideInternetResource();
            labelPages.Visible = numericPages.Visible = true;
            labelPublishment.Visible = textBoxPublishment.Visible = true;
            labelEdition.Visible = numericEdition.Visible = true;
        }

        private void InitVideoScreen()
        {
            HideBook();
            HideInternetResource();
            labelLength.Visible = numericLength.Visible = true;
        }

        private void InitInternetResourceScreen()
        {
            HideBook();
            HideVideo();
            labelMainLink.Visible = textBoxMainLink.Visible = true;
        }

        private void InitBook()
        {
            numericPages.Text = (Model as Book)?.Pages.ToString();
            textBoxPublishment.Text = (Model as Book)?.Publishment;
            numericEdition.Text = (Model as Book)?.Edition.ToString();

            panelDivisions.Visible = true;
            labelDivisions.Text = "Главы";
        }

        private void InitVideo()
        {
            numericLength.Text = (Model as VideoCourse)?.Length.ToString();

            panelDivisions.Visible = true;
            labelDivisions.Text = "Секции";
        }

        private void InitInternetResource()
        {
            textBoxMainLink.Text = (Model as InternetResource)?.MainLink;
            panelDivisions.Visible = false;
        }

        private void HideBook()
        {
            labelPages.Visible = numericPages.Visible = false;
            labelPublishment.Visible = textBoxPublishment.Visible = false;
            labelEdition.Visible = numericEdition.Visible = false;
        }

        private void HideVideo()
        {
            labelLength.Visible = numericLength.Visible = false;
        }

        private void HideInternetResource()
        {
            labelMainLink.Visible = textBoxMainLink.Visible = false;
        }

        private void SelectListItems(IEnumerable<string> collection, ListBox listBox)
        {
            if (collection == null) return;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                var theme = listBox.Items[i];
                listBox.SetSelected(i, collection.Contains(theme.ToString()));
            }
        }
        
        private void SetCover()
        {
            string path = textBoxCover.Text;
            Stream picture = ResourceHelper.GetResource(@"Pictures/" + path);
            if (picture != null) pictureCover.Image = Image.FromStream(picture);
            else textBoxCover.Text = Model.PathToCover;
        }

        private void SetDescription()
        {
            string path = textBoxDescriptionLink.Text;
            //string text = LibInitializer.ReadDescription(path);
            //if (string.IsNullOrEmpty(text)) textBoxDescriptionLink.Text = Model.PathToDescription;
            //else textBoxDescription.Text = text;
        }
        
        private void SaveToModel(LibResource oldModel)
        {
            SaveCommonPart(oldModel);
            SaveSpecificPart();
        }

        private void SaveCommonPart(LibResource oldModel)
        {
            Model.Title = textBoxTitle.Text;
            SetThemes();
            SetAuthors();
            SetLinks();
            if (int.TryParse(numericYear.Text, out int year))
                Model.Year = year;
            else Model.Year = oldModel.Year;

            SetCover();
            Model.PathToCover = textBoxCover.Text;
            SetDescription();
            Model.PathToDescription = textBoxDescriptionLink.Text;

            void SetThemes()
            {
                if (Model.Themes == null) return;
                Model.Themes.Clear();
                foreach (object item in listThemes.SelectedItems)
                {
                    Model.Themes.Add(item.ToString());
                }
            }

            void SetAuthors()
            {
                List<string> newAuthors = new List<string>();
                foreach (object item in listAuthors.Items)
                {
                    newAuthors.Add(item.ToString());
                }
                Model.Authors = newAuthors.ToArray();
            }

            void SetLinks()
            {
                List<Link> newLinks = new List<Link>();
                foreach (DataGridViewRow row in dgvLinks.Rows)
                {
                    newLinks.Add(new Link { Title = row.Cells[0].Value.ToString(), Path = row.Cells[1].Value.ToString() });
                }
                Model.Links = newLinks;
            }
        }

        private void SaveSpecificPart()
        {
            switch (Model)
            {
                case Book book:
                    if (int.TryParse(numericPages.Text, out int pages))
                        book.Pages = pages;
                    book.Publishment = textBoxPublishment.Text;
                    if (int.TryParse(numericEdition.Text, out int edition))
                        book.Edition = edition;
                    break;
                case VideoCourse course:
                    if (int.TryParse(numericLength.Text, out int length))
                        course.Length = length;
                    break;
                case InternetResource resource:
                    resource.MainLink = textBoxMainLink.Text;
                    break;
            }
        }

        #region EventHandlers
        private void comboResourceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Model == null || !IsNew) return;
            LibResource oldModel = Model;
            if (comboResourceTypes.Text.Equals(_resourceTypes[0])) Model = new Book();
            else if (comboResourceTypes.Text.Equals(_resourceTypes[1])) Model = new VideoCourse();
            else if (comboResourceTypes.Text.Equals(_resourceTypes[2])) Model = new InternetResource();
            else return;
            SaveToModel(Model);
            InitByType();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveToModel(Model);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureRefreshBtn_Click(object sender, EventArgs e)
        {
            SetCover();
        }

        private void descriptionRefreshBtn_Click(object sender, EventArgs e)
        {
            SetDescription();
        }

        private void authorsAddBtn_Click(object sender, EventArgs e)
        {
            AuthorForm addForm = new AuthorForm();
            addForm.Model = string.Empty;
            addForm.ShowDialog();
            if (addForm.Model != null) listAuthors.Items.Add(addForm.Model);
        }

        private void authorsEditBtn_Click(object sender, EventArgs e)
        {
            AuthorForm addForm = new AuthorForm();
            addForm.Model = listAuthors.Text;
            addForm.ShowDialog();
            int index = listAuthors.SelectedIndex;
            if (addForm.Model != null) listAuthors.Items.RemoveAt(index);
            listAuthors.Items.Insert(index, addForm.Model);
        }

        private void authorsRemoveBtn_Click(object sender, EventArgs e)
        {
            if (listAuthors.Items.Count < 2)
            {
                MessageBox.Show("Нельзя удалить последнего автора!");
                return;
            }
            int rowIndex = listAuthors.SelectedIndex;
            listAuthors.Items.RemoveAt(rowIndex);
        }
        #endregion
    }
}
