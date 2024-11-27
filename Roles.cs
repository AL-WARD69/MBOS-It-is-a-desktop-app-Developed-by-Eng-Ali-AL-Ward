using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MBOS_Full_System
{
    public partial class Roles : Form
    {
        int selected_role_id = 0;
        int selected_user_id = 0;
        string selected_role_name;
        public Roles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.rolesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.controlSecurityDataSet);

        }
        permissionscls per = new permissionscls();
        private void FormRole_Load(object sender, EventArgs e)
        {
            Edit_PassWord_Btn.Visible = false;
            Edit_Role_Btn.Visible = false;
            Edit_User_Btn.Visible = false;
            try
            {
                per.CheckUserActiveRole(Program.Jop_ID, Program.RoleName, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Fill_Roles();
            Fill_Users();

        }
        private void Fill_Roles()
        {
            BL.Show_Class show = new BL.Show_Class();
            RoleGridControl.DataSource = show.Get_Roles();
            RoleGridView.Columns["رقم الدور"].Visible = false;
        }
        private void Fill_Users()
        {
            BL.Show_Class show = new BL.Show_Class();
            UserGridControl.DataSource = show.Users();
            UserGridView.Columns["UserID"].Visible = false;
            UserGridView.Columns["department_id"].Visible = false;
        }
        

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
           // rolesBindingSource.AddNew();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
          //  rolesBindingSource.EndEdit();
          //  rolesTableAdapter.Update(controlSecurityDataSet.Roles);
          //  MessageBox.Show("تم الحفظ بنجاح");

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //rolesBindingSource.EndEdit();
            //rolesTableAdapter.Update(controlSecurityDataSet.Roles);
            //MessageBox.Show("تم التعديل بنجاح");
        }

        private void grantrolebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
        private void Add_User_Btn_Click(object sender, EventArgs e)
        {
            Users frm = new Users();
            frm.ShowDialog();
            Fill_Users();
        }

        private void RoleGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selected_role_id = Convert.ToInt32(RoleGridView.GetRowCellValue(RoleGridView.FocusedRowHandle, "رقم الدور"));
            selected_role_name= RoleGridView.GetRowCellValue(RoleGridView.FocusedRowHandle, "اسم الدور").ToString();
            if (selected_role_id != 0)
            {
               Edit_Role_Btn.Visible = true;
            }
        }

        private void UserGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selected_user_id = Convert.ToInt32(UserGridView.GetRowCellValue(UserGridView.FocusedRowHandle, "UserID"));
            if (selected_user_id != 0)
            {
                Edit_PassWord_Btn.Visible = true;
                Edit_User_Btn.Visible = true;
            }
        }

        private void Add_Role_Click(object sender, EventArgs e)
        {
            AddRole frm = new AddRole();
            frm.ShowDialog();
            Fill_Roles();
        }

        private void Edit_Role_Btn_Click(object sender, EventArgs e)
        {
            if (selected_role_id != 0)
            {
                AddRole frm = new AddRole(selected_role_name,selected_role_id);
                frm.ShowDialog();
                Fill_Roles();
            }
        }

        private void Edit_User_Btn_Click(object sender, EventArgs e)
        {
            if (selected_user_id != 0)
            {
                EditUsers frm = new EditUsers(selected_user_id);
                frm.ShowDialog();
                Fill_Users();
            }
        }

        private void Edit_PassWord_Btn_Click(object sender, EventArgs e)
        {
            if (selected_user_id != 0)
            {
                EditPassWord frm = new EditPassWord(selected_user_id);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("الرجاء تحديد مستخدم من القائمة");
            }
        }
    }
}
