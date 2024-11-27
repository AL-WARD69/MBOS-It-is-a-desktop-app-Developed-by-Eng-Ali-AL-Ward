using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MBOS_Full_System.REPORT_PL
{
    public partial class XtraReportDepartment : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDepartment()
        {
            InitializeComponent();
        }

        private void XtraReportDepartment_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //DeptReport deptReport = new DeptReport();

            //if(deptReport.combDept.Text=="قسم الاحصاء")
            //{
            //dept_table.DeleteColumn(mesure_cell);
            //dept_tableDB.DeleteColumn(mesure_cellDB);
            //}


        }

    }
}
