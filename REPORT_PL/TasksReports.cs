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

namespace MBOS_Full_System.REPORT_PL
{
    public partial class TasksReports : DevExpress.XtraEditors.XtraForm
    {

        public string taskCatigory;

        public TasksReports()
        {
            InitializeComponent();

            combReportType.Items.Add("نوع المهمة");
            combReportType.Items.Add("حالة المهمة");
            combReportType.Items.Add("الاهمية");
            combReportType.Items.Add("نسبة الانجاز");
            //combReportType.Items.Add("الفتره");
        }

        private void combReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            combReportDetail.Enabled = true;
            //labelControl1.Visible = false;
            //labelControl2.Visible = false;

            if (combReportType.Text == "نوع المهمة")
            {
                lblRepotDetail.Text = "نوع المهمة";
                lblRepotDetail.Visible = true;

                combReportDetail.Items.Clear();
                combReportDetail.Items.Add("مالية");
                combReportDetail.Items.Add("فنية");
                combReportDetail.Items.Add("ادارية");
                combReportDetail.Items.Add("اخرى");
                //dateEdit1.Enabled = false;
                //dateEdit2.Enabled = false;

                taskCatigory = "نوع المهمة";
            }
            else if (combReportType.Text == "حالة المهمة")
            {
                lblRepotDetail.Text = "حالة المهمة";
                lblRepotDetail.Visible = true;

                combReportDetail.Items.Clear();
                combReportDetail.Items.Add("منجزه");
                combReportDetail.Items.Add("جاريه");
                combReportDetail.Items.Add("متعثره");
                combReportDetail.Items.Add("اخرى");
                //dateEdit1.Enabled = false;
                //dateEdit2.Enabled = false;

                taskCatigory = "حالة المهمة";
            }
            else if (combReportType.Text == "الاهمية")
            {
                lblRepotDetail.Text = "الاهمية";
                lblRepotDetail.Visible = true;

                combReportDetail.Items.Clear();
                combReportDetail.Items.Add("عالية");
                combReportDetail.Items.Add("متوسطة");
                combReportDetail.Items.Add("عادية");
                combReportDetail.Items.Add("اخرى");
                //dateEdit1.Enabled = false;
                //dateEdit2.Enabled = false;

                taskCatigory = "الاهمية";

            }
            else if (combReportType.Text == "نسبة الانجاز")
            {
                lblRepotDetail.Text = "نسبة الانجاز";
                lblRepotDetail.Visible = true;

                combReportDetail.Items.Clear();
                combReportDetail.Items.Add("0");
                combReportDetail.Items.Add("10");
                combReportDetail.Items.Add("20");
                combReportDetail.Items.Add("30");
                combReportDetail.Items.Add("40");
                combReportDetail.Items.Add("50");
                combReportDetail.Items.Add("60");
                combReportDetail.Items.Add("70");
                combReportDetail.Items.Add("80");
                combReportDetail.Items.Add("90");
                combReportDetail.Items.Add("100");
                //dateEdit1.Enabled = false;
                //dateEdit2.Enabled = false;

                taskCatigory = "نسبة الانجاز";

            }
            //else
            //{
            //    //lblRepotDetail.Text = "الفتره";
            //    combReportDetail.Items.Clear();
            //    dateEdit1.Enabled = true;
            //    dateEdit2.Enabled = true;
            //    combReportDetail.Enabled = false;
            //    lblRepotDetail.Visible = false;
            //    labelControl1.Visible = true;
            //    labelControl2.Visible = true;

            //    taskCatigory = "الفتره";

            //}
        }

