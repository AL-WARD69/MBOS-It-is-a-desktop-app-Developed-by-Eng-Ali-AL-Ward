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
using DevExpress.XtraReports.UI;
using System.IO;

namespace MBOS_Full_System
{
   
    public partial class AddTaskWizard : DevExpress.XtraEditors.XtraForm
    {
        int task_id;
        string assigend_type;
        DataTable Assignee = new DataTable();
        BL.ADD add_task = new BL.ADD();
        public string iName;
        List<attach> add_attach = new List<attach> { };
            
        public AddTaskWizard()
        {
            InitializeComponent();
           
            //welcomeWizardPage1.Save
         //   layoutControl1.SaveLayoutToStream(stream);
          
        //    labelPreview_taskName.Text = TaskNameText.Text;
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
            dataTask();
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

        private void AddTaskWizard_Load(object sender, EventArgs e)
        {
            TaskStartDateText.Properties.MinValue = DateTime.Today;
          welcomeWizardPage1.AllowNext = false;
         
           // BL.Assign_Task Assign = new BL.Assign_Task();
        //  //  Assignee = Assign.Users();
        //    DataSet ds = new DataSet();
        //    ds = Assign.Departments(1);
        ////    ds.fi
        //  //   ds.FillDataSet(Assign.Departments(1));
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        Users.DataSource = ds.Tables[0];          
        //        Users.DisplayMember = "name";
        //        Users.ValueMember = "id";

        //    }
            BL.Show_Class GetLevel = new BL.Show_Class();
            BL.Assign_Task Assign = new BL.Assign_Task();

            if (GetLevel.Get_Dept_Level() == 2)
            {

                try
                {
                    //for (int i = 0; i< Assign.Users().Rows.Count; i++)
                    //{
                    //    wheight.Add(100);
                    //}
                    Assignee = Assign.Users();
                    Users.DataSource = Assignee;
                    Users.DisplayMember = "name";
                    Users.ValueMember = "UserID";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                assigend_type = "emplyees";
            }
            else
            {

                try
                {
                    BL.Show_Class department = new BL.Show_Class();
                    int parent_id = department.Get_Dept_Id();
                    //for (int i = 0; i < Assign.Departments(parent_id).Rows.Count; i++)
                    //{
                    //    wheight.Add(100);
                    //}
                       Assignee = Assign.Departments(parent_id);
                    Users.DataSource = Assign.Departments(parent_id);
                    Users.DisplayMember = "name";
                    Users.ValueMember = "id";
                    /*for (int i = 0; i < Users.ItemCount; i++)
                    {
                        MessageBox.Show(Users.SelectedItems[i].ToString());
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                assigend_type = "departments";
            }
            
        }

        private void Users_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
           
            
            //string item = Users.SelectedItem.ToString();
            //if(e.)
        }

        private void Users_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
           

               
                //  listBoxControl1.Items.Add(dis);

                //DataRow r;


                //  string item2 =(DataRowView)this.Users.CheckedItems;
                //  //  string item3=Users.CheckedIndices.to
                // var item = Users.SelectedValue.ToString();
                //      MessageBox.Show(item2);
            

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
       //     for (int i = 0; i < Users.SelectedItems.Count; i++)
       //     {

       //         /*Now with the following code we can get valemember and displaymember as per your requirement you can store in table. */

       //         DataRow r;

       //         r = ((DataRowView)this.Users.SelectedItems[i]).Row;

       //         string val = (r[this.Users.ValueMember]).ToString();

       //         string dis = (r[this.Users.DisplayMember]).ToString();
       //         listBoxControl1.Items.Add(dis);


       //         r = null;
       //         MessageBox.Show(r.ToString());

       //     }
       ////    foreach(DataRow row in () )
            //for (int i = 0; i < Users.Items.Count; i++)
            //{
            //    if (Users.GetItemChecked(i))
            //    {
            //        string str = Users.GetDisplayItemValue(i);
            //        MessageBox.Show(str);

            //        //next line invalid extension method
            //       // Users.Items[i].value;
            //    }
            //}
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
            EnableButton();

        }
        private void EnableButton()
        {
            if (TaskNameText.Text == "" || TaskEndDateText.Text == "" || TaskStartDateText.Text == "")
            {
                welcomeWizardPage1.AllowNext = false;
            }
            else { welcomeWizardPage1.AllowNext = true; }
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
            
            //if (string.IsNullOrEmpty(TaskStartDateText.Text))
            //{
            //    welcomeWizardPage1.AllowNext = false;
            //}
            //else
            //    welcomeWizardPage1.AllowNext = true;
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

        private void TaskStartDateText_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void TaskEndDateText_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void searchControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // MessageBox.Show(searchControl1.Text.ToString());
                string serachText = searchControl1.Text.ToString();
                bool is_found = false;
                for (int i = 0; i < Assignee.Rows.Count; i++)
                {

                    try
                    {
                        DataRow r;
                        r = ((DataRowView)Users.SelectedItem).Row;
                        //MessageBox.Show(r.ToString());
                        string dis = (r[this.Users.DisplayMember]).ToString();
                        if (dis.Trim().Contains(serachText.Trim()))
                        {
                            // MessageBox.Show("yes");
                            Users.SetSelected(i, true);
                            Users.MakeItemVisible(i);
                            is_found = true;
                            break;
                        }
                        else
                        {

                            Users.SetSelected(i, false);
                            Users.SetSelected(i + 1, true);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    // MessageBox.Show(dis);


                }
                if (!is_found)
                {
                    MessageBox.Show("لابوجد نتائج مطابقة للبحث");
                    Users.SetSelected(0, true);
                }

            }
        }

        private void buttonEdit_attachment_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                //  ofd.Multiselect = true;
                ofd.CheckFileExists = true;
                ofd.FilterIndex = 1;
                ofd.InitialDirectory = @"C:\";
                ofd.ShowReadOnly = true;
                ofd.ReadOnlyChecked = true;
                ofd.Title = "اختر  مرفق للمهمة  ";
                ofd.Filter = "ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP " + "|pdf files|*.pdf;";
                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\attach\";
                if (Directory.Exists(appPath) == false)
                {
                    Directory.CreateDirectory(appPath);
                }
                //
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iName = ofd.SafeFileName;
                       //  MessageBox.Show(iName);
                        string filepath = ofd.FileName;
                        // MessageBox.Show(filepath);
                        //  File.Copy(filepath, appPath + iName);
                        if (ofd.FilterIndex == 1)
                        {
                            // MessageBox.Show("is images");
                            //  is_image = true;
                            label_isimage.Text = "true";

                        }
                        else
                        {
                            //  MessageBox.Show("is not image");
                            //  is_image = false;
                            label_isimage.Text = "false";
                        }
                        //var path = buttonEdit_attachment.Text;
                        //var title = "إضافة مرفق";
                        //showpdfattach pdf = new showpdfattach(path, title);
                        //pdf.Show();
                        //  pictureEdit_attachment.Image = Image.FromFile(ofd.FileName);
                        // MessageBox.Show("is not image");
                        // pdfViewer1.LoadDocument(ofd.FileName);
                        //axAcroPDF1.LoadFile(ofd.FileName);
                        // axAcroPDF1.src = ofd.FileName;

                        buttonEdit_attachment.Text = ofd.FileName;
                        //buttonEdit_addattachment.Text = ofd.FileName;
                       
                        
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("يوجد مرفق بهذا الاسم من فضك أعد تمسية المرفق");

                    }
                }
                else
                {
                    ofd.Dispose();
                }



                //    else
                //   {


                //
                // buttonEdit_addattachment.Text = ofd.FileName;

                //  }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                DataTable rep = new DataTable();
                BL.Show_Class show = new BL.Show_Class();
                REPORT_PL.reportView viewer = new REPORT_PL.reportView();
                XtraReportTaskDetails rpt = new XtraReportTaskDetails();

                // MessageBox.Show(TaskPriorityText.Text);

                int id = Convert.ToInt32(add_task.Add_Task2(TaskNameText.Text, TaskDetailsText.Text, Convert.ToInt32(TaskBudgetText.Text), Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text, TaskPriorityText.Text).Rows[0][0].ToString());
                string path = iName;
              //  MessageBox.Show(path);
              
                int task_id = id;
               
              //  MessageBox.Show(iName);
              
                BL.ADD add_attche = new BL.ADD();
                   
                   if(add_attach.Count == 0)
                {
                    MessageBox.Show("no");


                    //  this.Close();
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
                                //  MessageBox.Show(Convert.ToInt32(Users.CheckedItems[x]).ToString());
                                // assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                                assign_dept.Assign_To_User(id, Convert.ToInt32(Users.CheckedItems[x]));

                            }
                            MessageBox.Show("تم اسناد المهمة بنجاح");

                            //rep = show.GetTaskReportDetailForUser(id);
                            //rpt.DataSource = rep;
                            //rpt.DataMember = "TaskReportDetailForUser";
                            //rpt.assinedTo.ExpressionBindings.Add(new ExpressionBinding("Text", "user_name"));

                        }
                        else
                        {
                            for (int x = 0; x < Users.CheckedItems.Count; x++)
                            {
                                //MessageBox.Show(wheight[Users.CheckedIndices[x]].ToString());
                                //MessageBox.Show(Users.CheckedItems[x].ToString());
                                //assign_dept.Assign_To_Dept(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                                assign_dept.Assign_To_Dept(id, Convert.ToInt32(Users.CheckedItems[x]));
                            }
                            MessageBox.Show("تم اسناد المهمة بنجاح");

                            //rep = show.GetTaskReportDetailForDept(id);
                            //rpt.DataSource = rep;
                            //rpt.DataMember = "TaskReportDetailForDept";
                            //rpt.assinedTo.ExpressionBindings.Add(new ExpressionBinding("Text", "dept_name"));

                        }
                        this.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("يجب ان يكون الوزن الكلي 100");
                        //}
                       
                    }


                }
                else
                {
                    MessageBox.Show("yse");
                   // string paht2 = buttonEdit_attachment.Text;
                    string title = textEdit3_attachtitle.Text;
                 //   bool is_image = Convert.ToBoolean(label_isimage.Text);

                    MessageBox.Show("تم اضافة المهمة بنجاح");
                    //   MessageBox.Show(id.ToString());
                    //  this.Close();
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
                                //  MessageBox.Show(Convert.ToInt32(Users.CheckedItems[x]).ToString());
                                // assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                                assign_dept.Assign_To_User(id, Convert.ToInt32(Users.CheckedItems[x]));

                            }
                            MessageBox.Show("تم اسناد المهمة بنجاح");

