namespace MBOS_Full_System
{
    partial class AssignTask
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
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTask));
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.Users = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.ItemHeight = 62;
            this.Users.Location = new System.Drawing.Point(54, 54);
            this.Users.LookAndFeel.SkinName = "Office 2007 Blue";
            this.Users.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(504, 315);
            this.Users.TabIndex = 0;
            tableColumnDefinition1.Length.Value = 91D;
            tableColumnDefinition2.Length.Value = 34D;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.FieldName = "DisplayMember";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "DisplayMember";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = null;
            templatedItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Name = "template1";
            tableRowDefinition1.Length.Value = 39D;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            this.Users.Templates.Add(itemTemplateBase1);
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 47);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "قم باختيار الموظفين";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(327, 377);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 28);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "اضافة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(435, 377);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(87, 28);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "الغاء";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(272, 12);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.searchControl1.Properties.AutoHeight = false;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePrompt = "أدخل السم الموضف المراد البحث عنة";
            this.searchControl1.Properties.ShowNullValuePromptWhenFocused = true;
            this.searchControl1.Size = new System.Drawing.Size(286, 34);
            this.searchControl1.TabIndex = 3;
            this.searchControl1.QueryIsSearchColumn += new DevExpress.XtraEditors.QueryIsSearchColumnEventHandler(this.searchControl1_QueryIsSearchColumn);
            this.searchControl1.SelectedIndexChanged += new System.EventHandler(this.searchControl1_SelectedIndexChanged);
            this.searchControl1.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.searchControl1_ButtonPressed);
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.Click += new System.EventHandler(this.searchControl1_Click);
            this.searchControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchControl1_KeyDown);
            this.searchControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchControl1_MouseClick);
            // 
            // Assign_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(20, 0);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 418);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Users);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Assign_Task";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اسناد المهمة";
            this.Load += new System.EventHandler(this.Assign_Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl Users;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}