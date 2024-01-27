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
    public partial class VotingPage : Form
    {
        public static string textPassForm2;
        

        public VotingPage()
        {
            InitializeComponent();
            

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string textPassdForm2 = studentidtxt.Text;
               


                if (studentidtxt.Text == "" || vote_fortxt.Text == "" )
                {
                    MessageBox.Show("Please Fill the all Field.", "All Field was Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_voting", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@stu_idcard_no", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = studentidtxt.Text;
                    SqlParameter param2 = new SqlParameter("@vote_for", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = vote_fortxt.Text;
                    int i = cmd.ExecuteNonQuery();


                    if (i > 0)
                    {
                        MessageBox.Show("Thank you for Our Voting");
                        VotingPage view = new VotingPage();
                        view.Show();
                        this.Hide();



                    }
                    else
                    {
                        MessageBox.Show("Failed Tyr Again...!");
                        VotingPage view = new VotingPage();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void useradminbtn_Click(object sender, EventArgs e)
        {
            UserLogin view = new UserLogin();
            view.Show();
            this.Hide();
        }

        private void useridtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void VotingPage_Load(object sender, EventArgs e)
        {
            studentidtxt.Text = Studentverify.textPassdForm1;

        }

        private void vote_fortxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Studentverify view = new Studentverify();
            view.Show();
            this.Hide();
        }
    }
}
