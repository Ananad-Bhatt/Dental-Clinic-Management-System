using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dental_Management_System
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        string query;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOG_INDataSet3.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter1.Fill(this.lOG_INDataSet3.Appointment);
            // TODO: This line of code loads data into the 'lOG_INDataSet2.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.lOG_INDataSet2.Table);
            // TODO: This line of code loads data into the 'lOG_INDataSet1.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.lOG_INDataSet1.Appointment);
            this.dOCTTableAdapter.Fill(this.lOG_INDataSet.DOCT);
            String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\LOG_IN.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(connstring);
            con.Open();
            cmd.Connection = con;
            adapter = new SqlDataAdapter("Select * from Appointment", connstring);
            dataset = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(dataset, "dataGridView1");

            DataRow dr;

            cmd = new SqlCommand("select * from DOCT", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Doctor--" };
            dt.Rows.InsertAt(dr, 0);


            DNAME.DisplayMember = "DNAME";
            DNAME.DataSource = dt;
        }

        public void display()
        {
            string qry = "Select * from Appointment";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime enteredDateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            DateTime currentDateTime = DateTime.Now;

            if (enteredDateTime >= currentDateTime)
            {
                display();
                string date = dateTimePicker1.Value.ToString("dd-MMMM-yyyy");
                string time = dateTimePicker2.Value.ToString("HH:mm:ss");
                query = $"INSERT INTO Appointment(Name, Date, Treatment, Time) VALUES ('{DNAME.Text}', '{date}', '{TREATMENT.Text}', '{time}')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment inserted successfully");
                display();
            }
            else
            {
                MessageBox.Show("Date and time cant be from past");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime enteredDateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            DateTime currentDateTime = DateTime.Now;

            if (enteredDateTime >= currentDateTime)
            {
                string date = dateTimePicker1.Value.ToString("dd-MMMM-yyyy");
                string time = dateTimePicker2.Value.ToString("HH:mm:ss");
                query = $"Update Appointment set date ='{date}' , time = '{time}' where Name = '{DNAME.Text}'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment has been updated successfully");
                display();
            }
            else
            {
                MessageBox.Show("Please enter a future or present date and time for the appointment update.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
            query = $"Delete from Appointment where Name='{DNAME.Text}'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Appointment has been removed");
            display();
        }

        private void treatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
