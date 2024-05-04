
namespace Magazine_Management_System
{
    partial class Form2
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
            this.username_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.role_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(566, 117);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(202, 20);
            this.username_tb.TabIndex = 0;
            this.username_tb.TextChanged += new System.EventHandler(this.username_tb_TextChanged);
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(566, 182);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(202, 20);
            this.email_tb.TabIndex = 1;
            this.email_tb.TextChanged += new System.EventHandler(this.email_tb_TextChanged);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(566, 252);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(202, 20);
            this.password_tb.TabIndex = 2;
            this.password_tb.TextChanged += new System.EventHandler(this.password_tb_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(439, 115);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(83, 20);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(454, 182);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(48, 20);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(439, 250);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 20);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_label.Location = new System.Drawing.Point(454, 327);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(42, 20);
            this.role_label.TabIndex = 7;
            this.role_label.Text = "Role";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // role_cmb
            // 
            this.role_cmb.FormattingEnabled = true;
            this.role_cmb.Items.AddRange(new object[] {
            "ADMIN",
            "AUTHOR",
            "READER"});
            this.role_cmb.Location = new System.Drawing.Point(566, 329);
            this.role_cmb.Name = "role_cmb";
            this.role_cmb.Size = new System.Drawing.Size(202, 21);
            this.role_cmb.TabIndex = 9;
            this.role_cmb.SelectedIndexChanged += new System.EventHandler(this.role_cmb_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 556);
            this.Controls.Add(this.role_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.username_tb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox role_cmb;
    }
}