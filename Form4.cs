using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dental_Management_System
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        string query;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\SEM 5\ADNF\PRACTICAL\Dental_Management_System\LOG_IN.mdf"";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(connstring);
            con.Open();
            cmd.Connection = con;

            adapter = new SqlDataAdapter("Select * from Patient", connstring);
            dataset = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(dataset, "dataGridView1");

        }

        public void display()
        {
            string qry = "Select * from Patient";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime enteredDateTime = new DateTime(DTP.Value.Year, DTP.Value.Month, DTP.Value.Day);
            DateTime currentDateTime = DateTime.Now;

            if (enteredDateTime <= currentDateTime)
            {
                display();
                string date = DTP.Value.ToString("dd-MMMM-yyyy");
                query = $"INSERT INTO Patient (pname, num, dob, gndr, adrs, alrgs) VALUES ('{NM.Text}','{PN.Text}' , '{date}', '{GNDR.Text}', '{ADRS.Text}', '{ALRGS.Text}')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Added Successfully");
                display();
            }
            else
            {
                MessageBox.Show("Date and time cant be Future");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
            query = $"Delete from Patient where pname='{NM.Text}'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient has been removed");
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
