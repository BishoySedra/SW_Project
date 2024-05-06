using CrystalDecisions.Shared;
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
    public partial class ArticleForm : Form
    {
        CrystalReport2 CR;
        public ArticleForm()
        {
            InitializeComponent();
        }

        private void category_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void magazine_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void article_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReport_btn_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, category_cmb.Text);
            CR.SetParameterValue(1, magazine_cmb.Text);
            CR.SetParameterValue(2, article_cmb.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
            for (int i = 0; i < 3; i++)
            {
                foreach (ParameterDiscreteValue v in CR.ParameterFields[i].DefaultValues)
                {
                    if (i == 0)
                        category_cmb.Items.Add(v.Value);
                    else if (i == 1)
                        magazine_cmb.Items.Add(v.Value);
                    else
                        article_cmb.Items.Add(v.Value);
                }
            }
        }
    }
}
