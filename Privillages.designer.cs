namespace MBOS_Full_System
{
    partial class Privillages
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
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlSecurityDataSet = new MBOS_Full_System.ControlSecurityDataSet();
            this.rolesTableAdapter = new MBOS_Full_System.ControlSecurityDataSetTableAdapters.RolesTableAdapter();
            this.controlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlsTableAdapter = new MBOS_Full_System.ControlSecurityDataSetTableAdapters.ControlsTableAdapter();
            this.tableAdapterManager = new MBOS_Full_System.ControlSecurityDataSetTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.disabled_elements = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.hidden_elements = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.all_elements = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.InVisible = new System.Windows.Forms.CheckBox();
            this.FormsCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleCompobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSecurityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disabled_elements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden_elements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_elements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.controlSecurityDataSet;
            // 
            // controlSecurityDataSet
            // 
            this.controlSecurityDataSet.DataSetName = "ControlSecurityDataSet";
            this.controlSecurityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // controlsBindingSource
            // 
            this.controlsBindingSource.DataMember = "Controls";
            this.controlsBindingSource.DataSource = this.controlSecurityDataSet;
            // 
            // controlsTableAdapter
            // 
            this.controlsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ControlsTableAdapter = this.controlsTableAdapter;
            this.tableAdapterManager.ControlsToRolesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.UpdateOrder = MBOS_Full_System.ControlSecurityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UsersToRolesTableAdapter = null;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.separatorControl2);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.disabled_elements);
            this.panelControl1.Controls.Add(this.hidden_elements);
            this.panelControl1.Controls.Add(this.all_elements);
            this.panelControl1.Controls.Add(this.checkBox2);
            this.panelControl1.Controls.Add(this.checkBox1);
            this.panelControl1.Controls.Add(this.InVisible);
            this.panelControl1.Controls.Add(this.FormsCombobox);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.RoleCompobox);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(298, 706);
            this.panelControl1.TabIndex = 5;
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineColor = System.Drawing.Color.Brown;
            this.separatorControl1.Location = new System.Drawing.Point(19, 309);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(263, 23);
            this.separatorControl1.TabIndex = 70;
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl2.LineColor = System.Drawing.Color.Brown;
            this.separatorControl2.Location = new System.Drawing.Point(19, 501);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(263, 23);
            this.separatorControl2.TabIndex = 70;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(117, 281);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 69;
            this.simpleButton2.Text = "تجميد";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(198, 665);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 69;
            this.simpleButton4.Text = "تحرير";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(197, 477);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 69;
            this.simpleButton3.Text = "اظهار";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(198, 281);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 69;
            this.simpleButton1.Text = "اخفاء";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // disabled_elements
            // 
            this.disabled_elements.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disabled_elements.Appearance.Options.UseFont = true;
            this.disabled_elements.Location = new System.Drawing.Point(31, 539);
            this.disabled_elements.Name = "disabled_elements";
            this.disabled_elements.Size = new System.Drawing.Size(242, 94);
            this.disabled_elements.TabIndex = 68;
            this.disabled_elements.SelectedIndexChanged += new System.EventHandler(this.controlscheckedlistbox_SelectedIndexChanged);
            // 
            // hidden_elements
            // 
            this.hidden_elements.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidden_elements.Appearance.Options.UseFont = true;
            this.hidden_elements.Location = new System.Drawing.Point(31, 348);
            this.hidden_elements.Name = "hidden_elements";
            this.hidden_elements.Size = new System.Drawing.Size(242, 100);
            this.hidden_elements.TabIndex = 68;
            this.hidden_elements.SelectedIndexChanged += new System.EventHandler(this.controlscheckedlistbox_SelectedIndexChanged);
            // 
            // all_elements
            // 
            this.all_elements.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_elements.Appearance.Options.UseFont = true;
            this.all_elements.Location = new System.Drawing.Point(31, 145);
            this.all_elements.Name = "all_elements";
            this.all_elements.Size = new System.Drawing.Size(242, 104);
            this.all_elements.TabIndex = 68;
            this.all_elements.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.controlscheckedlistbox_ItemCheck);
            this.all_elements.SelectedIndexChanged += new System.EventHandler(this.controlscheckedlistbox_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(187, 454);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 20);
            this.checkBox2.TabIndex = 66;
            this.checkBox2.Text = "تحديد الكل";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(188, 639);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 20);
            this.checkBox1.TabIndex = 66;
            this.checkBox1.Text = "تحديد الكل";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // InVisible
            // 
            this.InVisible.AutoSize = true;
            this.InVisible.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InVisible.Location = new System.Drawing.Point(188, 255);
            this.InVisible.Name = "InVisible";
            this.InVisible.Size = new System.Drawing.Size(85, 20);
            this.InVisible.TabIndex = 66;
            this.InVisible.Text = "تحديد الكل";
            this.InVisible.UseVisualStyleBackColor = true;
            this.InVisible.CheckedChanged += new System.EventHandler(this.InVisible_CheckedChanged);
            // 
            // FormsCombobox
            // 
            this.FormsCombobox.DisplayMember = "RoleName";
            this.FormsCombobox.FormattingEnabled = true;
            this.FormsCombobox.Location = new System.Drawing.Point(84, 98);
            this.FormsCombobox.Name = "FormsCombobox";
            this.FormsCombobox.Size = new System.Drawing.Size(189, 21);
            this.FormsCombobox.TabIndex = 5;
            this.FormsCombobox.ValueMember = "RoleID";
            this.FormsCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(168, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "عناصر تم تجميدها";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(176, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "عناصر تم اخفائها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(192, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "عناصر الصفحة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(228, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "الصفحة";
            // 
            // RoleCompobox
            // 
            this.RoleCompobox.FormattingEnabled = true;
            this.RoleCompobox.Location = new System.Drawing.Point(86, 44);
            this.RoleCompobox.Name = "RoleCompobox";
            this.RoleCompobox.Size = new System.Drawing.Size(189, 21);
            this.RoleCompobox.TabIndex = 5;
            this.RoleCompobox.SelectedIndexChanged += new System.EventHandler(this.RoleCompobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(193, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "الدور الوظيفي";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // Privillages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 706);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Privillages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ادارة الصلاحيات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrivillagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSecurityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disabled_elements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden_elements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_elements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlSecurityDataSet controlSecurityDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private ControlSecurityDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingSource controlsBindingSource;
        private ControlSecurityDataSetTableAdapters.ControlsTableAdapter controlsTableAdapter;
        private ControlSecurityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox RoleCompobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FormsCombobox;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckedListBoxControl all_elements;
        private System.Windows.Forms.CheckBox InVisible;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedListBoxControl disabled_elements;
        private DevExpress.XtraEditors.CheckedListBoxControl hidden_elements;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}