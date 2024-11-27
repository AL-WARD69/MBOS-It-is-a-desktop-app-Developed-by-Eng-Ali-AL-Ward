namespace MBOS_Full_System
{
    partial class add_general_archive
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
            this.txt_genaralid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_deptid = new System.Windows.Forms.TextBox();
            this.txt_foldername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_deptname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btnquit = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_genaralid
            // 
            this.txt_genaralid.Location = new System.Drawing.Point(413, 50);
            this.txt_genaralid.Name = "txt_genaralid";
            this.txt_genaralid.Size = new System.Drawing.Size(100, 20);
            this.txt_genaralid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الارشيف العام";
            // 
            // txt_deptid
            // 
            this.txt_deptid.Enabled = false;
            this.txt_deptid.Location = new System.Drawing.Point(145, 106);
            this.txt_deptid.Name = "txt_deptid";
            this.txt_deptid.Size = new System.Drawing.Size(34, 20);
            this.txt_deptid.TabIndex = 2;
            // 
            // txt_foldername
            // 
            this.txt_foldername.Location = new System.Drawing.Point(373, 140);
            this.txt_foldername.Name = "txt_foldername";
            this.txt_foldername.Size = new System.Drawing.Size(141, 20);
            this.txt_foldername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "تاريخ الاضافة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "أسم المجلد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "الموظف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "الجهة";
            // 
            // txt_userid
            // 
            this.txt_userid.Enabled = false;
            this.txt_userid.Location = new System.Drawing.Point(145, 50);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(34, 20);
            this.txt_userid.TabIndex = 11;
            // 
            // txt_deptname
            // 
            this.txt_deptname.Enabled = false;
            this.txt_deptname.Location = new System.Drawing.Point(12, 106);
            this.txt_deptname.Name = "txt_deptname";
            this.txt_deptname.Size = new System.Drawing.Size(127, 20);
            this.txt_deptname.TabIndex = 12;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(438, 202);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(12, 50);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(127, 20);
            this.txt_username.TabIndex = 14;
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(91, 202);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(75, 23);
            this.btnquit.TabIndex = 15;
            this.btnquit.Text = "خروج";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // txt_date
            // 
            this.txt_date.CustomFormat = "dd-MM-yyyy";
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_date.Location = new System.Drawing.Point(373, 99);
            this.txt_date.Name = "txt_date";
            this.txt_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_date.RightToLeftLayout = true;
            this.txt_date.Size = new System.Drawing.Size(141, 20);
            this.txt_date.TabIndex = 16;
            // 
            // add_general_archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(650, 336);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txt_deptname);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_foldername);
            this.Controls.Add(this.txt_deptid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_genaralid);
            this.Name = "add_general_archive";
            this.Text = "general_archive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.general_archives_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_genaralid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_deptid;
        private System.Windows.Forms.TextBox txt_foldername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.TextBox txt_deptname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.DateTimePicker txt_date;
    }
}