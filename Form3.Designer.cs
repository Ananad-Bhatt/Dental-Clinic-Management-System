namespace Dental_Management_System
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TREATMENT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DNAME = new System.Windows.Forms.ComboBox();
            this.lOG_INDataSet = new Dental_Management_System.LOG_INDataSet();
            this.dOCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTTableAdapter = new Dental_Management_System.LOG_INDataSetTableAdapters.DOCTTableAdapter();
            this.lOGINDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOG_INDataSet1 = new Dental_Management_System.LOG_INDataSet1();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Dental_Management_System.LOG_INDataSet1TableAdapters.AppointmentTableAdapter();
            this.lOG_INDataSet2 = new Dental_Management_System.LOG_INDataSet2();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Dental_Management_System.LOG_INDataSet2TableAdapters.TableTableAdapter();
            this.lOG_INDataSet3 = new Dental_Management_System.LOG_INDataSet3();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter1 = new Dental_Management_System.LOG_INDataSet3TableAdapters.AppointmentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Date", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "Date", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.appointmentBindingSource, "Date", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.appointmentBindingSource, "Date", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 38);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type Of Treatment : ";
            // 
            // TREATMENT
            // 
            this.TREATMENT.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.appointmentBindingSource1, "Name", true));
            this.TREATMENT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource1, "Name", true));
            this.TREATMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREATMENT.Location = new System.Drawing.Point(288, 135);
            this.TREATMENT.Name = "TREATMENT";
            this.TREATMENT.Size = new System.Drawing.Size(500, 38);
            this.TREATMENT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time : ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "Time", true));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.appointmentBindingSource, "Time", true));
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.appointmentBindingSource, "Time", true));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(288, 191);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(283, 38);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 147);
            this.dataGridView1.TabIndex = 8;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.Name = "treatmentToolStripMenuItem";
            this.treatmentToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.treatmentToolStripMenuItem.Text = "Treatment";
            this.treatmentToolStripMenuItem.Click += new System.EventHandler(this.treatmentToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update Appointment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(408, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete Appointment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(604, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "Show Appointments";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DNAME
            // 
            this.DNAME.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentBindingSource, "Name", true));
            this.DNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNAME.FormattingEnabled = true;
            this.DNAME.Location = new System.Drawing.Point(288, 33);
            this.DNAME.Name = "DNAME";
            this.DNAME.Size = new System.Drawing.Size(294, 37);
            this.DNAME.TabIndex = 14;
            // 
            // lOG_INDataSet
            // 
            this.lOG_INDataSet.DataSetName = "LOG_INDataSet";
            this.lOG_INDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTBindingSource
            // 
            this.dOCTBindingSource.DataMember = "DOCT";
            this.dOCTBindingSource.DataSource = this.lOG_INDataSet;
            // 
            // dOCTTableAdapter
            // 
            this.dOCTTableAdapter.ClearBeforeFill = true;
            // 
            // lOGINDataSetBindingSource
            // 
            this.lOGINDataSetBindingSource.DataSource = this.lOG_INDataSet;
            this.lOGINDataSetBindingSource.Position = 0;
            // 
            // lOG_INDataSet1
            // 
            this.lOG_INDataSet1.DataSetName = "LOG_INDataSet1";
            this.lOG_INDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.lOG_INDataSet1;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // lOG_INDataSet2
            // 
            this.lOG_INDataSet2.DataSetName = "LOG_INDataSet2";
            this.lOG_INDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.lOG_INDataSet2;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // lOG_INDataSet3
            // 
            this.lOG_INDataSet3.DataSetName = "LOG_INDataSet3";
            this.lOG_INDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "Appointment";
            this.appointmentBindingSource1.DataSource = this.lOG_INDataSet3;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DNAME);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TREATMENT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_INDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TREATMENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox DNAME;
        private LOG_INDataSet lOG_INDataSet;
        private System.Windows.Forms.BindingSource dOCTBindingSource;
        private LOG_INDataSetTableAdapters.DOCTTableAdapter dOCTTableAdapter;
        private System.Windows.Forms.BindingSource lOGINDataSetBindingSource;
        private LOG_INDataSet1 lOG_INDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private LOG_INDataSet1TableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private LOG_INDataSet2 lOG_INDataSet2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private LOG_INDataSet2TableAdapters.TableTableAdapter tableTableAdapter;
        private LOG_INDataSet3 lOG_INDataSet3;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private LOG_INDataSet3TableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
    }
}