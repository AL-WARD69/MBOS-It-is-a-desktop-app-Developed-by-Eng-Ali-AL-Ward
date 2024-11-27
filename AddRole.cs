using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MBOS_Full_System
{
    public partial class AddRole : DevExpress.XtraEditors.XtraForm
    {
        string selected_role_name;
        int selected_role_id = 0;
        public AddRole()
        {
            InitializeComponent();
        }
        public AddRole(string Role_Name,int RoleId)
        {
            InitializeComponent();
            selected_role_name = Role_Name;
            selected_role_id = RoleId;
            RoleName.Text = Role_Name;
            this.Text = "تعديل اسم الدور الوظيفي";
        }
        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            bool IsFound = false;
             BL.Show_Class user = new BL.Show_Class();
             DataTable Dt= user.Get_Roles();
            
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if (Dt.Rows[i][1].ToString() == RoleName.Text)
                {
                    IsFound = true;
                }
            }
            if (RoleName.Text != "")
            {
                if (!IsFound)
                {
                    try
                    {
                        BL.ADD role = new BL.ADD();
                        if (selected_role_id != 0)
                        {
                            role.Update_Role(RoleName.Text,selected_role_id);
                            MessageBox.Show("تم تعديل الدور الوظيفي بنجاح !");
                        }
                        else
                        {
                            role.Add_Role(RoleName.Text);
                            MessageBox.Show("تم اضافة الدور الوظيفي بنجاح !");
                        }
                        
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("يوجد دور وظيفي بهذا الاسم");
                }
            }
            else
            {
                ClearInputColor();
                MessageBox.Show("الرجاء ملء الحقول المطلوبة");
                if (RoleName.Text == "")
                {
                    RoleName.Properties.Appearance.BorderColor = Color.Red;
                    // MessageBox.Show("UserName");
                }
            }



        }
        private void ClearInputColor()
        {
            RoleName.Properties.Appearance.BorderColor = Color.MediumSeaGreen;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
