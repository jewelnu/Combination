using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NU_Solver
{
    public partial class SolveWindow : Form
    {
        public string filename = "";
        public string username = "";
        public string sub_code = "";
        //File_List caller;
        public DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public SolveWindow(string filename, string username,string sub, Form caller, bool needToSpan = false)
        {
            //this.caller = caller;
            this.filename = filename;
            this.sub_code = sub;
            //caller.Hide();
            InitializeComponent();
            if(needToSpan)
                span();
                CustomiseGridView();
        }
        private void litho_correction()
        {

            LithoCorrection L = new LithoCorrection();

            var result = L.ShowDialog();
            if (result == DialogResult.OK)
            {
                //string val = form.ReturnValue1;            //values preserved after close
                //string dateString = form.ReturnValue2;
                ////Do something here with these values

                ////for example
                //this.txtSomething.Text = val;
                MessageBox.Show("here" );
            }
            else

                MessageBox.Show("there");
        }
        private void CustomiseGridView()
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();                
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandText = string.Format("SELECT id, serial, err_dscr, exam_code, pap_code, regi, qr_code, scrpt_no, litho_1, litho_2 FROM dbo.E_solving where file_name = '{0}' order by id",filename);
                da.SelectCommand = cmd;
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].Visible = false;
                //this.dataGridView1.Columns[0].Width = 30;
                //this.dataGridView1.Columns[2].Width = 50;
                //this.dataGridView1.Columns[3].Width = 80;
                //this.dataGridView1.Columns[4].Width = 80;
                //this.dataGridView1.Columns[5].Width = 50;
                //this.dataGridView1.Columns[6].Width = 200;
                //this.dataGridView1.Columns[7].Width = 200;
                //DataGridViewTextBoxColumn binary = (DataGridViewTextBoxColumn)this.dataGridView1.Columns[6];
                //binary.MaxInputLength = 32;
                //DataGridViewTextBoxColumn exam_code = (DataGridViewTextBoxColumn)this.dataGridView1.Columns[2];
                //exam_code.MaxInputLength = 3;
                //DataGridViewTextBoxColumn exam_roll = (DataGridViewTextBoxColumn)this.dataGridView1.Columns[3];
                //exam_roll.MaxInputLength = 7;
                //DataGridViewTextBoxColumn reg_no = (DataGridViewTextBoxColumn)this.dataGridView1.Columns[4];
                //reg_no.MaxInputLength = 7;
                //DataGridViewTextBoxColumn sub_code = (DataGridViewTextBoxColumn)this.dataGridView1.Columns[5];
                //sub_code.MaxInputLength = 4;
                //this.dataGridView1.AllowUserToAddRows = false;
                //this.dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
                //this.dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
                //con.Close();                
            }
            catch (Exception ee)
            {
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
        }
        public void span()        
        {
            try
            {
                SqlConnection con = Database.GetConnectionObj();
                if (con == null)
                {
                    MessageBox.Show("Connection Problem");
                    return;
                }
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandText = string.Format("SELECT id, scanned_row, file_name FROM dbo.E_solving WHERE file_name = '{0}' ",filename);
                SqlDataReader reader = cmd.ExecuteReader();
                int serial = 1;
                int affectedRow=0;
                SqlConnection con2 = Database.GetConnectionObj();
                while (reader.Read())
                {
                    //MessageBox.Show(reader[0].ToString());
                    int id = Convert.ToInt32(reader["id"]);
                    string line = reader["scanned_row"].ToString();
                    if (line.Length != 144)
                        line = line + "        ";

                    //int n = dataGridView1.Rows.Add();
                    //string scan_sl = line.Substring(0, 50);
                    //string scan_sl = line.Substring(0, 50).Replace(' ', '*');
                    string dexcode      = line.Substring( 50, 32).Replace(' ', '0');
                    string exam_code    = line.Substring( 82,  3).Replace(' ', '*');
                    string reg_no       = line.Substring( 85, 11).Replace(' ', '*');
                    string pap_code     = line.Substring( 96,  6).Replace(' ', '*');
                    string hexcode      = line.Substring(102, 32).Replace(' ', '0');
                    //string err_dscr = "error goes here";
                    string err_dscr = checkExamCode(exam_code) +
                        checkSubjectCode(pap_code) +
                        checkRegi(reg_no) +
                        checkLitho("", "", dexcode, hexcode);

                    string update = string.Format( 
                        "UPDATE dbo.E_solving SET err_dscr = '{0}',exam_code = '{1}',pap_code = '{2}',regi = '{3}',litho_1 = '{4}',litho_2 = '{5}',updates = '{6}', serial = {7} WHERE id = '{8}'",
                        err_dscr,exam_code,pap_code,reg_no,dexcode,hexcode,"",serial++, id);
                    //MessageBox.Show(update);
                    //cmd.CommandText = update;
                    SqlCommand command = new SqlCommand(update, con2);
                    //SqlDataReader reader2 = command.ExecuteReader();
                    //command.ExecuteReader();
                    affectedRow = command.ExecuteNonQuery();
                    //MessageBox.Show(affectedRow.ToString()+" rows affected for id "+ id.ToString());
                }
                reader.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Database error.\n" + ee.StackTrace.ToString());
                Application.Exit();
            }
        }

        private void onSolveWindowClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void keyPressedOnCell(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //MessageBox.Show(this.dataGridView1.CurrentCell.RowIndex.ToString());
                //L.Show();
                litho_correction();
                //dataGridView1.BeginEdit(true);
                e.Handled = true;
            }
            else if (e.KeyChar == '+')
            {
                int rowno,
                next_col = 1,
                    //current_row = this.dataGridView1.CurrentCell.RowIndex,
                maxrow = this.dataGridView1.RowCount - 1;
                string search_pattern = "";
                int col = this.dataGridView1.CurrentCell.ColumnIndex;
                int row =this.dataGridView1.CurrentCell.RowIndex+1;
                if(col <=3){ //exam code
                    col = 3;
                    for (; row < this.dataGridView1.RowCount; row++)
                        if (this.dataGridView1.Rows[row].Cells[3].Value.ToString() != "201")
                        {
                            //MessageBox.Show(this.dataGridView1.Rows[row].Cells[3].Value.ToString());
                            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[row].Cells[3];
                            e.Handled = true;
                            return;
                        }
                    col=4;
                    row = 0;
                }
                if (col == 4)
                { //subject code
                    for (; row < this.dataGridView1.RowCount; row++)
                        if (this.dataGridView1.Rows[row].Cells[col].Value.ToString() != this.sub_code)
                        {
                            //MessageBox.Show(this.dataGridView1.Rows[row].Cells[col].Value.ToString());
                            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[row].Cells[col];
                            e.Handled = true;
                            return;
                        }
                    col = 5;
                    row = 0;
                }

                if (col == 5)
                { //subject code
                    for (; row < this.dataGridView1.RowCount; row++)
                        if (this.dataGridView1.Rows[row].Cells[2].Value.ToString().Contains("Regi"))
                        {
                            //MessageBox.Show(this.dataGridView1.Rows[row].Cells[col].Value.ToString());
                            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[row].Cells[col];
                            e.Handled = true;
                            return;
                        }
                    col = 6;
                    row = 0;
                }
                if (col > 5)
                { //subject code
                    for (; row < this.dataGridView1.RowCount; row++)
                        if (this.dataGridView1.Rows[row].Cells[2].Value.ToString().Contains("Litho"))
                        {
                            //MessageBox.Show(this.dataGridView1.Rows[row].Cells[col].Value.ToString());
                            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[row].Cells[7];
                            e.Handled = true;
                            return;
                        }
                    //col = 6;
                    //row = 0;
                }
                e.Handled = true;
            }
        }
        private string checkExamCode(string s) { return s != "201" ? "Exam code is not 201." : ""; }
        private string checkSubjectCode(string s) { return s != this.sub_code ? "Subject code is not " + this.sub_code + "." : ""; }
        private string checkRegi(string regi) {
            if( ! Regex.IsMatch(regi, @"^\d+$") )
                return "Regi Contains Invalid Caracter."; 
            return "";
        }
        private string checkLitho(string qr,string scrpt_no, string litho1, string litho2)
        {
            if (!Regex.IsMatch(litho1, @"^[10]+$"))
                return "Litho 1 Contains Invalid Caracter.";
            else if (!Regex.IsMatch(litho2, @"^[10]+$"))
                return "Litho 2 Contains Invalid Caracter.";
            else if (litho1 != litho2)
                return "Litho 1 & Litho 2 not Identical.";            
            return "";
        }

       
    }
}
