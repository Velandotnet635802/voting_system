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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtxt.Text == "" || emailidtxt.Text =="" || passwordtxt.Text=="") 
                {
                    MessageBox.Show("Please Fill the all Field.", "All Field was Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_userlog", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@user_id", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = useridtxt.Text;
                    SqlParameter param2 = new SqlParameter("@email", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = emailidtxt.Text;
                    SqlParameter param3 = new SqlParameter("@password", SqlDbType.VarChar);
                    cmd.Parameters.Add(param3).Value = passwordtxt.Text;
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("User Create successfully");
                        AdminPage view = new AdminPage();
                        view.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Failed Tyr Again...!");
                        AdminPage view = new AdminPage();
                        view.Show();
                        this.Hide();

                    }
                    
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emailidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage view = new AdminPage();
            view.Show();
            this.Hide();
        }

        private void useridtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