        private void btnReportTasks_Click(object sender, EventArgs e)
        {
            try
            {
                reportView frm = new reportView();
                XtraReportTasks rpt = new XtraReportTasks();
                DataTable dt = new DataTable();
                BL.ShowReport clsShow = new BL.ShowReport();

                if (dateEdit1.Text != "" && dateEdit2.Text != "")
                {
                    rpt.Parameters["dateFrom"].Value = dateEdit1.EditValue;
                    rpt.Parameters["dateTo"].Value = dateEdit2.EditValue;
                    rpt.Parameters["taskType"].Value = combReportType.Text;

                    rpt.lbl_dateFrom.Visible = true;
                    rpt.lbl_dateTo.Visible = true;
                    rpt.param_dateFrom.Visible = true;
                    rpt.param_dateTo.Visible = true;

                    rpt.xrLabel7.Visible = true;
                    rpt.xrLabel9.Visible = true;
                    rpt.xrLabel5.Visible = true;
                }

                for (int i = 0; i < rpt.Parameters.Count; i++)
                {
                    rpt.Parameters[i].Visible = false;
                }

                rpt.RequestParameters = false;

                if (taskCatigory == "نوع المهمة")
                {
                    if(checkPirode.Checked)
                    {
                        dt = clsShow.TASK_TYPE_REPORT_WITH_PIRODE(combReportDetail.Text,Convert.ToDateTime(dateEdit1.Text),Convert.ToDateTime(dateEdit2.Text));
                    }
                    else
                    {
                        dt = clsShow.TASK_TYPE_REPORT(combReportDetail.Text);
                        rpt.lbl_headerInfo.Text = "نموذج اجمالي الاعمال بحسب نوع المهمة ";

                    }
                }
                else if (taskCatigory == "حالة المهمة")
                {
                    if(checkPirode.Checked)
                    {
                        dt = clsShow.TASK_STATE_REPORT_WITH_PIRODE(combReportDetail.Text,Convert.ToDateTime(dateEdit1.Text),Convert.ToDateTime(dateEdit2.Text));
                    }
                    else
                    {
                        dt = clsShow.TASK_STATE_REPORT(combReportDetail.Text);
                        rpt.lbl_headerInfo.Text = "نموذج اجمالي الاعمال بحسب حالة المهمة ";

                    }
                }
                else if (taskCatigory == "الاهمية")
                {
                    if (checkPirode.Checked)
                    {
                        dt = clsShow.TASK_PRIORTY_REPORT_WITH_PIRODE(combReportDetail.Text, Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));

                    }
                    else
                    {
                        dt = clsShow.TASK_PRIORTY_REPORT(combReportDetail.Text);
                        rpt.lbl_headerInfo.Text = "نموذج اجمالي الاعمال بحسب الاهمية ";
                    }
                }
                else if (taskCatigory == "نسبة الانجاز")
                {
                    if (checkPirode.Checked)
                    {
                        dt = clsShow.TaskProgressReportWithPirode(float.Parse(combReportDetail.Text), Convert.ToDateTime(dateEdit1.Text), Convert.ToDateTime(dateEdit2.Text));
                    }
                    else
                    {
                        dt = clsShow.TaskProgressReport(float.Parse(combReportDetail.Text));
                        rpt.lbl_headerInfo.Text = "نموذج اجمالي الاعمال بحسب نسبة الانجاز ";
                    }
                }
                //else if (taskCatigory == "الفتره")
                //{
                //    lblRepotDetail.Visible = true;
                //    dt = clsShow.taskPirodeReport(Convert.ToDateTime(dateEdit1.EditValue),Convert.ToDateTime(dateEdit2.EditValue));
                //}
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لايوجد بيانات");
                }
                else
                {
                    rpt.DataSource = dt;
                    rpt.DataMember = "tasks";

                    rpt.id_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "id"));
                    rpt.procedure_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "name"));
                    rpt.component_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "description"));
                    rpt.quntity_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "task_level"));
                    rpt.type_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "type"));

                    //rpt.deptImplement_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text",""));
                    //rpt.deptShare_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text",""));
                    rpt.startDate_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "start_date"));
                    rpt.endDate_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "end_date"));
                    rpt.stateAssure_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "task_level"));

                    rpt.progress_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "progress"));
                    rpt.stateProcedure_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "task_state"));

                    frm.documentViewer1.DocumentSource = rpt;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkPirode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPirode.Checked == true)
            {
                labelControl1.Visible = true;
                labelControl2.Visible = true;
                dateEdit1.Enabled = true;
                dateEdit2.Enabled = true;

            }
            else
            {
                labelControl1.Visible = false;
                labelControl2.Visible = false;
                dateEdit1.Enabled = false;
                dateEdit2.Enabled = false;
                dateEdit1.Text = null;
                dateEdit2.Text = null;
            }
        }
    }
}