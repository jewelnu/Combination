using System.Windows.Forms;
namespace NU_Solver
{
    partial class E_solve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_solve));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cell_val = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_bundle_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_current_user = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btnReleaseFile = new System.Windows.Forms.Button();
            this.cmdNextError = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotal_record = new System.Windows.Forms.Label();
            this.lblcurrent_record = new System.Windows.Forms.Label();
            this.lbltotal_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangeSub = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1127, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Record: ";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(1108, 370);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(123, 32);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lbl_cell_val);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_bundle_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_current_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Location = new System.Drawing.Point(1, 774);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 22);
            this.panel1.TabIndex = 6;
            // 
            // lbl_cell_val
            // 
            this.lbl_cell_val.AutoSize = true;
            this.lbl_cell_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cell_val.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_cell_val.Location = new System.Drawing.Point(715, 3);
            this.lbl_cell_val.Name = "lbl_cell_val";
            this.lbl_cell_val.Size = new System.Drawing.Size(20, 16);
            this.lbl_cell_val.TabIndex = 20;
            this.lbl_cell_val.Text = "0 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(600, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Active Cell:";
            // 
            // lbl_bundle_name
            // 
            this.lbl_bundle_name.AutoSize = true;
            this.lbl_bundle_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bundle_name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_bundle_name.Location = new System.Drawing.Point(432, 3);
            this.lbl_bundle_name.Name = "lbl_bundle_name";
            this.lbl_bundle_name.Size = new System.Drawing.Size(20, 16);
            this.lbl_bundle_name.TabIndex = 18;
            this.lbl_bundle_name.Text = "0 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(317, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bundle Name:";
            // 
            // lbl_current_user
            // 
            this.lbl_current_user.AutoSize = true;
            this.lbl_current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_user.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_current_user.Location = new System.Drawing.Point(57, 4);
            this.lbl_current_user.Name = "lbl_current_user";
            this.lbl_current_user.Size = new System.Drawing.Size(20, 16);
            this.lbl_current_user.TabIndex = 16;
            this.lbl_current_user.Text = "0 ";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_user.Location = new System.Drawing.Point(3, 4);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(53, 16);
            this.lbl_user.TabIndex = 10;
            this.lbl_user.Text = "User : ";
            // 
            // btnReleaseFile
            // 
            this.btnReleaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseFile.Location = new System.Drawing.Point(1108, 332);
            this.btnReleaseFile.Name = "btnReleaseFile";
            this.btnReleaseFile.Size = new System.Drawing.Size(123, 32);
            this.btnReleaseFile.TabIndex = 7;
            this.btnReleaseFile.Text = "&Release File";
            this.btnReleaseFile.UseVisualStyleBackColor = true;
            this.btnReleaseFile.Click += new System.EventHandler(this.btnReleaseFile_Click);
            // 
            // cmdNextError
            // 
            this.cmdNextError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNextError.Location = new System.Drawing.Point(1108, 248);
            this.cmdNextError.Name = "cmdNextError";
            this.cmdNextError.Size = new System.Drawing.Size(123, 32);
            this.cmdNextError.TabIndex = 8;
            this.cmdNextError.Text = "&Next Error/+";
            this.cmdNextError.UseVisualStyleBackColor = true;
            this.cmdNextError.Click += new System.EventHandler(this.cmdNextError_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(1108, 490);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(123, 32);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            //this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(229, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Record: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(487, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Error: ";
            // 
            // lbltotal_record
            // 
            this.lbltotal_record.AutoSize = true;
            this.lbltotal_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_record.ForeColor = System.Drawing.Color.Maroon;
            this.lbltotal_record.Location = new System.Drawing.Point(125, 9);
            this.lbltotal_record.Name = "lbltotal_record";
            this.lbltotal_record.Size = new System.Drawing.Size(24, 20);
            this.lbltotal_record.TabIndex = 13;
            this.lbltotal_record.Text = "0 ";
            // 
            // lblcurrent_record
            // 
            this.lblcurrent_record.AutoSize = true;
            this.lblcurrent_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrent_record.ForeColor = System.Drawing.Color.Maroon;
            this.lblcurrent_record.Location = new System.Drawing.Point(355, 9);
            this.lblcurrent_record.Name = "lblcurrent_record";
            this.lblcurrent_record.Size = new System.Drawing.Size(24, 20);
            this.lblcurrent_record.TabIndex = 14;
            this.lblcurrent_record.Text = "0 ";
            // 
            // lbltotal_error
            // 
            this.lbltotal_error.AutoSize = true;
            this.lbltotal_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_error.ForeColor = System.Drawing.Color.Maroon;
            this.lbltotal_error.Location = new System.Drawing.Point(597, 9);
            this.lbltotal_error.Name = "lbltotal_error";
            this.lbltotal_error.Size = new System.Drawing.Size(24, 20);
            this.lbltotal_error.TabIndex = 15;
            this.lbltotal_error.Text = "0 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1101, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 170);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnChangeSub
            // 
            this.btnChangeSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSub.Location = new System.Drawing.Point(1108, 286);
            this.btnChangeSub.Name = "btnChangeSub";
            this.btnChangeSub.Size = new System.Drawing.Size(123, 32);
            this.btnChangeSub.TabIndex = 17;
            this.btnChangeSub.Text = "&Change Subject";
            this.btnChangeSub.UseVisualStyleBackColor = true;
            // 
            // E_solve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 801);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "E_solve";
            this.Text = "E_solve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onSolveWindowClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dataGridView1;
        myDataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private Button btnFinish;
        private Panel panel1;
        private Button btnReleaseFile;
        private Button cmdNextError;
        private Button cmdClose;
        private Label lbl_user;
        private Label label2;
        private Label label3;
        private Label lbltotal_record;
        private Label lblcurrent_record;
        private Label lbltotal_error;
        private Label lbl_current_user;
        private Label lbl_bundle_name;
        private Label label5;
        private Label lbl_cell_val;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnChangeSub;// = new myDataGridView();
    }
    class myDataGridView : System.Windows.Forms.DataGridView
    {
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return true;
            return base.ProcessDataGridViewKey(e);
        }
    }
}