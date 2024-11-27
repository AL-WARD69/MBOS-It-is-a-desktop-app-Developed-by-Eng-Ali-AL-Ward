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
    public partial class AddTask : DevExpress.XtraEditors.XtraForm
    {
        BL.ADD add_task =new BL.ADD();
        public AddTask()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

      

        private void save_task_btn_Click(object sender, EventArgs e)
        {

            try
            {
               // MessageBox.Show(TaskPriorityText.Text);
                add_task.Add_Task(TaskNameText.Text, TaskDetailsText.Text, Convert.ToInt32(TaskBudgetText.Text), Convert.ToDateTime(TaskStartDateText.Text), Convert.ToDateTime(TaskEndDateText.Text), TaskTypeText.Text, TaskPriorityText.Text);
                MessageBox.Show("تم اضافة المهمة بنجاح");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void task_name_Validating(object sender, CancelEventArgs e)
        {
            if (!this.IsMdiChild)
            {
                if ((sender as TextEdit).Text == "")
                {
                    e.Cancel = true;
                    TaskNameText.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
                }
            }
        }

        private void task_name_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "الرجاء تعبئة الحقل المطلوب ";

        }

        private void AddTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            BL.Show_Class dept=new BL.Show_Class();

            if (dept.Get_Dept_Name().Rows[0][0].ToString() == "إداره المشاريع")
            {
                this.Text = "اضافة مشروع جديد";
                groupControl1.Text = "معلومات المشروع";
                TaskNameLabel.Text = "اسم المشروع";
                TaskDetailsLabel.Text = "تفاصيل المشروع";
                TaskEndDateLabel.Text = "تاريخ انهاء المشروع";
                TaskStartDateLabel.Text = "تاريخ بدء المشروع";
                TaskTypeLabel.Text = "نوع المشروع";
            }
        }
    }
}