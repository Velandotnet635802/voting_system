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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (useridtxt.Text == "" || nametxt.Text == "" || departmenttxt.Text == "" || emailtxt.Text == "")
                {
                    MessageBox.Show("Please Fill the all Field.", "All Field was Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_studata", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@stu_idcard_no", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = useridtxt.Text;
                    SqlParameter param2 = new SqlParameter("@stu_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = nametxt.Text;
                    SqlParameter param3 = new SqlParameter("@department", SqlDbType.VarChar);
                    cmd.Parameters.Add(param3).Value = departmenttxt.Text;
                    SqlParameter param4 = new SqlParameter("@stu_email", SqlDbType.VarChar);
                    cmd.Parameters.Add(param4).Value = emailtxt.Text;
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("Student Data Insert successfully");
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminPage view = new AdminPage();
            view.Show();
            this.Hide();
        }
    }
}
