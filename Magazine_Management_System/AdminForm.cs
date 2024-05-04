using Magazine_Management_System.Repository.UserRepository;
using Magazine_Management_System.Repository.CategoryRepository;
using Magazine_Management_System.Model;
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
using Oracle.DataAccess.Types;
using Magazine_Management_System.Repository.ArticleRepository;

namespace Magazine_Management_System
{
    public partial class AdminForm : Form
    {
        int AdminID;
        public AdminForm(int ID)
        {
            InitializeComponent();
            this.AdminID = ID;

        }
        MagazineRepository magazineRepository = new MagazineRepository();
        ArticleRepository articleRepository = new ArticleRepository();
        private void button1_Click(object sender, EventArgs e)
        {
            articleRepository.SearchPendingArticlesDisconnectedLayer(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            articleRepository.UpdateMagazineArticlesDisconnectedLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createMagazineButton_Click(object sender, EventArgs e)
        {
            string MagazineName = magazineName.Text;
            int ID = magazineRepository.SaveMagazine(MagazineName, AdminID, new OracleDate(DateTime.Now));
            if(ID != -1)
            {
                MessageBox.Show("Magazine Created Successfully with id: " + ID);
            }
            else
            {
                MessageBox.Show("Magazine Creation Failed");
            }
        }
    }
}
