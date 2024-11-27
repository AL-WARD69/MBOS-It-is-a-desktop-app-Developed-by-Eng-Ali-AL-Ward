namespace MBOS_Full_System
{
    partial class backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backup));
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(58, 77);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(178, 55);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Text = "نسخ احتياطي";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(58, 218);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(178, 58);
            this.btn_restore.TabIndex = 1;
            this.btn_restore.Text = "استعادة النسخ";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.button2_Click);
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 384);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_backup);
            this.Location = new System.Drawing.Point(200, 300);
            this.Name = "backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "backup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.backup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_restore;
    }
}