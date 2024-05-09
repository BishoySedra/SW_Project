using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System.Repository.MagazineRepository;
using Magazine_Management_System.Repository.CategoryRepository;
using Magazine_Management_System.Repository.ArticleRepository;
using Magazine_Management_System.Model;

namespace Magazine_Management_System
{
    public partial class AuthorForm : Form
    {
        int AuthorID;
        MagazineRepository magazineRepository = new MagazineRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        ArticleRepository articleRepository = new ArticleRepository();
        public AuthorForm(int authorID)
        {
            InitializeComponent();
            AuthorID = authorID;
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            List<Magazine> magazines = magazineRepository.GetAllMagazines();
            if (magazines != null)
            {
                foreach (Magazine magazine in magazines)
                {
                    magazineComboBox.Items.Add(magazine.Id + " " + magazine.Name);
                }
            }
            List<Category> categories = categoryRepository.GetAllCategories();
            if (categories != null)
            {
                foreach (Category category in categories)
                {
                    categoryComboBox.Items.Add(category.Id + " " + category.Name);
                }
            }

        }

        private void publishArticle_Click(object sender, EventArgs e)
        {
            //get the selected magazine and category
            string magazine = magazineComboBox.SelectedItem.ToString();
            string category = categoryComboBox.SelectedItem.ToString();
            //get the magazine id and category id
            int magazineId = Convert.ToInt32(magazine.Split(' ')[0]);
            int categoryId = Convert.ToInt32(category.Split(' ')[0]);
            //get the article title and content
            string title = articleTitleTextBox.Text;
            string content = articleContentTextBox.Text;


            int r = articleRepository.SaveArticle(title, content, magazineId, categoryId, AuthorID, "PENDING");
            if(r != -1)
            {
                MessageBox.Show("Article saved successfully");
            }
            else
            {
                MessageBox.Show("Error saving article");
            }

        }
    }
}
