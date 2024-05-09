
namespace Magazine_Management_System
{
    partial class ArticleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateReport_btn = new System.Windows.Forms.Button();
            this.category_cmb = new System.Windows.Forms.ComboBox();
            this.magazine_cmb = new System.Windows.Forms.ComboBox();
            this.article_cmb = new System.Windows.Forms.ComboBox();
            this.category_label = new System.Windows.Forms.Label();
            this.magazine_label = new System.Windows.Forms.Label();
            this.article_label = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // GenerateReport_btn
            // 
            this.GenerateReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport_btn.Location = new System.Drawing.Point(620, 112);
            this.GenerateReport_btn.Name = "GenerateReport_btn";
            this.GenerateReport_btn.Size = new System.Drawing.Size(186, 60);
            this.GenerateReport_btn.TabIndex = 0;
            this.GenerateReport_btn.Text = "Generate Report";
            this.GenerateReport_btn.UseVisualStyleBackColor = true;
            this.GenerateReport_btn.Click += new System.EventHandler(this.GenerateReport_btn_Click);
            // 
            // category_cmb
            // 
            this.category_cmb.FormattingEnabled = true;
            this.category_cmb.Location = new System.Drawing.Point(193, 58);
            this.category_cmb.Name = "category_cmb";
            this.category_cmb.Size = new System.Drawing.Size(159, 21);
            this.category_cmb.TabIndex = 1;
            this.category_cmb.SelectedIndexChanged += new System.EventHandler(this.category_cmb_SelectedIndexChanged);
            // 
            // magazine_cmb
            // 
            this.magazine_cmb.FormattingEnabled = true;
            this.magazine_cmb.Location = new System.Drawing.Point(620, 58);
            this.magazine_cmb.Name = "magazine_cmb";
            this.magazine_cmb.Size = new System.Drawing.Size(159, 21);
            this.magazine_cmb.TabIndex = 2;
            this.magazine_cmb.SelectedIndexChanged += new System.EventHandler(this.magazine_cmb_SelectedIndexChanged);
            // 
            // article_cmb
            // 
            this.article_cmb.FormattingEnabled = true;
            this.article_cmb.Location = new System.Drawing.Point(1026, 58);
            this.article_cmb.Name = "article_cmb";
            this.article_cmb.Size = new System.Drawing.Size(289, 21);
            this.article_cmb.TabIndex = 3;
            this.article_cmb.SelectedIndexChanged += new System.EventHandler(this.article_cmb_SelectedIndexChanged);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(65, 56);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(81, 20);
            this.category_label.TabIndex = 4;
            this.category_label.Text = "Category";
            // 
            // magazine_label
            // 
            this.magazine_label.AutoSize = true;
            this.magazine_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazine_label.Location = new System.Drawing.Point(476, 56);
            this.magazine_label.Name = "magazine_label";
            this.magazine_label.Size = new System.Drawing.Size(86, 20);
            this.magazine_label.TabIndex = 5;
            this.magazine_label.Text = "Magazine";
            // 
            // article_label
            // 
            this.article_label.AutoSize = true;
            this.article_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_label.Location = new System.Drawing.Point(903, 56);
            this.article_label.Name = "article_label";
            this.article_label.Size = new System.Drawing.Size(60, 20);
            this.article_label.TabIndex = 6;
            this.article_label.Text = "Article";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 224);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1407, 451);
            this.crystalReportViewer1.TabIndex = 7;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 713);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.article_label);
            this.Controls.Add(this.magazine_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.article_cmb);
            this.Controls.Add(this.magazine_cmb);
            this.Controls.Add(this.category_cmb);
            this.Controls.Add(this.GenerateReport_btn);
            this.Name = "ArticleForm";
            this.Text = "Aticle Status";
            this.Load += new System.EventHandler(this.Report1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateReport_btn;
        private System.Windows.Forms.ComboBox category_cmb;
        private System.Windows.Forms.ComboBox magazine_cmb;
        private System.Windows.Forms.ComboBox article_cmb;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label magazine_label;
        private System.Windows.Forms.Label article_label;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}