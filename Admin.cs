using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college_chairman_voting_system
    
{

    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
        }

        private void staffidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = staffidtxt.Text;
                string password = passwordtxt.Text;


                string validUsername = "velan";
                string validPassword = "petta123";

                if (username == validUsername && password == validPassword)
                {
                    MessageBox.Show("Valid Admin!");
                    AdminPage add = new AdminPage();
                    add.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid Admin Id or Password.");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid admin");
            }


        }

       

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            UserLogin back = new UserLogin();
            back.Show();
            this.Hide();
        }
    }   }
