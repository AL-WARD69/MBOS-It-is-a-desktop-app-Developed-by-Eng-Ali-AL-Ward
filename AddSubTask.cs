using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBOS_Full_System
{
    public partial class AddSubTask : DevExpress.XtraEditors.XtraForm
    {
        int selected_task_id ;
        public bool  IS_update;
        BL.ADD add_subTask = new BL.ADD();
        DataTable dt = new DataTable();
        public AddSubTask(int select_id , bool is_update)
        {
            InitializeComponent();
            selected_task_id = select_id;
            IS_update = is_update;
        }
        public AddSubTask()
        {
            InitializeComponent();
        }
        private void task_budget_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void AddSubTask_Load(object sender, EventArgs e)
        {
            BL.Show task = new BL.Show();
            try
            {
                if(IS_update == false)
                {
                    //mean insert data 
                    dt = task.Show_Task(selected_task_id);
                    MainTaskName.Text = dt.Rows[0][1].ToString();
                    TaskNameText.Text = dt.Rows[0][1].ToString();
                    TaskPriorityText.SelectedText = dt.Rows[0][4].ToString();
                    TaskTypeText.SelectedText = dt.Rows[0][7].ToString();
                }
                else
                {
                    dt = task.Show_Task(selected_task_id);
                    this.Text = "التعديل علي بيانات المهمه ";
                    SubTask_groupControl.Text = "تعديل بيانات المهمه";
                    MainTaskName.Text = dt.Rows[0][1].ToString();
                    labelControl_subtaskname.Text = "اسم المهمه";
                    TaskNameText.Text = dt.Rows[0][1].ToString();
                    TaskPriorityText.SelectedText = dt.Rows[0][4].ToString();
                    TaskTypeText.SelectedText = dt.Rows[0][7].ToString();
                    // MessageBox.Show(dt.Rows[0][10].ToString());
                    //MessageBox.Show(selected_task_id.ToString());
                    if(dt.Rows[0][10].ToString() == "")
                    {
                        TaskWheightText.Visible = false;
                        labelControl_weightTask.Visible = false;
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //dt = task.Show_Task(selected_task_id);
            //MainTaskName.Text = dt.Rows[0][1].ToString();
            //TaskNameText.Text = dt.Rows[0][1].ToString();
            //TaskPriorityText.SelectedText = dt.Rows[0][4].ToString();
            //TaskTypeText.SelectedText = dt.Rows[0][7].ToString();
           // = dt.Rows[0][8].ToString();
            //= dt.Rows[0][9].ToString();
            // TODO: This line of code loads data into the 'mBOSDataSet.tasks' table. You can move, or remove it, as needed.
          //  this.tasksTableAdapter.Fill(this.mBOSDataSet.tasks);
            // TODO: This line of code loads data into the 'mBOSDataSet.departments' table. You can move, or remove it, as needed.
           // this.departmentsTableAdapter.Fill(this.mBOSDataSet.departments);
            //MessageBox.Show(selected_task_id.ToString());
        }

        private void SubTaskSave_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(IS_update == false)
                {
                    if (Convert.ToDateTime(TaskStartDateText.Text) < Convert.ToDateTime(dt.Rows[0][9]))
                    {
                        MessageBox.Show("يجب ان يكون تاريخ بدء المهمة اكبر من تاريخ بدء المهمة الرئيسية \n تاريخ بدء المهمة الرئيسية هو :" + dt.Rows[0][9].ToString());
                    }
                    else if (Convert.ToDateTime(TaskEndDateText.Text) > Convert.ToDateTime(dt.Rows[0][8]))
                    {
                        MessageBox.Show("يجب ان يكون تاريخ انتهاء المهمة اقل من تاريخ انتهاء المهمة الرئيسية \n تاريخ انتهاء المهمة الرئيسية هو :" + dt.Rows[0][8].ToString());
                    }

                    else
                    {
                        BL.Show_Class Dept_id = new BL.Show_Class();
                        int dept_id = Dept_id.Get_Dept_Id();
                        add_subTask.ADD_Sub_TASK(selected_task_id, TaskNameText.Text, TaskDetailsText.Text, TaskPriorityText.Text, Convert.ToInt32(TaskBudgetText.Text), Convert.ToInt32(TaskWheightText.Text), dept_id, Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text);
                        MessageBox.Show("تم اضافة المهمة االغرعية بنجاح");
                        this.Close();
                    }
                }
                else
                {
                    BL.Show task = new BL.Show();
                    dt = task.Show_Task(selected_task_id);
                   //MessageBox.Show(selected_task_id.ToString());
                   // MessageBox.Show("uuuuuuuuu");
                    BL.Show_Class Dept_id = new BL.Show_Class();
                    int dept_id = Dept_id.Get_Dept_Id();
                    BL.ADD update_task = new BL.ADD();
                    if (Convert.ToDateTime(TaskStartDateText.Text) < Convert.ToDateTime(dt.Rows[0][8]))
                    {
                        MessageBox.Show("يجب ان يكون تاريخ بدء المهمة ليس اقل من تاريح المهمه الرئيسية  \n تاريخ بدء المهمة الرئيسية هو :" + dt.Rows[0][9].ToString());
                    }
                    else
                    {
                        if(dt.Rows[0][10].ToString() =="")
                        {
                            // update main_task
                            update_task.Update_Task_data(selected_task_id, TaskNameText.Text, TaskDetailsText.Text, TaskPriorityText.Text, Convert.ToInt32(TaskBudgetText.Text), dept_id, Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text);
                            MessageBox.Show("تم تعديل بيانات المهمه بنجاح");
                            this.Close();

                        }
                        else
                        {
                            // update_sub_task 
                           update_task.Update_Sub_Task(selected_task_id, TaskNameText.Text, TaskDetailsText.Text, TaskPriorityText.Text, Convert.ToInt32(TaskBudgetText.Text), dept_id, Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text, Convert.ToInt32(TaskWheightText.Text) );
                            MessageBox.Show("تم تعديل بيانات المهمه الفرغيه بنجاح");
                        }

                    }





                    /*  else if (dt.Rows[0][10].ToString() =="")
                          {
                              // is main taSK 

                          }
                      else
                      {
                         int parent_id =Convert.ToInt32(dt.Rows[0][10].ToString());
                          // IS sub_task  
                      }*/
                }



                
               
                //if (selected_task_id==null)
                //{
                //    add_subTask.ADD_Sub_TASK(taskcombobox.SelectedValue, subtask_nametxt.Text, subtask_desc_memo.Text, subtask_importanc_comboBox.Text, Convert.ToInt32(subtask_budgettxt.Text), Convert.ToInt32(task_wheight_comboBoxEdit.Text), dept_id, Convert.ToDateTime(subtask_enddatetxt.Text),
                //        subtask_iterativcombox.Text);
                //}
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubTask_groupControl_Paint(object sender, PaintEventArgs e)
        {

        }
        }
    }

