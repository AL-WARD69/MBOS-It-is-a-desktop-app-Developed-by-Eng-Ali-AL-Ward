using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace MBOS_Full_System
{
    public partial class AddSubTaskWizard : DevExpress.XtraEditors.XtraForm
    {
        /////////////////////////////////////////
        int selected_task_id;
        int sub_task_id=0;
        int sub_task_wheight;
        int SubTaskWheightSum = 0;
        DataTable dt = new DataTable();
        string assigend_type;
        DataTable Assignee = new DataTable();
        DataTable SubTasks = new DataTable();
        BL.ADD add_task = new BL.ADD();
        BL.Show_Class Show_Info = new BL.Show_Class();
        int dept_id;
        string task_type;
        /// //////////////////////////////////////
        
        public AddSubTaskWizard(int parent_task_id)
        {
            InitializeComponent();
            selected_task_id = parent_task_id;
        }

        public AddSubTaskWizard()
        {
            InitializeComponent();
        }
        public void dataTask()
        {
            labelPreview_taskName.Text = "أسم المهمة: " + TaskNameText.Text;
            memoEdit1.Text = TaskDetailsText.Text;
            labelPreview_taskBudget.Text = "الميزانية: " + TaskBudgetText.Text;
            labelpreview_startdateTask.Text = "تاريخ بدء المهمة: " + TaskStartDateText.Text;
            labelpreview_endDateTask.Text = "تاريخ أنتهاء المهمة: " + TaskEndDateText.Text;
            labelpreview_typeTask.Text = "نوع المهمة:" + TaskTypeText.Text;
            labelpreview_prioritytask.Text = "أولويةالمهمة:" + TaskPriorityText.Text;
            labelControl6.Text = "وزن المهمة :" + TaskWheightText.Text;
        }
        public void dataStep()
        {
            labelPreview_taskName.Text = "أسم الخطوة: " + TaskNameText.Text;
            memoEdit1.Text = TaskDetailsText.Text;
            labelPreview_taskBudget.Text = "الميزانية: " + TaskBudgetText.Text;
            labelpreview_startdateTask.Text = "تاريخ بدء الخطوة: " + TaskStartDateText.Text;
            labelpreview_endDateTask.Text = "تاريخ أنتهاء الخطوة: " + TaskEndDateText.Text;
            labelpreview_typeTask.Text = "نوع الخطوة:" + TaskTypeText.Text;
            labelpreview_prioritytask.Text = "أولوية الخطوة:" + TaskPriorityText.Text;
            labelControl6.Text = "وزن الخطوة :" + TaskWheightText.Text;
        }

        private void TaskNameText_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (task_type == "task")
            {
                dataTask();
            }
            else
            {
                dataStep();
            }
           //dataTask(TaskNameText.Text, TaskDetailsText.Text, Convert.ToInt32(TaskBudgetText.Text), Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text, TaskPriorityText.Text);
           //foreach (var Item in Users.CheckedItems)
           //{
           //    listBoxControl1.Items.Add(Item);
           //}
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelpreview_detailsTask_Click(object sender, EventArgs e)
        {

        }
        public void fill_sub()
        {
            dept_id = Show_Info.Get_Dept_Id();
            BL.Show task = new BL.Show();
            SubTasks = Show_Info.Get_SubTask_Childs(selected_task_id, dept_id);
            WheightgridControl.DataSource = SubTasks;
            SubTaskWheightSum = Show_Info.Get_Sum_Task_Childs_Wheight(selected_task_id, dept_id);
            all_wheight.Text = SubTaskWheightSum.ToString();
        }
        private void AddTaskWizard_Load(object sender, EventArgs e)
        {
            fill_sub();
            BL.Show task = new BL.Show();
            //SubTasks.ChildRelations.Add(WheightgridControl.Columns[0],
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            TaskWheightText.Text = 0.ToString();
            MessageBox.Show(dept_id.ToString());
            try
            {
                BL.Assign_Task Assign = new BL.Assign_Task();
                if (add_task.Get_Dept_Childs(dept_id).Rows.Count > 0)
                {
                    gridView1.Columns[0].Visible = false;
                    gridView1.Columns[1].Caption = "اسم المهمة";
                    gridView1.Columns[2].Caption = "وصف المهمة";
                    gridView1.Columns[3].Caption = "درجة الاهمية";
                    gridView1.Columns[4].Visible = false;
                    gridView1.Columns[5].Visible = false;
                    gridView1.Columns[6].Visible = false;
                    gridView1.Columns[7].Visible = false;
                    gridView1.Columns[8].Visible = false;
                    gridView1.Columns[9].Visible = false; 
                    gridView1.Columns[10].Caption = "وزن المهمة";
                    task_type = "task";
                    dt = task.Show_Task(selected_task_id);
                    this.Text = "اضافة مهمة فرعية";
                    AddSubTaskWizard.ActiveForm.Text = dt.Rows[0][1].ToString();
                    Toplabel.Text = dt.Rows[0][1].ToString();
                    TaskNameText.Text = dt.Rows[0][1].ToString();
                    TaskPriorityText.SelectedText = dt.Rows[0][4].ToString();
                    TaskTypeText.SelectedText = dt.Rows[0][7].ToString();
                    TaskStartDateText.Properties.MinValue = DateTime.Today;
                    TaskEndDateText.Properties.MinValue = DateTime.Today; 
                    //TaskEndDateText.Properties.MaxValue = Convert.ToDateTime(dt.Rows[0][8]);
                    Users.DataSource = Assign.Departments(dept_id);
                    Users.DisplayMember = "name";
                    Users.ValueMember = "id";
                    assigend_type = "departments";
                }
                else
                {
                    MessageBox.Show("ss");
                    WheightWarrning.Text = "يجب ان يكون الوزن الكلي لجميع الخطوات الفرعية=100";
                    gridView1.Columns[0].Visible = false;
                    gridView1.Columns[1].Caption = "اسم الخطوة";
                    gridView1.Columns[2].Caption = "وصف الخطوة";
                    gridView1.Columns[3].Caption = "درجة الاهمية";
                    gridView1.Columns[4].Visible = false;
                    gridView1.Columns[5].Visible = false;
                    gridView1.Columns[6].Visible = false;
                    gridView1.Columns[7].Visible = false;
                    gridView1.Columns[8].Visible = false;
                    gridView1.Columns[9].Visible = false;
                    gridView1.Columns[10].Caption = "وزن الخطوة";
                    welcomeWizardPage1.Text = "اضافة بيانات الخطوة الفرعية";
                    wizardPage3.Text = "تحديد وزن الخطوة";
                    WheightTextDesc.Text = "جميع الخطوات الفرعية لهذه المهمة مع الاوزان والمسند لهم المهمة";
                    labelControl7.Text = "تحديد الوزن لهذه الخطوة";
                    labelControl9.Text = "المسند لهم الخطوة";
                    TaskNameLabel.Text = "اسم الخطوة";
                    TaskDetailsLabel.Text = "تفاصيل الخطوة";
                    TaskStartDateLabel.Text = "تاريخ بدء الخطوة";
                    TaskEndDateLabel.Text = "تاريخ انتهاء الخطوة";
                    TaskTypeLabel.Text = "نوع الخطوة";
                    task_type = "step";
                    dt = task.Show_Task(selected_task_id);
                    this.Text = "اضافة خطوة فرعية";
                    AddSubTaskWizard.ActiveForm.Text = dt.Rows[0][1].ToString();
                    Toplabel.Text = dt.Rows[0][1].ToString();
                    TaskNameText.Text = dt.Rows[0][1].ToString();
                    TaskPriorityText.SelectedText = dt.Rows[0][4].ToString();
                    TaskTypeText.SelectedText = dt.Rows[0][7].ToString();
                    TaskStartDateText.Properties.MinValue = DateTime.Today;
                    TaskEndDateText.Properties.MinValue = DateTime.Today; 
                    //TaskEndDateText.Properties.MaxValue = Convert.ToDateTime(dt.Rows[0][8]);
                    Assignee = Assign.Users();
                    Users.DataSource = Assignee;
                    Users.DisplayMember = "name";
                    Users.ValueMember = "UserID";
                    assigend_type = "emplyees";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Users_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            //string item = Users.SelectedItem.ToString();
            //if(e.)
        }

        private void Users_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
           
            DataRow r;
            this.Users.SetSelected(e.Index, true);
                r = ((DataRowView)this.Users.SelectedItem).Row;

                string dis = (r[this.Users.DisplayMember]).ToString();

                if (e.NewValue == CheckState.Checked)
                {
                    listBoxControl1.Items.Add(dis);
                }
                else
                {
                    listBoxControl1.Items.Remove(dis);
                }        
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
      
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            int id;
            int Budget = 0;
            try
            {
                if (TaskBudgetText.Text != "")
                {
                    Budget = Convert.ToInt32(TaskBudgetText.Text);
                }
              
               id = Convert.ToInt32(add_task.ADD_Sub_TASK(selected_task_id, TaskNameText.Text, TaskDetailsText.Text, TaskPriorityText.Text, Budget, Convert.ToInt32(TaskWheightText.Text), dept_id, Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text).Rows[0][0].ToString());
                
                
                 //////////////////////////////////////////////////////////////
                if (Users.CheckedItems.Count != 0)
                {
                    //int wheight_sum = 0;
                    //for (int x = 0; x < Users.CheckedItems.Count; x++)
                    //{
                    //    wheight_sum += Convert.ToInt32(wheight[Users.CheckedIndices[x]]);
                    //}
                    BL.ADD assign_dept = new BL.ADD();
                    //MessageBox.Show(wheight_sum.ToString());
                    //if (wheight_sum == 100)
                    //{

                    if (assigend_type == "emplyees")
                    {
                        for (int x = 0; x < Users.CheckedItems.Count; x++)
                        {
                            assign_dept.Assign_To_User(id, Convert.ToInt32(Users.CheckedItems[x]));
                        }
                        // MessageBox.Show("تم اسناد المهمة بنجاح");
                        MessageBox.Show("تم اضافة الخطوة االفرعية بنجاح");
                        this.Close();

                    }
                    else
                    {
                        for (int x = 0; x < Users.CheckedItems.Count; x++)
                        {
                            assign_dept.Assign_To_Dept(id, Convert.ToInt32(Users.CheckedItems[x]));
                        }
                        // MessageBox.Show("تم اسناد المهمة بنجاح");
                        MessageBox.Show("تم اضافة المهمة االفرعية بنجاح");
                        this.Close();
                    }
                }
                else
                {
                    ////لم يتم اسناد المهمة بعد
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkEdit1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                Users.CheckAll();
                Users.SelectAll();
            }
            else
            {
                Users.UnSelectAll();
                Users.UnCheckAll();
            }
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }

        private void TaskNameText_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as TextEdit).Text == "")
            {
                e.Cancel = true;
                TaskNameText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
             //   welcomeWizardPage1.AllowNext = false;

            }
            //else { welcomeWizardPage1.AllowNext = true; }
              
        }

        private void TaskNameText_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "الرجاء تعبئة الحقل المطلوب ";
        }

        private void Users_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TaskNameText_TextChanged(object sender, EventArgs e)
        {
        //    if (String.IsNullOrEmpty(TaskNameText.Text))
        //        welcomeWizardPage1.AllowNext = false;
        //  else
        //        welcomeWizardPage1.AllowNext = true;
        }

        private void labelPreview_taskName_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelpreview_prioritytask_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelpreview_startdateTask_Click(object sender, EventArgs e)
        {

        }

        private void labelpreview_endDateTask_Click(object sender, EventArgs e)
        {

        }

        private void TaskStartDateText_DateTimeChanged(object sender, EventArgs e)
        {
            if ((sender as DateEdit).Text != "")
            {
                TaskEndDateText.Properties.MinValue = Convert.ToDateTime(TaskStartDateText.Text);
            }

        }

        private void TaskStartDateText_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as DateEdit).Text == "")
            {
                e.Cancel = true;
                TaskNameText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               // welcomeWizardPage1.AllowNext = false;
            }
            //else { welcomeWizardPage1.AllowNext = true; }
            
            //if (string.IsNullOrEmpty(TaskStartDateText.Text))//
            //{//
            //welcomeWizardPage1.AllowNext = false;//
            //}//
            //else//
            //welcomeWizardPage1.AllowNext = true;//
        }

        private void TaskStartDateText_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "الرجاء تعبئة الحقل المطلوب ";
        }

        private void TaskEndDateText_Validating(object sender, CancelEventArgs e)
        {

            if ((sender as DateEdit).Text == "")
            {

                e.Cancel = true;
                TaskNameText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
              //  welcomeWizardPage1.AllowNext = false;
            }
           // else { welcomeWizardPage1.AllowNext = true; }
        }

        private void TaskEndDateText_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "الرجاء تعبئة الحقل المطلوب ";
        }

        private void welcomeWizardPage1_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(TaskNameText.Text) || string.IsNullOrEmpty(TaskStartDateText.Text) || string.IsNullOrEmpty(TaskEndDateText.Text))
            //{
            //    welcomeWizardPage1.AllowNext = false;
            //}
            //else
            //{
            //    welcomeWizardPage1.AllowNext = true;
            //}

                //  
          //  if ((sender as DateEdit).Text == "" || (sender as TextEdit).Text == "")
        //    {
        //        e.Cancel = true;
        //        TaskNameText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
        //        welcomeWizardPage1.AllowNext = false;
        //    }
        //    else
        //    {
        //        welcomeWizardPage1.AllowNext = true;
        //    }
        }

        private void Users_ParentChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
             sub_task_id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[0]));
             try
             {
                 sub_task_wheight = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]));
                 comboBox1.Text = sub_task_wheight.ToString();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             SubNamelabelControl1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                // MessageBox.Show(task_id.ToString());
            BL.Show_Class assign = new BL.Show_Class();
            gridView3.Appearance.Row.Options.UseTextOptions = true;
            gridView3.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            
            if (task_type == "task")
            {
                assignedforgrid.DataSource = assign.Show_Task_Dept(sub_task_id);
                gridView3.Columns[0].Visible = false;
                gridView3.Columns[3].Visible = false;
                gridView3.Columns[4].Visible = false;
            }
            else
            {
                assignedforgrid.DataSource = assign.Show_Task_Emp(sub_task_id);
                gridView3.Columns[0].Visible = false;
                gridView3.Columns[3].Visible = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (sub_task_id != 0)
            {
                BL.ADD add = new BL.ADD();
                //MessageBox.Show(comboBox1.Text);
                if (comboBox1.Text != "")
                {
                    int otherWheghit =100 - (SubTaskWheightSum - sub_task_wheight);
                    if (Convert.ToInt32(comboBox1.Text) <= otherWheghit)
                    {
                        add.Update_Task_Wheight(sub_task_id, Convert.ToInt32(comboBox1.Text));
                        fill_sub();
                        TaskWheightText.Text = (100 - SubTaskWheightSum).ToString();
                    }
                    else
                    {
                        MessageBox.Show("لايمكن تجازوز النسبة الكاملة 100");
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء تحديد الوزن");
                }
            }
            else
            {
                MessageBox.Show("قم بالتحديد على المهمة الفرعية اولا");
            }
        }

        private void TaskWheightText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubTaskWheightSum + Convert.ToInt32(TaskWheightText.Text) > 100 && SubTaskWheightSum !=100)
            {
                TaskWheightText.Text = (100 - SubTaskWheightSum).ToString();
                WheightWarrning.Visible = true;
                if (task_type == "task")
                {
                    WheightWarrning.Text = "يجب ان يكون الوزن الكلي لجميع المهام الفرعية =100";
                }
                else
                {
                    WheightWarrning.Text = "يجب ان يكون الوزن الكلي لجميع الخطوات الفرعية=100";
                }
                //// MessageBox.Show("hello");
                wizardPage3.AllowNext = true;
            }
            else if (SubTaskWheightSum + Convert.ToInt32(TaskWheightText.Text) > 100 && SubTaskWheightSum == 100)
            {
                TaskWheightText.Text = 0.ToString();
                WheightWarrning.Visible = true;
                //MessageBox.Show("يجب ان يكون وزن المهمة اكبر من الصفر");
                wizardPage3.AllowNext = false;
            }
            else
            {
                WheightWarrning.Visible = false;
                wizardPage3.AllowNext = true;
                if (Convert.ToInt32(TaskWheightText.Text) == 0)
                {
                    wizardPage3.AllowNext = false;
                    WheightWarrning.Text = "يجب ان يكون وزن المهمة اكبر من الصفر";
                }
            }

        }
    }
}