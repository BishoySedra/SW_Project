namespace Magazine_Management_System
{
    partial class AuthorForm
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
            this.articleContentTextBox = new System.Windows.Forms.RichTextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.magazineComboBox = new System.Windows.Forms.ComboBox();
            this.publishArticle = new System.Windows.Forms.Button();
            this.articleTitleTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // articleContentTextBox
            // 
            this.articleContentTextBox.Location = new System.Drawing.Point(171, 261);
            this.articleContentTextBox.Name = "articleContentTextBox";
            this.articleContentTextBox.Size = new System.Drawing.Size(414, 118);
            this.articleContentTextBox.TabIndex = 0;
            this.articleContentTextBox.Text = "";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(171, 170);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(168, 143);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Magazine";
            // 
            // magazineComboBox
            // 
            this.magazineComboBox.FormattingEnabled = true;
            this.magazineComboBox.Location = new System.Drawing.Point(316, 170);
            this.magazineComboBox.Name = "magazineComboBox";
            this.magazineComboBox.Size = new System.Drawing.Size(121, 21);
            this.magazineComboBox.TabIndex = 3;
            // 
            // publishArticle
            // 
            this.publishArticle.Location = new System.Drawing.Point(171, 385);
            this.publishArticle.Name = "publishArticle";
            this.publishArticle.Size = new System.Drawing.Size(75, 23);
            this.publishArticle.TabIndex = 5;
            this.publishArticle.Text = "Publish";
            this.publishArticle.UseVisualStyleBackColor = true;
            this.publishArticle.Click += new System.EventHandler(this.publishArticle_Click);
            // 
            // articleTitleTextBox
            // 
            this.articleTitleTextBox.Location = new System.Drawing.Point(171, 223);
            this.articleTitleTextBox.Name = "articleTitleTextBox";
            this.articleTitleTextBox.Size = new System.Drawing.Size(212, 32);
            this.articleTitleTextBox.TabIndex = 6;
            this.articleTitleTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Article Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Article Content";
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articleTitleTextBox);
            this.Controls.Add(this.publishArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.magazineComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.articleContentTextBox);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox articleContentTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox magazineComboBox;
        private System.Windows.Forms.Button publishArticle;
        private System.Windows.Forms.RichTextBox articleTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}