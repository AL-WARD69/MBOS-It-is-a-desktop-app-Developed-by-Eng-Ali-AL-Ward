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
    public partial class Charts : Form
    {
        BL.Show_Class show = new BL.Show_Class();
        DataTable dtchart = new DataTable();
        BL.ChartData chartData = new BL.ChartData();
        Home home = new Home();
        public Charts()
        {
            InitializeComponent();
            dtchart = show.assuer_department();
            this.deptName_combobox_chart.DataSource = chartData.get_all_dept();
            this.deptName_combobox_chart.DisplayMember = "name";
            this.deptName_combobox_chart.ValueMember = "id";
            deptName_combobox_chart.SelectedIndex = -1;
        }

        private void refresh_btnchart_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            dt = chartData.getChart(Convert.ToInt32(deptName_combobox_chart.SelectedValue));
            if (dt.Rows.Count != 0)
            {

                chartControl_getprogress_tasks.DataSource = dt;
                chartControl_getTaskType.DataSource = dt;
                DataTable dt2 = new DataTable();
                dt2 = chartData.get_establishedDept_task(Convert.ToInt32(deptName_combobox_chart.SelectedValue));
                DataTable dt3 = new DataTable();
                dt3 = chartData.get_in_implemenation_task(Convert.ToInt32(deptName_combobox_chart.SelectedValue));
                CountLabel_establishedTask.Text =dt2.Rows.Count.ToString()+" +" ;
                int count_established_task = (Convert.ToInt32(dt2.Rows.Count) * 100) / dt.Rows.Count;
                labelComponent_esatablishedTask.Text = count_established_task.ToString() + "%";
                arcScaleComponent_establishedTask.Value = count_established_task;
                arcScaleComponent_establishedTask.EnableAnimation = true;
                int count_in_implementation_task = (Convert.ToInt32(dt3.Rows.Count) * 100) / dt.Rows.Count;
                CountLabel_InEstablishedTask.Text = dt3.Rows.Count.ToString() + " +";
                labelComponent_inestablishedTask.Text = count_in_implementation_task.ToString() + "%";
                arcScaleComponent_inestablishedTask.Value = count_in_implementation_task;
                arcScaleComponent_inestablishedTask.EnableAnimation = true;
                DataTable dt4 = new DataTable();
                dt4 = chartData.get_non_implemenation_task(Convert.ToInt32(deptName_combobox_chart.SelectedValue));
                int count_non_established_task = (Convert.ToInt32(dt4.Rows.Count) * 100) / dt.Rows.Count;
                CountLabel_NonEstablishedTask.Text = dt4.Rows.Count.ToString() + " +";
                labelComponent_nonEstablishedTask.Text = count_non_established_task.ToString() + "%";
                arcScaleComponent_nonEstablishedTask.Value = count_non_established_task;
                arcScaleComponent_nonEstablishedTask.EnableAnimation = true;
                Labelheader_countdeptTask.Text = "أجمالي عدد المهام ::   " + dt.Rows.Count.ToString();
                DataTable dt5 = new DataTable();
                gridControl1.DataSource = chartData.get_task_type(Convert.ToInt32(deptName_combobox_chart.SelectedValue), btn_get_taskNew.Text);
              //  btn_get_taskNew.Checked = true;
            }
            else
            {
            }
        }

       

        private void btn_get_taskNew_CheckedChanged(object sender, EventArgs e)
        {

            gridControl1.DataSource = chartData.get_task_type(Convert.ToInt32(deptName_combobox_chart.SelectedValue), btn_get_taskNew.Text);
        //   btn_get_taskNew.Checked = true;

        //   btn_get_stage_task.Checked = false;
        //   btn_get_completetask.Checked = false;
        }

        private void btn_get_stage_task_CheckedChanged(object sender, EventArgs e)
        {

           
            gridControl1.DataSource = chartData.get_task_type(Convert.ToInt32(deptName_combobox_chart.SelectedValue), btn_get_stage_task.Text);
            //btn_get_stage_task.Checked = true;
            //btn_get_taskNew.Checked = false;
            //btn_get_completetask.Checked = false;
        }

        private void btn_get_completetask_CheckedChanged(object sender, EventArgs e)
        {
        gridControl1.DataSource = chartData.get_task_type(Convert.ToInt32(deptName_combobox_chart.SelectedValue), btn_get_completetask.Text);
       //btn_get_completetask.Checked = true;
       //btn_get_stage_task.Checked = false;
       //btn_get_taskNew.Checked = false;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
