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
    public partial class File_List : Form
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        //public DataTable dt = new DataTable();
        //public SqlDataAdapter da = new SqlDataAdapter();
        public string username = "";
        public string sub_code = "";
        login caller;
        public File_List()
        {
            InitializeComponent();
        }
        public File_List(string username,login caller)
        {
            this.username = username;
            this.caller = caller;
            InitializeComponent();
            //loadSolveWindow();
            //this.Hide();
            //loadFreeFiles();
            file_load_listview();
        }
        private void file_list_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void file_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you really want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                e.Cancel = true;            
        }
        public void loadFreeFiles(){
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Can't create and open a connection");
                SqlCommand cmd = new SqlCommand("", con);
                //username = tb_username.Text.ToString();
                //password = tb_password.Text.ToString();

                cmd.CommandText = "SELECT dbo.file_list.file_name,rows,file_size FROM dbo.file_list WHERE dbo.file_list.solver_name IS NULL OR dbo.file_list.solver_name = '__NONE'";
                //cmd.CommandText = "SELECT dbo.file_list.file_name FROM dbo.file_list";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //this.file_list_box.Items.Add(reader[0].ToString());
                    this.file_list_box.Items.Add(reader[0].ToString() + "      " + (reader[1].ToString()) + "      " + (reader[2].ToString()));
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
        public bool getAccess(string filename)
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Can't create and open a connection");                
                SqlCommand cmd = new SqlCommand("", con);

                cmd.CommandText = string.Format(
                    "UPDATE dbo.file_list " +
                    "SET solver_name = '{0}', solve_status = 'SOLVING', start_date = CURRENT_TIMESTAMP " +
                    "WHERE file_name = '{1}' AND ISNULL(solver_name, '__NONE') = '__NONE'",
                    username,filename);
                if (cmd.ExecuteNonQuery() == 0)
                    return false;                
                con.Close();
                con.Dispose();
                return true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
            return false;
        }
        public string getSub(string filename)
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Can't create and open a connection");
                SqlCommand cmd = new SqlCommand("", con);       
                cmd.CommandText = string.Format("SELECT pap_code FROM dbo.file_list WHERE file_name = '{0}'",filename);
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
        private void file_selected(object sender, EventArgs e)
        {
            //int index = this.file_list_box.SelectedIndex;
            //string filename=this.file_list_box.Items[index].ToString().Substring(0,14).Trim();

            //int index = this.listView1.SelectedIndex;
            string filename = this.listView1.SelectedItems[0].SubItems[0].Text.ToString();
            //MessageBox.Show(filename);
            if (getAccess(filename))
            {
                //SolveWindow slw = new SolveWindow(filename, username, getSub(filename), this,true);
                E_solve slw = new E_solve(filename, username, getSub(filename), caller, true);
                this.Hide();
                slw.Show();
                //this.Close();
            }
            else
                MessageBox.Show("File Access failure. Try diffrent file.");
                //this.file_list_box.Items.Remove(this.file_list_box.Items[index].ToString());
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void file_double_clicked(object sender, EventArgs e)
        {
            //MessageBox.Show("file_double_clicked ");
            e.ToString();
            file_selected(sender,e);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text.ToString());
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void file_load_listview()        
        {
            try
            {
                listView1.View = View.Details;
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Connection failed! Please try again.");

                SqlDataAdapter ada =new SqlDataAdapter("SELECT * FROM dbo.file_list WHERE dbo.file_list.solver_name IS NULL OR dbo.file_list.solver_name = '__NONE'",con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["file_name"].ToString());
                    listitem.SubItems.Add(dr["file_size"].ToString());
                    listitem.SubItems.Add(dr["rows"].ToString());
                    listitem.SubItems.Add(dr["solve_status"].ToString());
                    listView1.Items.Add(listitem);
                }
                dt.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
