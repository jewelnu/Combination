using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace NU_Solver
{
    public partial class changepassword : Form
    {
        public string username = "";
        public changepassword(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string con = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
            SqlConnection cn=new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            dbbase ChPassword=new dbbase();
            string strCmd = "update solvers set Password='" + txtNewPassword.Text + "' where solver_name='" + username.ToString() + "'";
            //"select * from solvers where solver_name='" + user + "' and passkey='" + pass + "'";
            if (ChPassword.login(username.ToString(), txtOldPassword.Text) == true)
            {

                //MessageBox.Show(username.ToString());
                if (txtNewPassword.Text == txtConfPassword.Text)
                {
                    try
                    {
                        cn.Open();
                        cmd.Connection = cn;
                        cmd.CommandText = strCmd;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Successfully saved! Please presearved password for future use.");
                        cn.Close();
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfPassword.Text = "";
                        txtOldPassword.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        txtOldPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("New Passwords Does Not Match! Try again");
                    txtNewPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("User name or Password Incorrect!");
                txtOldPassword.Focus();

            }
        }
    }
}
