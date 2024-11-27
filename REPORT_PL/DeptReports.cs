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
    public partial class DeptReports : DevExpress.XtraEditors.XtraForm
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public string type;

        public DeptReports()
        {
            InitializeComponent();

            combSelect.Items.Add("الإدارات");
            combSelect.Items.Add("الاقسام");
            combSelect.Items.Add("المختصين");
            combSelect.Items.Add("المنسقين");
        }

        private void DeptReports_Load(object sender, EventArgs e)
        {

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

        private void combSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            BL.ShowReport dept = new BL.ShowReport();

            combDept.Enabled = true;

            if (combSelect.Text == "الإدارات")
            {
                lblDept.Text = "تقريرعن ادارة :";
                lblDept.Visible = true;

                combDept.DataSource = dept.GET_DEPARTMENTS_NAME(1);
                combDept.DisplayMember = "name";
                combDept.ValueMember = "id";

                type = "department";

            }
            else if (combSelect.Text == "الاقسام")
            {
                lblDept.Text = "تقريرعن قسم :";
                lblDept.Visible = true;

                combDept.DataSource = dept.GET_DEPARTMENTS_NAME(2);
                combDept.DisplayMember = "name";
                combDept.ValueMember = "id";

                type = "department";
            }
            else if (combSelect.Text == "المختصين")
            {
                lblDept.Text = "تقريرعن المختصين :";
                lblDept.Visible = true;

                combDept.DataSource = dept.GET_ALL_USERS_NAME();
                combDept.DisplayMember = "name";
                combDept.ValueMember = "UserID";

                type = "user";
            }
            else if (combSelect.Text == "المنسقين")
            {
                lblDept.Text = "تقريرعن المنسقين :";
                lblDept.Visible = true;

                //type = "user";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("date : "+ dateEdit1.EditValue);

            try
            {
                REPORT_PL.reportView frm = new REPORT_PL.reportView();
                REPORT_PL.XtraReportDepartment rpt = new REPORT_PL.XtraReportDepartment();
                DataTable dt = new DataTable();
                BL.ShowReport clsShow = new BL.ShowReport();


                //rpt.Parameters["DateFrom"].Value = dateEdit1.EditValue;
                //rpt.Parameters["DateTo"].Value = dateEdit2.EditValue;
                rpt.Parameters["DeptName"].Value = combDept.Text;

                if (dateEdit1.Text != "" && dateEdit2.Text != "")
                {
                    rpt.Parameters["DateFrom"].Value = dateEdit1.EditValue;
                    rpt.Parameters["DateTo"].Value = dateEdit2.EditValue;
                    rpt.lbl_dateFrom.Visible = true;
                    rpt.lbl_dateTo.Visible = true;
                    rpt.param_dateFrom.Visible = true;
                    rpt.param_dateTo.Visible = true;
                }

                for (int i = 0; i < rpt.Parameters.Count; i++)
                {
                    rpt.Parameters[i].Visible = false;
                }

                rpt.RequestParameters = false;

                if (type == "department")
                {
                    rpt.lbl_deptName.Text = "تقرير عن قسم/إدارة";
                    //MessageBox.Show("department");

                    //dt = clsShow.deptGetReport(DateTime.ParseExact(dateEdit1.EditValue.ToString(), "dd/mm/yyyy", null), DateTime.ParseExact(dateEdit2.EditValue.ToString(), "dd/mm/yyyy", null), Convert.ToInt32(combDept.SelectedValue));

                    //dt = clsShow.deptGetReport(Convert.ToString(DateTime.ParseExact(dateEdit1.EditValue.ToString(), "yyyy-mm-dd", null)), Convert.ToString(DateTime.ParseExact(dateEdit1.EditValue.ToString(), "yyyy-mm-dd", null)), Convert.ToInt32(combDept.SelectedValue));
                    if (checkPirode.Checked)
                    {
                        //MessageBox.Show("department with date");

                        dt = clsShow.deptGetReportWithPirod(Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue), Convert.ToInt32(combDept.SelectedValue));
                        check_dept(rpt);
                        //rpt.DataSource = dt;
                        //rpt.DataMember = "tasks";
                        //rpt.DataAdapter = dt;
                        //rpt.DataSource = ds;
                    }
                    else
                    {
                        //MessageBox.Show("department without date");

                        dt = clsShow.deptGetReport(Convert.ToInt32(combDept.SelectedValue));
                        check_dept(rpt);

                    }



                }
                else if (type == "user")
                {
                    rpt.lbl_deptName.Text = "تقرير عن المختص";
                    if (checkPirode.Checked)
                    {
                        dt = clsShow.UserGetReportWithPirode(Convert.ToInt32(combDept.SelectedValue), Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue));
                        
                        rpt.dept_table.DeleteColumn(rpt.wight_cell);
                        rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                        rpt.dept_table.DeleteColumn(rpt.order_cell);
                        rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                        rpt.dept_table.DeleteColumn(rpt.money_cell);
                        rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);
                    }
                    else
                    { 
                    //MessageBox.Show("user");
                    
                    dt = clsShow.UserGetReport(Convert.ToInt32(combDept.SelectedValue));

                    rpt.dept_table.DeleteColumn(rpt.wight_cell);
                    rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                    rpt.dept_table.DeleteColumn(rpt.order_cell);
                    rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                    rpt.dept_table.DeleteColumn(rpt.money_cell);
                    rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                    //ReportPrintTool pt = new ReportPrintTool(rpt);
                    //pt.ShowPreviewDialog();
                    //ReportDesignTool designTool = new ReportDesignTool(rpt);
                    //designTool.ShowRibbonDesignerDialog();


                    //rpt.DataAdapter = dt;
                    }

                }

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
                    rpt.wight_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "wight"));
                    rpt.component_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "description"));
                    rpt.typ_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "type"));
                    rpt.country_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "beneficiary"));
                    rpt.location_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "locations_number"));
                    rpt.quntity_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "task_level"));
                    rpt.order_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "assigned_from"));
                    rpt.money_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "budget"));
                    rpt.implementing_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "government_id"));
                    rpt.dateAssine_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "start_date"));
                    rpt.dateImplement_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "end_date"));
                    rpt.from_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "start_date"));
                    rpt.to_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "end_date"));
                    rpt.progress_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "progress"));
                    //rpt.stateAssure_cell.ExpressionBindings.Add(new ExpressionBinding("Text",""));
                    rpt.stateProcedure_cellDB.ExpressionBindings.Add(new ExpressionBinding("Text", "task_state"));

                    frm.documentViewer1.DocumentSource = rpt;
                    frm.ShowDialog();
                }
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }//end catch
        }

        public void check_dept(XtraReportDepartment rpt)
        {
            //XtraReportDepartment rpt = new XtraReportDepartment();
            if (combDept.Text == "قسم القوى والتمليف")
            {
                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);
                //XtraReportDepartment Report = new XtraReportDepartment();
                //rpt.dept_table.DeleteColumn(rpt.mesure_cell);

                //rpt.dept_table.InsertColumnToLeft(rpt.mesure_cell,true);

                //rpt.dept_table.PerformLayout();

                //XRTableCell namber = new XRTableCell();
                //namber.Name="num";
                //namber.Text="hello";
                //rpt.dept_table.Rows[0].Cells.Add(new XRTableCell { Text = "nnnn", Name = "nn" }.NextCell);
            }
            else if (combDept.Text == "قسم المباني")
            {
                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);
            }
            else if (combDept.Text == "قسم الشبكات")
            {
                rpt.dept_table.DeleteColumn(rpt.wight_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);
            }
            else if (combDept.Text == "قسم التراسل")
            {
                rpt.dept_table.DeleteColumn(rpt.wight_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);
            }
            else if (combDept.Text == "قسم السنترالات")
            {
                rpt.dept_table.DeleteColumn(rpt.wight_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);
            }
            else if (combDept.Text == "قسم النفقات الاستثمارية")
            {
                rpt.dept_table.DeleteColumn(rpt.wight_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);
            }
            else if (combDept.Text == "قسم التخطيط" || combDept.Text == "قسم الاحصاء")
            {
                rpt.dept_table.DeleteColumn(rpt.wight_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                rpt.dept_table.DeleteColumn(rpt.locationImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.location_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.country_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);
            }
            else
            {
                rpt.dept_table.DeleteColumn(rpt.wight_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.wight_cellDB);

                rpt.dept_table.DeleteColumn(rpt.money_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.money_cellDB);

                rpt.dept_table.DeleteColumn(rpt.pirodImplement_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.from_cellDB);
                rpt.dept_tableDB.DeleteColumn(rpt.to_cellDB);

                rpt.dept_table.DeleteColumn(rpt.order_cell);
                rpt.dept_tableDB.DeleteColumn(rpt.order_cellDB);

            }
        }
    }
}