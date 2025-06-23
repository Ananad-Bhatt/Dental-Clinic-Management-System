namespace Dental_Management_System
{
    partial class Log_In
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
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SBMTBTN1 = new System.Windows.Forms.Button();
            this.RGSTRBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(212, 46);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(189, 38);
            this.userName.TabIndex = 2;
            this.userName.TextChanged += new System.EventHandler(this.USRNMTXB_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(212, 105);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(189, 38);
            this.password.TabIndex = 3;
            // 
            // SBMTBTN1
            // 
            this.SBMTBTN1.Location = new System.Drawing.Point(212, 180);
            this.SBMTBTN1.Name = "SBMTBTN1";
            this.SBMTBTN1.Size = new System.Drawing.Size(75, 23);
            this.SBMTBTN1.TabIndex = 4;
            this.SBMTBTN1.Text = "SUBMIT";
            this.SBMTBTN1.UseVisualStyleBackColor = true;
            this.SBMTBTN1.Click += new System.EventHandler(this.SBMTBTN1_Click);
            // 
            // RGSTRBTN
            // 
            this.RGSTRBTN.Location = new System.Drawing.Point(351, 196);
            this.RGSTRBTN.Name = "RGSTRBTN";
            this.RGSTRBTN.Size = new System.Drawing.Size(138, 23);
            this.RGSTRBTN.TabIndex = 5;
            this.RGSTRBTN.Text = "ADD USER";
            this.RGSTRBTN.UseVisualStyleBackColor = true;
            this.RGSTRBTN.Click += new System.EventHandler(this.RGSTRBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "FOR ADMIN :";
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RGSTRBTN);
            this.Controls.Add(this.SBMTBTN1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Log_In";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button SBMTBTN1;
        private System.Windows.Forms.Button RGSTRBTN;
        private System.Windows.Forms.Label label3;
    }
}

