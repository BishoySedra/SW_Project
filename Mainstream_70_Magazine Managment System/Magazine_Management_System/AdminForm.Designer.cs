namespace Magazine_Management_System
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.magazineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.reportGen_label = new System.Windows.Forms.Label();
            this.articleReport_btn = new System.Windows.Forms.Button();
            this.subscriptionReport_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Articles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create New Magazine";
            // 
            // magazineName
            // 
            this.magazineName.Location = new System.Drawing.Point(178, 394);
            this.magazineName.Name = "magazineName";
            this.magazineName.Size = new System.Drawing.Size(189, 20);
            this.magazineName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Magazine Name";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(228, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.createMagazineButton_Click);
            // 
            // reportGen_label
            // 
            this.reportGen_label.AutoSize = true;
            this.reportGen_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportGen_label.Location = new System.Drawing.Point(697, 316);
            this.reportGen_label.Name = "reportGen_label";
            this.reportGen_label.Size = new System.Drawing.Size(246, 33);
            this.reportGen_label.TabIndex = 7;
            this.reportGen_label.Text = "Generate Reports";
            // 
            // articleReport_btn
            // 
            this.articleReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleReport_btn.Location = new System.Drawing.Point(703, 420);
            this.articleReport_btn.Name = "articleReport_btn";
            this.articleReport_btn.Size = new System.Drawing.Size(89, 27);
            this.articleReport_btn.TabIndex = 8;
            this.articleReport_btn.Text = "Generate";
            this.articleReport_btn.UseVisualStyleBackColor = true;
            this.articleReport_btn.Click += new System.EventHandler(this.articleReport_btn_Click);
            // 
            // subscriptionReport_btn
            // 
            this.subscriptionReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionReport_btn.Location = new System.Drawing.Point(854, 420);
            this.subscriptionReport_btn.Name = "subscriptionReport_btn";
            this.subscriptionReport_btn.Size = new System.Drawing.Size(89, 27);
            this.subscriptionReport_btn.TabIndex = 9;
            this.subscriptionReport_btn.Text = "Generate";
            this.subscriptionReport_btn.UseVisualStyleBackColor = true;
            this.subscriptionReport_btn.Click += new System.EventHandler(this.subscriptionReport_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Article status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(850, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subscriptions";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subscriptionReport_btn);
            this.Controls.Add(this.articleReport_btn);
            this.Controls.Add(this.reportGen_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magazineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox magazineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label reportGen_label;
        private System.Windows.Forms.Button articleReport_btn;
        private System.Windows.Forms.Button subscriptionReport_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

