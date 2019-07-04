using System;
using System.Windows.Forms;

namespace BooksAndCourses.WinForms
{
    public partial class AuthorForm : Form
    {
        internal string Model { get; set; }

        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            Text = string.IsNullOrEmpty(Model) ? "Добавление" : "Редактирование";
            Text += " автора";
            textAuthor.Text = Model;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Model = textAuthor.Text;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Model = null;
            Close();
        }
    }
}
