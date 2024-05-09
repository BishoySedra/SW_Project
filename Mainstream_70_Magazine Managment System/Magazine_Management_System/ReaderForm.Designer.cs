namespace Magazine_Management_System
{
    partial class ReaderForm
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
            this.subscribedMagazines = new System.Windows.Forms.ComboBox();
            this.toBeSubscribedMagazines = new System.Windows.Forms.ComboBox();
            this.userArticles = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magazines to subscribe to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Magazines you are susbcribed to:";
            // 
            // subscribedMagazines
            // 
            this.subscribedMagazines.FormattingEnabled = true;
            this.subscribedMagazines.Location = new System.Drawing.Point(12, 77);
            this.subscribedMagazines.Name = "subscribedMagazines";
            this.subscribedMagazines.Size = new System.Drawing.Size(342, 21);
            this.subscribedMagazines.TabIndex = 2;
            // 
            // toBeSubscribedMagazines
            // 
            this.toBeSubscribedMagazines.FormattingEnabled = true;
            this.toBeSubscribedMagazines.Location = new System.Drawing.Point(1028, 77);
            this.toBeSubscribedMagazines.Name = "toBeSubscribedMagazines";
            this.toBeSubscribedMagazines.Size = new System.Drawing.Size(342, 21);
            this.toBeSubscribedMagazines.TabIndex = 3;
            // 
            // userArticles
            // 
            this.userArticles.HideSelection = false;
            this.userArticles.Location = new System.Drawing.Point(134, 305);
            this.userArticles.Name = "userArticles";
            this.userArticles.Size = new System.Drawing.Size(1102, 196);
            this.userArticles.TabIndex = 4;
            this.userArticles.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(538, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Articles of magazines you are subscribed to";
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userArticles);
            this.Controls.Add(this.toBeSubscribedMagazines);
            this.Controls.Add(this.subscribedMagazines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReaderForm";
            this.Text = "ReaderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subscribedMagazines;
        private System.Windows.Forms.ComboBox toBeSubscribedMagazines;
        private System.Windows.Forms.ListView userArticles;
        private System.Windows.Forms.Label label4;
    }
}