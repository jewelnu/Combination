using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NU_Solver
{
    public partial class slash : Form
    {
        //Timer tmr;
        public slash()
        {
            InitializeComponent();
        }
        private void slash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            lblStatus.Text = "Loading...";
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                if (progressBar1.Value >= 8) { lblStatus.Text = "Successfully loading..."; }
                else if (progressBar1.Value >= 6) { lblStatus.Text = "SIF file loading..."; }
                else if (progressBar1.Value >= 4) { lblStatus.Text = "User loading..."; }
                else if (progressBar1.Value >= 2) { lblStatus.Text = "Bundle list loading..."; }
                else if (progressBar1.Value >= 1) { lblStatus.Text = "Error generating..."; }
                else { lblStatus.Text = "Progress...";}
                progressBar1.Value++;
                
            }
            else
            {
            
                timer1.Stop();
                //display mainform
                login mf = new login();
                mf.Show();
                //hide this form
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
