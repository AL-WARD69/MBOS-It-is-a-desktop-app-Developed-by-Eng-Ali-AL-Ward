namespace MBOS_Full_System
{
    partial class archive_noti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archive_noti));
            this.txt_deptid2 = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtdept_name1 = new System.Windows.Forms.TextBox();
            this.txtdept_id = new System.Windows.Forms.TextBox();
            this.txtdeptname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_deptid2
            // 
            this.txt_deptid2.Location = new System.Drawing.Point(142, 128);
            this.txt_deptid2.Name = "txt_deptid2";
            this.txt_deptid2.Size = new System.Drawing.Size(100, 20);
            this.txt_deptid2.TabIndex = 15;
            this.txt_deptid2.Visible = false;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(914, 129);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(100, 20);
            this.txtuserid.TabIndex = 14;
            this.txtuserid.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(799, 128);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 13;
            this.textBox12.Visible = false;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(666, 129);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 12;
            this.txtusername.Visible = false;
            // 
            // txtdept_name1
            // 
            this.txtdept_name1.Location = new System.Drawing.Point(537, 128);
            this.txtdept_name1.Name = "txtdept_name1";
            this.txtdept_name1.Size = new System.Drawing.Size(100, 20);
            this.txtdept_name1.TabIndex = 11;
            this.txtdept_name1.Visible = false;
            // 
            // txtdept_id
            // 
            this.txtdept_id.Location = new System.Drawing.Point(391, 129);
            this.txtdept_id.Name = "txtdept_id";
            this.txtdept_id.Size = new System.Drawing.Size(100, 20);
            this.txtdept_id.TabIndex = 10;
            this.txtdept_id.Visible = false;
            // 
            // txtdeptname
            // 
            this.txtdeptname.Location = new System.Drawing.Point(259, 128);
            this.txtdeptname.Name = "txtdeptname";
            this.txtdeptname.Size = new System.Drawing.Size(100, 20);
            this.txtdeptname.TabIndex = 9;
            this.txtdeptname.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1006, 403);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // archive_noti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_deptid2);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtdept_name1);
            this.Controls.Add(this.txtdept_id);
            this.Controls.Add(this.txtdeptname);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 110);
            this.Name = "archive_noti";
            this.Text = "archive_noti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.archive_noti_Activated);
            this.Load += new System.EventHandler(this.archive_noti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_deptid2;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtdept_name1;
        private System.Windows.Forms.TextBox txtdept_id;
        private System.Windows.Forms.TextBox txtdeptname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}