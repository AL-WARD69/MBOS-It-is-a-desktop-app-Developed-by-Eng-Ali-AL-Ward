namespace MBOS_Full_System
{
    partial class display
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(display));
            this.btnprintall = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.االمرفقات = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtempsend = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(this.btnprintall);
            panel1.Controls.Add(this.btnprint);
            panel1.Controls.Add(this.btnsearch);
            panel1.Controls.Add(this.btnquit);
            panel1.Controls.Add(this.dataGridView1);
            panel1.Controls.Add(this.label8);
            panel1.Controls.Add(this.txtempsend);
            panel1.Controls.Add(this.txt_userid);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            panel1.Size = new System.Drawing.Size(1012, 536);
            panel1.TabIndex = 1;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnprintall
            // 
            this.btnprintall.Location = new System.Drawing.Point(154, 221);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.Size = new System.Drawing.Size(180, 43);
            this.btnprintall.TabIndex = 38;
            this.btnprintall.Text = "طباعة الكل";
            this.btnprintall.UseVisualStyleBackColor = true;
            this.btnprintall.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(154, 172);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(180, 43);
            this.btnprint.TabIndex = 37;
            this.btnprint.Text = "طباعة ";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(154, 123);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(180, 43);
            this.btnsearch.TabIndex = 35;
            this.btnsearch.Text = "بحث";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnquit.Location = new System.Drawing.Point(154, 270);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(180, 43);
            this.btnquit.TabIndex = 34;
            this.btnquit.Text = "خروج";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.االمرفقات});
            this.dataGridView1.Location = new System.Drawing.Point(142, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // االمرفقات
            // 
            this.االمرفقات.HeaderText = "المرفقات";
            this.االمرفقات.Name = "االمرفقات";
            this.االمرفقات.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.االمرفقات.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(909, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "بيانات البحث";
            // 
            // txtempsend
            // 
            this.txtempsend.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsend.Location = new System.Drawing.Point(531, 141);
            this.txtempsend.Name = "txtempsend";
            this.txtempsend.Size = new System.Drawing.Size(355, 25);
            this.txtempsend.TabIndex = 26;
            this.txtempsend.TextChanged += new System.EventHandler(this.txtempsend_TextChanged);
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(290, 97);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(91, 20);
            this.txt_userid.TabIndex = 16;
            this.txt_userid.Visible = false;
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1012, 536);
            this.Controls.Add(panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(1, 110);
            this.Name = "display";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "display";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.display_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtempsend;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnprintall;
        private System.Windows.Forms.DataGridViewButtonColumn االمرفقات;

    }
}