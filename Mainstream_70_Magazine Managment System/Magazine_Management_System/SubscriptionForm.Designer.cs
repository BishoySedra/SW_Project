namespace Magazine_Management_System
{
    partial class SubscriptionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.suggestedMagazines = new System.Windows.Forms.ComboBox();
            this.subscribedMagazinesComboBox = new System.Windows.Forms.ComboBox();
            this.articles = new System.Windows.Forms.ListView();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of magazines you are not subscribed to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of magazines you are subscribed to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Articles of the magazines you are subscribed to";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // suggestedMagazines
            // 
            this.suggestedMagazines.FormattingEnabled = true;
            this.suggestedMagazines.Location = new System.Drawing.Point(702, 90);
            this.suggestedMagazines.Name = "suggestedMagazines";
            this.suggestedMagazines.Size = new System.Drawing.Size(352, 21);
            this.suggestedMagazines.TabIndex = 3;
            // 
            // subscribedMagazinesComboBox
            // 
            this.subscribedMagazinesComboBox.FormattingEnabled = true;
            this.subscribedMagazinesComboBox.Location = new System.Drawing.Point(30, 90);
            this.subscribedMagazinesComboBox.Name = "subscribedMagazinesComboBox";
            this.subscribedMagazinesComboBox.Size = new System.Drawing.Size(352, 21);
            this.subscribedMagazinesComboBox.TabIndex = 4;
            // 
            // articles
            // 
            this.articles.HideSelection = false;
            this.articles.Location = new System.Drawing.Point(145, 313);
            this.articles.Name = "articles";
            this.articles.Size = new System.Drawing.Size(840, 217);
            this.articles.TabIndex = 5;
            this.articles.UseCompatibleStateImageBehavior = false;
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(1060, 88);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(75, 23);
            this.subscribeButton.TabIndex = 6;
            this.subscribeButton.Text = "Susbcribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 563);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.articles);
            this.Controls.Add(this.subscribedMagazinesComboBox);
            this.Controls.Add(this.suggestedMagazines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubscriptionForm";
            this.Text = "SubscriptionForm";
            this.Load += new System.EventHandler(this.SubscriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox suggestedMagazines;
        private System.Windows.Forms.ComboBox subscribedMagazinesComboBox;
        private System.Windows.Forms.ListView articles;
        private System.Windows.Forms.Button subscribeButton;
    }
}