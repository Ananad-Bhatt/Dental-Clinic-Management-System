namespace Dental_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NEWUSR = new System.Windows.Forms.TextBox();
            this.NEWPASS = new System.Windows.Forms.TextBox();
            this.SHOW = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NEWUSR
            // 
            this.NEWUSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSR.Location = new System.Drawing.Point(312, 38);
            this.NEWUSR.Name = "NEWUSR";
            this.NEWUSR.Size = new System.Drawing.Size(243, 34);
            this.NEWUSR.TabIndex = 3;
            // 
            // NEWPASS
            // 
            this.NEWPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWPASS.Location = new System.Drawing.Point(312, 121);
            this.NEWPASS.Name = "NEWPASS";
            this.NEWPASS.Size = new System.Drawing.Size(243, 34);
            this.NEWPASS.TabIndex = 4;
            // 
            // SHOW
            // 
            this.SHOW.Location = new System.Drawing.Point(34, 202);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(140, 38);
            this.SHOW.TabIndex = 5;
            this.SHOW.Text = "SHOW USERS";
            this.SHOW.UseVisualStyleBackColor = true;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(207, 202);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(140, 56);
            this.UPDATE.TabIndex = 6;
            this.UPDATE.Text = "UPDATE PASSWORD";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(375, 202);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(140, 38);
            this.INSERT.TabIndex = 7;
            this.INSERT.Text = "ADD USER";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(559, 202);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(140, 38);
            this.DELETE.TabIndex = 8;
            this.DELETE.Text = "DELETE USER";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 175);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Log Into System(For Admin)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SHOW);
            this.Controls.Add(this.NEWPASS);
            this.Controls.Add(this.NEWUSR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Admin Control";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NEWUSR;
        private System.Windows.Forms.TextBox NEWPASS;
        private System.Windows.Forms.Button SHOW;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}