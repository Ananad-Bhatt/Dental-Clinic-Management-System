using System;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Dental_Management_System
{
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        string query;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\SEM 5\ADNF\PRACTICAL\Dental_Management_System\LOG_IN.mdf"";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(connstring);
            con.Open();
            cmd.Connection = con;

            adapter = new SqlDataAdapter("Select * from Treatment", connstring);
            dataset = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(dataset, "dataGridView1");
        }

        public void display()
        {
            string qry = "Select * from Treatment";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void INSRT_Click(object sender, EventArgs e)
        {
            display();
            query = $"INSERT INTO Treatment (TName, TCost, TDescription) VALUES ('{NM.Text}','{COST.Text}', '{Description.Text}')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Treatment Data Added Successfully");
            display();
        }

        private void UPDT_Click(object sender, EventArgs e)
        {
            display();
            query = $"Update Treatment set TCost ='{COST.Text}' , TDescription = '{Description.Text}' where TName = '{NM.Text}'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Treatment has been updated successfully");
            display();
        }

        private void DLT_Click(object sender, EventArgs e)
        {
            display();
            query = $"Delete from Treatment where TName='{NM.Text}'";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Treatment Data has been removed");
            display();
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
