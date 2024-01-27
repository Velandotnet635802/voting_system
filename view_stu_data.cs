using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college_chairman_voting_system
{
    public partial class view_stu_data : Form
    {
        public view_stu_data()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_stu_dataview", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage view = new AdminPage();
            view.Show();
            this.Hide();
        }
    }
}
