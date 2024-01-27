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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Votingstatus view = new Votingstatus();
            view.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin view = new Admin();
            view.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStudent view = new AddStudent();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewUser view = new NewUser();
            view.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewUser view = new ViewUser();
            view.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditStudentData view = new EditStudentData();
            view.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            view_stu_data view = new view_stu_data();
            view.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(@"Do You Clear the All Student Data...!It's Can't Recoverd...! ", @"Warning...!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_clearstudata", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("All Student data will be cleared....!");
                }
                
                else 
                {
                    AdminPage view = new AdminPage();
                    view.Show();
                    this.Hide();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(@"Do You Clear the All User Data...!It's Can't Recoverd...! ", @"Warning...!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_clearuserdata", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("All User data will be cleared....!");
                }

                else
                {
                    AdminPage view = new AdminPage();
                    view.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(@"Do You Clear the All Voting Status Data...!It's Can't Recoverd...! ", @"Warning...!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_votingdata", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("All Voting Status data will be cleared....!");
                }

                else
                {
                    AdminPage view = new AdminPage();
                    view.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
