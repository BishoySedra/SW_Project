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
    public partial class SubscriptionStatusForm : Form
    {
        CrystalReport3 CR;
        public SubscriptionStatusForm()
        {
            InitializeComponent();
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
        }
    }
}
