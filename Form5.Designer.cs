namespace Dental_Management_System
{
    partial class Form5
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
            this.NM = new System.Windows.Forms.TextBox();
            this.COST = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.INSRT = new System.Windows.Forms.Button();
            this.UPDT = new System.Windows.Forms.Button();
            this.DLT = new System.Windows.Forms.Button();
            this.SHOW = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description : ";
            // 
            // NM
            // 
            this.NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NM.Location = new System.Drawing.Point(126, 37);
            this.NM.Name = "NM";
            this.NM.Size = new System.Drawing.Size(312, 34);
            this.NM.TabIndex = 3;
            // 
            // COST
            // 
            this.COST.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COST.Location = new System.Drawing.Point(546, 39);
            this.COST.Name = "COST";
            this.COST.Size = new System.Drawing.Size(156, 34);
            this.COST.TabIndex = 4;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(183, 85);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(520, 72);
            this.Description.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.treatmentToolStripMenuItem,
            this.prescriptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.Name = "treatmentToolStripMenuItem";
            this.treatmentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.treatmentToolStripMenuItem.Text = "Appointment";
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 163);
            this.dataGridView1.TabIndex = 11;
            // 
            // INSRT
            // 
            this.INSRT.BackColor = System.Drawing.Color.Transparent;
            this.INSRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSRT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.INSRT.Location = new System.Drawing.Point(12, 169);
            this.INSRT.Name = "INSRT";
            this.INSRT.Size = new System.Drawing.Size(165, 39);
            this.INSRT.TabIndex = 15;
            this.INSRT.Text = "Insert";
            this.INSRT.UseVisualStyleBackColor = false;
            this.INSRT.Click += new System.EventHandler(this.INSRT_Click);
            // 
            // UPDT
            // 
            this.UPDT.BackColor = System.Drawing.Color.Transparent;
            this.UPDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UPDT.Location = new System.Drawing.Point(182, 169);
            this.UPDT.Name = "UPDT";
            this.UPDT.Size = new System.Drawing.Size(165, 39);
            this.UPDT.TabIndex = 19;
            this.UPDT.Text = "Update";
            this.UPDT.UseVisualStyleBackColor = false;
            this.UPDT.Click += new System.EventHandler(this.UPDT_Click);
            // 
            // DLT
            // 
            this.DLT.BackColor = System.Drawing.Color.Transparent;
            this.DLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DLT.Location = new System.Drawing.Point(353, 169);
            this.DLT.Name = "DLT";
            this.DLT.Size = new System.Drawing.Size(165, 39);
            this.DLT.TabIndex = 20;
            this.DLT.Text = "Delete";
            this.DLT.UseVisualStyleBackColor = false;
            this.DLT.Click += new System.EventHandler(this.DLT_Click);
            // 
            // SHOW
            // 
            this.SHOW.BackColor = System.Drawing.Color.Transparent;
            this.SHOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SHOW.Location = new System.Drawing.Point(524, 169);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(178, 39);
            this.SHOW.TabIndex = 21;
            this.SHOW.Text = "Show Data";
            this.SHOW.UseVisualStyleBackColor = false;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(715, 391);
            this.Controls.Add(this.SHOW);
            this.Controls.Add(this.DLT);
            this.Controls.Add(this.UPDT);
            this.Controls.Add(this.INSRT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.COST);
            this.Controls.Add(this.NM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form5";
            this.Text = "Treatment";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NM;
        private System.Windows.Forms.TextBox COST;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button INSRT;
        private System.Windows.Forms.Button UPDT;
        private System.Windows.Forms.Button DLT;
        private System.Windows.Forms.Button SHOW;
    }
}