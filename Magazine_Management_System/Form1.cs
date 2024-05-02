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

namespace Magazine_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            UserRepository userRepository = new UserRepository();
            userRepository.SaveUser(new User())

        }

    }
}
