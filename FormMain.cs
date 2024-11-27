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
    //DevExpress.XtraEditors.XtraForm
    //DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
            

        }
        permissionscls per = new permissionscls();
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                per.CheckUserActiveRole(Program.Jop_ID, this.roletxt.Text, this);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            //users. = this;
            users.Show();
        }

        private void الادوارالوظيفيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.Show();
        }

        private void الصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Permissions per = new Permissions();
            //per.Show();
        }

        private void تهيئةالاداراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //if (!panelControl1.Controls.Contains(Departments.Instance))
            //{
            //    panelControl1.Controls.Add(Departments.Instance);
            //    Departments.Instance.Dock = DockStyle.Fill;
            //    Departments.Instance.BringToFront();
            //}
            //else
            //{
            //    Departments.Instance.BringToFront();
            //}
            //splashScreenManager1.CloseWaitForm();
            //addDepartment dd = new addDepartment();
            //dd.Show();
        }

        private void إنشاءمهمةرئيسيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTask tsk = new AddTask();
            tsk.Show();
           
        }

        private void main_taskshowelement_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //if (!panelControl1.Controls.Contains(chart.Instance))
            //{
            //    panelControl1.Controls.Add(chart.Instance);
            //    chart.Instance.Dock = DockStyle.Fill;
            //    chart.Instance.BringToFront();
            //}
            //else
            //{
            //    chart.Instance.BringToFront();
            //}
            //splashScreenManager1.CloseWaitForm();
        }

        private void مخطط_مستوى_الانجاز_للمهام_الفرعية_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //if (!panelControl1.Controls.Contains(chart.Instance))
            //{
            //    panelControl1.Controls.Add(chart.Instance);
            //    chart.Instance.Dock = DockStyle.Fill;
            //    chart.Instance.BringToFront();
            //}
            //else
            //{
            //    chart.Instance.BringToFront();
            //}
            //splashScreenManager1.CloseWaitForm();
        }

        private void steps_showelement_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //if (!panelControl1.Controls.Contains(chart.Instance))
            //{
            //    panelControl1.Controls.Add(chart.Instance);
            //    chart.Instance.Dock = DockStyle.Fill;
            //    chart.Instance.BringToFront();
            //}
            //else
            //{
            //    chart.Instance.BringToFront();
            //}
            //splashScreenManager1.CloseWaitForm();
        }

        private void إنشاءمهمةفرعيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // AddSubTask stsk = new AddSubTask();
            //stsk.Show();
        }

        private void تقريرالانجازToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //splashScreenManager1.ShowWaitForm();
            //if (!panelControl1.Controls.Contains(Tasks.Instance))
            //{
            //    panelControl1.Controls.Add(Tasks.Instance);
            //    Tasks.Instance.Dock = DockStyle.Fill;
            //    Tasks.Instance.BringToFront();
            //}
            //else
            //{
            //    Tasks.Instance.BringToFront();

            //}
            //splashScreenManager1.CloseWaitForm();
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}