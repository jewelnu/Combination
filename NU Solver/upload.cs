using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NU_Solver
{
    public partial class upload : Form
    {
        string folder = @"D:\Scanned\";
        public upload()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            label2.Text = "Processing...";
            DirectoryInfo dr = new DirectoryInfo(folder);
            for (int i = 0; i < dr.GetFiles().Length; i++)
            {
                //this.listBox1.Items.Add(dr.GetFiles()[i].Name);
                uploadfile(dr.GetFiles()[i].Name);
            }
            this.Close();
            label2.Text = "Finished...";
            MessageBox.Show("Finished");
        }
        private void uploadfile(string filename)
        {
            string fullpath = folder + filename;
            string sub_code = "";
            int tot_rec = File.ReadAllLines(fullpath).Length;
            int file_size = 0;

            FileInfo info = new FileInfo(fullpath);
            long value =info.Length;
            file_size=Convert.ToInt32(value / 1024.0); // for kb

            //MessageBox.Show(file_size.ToString());
            //MessageBox.Show(tot_rec.ToString());
            if (filename.Length >= 7)
                sub_code = "31" + filename.Substring(1, 4);
            string filename_insert = String.Format("INSERT INTO dbo.[file_list] ([file_name],[pap_code],[insert_date],[rows],[file_size]) values('{0}','{1}', CURRENT_TIMESTAMP,'{2}','{3}')", filename, sub_code, tot_rec, file_size);
            //this.textBox1.Text = this.textBox1.Text + filename_insert;
            //this.richTextBox1.Text = this.richTextBox1.Text +"\n"+ filename_insert;
            //return;
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null) throw new Exception("Can't create and open a connection");
                SqlCommand cmd = new SqlCommand(filename_insert, con);
                SqlDataReader reader = cmd.ExecuteReader();

                //listBox1.Items.Add(filename.ToString());
                this.richTextBox1.Text = filename + " inserted.\n" + this.richTextBox1.Text;
                SqlConnection con2 = Database.GetConnectionObj();
                StreamReader sr = new StreamReader(fullpath);

                int sl = 0;
                while (sr.EndOfStream == false)
                {
                    sl++;
                    string line = sr.ReadLine();
                    //sl = Int32.Parse(line.Substring(0,10));
                    string insert_line = string.Format(
                        "INSERT INTO [dbo].[E_solving] " +
                        "([file_name] " +
                        ",[scanned_row]" +
                        ",[serial]) VALUES ('{0}','{1}','{2}')",
                        filename, line, sl);
                        //richTextBox1.AppendText(filename);
                    esolve es=new esolve();
                    //espan(string username, string filename, string sub_code)
                    
                    es.espan(filename, sub_code, "");
                    //SqlCommand command = new SqlCommand(insert_line, con2);
                    //SqlCommand command = new SqlCommand(insert_line, con2);
                    int tr = 0;
                Back:
                    tr++;
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(insert_line, con2);
                        cmd1.ExecuteNonQuery();
                        //SqlDataReader reader1 = cmd1.ExecuteReader();                        
                    }
                    catch (Exception ee)
                    {
                        //this.richTextBox1.Text = filename + "ROW insertion FAILED. " + tr + "time\n" + line + "\n" + this.richTextBox1.Text;
                        //MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                        if (tr < 100)
                            goto Back;
                        else
                        {
                            //this.richTextBox1.Text += filename + "Permanent ROW insertion FAILED. " + ++tr + "time\n" + line + "\n" + this.richTextBox1.Text;
                            this.richTextBox1.Text = insert_line + "\n" + this.richTextBox1.Text;

                        }
                    }
                    StreamWriter lg = new StreamWriter("log.log");
                    lg.Write(this.richTextBox1.Text.ToString());
                    lg.Dispose();
                }
                sr.Dispose();
                //con2.Close();
                con.Close();
                con.Dispose();
              

            }
            catch (Exception ee)
            {
                this.richTextBox1.Text = filename + " insertion FAILED. May be same file name already exissts.\n" + this.richTextBox1.Text;
                //MessageBox.Show(string.Format("{0} May be alredy uploaded in Database", filename));
                //MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                //Application.Exit();
            }
        }

        private void exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
    }
}
