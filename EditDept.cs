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
    public partial class EditDept : DevExpress.XtraEditors.XtraForm
    {
        int id;
        public bool IsPrimary;
        public EditDept(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        public EditDept()
        {
            InitializeComponent();
        }
        private void update_dept_btn_Click(object sender, EventArgs e)
        {
            BL.ADD update_dept = new BL.ADD();
            int dept_parent;
             int managerID ;
            //MessageBox.Show("update");
            //MessageBox.Show(id.ToString());
            if (add_dept_manager.SelectedIndex == -1)
            {
              managerID=0;
            }
            else
            {
                managerID = Convert.ToInt32(add_dept_manager.SelectedValue);
            }
           
            if (!IsPrimary)
            {
                dept_parent = Convert.ToInt32(dept_type_cb.SelectedValue);
                //MessageBox.Show(dept_type_cb.SelectedValue.ToString());
            }
            else
            {
                dept_parent = 0;
            }
            update_dept.Edit_Dept(id, textEdit1.Text, textEdit2.Text, managerID, dept_parent);
            this.Close();
        }

        private void EditDept_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                add_dept_manager.SelectedIndex = -1;
                add_dept_manager.Enabled = false;
            }
            else
            {

                add_dept_manager.Enabled = true;
            }
        }
    }
}