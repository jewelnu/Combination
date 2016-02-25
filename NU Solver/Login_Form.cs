using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NU_Solver
{
    public partial class login : Form
    {
        public String username = "";
        public String password = "";
        //File_List file_list_form = new File_List();
            
        public login()
        {
            InitializeComponent();
        }
        
        private void b_login_Click(object sender, EventArgs e)
        {
            //int n;
            ////n = Int32.TryParse("0000000027] ");
            //MessageBox.Show("i="+n+"__");
            //Database.init();
            //MessageBox.Show(Database.isValid("211000").ToString());
            //return;
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null)
                {
                    MessageBox.Show("Connection Problem");
                    return;
                }
                SqlCommand cmd = new SqlCommand("",con);
                username = tb_username.Text.ToString();
                password = tb_password.Text.ToString();

                cmd.CommandText = String.Format("SELECT dbo.solvers.status FROM dbo.solvers WHERE dbo.solvers.solver_name = '{0}' AND dbo.solvers.passkey = '{1}'", username, password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //MessageBox.Show(reader["status"].ToString());
                    Database.init();

                    if (reader["status"].ToString() == "solver")
                    {
                        loadAppropriateWindow();
                        return;
                    }
                    else if (reader["status"].ToString() == "uploader")
                    {
                        upload upload_frm = new upload();
                        upload_frm.Show();
                        this.Hide();
                        return;
                    }
                    //exm_roll.Add(reader["exm_roll"].ToString());
                    //reg_no.Add(reader["reg_no"].ToString());
                }
                reader.Dispose();
                MessageBox.Show("Invalid User id and Password!\nTry again.","My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                tb_username.Focus();
                //MessageBox.Show( username + "\n" + password );
                //file_list_form.File_List("File Name", username);  
            }
            catch (Exception ee)
            {
                //MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
        }
        public void loadAppropriateWindow()
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Can't create and open a connection");
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandText = string.Format("SELECT file_name FROM dbo.file_list WHERE solver_name = '{0}' AND solve_status = 'solving'",username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string filename = reader[0].ToString();
                    //SolveWindow slw = new SolveWindow(filename, username, getSub(filename), this, false);
                    //this.Hide();
                    //slw.Show();
                    E_solve slw = new E_solve(filename, username, getSub(filename), this, false);
                    this.Hide();
                    slw.Show();
                    //this.Close();
                }
                else
                {
                    File_List file_list_form = new File_List(username,this);
                    file_list_form.Show();
                    this.Hide();
                }
                reader.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
        }
        public string getSub(string filename)
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Can't create and open a connection");
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandText = string.Format("SELECT pap_code FROM dbo.file_list WHERE file_name = '{0}'", filename);
                SqlDataReader reader = cmd.ExecuteReader();
                string sub_code = "";
                if (reader.Read())
                {
                    sub_code = reader[0].ToString();
                }
                reader.Dispose();
                con.Close();
                con.Dispose();
                return sub_code;
            }
            catch (Exception ee)
            {
                
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
