namespace MBOS_Full_System
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.TaskDetailsText = new DevExpress.XtraEditors.MemoEdit();
            this.TaskNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.TaskNameText = new DevExpress.XtraEditors.TextEdit();
            this.TaskDetailsLabel = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.save_task_btn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.TaskStartDateText = new DevExpress.XtraEditors.DateEdit();
            this.TaskBudgetLabel = new DevExpress.XtraEditors.LabelControl();
            this.TaskBudgetText = new DevExpress.XtraEditors.TextEdit();
            this.TaskStartDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.TaskPriorityLabel = new DevExpress.XtraEditors.LabelControl();
            this.TaskPriorityText = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TaskTypeText = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TaskTypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.TaskEndDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.TaskEndDateText = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDetailsText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskStartDateText.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskStartDateText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskBudgetText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPriorityText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTypeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskEndDateText.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskEndDateText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskDetailsText
            // 
            this.behaviorManager1.SetBehaviors(this.TaskDetailsText, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, ((System.Drawing.Image)(resources.GetObject("TaskDetailsText.Behaviors"))), null)))});
            this.TaskDetailsText.Location = new System.Drawing.Point(22, 134);
            this.TaskDetailsText.Name = "TaskDetailsText";
            this.TaskDetailsText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TaskDetailsText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskDetailsText.Properties.NullValuePrompt = "تفاصيل المهمة";
            this.TaskDetailsText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskDetailsText.Size = new System.Drawing.Size(489, 66);
            this.TaskDetailsText.TabIndex = 3;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskNameLabel.Appearance.Options.UseFont = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(439, 48);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(72, 17);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "اسم المهمة";
            // 
            // TaskNameText
            // 
            this.TaskNameText.Location = new System.Drawing.Point(314, 71);
            this.TaskNameText.Name = "TaskNameText";
            this.TaskNameText.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.TaskNameText.Properties.Appearance.Options.UseBorderColor = true;
            this.TaskNameText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TaskNameText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskNameText.Properties.AutoHeight = false;
            this.TaskNameText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TaskNameText.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.TaskNameText.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TaskNameText.Properties.NullValuePrompt = "عنوان المهمة";
            this.TaskNameText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskNameText.Properties.ShowNullValuePromptWhenFocused = true;
            this.TaskNameText.Size = new System.Drawing.Size(197, 27);
            this.TaskNameText.TabIndex = 1;
            this.TaskNameText.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.task_name_InvalidValue);
            this.TaskNameText.Validating += new System.ComponentModel.CancelEventHandler(this.task_name_Validating);
            // 
            // TaskDetailsLabel
            // 
            this.TaskDetailsLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskDetailsLabel.Appearance.Options.UseFont = true;
            this.TaskDetailsLabel.Location = new System.Drawing.Point(425, 111);
            this.TaskDetailsLabel.Name = "TaskDetailsLabel";
            this.TaskDetailsLabel.Size = new System.Drawing.Size(86, 17);
            this.TaskDetailsLabel.TabIndex = 4;
            this.TaskDetailsLabel.Text = "تفاصيل المهمة";
            this.TaskDetailsLabel.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.LineColor = System.Drawing.Color.Gray;
            this.separatorControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.separatorControl1.LineThickness = 1;
            this.separatorControl1.Location = new System.Drawing.Point(2, 24);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(1);
            this.separatorControl1.Size = new System.Drawing.Size(519, 18);
            this.separatorControl1.TabIndex = 10;
            // 
            // save_task_btn
            // 
            this.save_task_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.save_task_btn.Appearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.save_task_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.save_task_btn.Appearance.ForeColor = System.Drawing.Color.BlueViolet;
            this.save_task_btn.Appearance.Options.UseBackColor = true;
            this.save_task_btn.Appearance.Options.UseBorderColor = true;
            this.save_task_btn.Appearance.Options.UseFont = true;
            this.save_task_btn.Appearance.Options.UseForeColor = true;
            this.save_task_btn.AppearanceHovered.BackColor = System.Drawing.Color.BlueViolet;
            this.save_task_btn.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.save_task_btn.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.save_task_btn.AppearanceHovered.Options.UseBackColor = true;
            this.save_task_btn.AppearanceHovered.Options.UseFont = true;
            this.save_task_btn.AppearanceHovered.Options.UseForeColor = true;
            this.save_task_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("save_task_btn.ImageOptions.Image")));
            this.save_task_btn.Location = new System.Drawing.Point(102, 370);
            this.save_task_btn.Name = "save_task_btn";
            this.save_task_btn.Size = new System.Drawing.Size(75, 25);
            this.save_task_btn.TabIndex = 16;
            this.save_task_btn.Text = "حفظ";
            this.save_task_btn.Click += new System.EventHandler(this.save_task_btn_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.DarkOrange;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.DarkOrange;
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButton2.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(21, 370);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 25);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "ألغاء";
            // 
            // TaskStartDateText
            // 
            this.TaskStartDateText.EditValue = null;
            this.TaskStartDateText.Location = new System.Drawing.Point(314, 242);
            this.TaskStartDateText.Name = "TaskStartDateText";
            this.TaskStartDateText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(233)))));
            this.TaskStartDateText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskStartDateText.Properties.AutoHeight = false;
            this.TaskStartDateText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TaskStartDateText.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TaskStartDateText.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TaskStartDateText.Properties.DisplayFormat.FormatString = "";
            this.TaskStartDateText.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TaskStartDateText.Properties.EditFormat.FormatString = "";
            this.TaskStartDateText.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TaskStartDateText.Properties.Mask.EditMask = "";
            this.TaskStartDateText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TaskStartDateText.Properties.NullValuePrompt = "تاريخ بدء المهمة";
            this.TaskStartDateText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskStartDateText.Properties.ShowNullValuePromptWhenFocused = true;
            this.TaskStartDateText.Size = new System.Drawing.Size(197, 27);
            this.TaskStartDateText.TabIndex = 4;
            // 
            // TaskBudgetLabel
            // 
            this.TaskBudgetLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskBudgetLabel.Appearance.Options.UseFont = true;
            this.TaskBudgetLabel.Location = new System.Drawing.Point(185, 48);
            this.TaskBudgetLabel.Name = "TaskBudgetLabel";
            this.TaskBudgetLabel.Size = new System.Drawing.Size(47, 17);
            this.TaskBudgetLabel.TabIndex = 24;
            this.TaskBudgetLabel.Text = "الميزانية";
            // 
            // TaskBudgetText
            // 
            this.TaskBudgetText.Location = new System.Drawing.Point(22, 71);
            this.TaskBudgetText.Name = "TaskBudgetText";
            this.TaskBudgetText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TaskBudgetText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskBudgetText.Properties.AutoHeight = false;
            this.TaskBudgetText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TaskBudgetText.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.TaskBudgetText.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TaskBudgetText.Properties.Mask.EditMask = "c";
            this.TaskBudgetText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TaskBudgetText.Properties.NullValuePrompt = "الميزانية";
            this.TaskBudgetText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskBudgetText.Properties.ShowNullValuePromptWhenFocused = true;
            this.TaskBudgetText.Size = new System.Drawing.Size(212, 27);
            this.TaskBudgetText.TabIndex = 2;
            // 
            // TaskStartDateLabel
            // 
            this.TaskStartDateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskStartDateLabel.Appearance.Options.UseFont = true;
            this.TaskStartDateLabel.Location = new System.Drawing.Point(418, 219);
            this.TaskStartDateLabel.Name = "TaskStartDateLabel";
            this.TaskStartDateLabel.Size = new System.Drawing.Size(93, 17);
            this.TaskStartDateLabel.TabIndex = 26;
            this.TaskStartDateLabel.Text = "تاريخ بدء المهمة";
            // 
            // TaskPriorityLabel
            // 
            this.TaskPriorityLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskPriorityLabel.Appearance.Options.UseFont = true;
            this.TaskPriorityLabel.Location = new System.Drawing.Point(435, 287);
            this.TaskPriorityLabel.Name = "TaskPriorityLabel";
            this.TaskPriorityLabel.Size = new System.Drawing.Size(76, 17);
            this.TaskPriorityLabel.TabIndex = 28;
            this.TaskPriorityLabel.Text = "درجة الاهمية";
            // 
            // TaskPriorityText
            // 
            this.TaskPriorityText.Location = new System.Drawing.Point(314, 310);
            this.TaskPriorityText.Name = "TaskPriorityText";
            this.TaskPriorityText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TaskPriorityText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskPriorityText.Properties.AutoHeight = false;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.White;
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.TaskPriorityText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.TaskPriorityText.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TaskPriorityText.Properties.DropDownRows = 2;
            this.TaskPriorityText.Properties.Items.AddRange(new object[] {
            "عاجلة",
            "عادية"});
            this.TaskPriorityText.Properties.NullValuePrompt = "درجة الاهمية";
            this.TaskPriorityText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskPriorityText.Properties.ShowNullValuePromptWhenFocused = true;
            this.TaskPriorityText.Size = new System.Drawing.Size(197, 27);
            this.TaskPriorityText.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImageOptions.AllowGlyphSkinning = true;
            this.groupControl1.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(-1);
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.TaskTypeText);
            this.groupControl1.Controls.Add(this.TaskTypeLabel);
            this.groupControl1.Controls.Add(this.TaskPriorityText);
            this.groupControl1.Controls.Add(this.TaskPriorityLabel);
            this.groupControl1.Controls.Add(this.TaskEndDateLabel);
            this.groupControl1.Controls.Add(this.TaskStartDateLabel);
            this.groupControl1.Controls.Add(this.TaskBudgetText);
            this.groupControl1.Controls.Add(this.TaskBudgetLabel);
            this.groupControl1.Controls.Add(this.TaskEndDateText);
            this.groupControl1.Controls.Add(this.TaskStartDateText);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.save_task_btn);
            this.groupControl1.Controls.Add(this.separatorControl1);
            this.groupControl1.Controls.Add(this.TaskDetailsLabel);
            this.groupControl1.Controls.Add(this.TaskNameText);
            this.groupControl1.Controls.Add(this.TaskNameLabel);
            this.groupControl1.Controls.Add(this.TaskDetailsText);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.groupControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.groupControl1.LookAndFeel.SkinName = "Office 2013";
            this.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(523, 417);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "معلومات المهمة";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // TaskTypeText
            // 
            this.TaskTypeText.Location = new System.Drawing.Point(22, 310);
            this.TaskTypeText.Name = "TaskTypeText";
            this.TaskTypeText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(233)))));
            this.TaskTypeText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskTypeText.Properties.AutoHeight = false;
            serializableAppearanceObject5.BackColor = System.Drawing.Color.White;
            serializableAppearanceObject5.Options.UseBackColor = true;
            this.TaskTypeText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.TaskTypeText.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TaskTypeText.Properties.DropDownRows = 2;
            this.TaskTypeText.Properties.Items.AddRange(new object[] {
            "ادارية",
            "فنية ",
            "مالية"});
            this.TaskTypeText.Properties.NullValuePrompt = "نوع المهمة";
            this.TaskTypeText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskTypeText.Properties.ShowNullValuePromptWhenFocused = true;
            this.TaskTypeText.Size = new System.Drawing.Size(212, 27);
            this.TaskTypeText.TabIndex = 5;
            // 
            // TaskTypeLabel
            // 
            this.TaskTypeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskTypeLabel.Appearance.Options.UseFont = true;
            this.TaskTypeLabel.Location = new System.Drawing.Point(171, 287);
            this.TaskTypeLabel.Name = "TaskTypeLabel";
            this.TaskTypeLabel.Size = new System.Drawing.Size(63, 17);
            this.TaskTypeLabel.TabIndex = 28;
            this.TaskTypeLabel.Text = "نوع المهمة";
            // 
            // TaskEndDateLabel
            // 
            this.TaskEndDateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TaskEndDateLabel.Appearance.Options.UseFont = true;
            this.TaskEndDateLabel.Location = new System.Drawing.Point(129, 219);
            this.TaskEndDateLabel.Name = "TaskEndDateLabel";
            this.TaskEndDateLabel.Size = new System.Drawing.Size(105, 17);
            this.TaskEndDateLabel.TabIndex = 26;
            this.TaskEndDateLabel.Text = "تاريخ انتهاء المهمة";
            // 
            // TaskEndDateText
            // 
            this.TaskEndDateText.EditValue = null;
            this.TaskEndDateText.Location = new System.Drawing.Point(22, 242);
            this.TaskEndDateText.Name = "TaskEndDateText";
            this.TaskEndDateText.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(175)))), ((int)(((byte)(233)))));
            this.TaskEndDateText.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.TaskEndDateText.Properties.AutoHeight = false;
            this.TaskEndDateText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TaskEndDateText.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TaskEndDateText.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TaskEndDateText.Properties.DisplayFormat.FormatString = "";
            this.TaskEndDateText.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TaskEndDateText.Properties.EditFormat.FormatString = "";
            this.TaskEndDateText.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TaskEndDateText.Properties.Mask.EditMask = "";
            this.TaskEndDateText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TaskEndDateText.Properties.NullValuePrompt = "تاريخ انتهاء المهمة";
            this.TaskEndDateText.Properties.NullValuePromptShowForEmptyValue = true;
            this.TaskEndDateText.Properties.ShowNullValuePromptWhenFocused = true;
            this.TaskEndDateText.Size = new System.Drawing.Size(212, 27);
            this.TaskEndDateText.TabIndex = 4;
            // 
            // AddTask
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 417);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة مهمة جديدة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTask_FormClosing);
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDetailsText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskStartDateText.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskStartDateText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskBudgetText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPriorityText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTypeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskEndDateText.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskEndDateText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.MemoEdit TaskDetailsText;
        private DevExpress.XtraEditors.LabelControl TaskNameLabel;
        private DevExpress.XtraEditors.TextEdit TaskNameText;
        private DevExpress.XtraEditors.LabelControl TaskDetailsLabel;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton save_task_btn;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DateEdit TaskStartDateText;
        private DevExpress.XtraEditors.LabelControl TaskBudgetLabel;
        private DevExpress.XtraEditors.TextEdit TaskBudgetText;
        private DevExpress.XtraEditors.LabelControl TaskStartDateLabel;
        private DevExpress.XtraEditors.LabelControl TaskPriorityLabel;
        private DevExpress.XtraEditors.ComboBoxEdit TaskPriorityText;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl TaskEndDateLabel;
        private DevExpress.XtraEditors.DateEdit TaskEndDateText;
        private DevExpress.XtraEditors.ComboBoxEdit TaskTypeText;
        private DevExpress.XtraEditors.LabelControl TaskTypeLabel;
    }
}