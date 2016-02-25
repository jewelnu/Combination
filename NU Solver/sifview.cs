using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace NU_Solver
{
    public partial class sifview : Form
    {
        private string comtext;
        public string reg1 = "";

        public sifview(string comdtext1, string reg)
        {
            InitializeComponent();
            comtext = comdtext1;
            //MessageBox.Show(comtext);

            SqlConnection con = Database.GetConnectionObj();
            SqlCommand cmd = new SqlCommand("", con);

            reg1 = reg;
            //MessageBox.Show(reg.ToString());
            cmd.CommandText = comtext;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            this.dataGridView1.AutoResizeColumns();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[2].Width = 200;
            con.Close();
        }

        private void GoRegino()
        {
            int maxrow = this.dataGridView1.RowCount - 1;
            //MessageBox.Show(maxrow.ToString());
            //string cur_str = "";
            //string search_pattern = "";
            int col = 1;
            //int col = this.dataGridView1.CurrentCell.ColumnIndex;
            int row = this.dataGridView1.CurrentCell.RowIndex; // +1;
            if (col == 1)
            {
                //subject code
                for (; row < this.dataGridView1.RowCount; row++)
                    //  MessageBox.Show(reg1.ToString());
                    if (this.dataGridView1.Rows[row].Cells[1].Value.ToString() == reg1.ToString())
                    {
                        //MessageBox.Show(this.dataGridView1.Rows[row].Cells[col].Value.ToString());
                        this.dataGridView1.CurrentCell = this.dataGridView1.Rows[row].Cells[col];
                        //e.Handled = true;
                        return;
                    }
                col = 1;
                row = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoRegino();

        }

        private void sifview_Load(object sender, EventArgs e)
        {
            GoRegino();
        }

        private void sifview_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

    }
}
