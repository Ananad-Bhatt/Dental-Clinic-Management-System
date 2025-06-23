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

namespace Dental_Management_System
{
    public partial class Log_In : Form
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\LOG_IN.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        public Log_In()
        {
            InitializeComponent();
        }

        private void USRNMTXB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SBMTBTN1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            string query = $"SELECT COUNT(*) FROM LOG_IN WHERE USERNAME = '{userName.Text}' AND PASSWORD = '{password.Text}'";

            SqlCommand cmd = new SqlCommand(query, con);
            string count = cmd.ExecuteScalar().ToString();
            int cou = int.Parse(count);

            if (cou > 0)
            {
                MessageBox.Show("Logged");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
                MessageBox.Show("User Not Found");
        }

        private void RGSTRBTN_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            string query = $"SELECT COUNT(*) FROM LOG_IN WHERE USERNAME = '{userName.Text}' AND PASSWORD = '{password.Text}'";

            SqlCommand cmd = new SqlCommand(query, con);
            string count = cmd.ExecuteScalar().ToString();
            int cou = int.Parse(count);

            if (cou > 0)
            {
                form();
            }
            else
            {
                MessageBox.Show("Incorrect Password or username for admin");
            }

            void form()
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}
