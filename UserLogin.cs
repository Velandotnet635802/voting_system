using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace college_chairman_voting_system
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtxt.Text == "" || passwordtxt.Text == "")
                {
                    MessageBox.Show("Please Fill the all Field.", "All Field was Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@user_id", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = useridtxt.Text;
                    SqlParameter param2 = new SqlParameter("@password", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = passwordtxt.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    if (a > 0)
                    {
                        MessageBox.Show("Valid User");
                        Studentverify sv = new Studentverify();
                        sv.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("InValid User");
                    }
                    con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void adminlogbtn_Click(object sender, EventArgs e)
        {
            Admin adminpage = new Admin();
            adminpage.Show();
            this.Hide();
        }
    }
}
