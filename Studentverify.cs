using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace college_chairman_voting_system
{
    public partial class Studentverify : Form

    {
        public static string textPassdForm1;

        String randomCode;
        public static String to;

        public Studentverify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtemail.Text).ToString();
            from = "pettapetta26@gmail.com";
            pass = "mugdlgfefxfxdkog";
            messageBody = "Your Student Verification Code is  " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Student Verification Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtverify.Text).ToString())
            {
                MessageBox.Show("Student Verified Successfully");
                to = txtemail.Text;
                
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void Studentverify_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
                
            {
                textPassdForm1 = stuidtxt.Text;
               

               

                if (stuidtxt.Text == "" || stunametxt.Text == "" || txtemail.Text == "" || txtverify.Text == "")
                {
                    MessageBox.Show("Please Fill the all Field.", "All Field was Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connection = ConfigurationManager.ConnectionStrings["votingconnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_stu_verify", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@stu_idcard_no", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = stuidtxt.Text;
                    SqlParameter param2 = new SqlParameter("@stu_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = stunametxt.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    if (a > 0)
                    {
                        MessageBox.Show("Student Valid successfully");
                        VotingPage view = new VotingPage();
                        view.Show();
                        this.Hide(); 
                        
                    }
                    else
                    {
                        MessageBox.Show("InValid User...!");
                    }
                    con.Close();
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            UserLogin view = new UserLogin();
            view.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                stuidtxt.Text = VotingPage.textPassForm2;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                stuidtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                stunametxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stuidtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
