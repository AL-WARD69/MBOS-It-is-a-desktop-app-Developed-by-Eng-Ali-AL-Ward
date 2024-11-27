namespace MBOS_Full_System
{
    partial class Header
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
            this.txt_headerid = new System.Windows.Forms.TextBox();
            this.txt_en_name = new System.Windows.Forms.TextBox();
            this.txt_ar_name = new System.Windows.Forms.TextBox();
            this.add_logo = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_deptname = new System.Windows.Forms.TextBox();
            this.txt_deptid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_headerid
            // 
            this.txt_headerid.Location = new System.Drawing.Point(336, 27);
            this.txt_headerid.Name = "txt_headerid";
            this.txt_headerid.Size = new System.Drawing.Size(100, 20);
            this.txt_headerid.TabIndex = 0;
            // 
            // txt_en_name
            // 
            this.txt_en_name.Location = new System.Drawing.Point(250, 104);
            this.txt_en_name.Name = "txt_en_name";
            this.txt_en_name.Size = new System.Drawing.Size(186, 20);
            this.txt_en_name.TabIndex = 1;
            // 
            // txt_ar_name
            // 
            this.txt_ar_name.Location = new System.Drawing.Point(250, 63);
            this.txt_ar_name.Name = "txt_ar_name";
            this.txt_ar_name.Size = new System.Drawing.Size(186, 20);
            this.txt_ar_name.TabIndex = 2;
            // 
            // add_logo
            // 
            this.add_logo.Location = new System.Drawing.Point(80, 156);
            this.add_logo.Name = "add_logo";
            this.add_logo.Size = new System.Drawing.Size(126, 23);
            this.add_logo.TabIndex = 5;
            this.add_logo.Text = "أضافة شعار";
            this.add_logo.UseVisualStyleBackColor = true;
            this.add_logo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(431, 412);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(276, 412);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "رقم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "الاسم الانجليزي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "الاسم العربي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "اسم القسم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "الشعار";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo.Location = new System.Drawing.Point(80, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(126, 112);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 67;
            this.logo.TabStop = false;
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(38, 412);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 70;
            this.btn_quit.Text = "خروج";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(520, 210);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(168, 412);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 72;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_deptname
            // 
            this.txt_deptname.Location = new System.Drawing.Point(255, 143);
            this.txt_deptname.Name = "txt_deptname";
            this.txt_deptname.Size = new System.Drawing.Size(147, 20);
            this.txt_deptname.TabIndex = 73;
            // 
            // txt_deptid
            // 
            this.txt_deptid.Location = new System.Drawing.Point(408, 143);
            this.txt_deptid.Name = "txt_deptid";
            this.txt_deptid.Size = new System.Drawing.Size(28, 20);
            this.txt_deptid.TabIndex = 74;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 462);
            this.Controls.Add(this.txt_deptid);
            this.Controls.Add(this.txt_deptname);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.add_logo);
            this.Controls.Add(this.txt_ar_name);
            this.Controls.Add(this.txt_en_name);
            this.Controls.Add(this.txt_headerid);
            this.Name = "Header";
            this.Text = "Header";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Header_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_headerid;
        private System.Windows.Forms.TextBox txt_en_name;
        private System.Windows.Forms.TextBox txt_ar_name;
        private System.Windows.Forms.Button add_logo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_deptname;
        private System.Windows.Forms.TextBox txt_deptid;
    }
}