                            //rep = show.GetTaskReportDetailForUser(id);
                            //rpt.DataSource = rep;
                            //rpt.DataMember = "TaskReportDetailForUser";
                            //rpt.assinedTo.ExpressionBindings.Add(new ExpressionBinding("Text", "user_name"));

                        }
                        else
                        {
                            for (int x = 0; x < Users.CheckedItems.Count; x++)
                            {
                                //MessageBox.Show(wheight[Users.CheckedIndices[x]].ToString());
                                //MessageBox.Show(Users.CheckedItems[x].ToString());
                                //assign_dept.Assign_To_Dept(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                                assign_dept.Assign_To_Dept(id, Convert.ToInt32(Users.CheckedItems[x]));
                            }
                            MessageBox.Show("تم اسناد المهمة بنجاح");

                            //rep = show.GetTaskReportDetailForDept(id);
                            //rpt.DataSource = rep;
                            //rpt.DataMember = "TaskReportDetailForDept";
                            //rpt.assinedTo.ExpressionBindings.Add(new ExpressionBinding("Text", "dept_name"));

                        }
                        this.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("يجب ان يكون الوزن الكلي 100");
                        //}
                        for(int i = 0; i <add_attach.Count; i++)
                        {
                            add_attche.ADD_Task_Attachment(task_id, add_attach[i].name, add_attach[i].title, add_attach[i].is_image.ToString());
                            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\attach\";
                            File.Copy(add_attach[i].attach_path, appPath + add_attach[i].name);
                        }
                        
                    }

                }


                //for (int i = 0; i < rpt.Parameters.Count; i++)
                //{
                //    rpt.Parameters[i].Visible = false;
                //}









                //int assurId = show.Get_Dept_Id();
                //string assureName = show.GetAssureTask(id, assurId).Rows[0][1].ToString();



                //rpt.Parameters["taskName"].Value = TaskNameText.Text;
                //rpt.Parameters["taskBudjet"].Value = TaskBudgetText.Text;
                //rpt.Parameters["taskDescription"].Value = TaskDetailsText.Text;
                //rpt.Parameters["taskStartDate"].Value = TaskStartDateText.Text;
                //rpt.Parameters["taskEndDate"].Value = TaskEndDateText.Text;
                //rpt.Parameters["taskPriority"].Value = TaskPriorityText.Text;
                //rpt.Parameters["taskType"].Value = TaskTypeText.Text;
                //rpt.Parameters["taskAssureName"].Value = assureName;


                //viewer.documentViewer1.DocumentSource = rpt;
                //viewer.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            attach at = new attach();
            at.name = iName;
            at.title = textEdit3_attachtitle.Text;
            at.is_image = Convert.ToBoolean(label_isimage.Text);
            at.attach_path = buttonEdit_attachment.Text;
            if (add_attach.Count == 0)
            {
                add_attach.Add(at);
            }
            bool is_found = false;
            for (int i = 0; i < add_attach.Count; i++)
            {
                if (at.name == add_attach[i].name)
                {
                    MessageBox.Show("هذا المرفق متوفر سابقا الرجاء أعد تسمية ");
                    is_found = true;
                }

            }
            if (!is_found)
            {
                add_attach.Add(at);
            }

            //DevExpress.XtraVerticalGrid.Rows.BaseRow rowl = gridView1.AddNewRow()
           // gridView1.cre

        }
    }

    public class attach
    {
        public string title;
        public string name;
        public bool is_image;
        public string attach_path;
    }
}