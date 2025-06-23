using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Management_System
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        string query;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\LOG_IN.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(connstring);
            con.Open();
            cmd.Connection = con;

            adapter = new SqlDataAdapter("Select * from Log_In", connstring);
            dataset = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(dataset, "dataGridView1");
        }

        public void display()
        {
            string qry = "Select * from Log_In";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            display();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            display();
            query = $"Insert into Log_in(username, password) values ('{NEWUSR.Text}', '{NEWPASS.Text}')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("User inserted Successfully");
            display();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            display();
            query = $"Update Log_in set password='{NEWPASS.Text}' where username = '{NEWUSR.Text}'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password has been updated successfully");
            display();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (NEWUSR.Text != "admin")
                {
                    display();
                    query = $"Delete from Log_in where username='{NEWUSR.Text}'";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has been removed");
                    display();
                }
            else
            {
                MessageBox.Show("User admin cant be removed", "Admin Removal Requested");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_In obj = new Log_In();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
