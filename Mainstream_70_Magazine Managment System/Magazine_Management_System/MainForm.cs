using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            this.Hide();
            regForm.FormClosed += RegFormClosed;
            regForm.Show();
        }

        private void RegFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.FormClosed += LoginFormClosed;
            loginForm.Show();
            
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
