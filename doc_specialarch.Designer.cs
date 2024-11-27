namespace MBOS_Full_System
{
    partial class doc_specialarch
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
            this.components = new System.ComponentModel.Container();
            this.archiv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.deptname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butsave = new System.Windows.Forms.Button();
            this.butdisplayall = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.butdocarchived = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doc_subject = new System.Windows.Forms.TextBox();
            this.foldernames = new System.Windows.Forms.TextBox();
            this.doc_id = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sp_idfolder = new System.Windows.Forms.ComboBox();
            this.room_id = new System.Windows.Forms.ComboBox();
            this.no_shlf = new System.Windows.Forms.ComboBox();
            this.no_ra = new System.Windows.Forms.ComboBox();
            this.butsearch = new System.Windows.Forms.Button();
            this.txt_deptid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doctype = new System.Windows.Forms.CheckBox();
            this.mai_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.archivetype = new System.Windows.Forms.CheckBox();
            this.specialArchiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialArchiveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox14 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialArchiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialArchiveBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // archiv
            // 
            this.archiv.DataPropertyName = "ارشفة";
            this.archiv.HeaderText = "ارشفة";
            this.archiv.Name = "archiv";
            this.archiv.Text = "أرشفة";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20.30457F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "رقم الوثيقة";
            // 
            // deptname
            // 
            this.deptname.Location = new System.Drawing.Point(794, 215);
            this.deptname.Name = "deptname";
            this.deptname.Size = new System.Drawing.Size(150, 20);
            this.deptname.TabIndex = 70;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.archiv});
            this.dataGridView1.Location = new System.Drawing.Point(66, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 231);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butsave.Location = new System.Drawing.Point(780, 297);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(140, 39);
            this.butsave.TabIndex = 0;
            this.butsave.Text = "حفظ";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // butdisplayall
            // 
            this.butdisplayall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butdisplayall.Location = new System.Drawing.Point(426, 297);
            this.butdisplayall.Name = "butdisplayall";
            this.butdisplayall.Size = new System.Drawing.Size(143, 42);
            this.butdisplayall.TabIndex = 3;
            this.butdisplayall.Text = "عرض الكل ";
            this.butdisplayall.UseVisualStyleBackColor = false;
            this.butdisplayall.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new.Location = new System.Drawing.Point(939, 297);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(129, 39);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.button2_Click);
            // 
            // butupdate
            // 
            this.butupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butupdate.Location = new System.Drawing.Point(608, 298);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(140, 41);
            this.butupdate.TabIndex = 6;
            this.butupdate.Text = "تعديل";
            this.butupdate.UseVisualStyleBackColor = false;
            this.butupdate.Click += new System.EventHandler(this.button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(994, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "رقم الدولاب";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1011, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "موضوع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, -146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "رقم المدير";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "رقم غرفة ";
            // 
            // butexit
            // 
            this.butexit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butexit.Location = new System.Drawing.Point(119, 296);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(127, 44);
            this.butexit.TabIndex = 4;
            this.butexit.Text = "خروج";
            this.butexit.UseVisualStyleBackColor = false;
            this.butexit.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(990, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "اسم المجلد  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الرف";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "بحث";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // butdocarchived
            // 
            this.butdocarchived.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.butdocarchived.Location = new System.Drawing.Point(273, 296);
            this.butdocarchived.Name = "butdocarchived";
            this.butdocarchived.Size = new System.Drawing.Size(127, 44);
            this.butdocarchived.TabIndex = 7;
            this.butdocarchived.Text = "الوثائق المؤرشفة يدويا";
            this.butdocarchived.UseVisualStyleBackColor = false;
            this.butdocarchived.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(950, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الارشيف الخاص";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.doc_subject);
            this.panel1.Controls.Add(this.foldernames);
            this.panel1.Controls.Add(this.doc_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sp_idfolder);
            this.panel1.Controls.Add(this.room_id);
            this.panel1.Controls.Add(this.no_shlf);
            this.panel1.Controls.Add(this.no_ra);
            this.panel1.Controls.Add(this.butexit);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.butdocarchived);
            this.panel1.Controls.Add(this.butupdate);
            this.panel1.Controls.Add(this.butdisplayall);
            this.panel1.Controls.Add(this.butsearch);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.txt_deptid);
            this.panel1.Controls.Add(this.butsave);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.mai_id);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.deptname);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 351);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // doc_subject
            // 
            this.doc_subject.Location = new System.Drawing.Point(823, 69);
            this.doc_subject.Name = "doc_subject";
            this.doc_subject.Size = new System.Drawing.Size(120, 20);
            this.doc_subject.TabIndex = 92;
            // 
            // foldernames
            // 
            this.foldernames.Location = new System.Drawing.Point(794, 165);
            this.foldernames.Name = "foldernames";
            this.foldernames.Size = new System.Drawing.Size(149, 20);
            this.foldernames.TabIndex = 91;
            // 
            // doc_id
            // 
            this.doc_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doc_id.FormattingEnabled = true;
            this.doc_id.Location = new System.Drawing.Point(470, 18);
            this.doc_id.Name = "doc_id";
            this.doc_id.Size = new System.Drawing.Size(121, 21);
            this.doc_id.TabIndex = 90;
            this.doc_id.SelectedIndexChanged += new System.EventHandler(this.doc_id_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1002, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "اسم القسم";
            // 
            // sp_idfolder
            // 
            this.sp_idfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sp_idfolder.FormattingEnabled = true;
            this.sp_idfolder.Location = new System.Drawing.Point(823, 22);
            this.sp_idfolder.Name = "sp_idfolder";
            this.sp_idfolder.Size = new System.Drawing.Size(121, 21);
            this.sp_idfolder.TabIndex = 88;
            this.sp_idfolder.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // room_id
            // 
            this.room_id.FormattingEnabled = true;
            this.room_id.Location = new System.Drawing.Point(470, 114);
            this.room_id.Name = "room_id";
            this.room_id.Size = new System.Drawing.Size(121, 21);
            this.room_id.TabIndex = 86;
            // 
            // no_shlf
            // 
            this.no_shlf.FormattingEnabled = true;
            this.no_shlf.Location = new System.Drawing.Point(823, 113);
            this.no_shlf.Name = "no_shlf";
            this.no_shlf.Size = new System.Drawing.Size(121, 21);
            this.no_shlf.TabIndex = 85;
            // 
            // no_ra
            // 
            this.no_ra.FormattingEnabled = true;
            this.no_ra.Location = new System.Drawing.Point(470, 165);
            this.no_ra.Name = "no_ra";
            this.no_ra.Size = new System.Drawing.Size(121, 21);
            this.no_ra.TabIndex = 84;
            this.no_ra.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // butsearch
            // 
            this.butsearch.Location = new System.Drawing.Point(19, 227);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(81, 23);
            this.butsearch.TabIndex = 9;
            this.butsearch.Text = "بحث";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Visible = false;
            this.butsearch.Click += new System.EventHandler(this.button9_Click);
            // 
            // txt_deptid
            // 
            this.txt_deptid.Location = new System.Drawing.Point(9, 193);
            this.txt_deptid.Name = "txt_deptid";
            this.txt_deptid.Size = new System.Drawing.Size(100, 20);
            this.txt_deptid.TabIndex = 78;
            this.txt_deptid.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(613, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 76;
            this.label13.Text = "رقم المراسلة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doctype);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 89);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع الوثيقة";
            // 
            // doctype
            // 
            this.doctype.AutoSize = true;
            this.doctype.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.doctype.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctype.Location = new System.Drawing.Point(34, 34);
            this.doctype.Name = "doctype";
            this.doctype.Size = new System.Drawing.Size(72, 27);
            this.doctype.TabIndex = 64;
            this.doctype.Text = "صورة";
            this.doctype.UseVisualStyleBackColor = true;
            // 
            // mai_id
            // 
            this.mai_id.Location = new System.Drawing.Point(463, 69);
            this.mai_id.Name = "mai_id";
            this.mai_id.Size = new System.Drawing.Size(128, 20);
            this.mai_id.TabIndex = 75;
            this.mai_id.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.archivetype);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(209, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 89);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع الارشفة";
            // 
            // archivetype
            // 
            this.archivetype.AutoSize = true;
            this.archivetype.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.archivetype.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivetype.Location = new System.Drawing.Point(35, 25);
            this.archivetype.Name = "archivetype";
            this.archivetype.Size = new System.Drawing.Size(71, 27);
            this.archivetype.TabIndex = 62;
            this.archivetype.Text = "اليدوية";
            this.archivetype.UseVisualStyleBackColor = true;
            this.archivetype.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // specialArchiveBindingSource
            // 
            this.specialArchiveBindingSource.DataMember = "special_Archive";
            // 
            // specialArchiveBindingSource1
            // 
            this.specialArchiveBindingSource1.DataMember = "special_Archive";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(-3, 398);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(63, 20);
            this.textBox14.TabIndex = 84;
            this.textBox14.Visible = false;
            // 
            // doc_specialarch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 110);
            this.Name = "doc_specialarch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الارشيف الخاص";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialArchiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialArchiveBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn archiv;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deptname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.BindingSource specialArchiveBindingSource;
        private System.Windows.Forms.Button butdisplayall;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button butdocarchived;
        private System.Windows.Forms.BindingSource specialArchiveBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox archivetype;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_deptid;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.CheckBox doctype;
        public System.Windows.Forms.TextBox mai_id;
        private System.Windows.Forms.ComboBox no_ra;
        private System.Windows.Forms.ComboBox no_shlf;
        private System.Windows.Forms.ComboBox room_id;
        private System.Windows.Forms.ComboBox doc_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sp_idfolder;
        private System.Windows.Forms.TextBox foldernames;
        private System.Windows.Forms.TextBox doc_subject;
        private System.Windows.Forms.TextBox textBox14;
    }
}