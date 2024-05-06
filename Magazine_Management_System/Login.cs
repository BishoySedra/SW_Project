using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System.Repository.UserRepository;
using Magazine_Management_System.Model;

namespace Magazine_Management_System
{
    public partial class Login : Form
    {
        UserRepository userRepository = new UserRepository();
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //get email and password from user
            string email = email_tb.Text;
            string password = password_tb.Text;

            User user = userRepository.GetUserByCredentials(email, password);
            Console.WriteLine(user);
            if (user != null)
            {
                if(user.Role.Equals("ADMIN"))
                {
                    AdminForm form1 = new AdminForm(user.Id);
                    this.Hide();
                    form1.FormClosed += AdminFormClosed;
                    form1.Show();

                }
                else if (user.Role.Equals("AUTHOR"))
                {
                    AuthorForm form = new AuthorForm(user.Id);
                    this.Hide();
                    form.FormClosed += AuthorFormClosed;
                    form.Show();
                }
                else if(user.Role.Equals("READER"))
                {
                    SubscriptionForm form = new SubscriptionForm(user.Id);
                    this.Hide();
                    form.FormClosed += ReaderFormClosed;
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
                MessageBox.Show("Login Failed");

        }

        private void AdminFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void AuthorFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ReaderFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
