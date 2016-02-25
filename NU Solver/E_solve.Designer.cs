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
            this.lbltotal_record = new System.Windows.Forms.Label();
            this.lbltotal_error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bundle_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_current_user = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAllError = new System.Windows.Forms.Button();
            this.btnNextError = new System.Windows.Forms.Button();
            this.btnShowError = new System.Windows.Forms.Button();
            this.btnReleaseFile = new System.Windows.Forms.Button();
            this.btnFinishPost = new System.Windows.Forms.Button();
            this.btnReplaceSubject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentRecord = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new NU_Solver.myDataGridView();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Record:";
            // 
            // lbltotal_record
            // 
            this.lbltotal_record.AutoSize = true;
            this.lbltotal_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_record.ForeColor = System.Drawing.Color.Maroon;
            this.lbltotal_record.Location = new System.Drawing.Point(135, 9);
            this.lbltotal_record.Name = "lbltotal_record";
            this.lbltotal_record.Size = new System.Drawing.Size(19, 20);
            this.lbltotal_record.TabIndex = 3;
            this.lbltotal_record.Text = "0";
            // 
            // lbltotal_error
            // 
            this.lbltotal_error.AutoSize = true;
            this.lbltotal_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_error.ForeColor = System.Drawing.Color.Maroon;
            this.lbltotal_error.Location = new System.Drawing.Point(647, 9);
            this.lbltotal_error.Name = "lbltotal_error";
            this.lbltotal_error.Size = new System.Drawing.Size(19, 20);
            this.lbltotal_error.TabIndex = 5;
            this.lbltotal_error.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Error:";
            // 
            // lbl_bundle_name
            // 
            this.lbl_bundle_name.AutoSize = true;
            this.lbl_bundle_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bundle_name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_bundle_name.Location = new System.Drawing.Point(898, 9);
            this.lbl_bundle_name.Name = "lbl_bundle_name";
            this.lbl_bundle_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_bundle_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bundle Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_current_user);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 713);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 27);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(645, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sif view:";
            // 
            // lbl_current_user
            // 
            this.lbl_current_user.AutoSize = true;
            this.lbl_current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_user.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_current_user.Location = new System.Drawing.Point(118, 3);
            this.lbl_current_user.Name = "lbl_current_user";
            this.lbl_current_user.Size = new System.Drawing.Size(0, 20);
            this.lbl_current_user.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "User name: ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(1084, 668);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAllError
            // 
            this.btnAllError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllError.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAllError.Location = new System.Drawing.Point(1083, 329);
            this.btnAllError.Name = "btnAllError";
            this.btnAllError.Size = new System.Drawing.Size(136, 33);
            this.btnAllError.TabIndex = 10;
            this.btnAllError.Text = "&All Error";
            this.btnAllError.UseVisualStyleBackColor = true;
            this.btnAllError.Click += new System.EventHandler(this.btnAllError_Click);
            // 
            // btnNextError
            // 
            this.btnNextError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextError.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNextError.Location = new System.Drawing.Point(1083, 369);
            this.btnNextError.Name = "btnNextError";
            this.btnNextError.Size = new System.Drawing.Size(136, 33);
            this.btnNextError.TabIndex = 11;
            this.btnNextError.Text = "&Next Error";
            this.btnNextError.UseVisualStyleBackColor = true;
            this.btnNextError.Click += new System.EventHandler(this.btnNextError_Click);
            // 
            // btnShowError
            // 
            this.btnShowError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowError.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnShowError.Location = new System.Drawing.Point(1083, 409);
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.Size = new System.Drawing.Size(136, 33);
            this.btnShowError.TabIndex = 12;
            this.btnShowError.Text = "&Show Error";
            this.btnShowError.UseVisualStyleBackColor = true;
            this.btnShowError.Click += new System.EventHandler(this.btnShowError_Click);
            // 
            // btnReleaseFile
            // 
            this.btnReleaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseFile.ForeColor = System.Drawing.Color.Indigo;
            this.btnReleaseFile.Location = new System.Drawing.Point(1083, 499);
            this.btnReleaseFile.Name = "btnReleaseFile";
            this.btnReleaseFile.Size = new System.Drawing.Size(136, 33);
            this.btnReleaseFile.TabIndex = 13;
            this.btnReleaseFile.Text = "&Release File";
            this.btnReleaseFile.UseVisualStyleBackColor = true;
            this.btnReleaseFile.Click += new System.EventHandler(this.btnReleaseFile_Click_1);
            // 
            // btnFinishPost
            // 
            this.btnFinishPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishPost.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinishPost.Location = new System.Drawing.Point(1083, 539);
            this.btnFinishPost.Name = "btnFinishPost";
            this.btnFinishPost.Size = new System.Drawing.Size(136, 33);
            this.btnFinishPost.TabIndex = 14;
            this.btnFinishPost.Text = "&Finish and Post";
            this.btnFinishPost.UseVisualStyleBackColor = true;
            this.btnFinishPost.Click += new System.EventHandler(this.btnFinishPost_Click);
            // 
            // btnReplaceSubject
            // 
            this.btnReplaceSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceSubject.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReplaceSubject.Location = new System.Drawing.Point(1084, 448);
            this.btnReplaceSubject.Name = "btnReplaceSubject";
            this.btnReplaceSubject.Size = new System.Drawing.Size(136, 33);
            this.btnReplaceSubject.TabIndex = 15;
            this.btnReplaceSubject.Text = "Repla&ce Subject";
            this.btnReplaceSubject.UseVisualStyleBackColor = true;
            this.btnReplaceSubject.Click += new System.EventHandler(this.btnReplaceSubject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 208);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentRecord
            // 
            this.lblCurrentRecord.AutoSize = true;
            this.lblCurrentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRecord.ForeColor = System.Drawing.Color.Maroon;
            this.lblCurrentRecord.Location = new System.Drawing.Point(413, 10);
            this.lblCurrentRecord.Name = "lblCurrentRecord";
            this.lblCurrentRecord.Size = new System.Drawing.Size(19, 20);
            this.lblCurrentRecord.TabIndex = 18;
            this.lblCurrentRecord.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Current Record:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1070, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 214);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(118, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Macintosh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.dataGridView1.Size = new System.Drawing.Size(1056, 669);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellValueChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressedOnCell);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(1084, 620);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(136, 33);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1139, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // E_solve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblCurrentRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReplaceSubject);
            this.Controls.Add(this.btnFinishPost);
            this.Controls.Add(this.btnReleaseFile);
            this.Controls.Add(this.btnShowError);
            this.Controls.Add(this.btnNextError);
            this.Controls.Add(this.btnAllError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_bundle_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotal_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotal_record);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dataGridView1;
        myDataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private Label lbltotal_record;
        private Label lbltotal_error;
        private Label label3;
        private Label lbl_bundle_name;
        private Label label5;
        private Panel panel1;
        private Label lbl_current_user;
        private Label label4;
        private Button btnClose;
        private Button btnAllError;
        private Button btnNextError;
        private Button btnShowError;
        private Button btnReleaseFile;
        private Button btnFinishPost;
        private Button btnReplaceSubject;
        private PictureBox pictureBox1;
        private Label lblCurrentRecord;
        private Label label6;
        private Panel panel2;
        private Label label2;
        private Button btnChangePassword;
        private Label label8;
        private Label label7;
        private Button button1;// = new myDataGridView();
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