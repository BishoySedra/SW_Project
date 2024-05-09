
﻿using System;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        UserRepository userRepo = new UserRepository();

        private void username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {

        }


        private void role_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string email = email_tb.Text;
            string password = password_tb.Text;

            string selectedRole = role_cmb.SelectedItem.ToString();


            int ID = userRepo.SaveUser(new User(email, username, password, selectedRole));
            MessageBox.Show($"ID: {ID}");
            username_label.Text = "";
            email_label.Text = "";
            password_label.Text = "";

        }
    }
}

