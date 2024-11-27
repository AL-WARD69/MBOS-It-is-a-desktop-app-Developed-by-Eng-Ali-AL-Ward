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
    public partial class EditUsers : DevExpress.XtraEditors.XtraForm
    {
        int user_id;
        public EditUsers(int id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlSecurityDataSet);

        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            BL.ADD dept = new BL.ADD();
            BL.Show_Class fill = new BL.Show_Class();
            Dept.DataSource = dept.GET_ALL_DEPARTMENTS();
            Dept.DisplayMember = "name";
            Dept.ValueMember = "id";
            RolesJops.DataSource = fill.Get_Roles();
            RolesJops.DisplayMember = "اسم الدور";
            RolesJops.ValueMember = "رقم الدور";
           
            
            //// TODO: This line of code loads data into the 'mBOSDataSet.departments' table. You can move, or remove it, as needed.
            //this.departmentsTableAdapter.Fill(this.mBOSDataSet.departments);
            //// TODO: This line of code loads data into the 'controlSecurityDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.controlSecurityDataSet.Users);
            fill_details();
        }
        private void fill_details()
        {
            BL.ADD dept = new BL.ADD();
            BL.Show_Class fill = new BL.Show_Class();
            DataTable dt = new DataTable();
            dt = fill.Get_User_Info_By_Id(user_id);
            UserName.Text = dt.Rows[0][0].ToString();
            Phone.Text = dt.Rows[0][2].ToString();
            JopName.Text = dt.Rows[0][3].ToString();
            if (dt.Rows[0][4].ToString() =="True")
            {
                activeCheckEdit.Checked = true;
            }

            for (int i = 0; i < dept.GET_ALL_DEPARTMENTS().Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[0][1].ToString()) == Convert.ToInt32(dept.GET_ALL_DEPARTMENTS().Rows[i][0]))
                {
                    //MessageBox.Show(add_dept.GET_ALL_DEPARTMENTS().Rows[i][5].ToString());
                    Dept.SelectedIndex = i;
                }
               // MessageBox.Show(dept.GET_ALL_DEPARTMENTS().Rows[i][0].ToString());    
            }
            
            RolesJops.CheckAll();
            int count = RolesJops.CheckedItems.Count;
            int jop_id = Convert.ToInt32(dt.Rows[0][5].ToString());
            //dt = fill.Get_User_Roles(jop_id);
            DataTable df = new DataTable();
            df = fill.Get_User_Roles(jop_id);
            for (int x = count - 1; x >= 0; x--)
            {
                bool result = false;
                for (int i = 0; i < df.Rows.Count; i++)
                {
                    //MessageBox.Show(df.Rows[i][0].ToString() +" "+ RolesJops.CheckedItems[x].ToString());
                    if (df.Rows[i][0].ToString() == RolesJops.CheckedItems[x].ToString())
                    {
                        result = true;
                       // MessageBox.Show("yy");
                    }
                }
                if (!result)
                {
                    RolesJops.SetItemChecked(x, false);
                }
            }
            //RolesJops.SetItemChecked(0, false);
        }
      

        private void savebtn_Click(object sender, EventArgs e)
        {
            //if (pswrdconfromtxt.Text != passwordTextEdit.Text)
            //{
            //    MessageBox.Show("كلمه المرور غير مطابقه");
            //    return;
            //}
            //else
            //{
            //    try
            //    {
            //        usersBindingSource.EndEdit();
            //        usersTableAdapter.Update(controlSecurityDataSet.Users);
            //        MessageBox.Show("تم الحفظ بنجاح");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

            //}
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //usersBindingSource.AddNew();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    usersBindingSource.EndEdit();
            //    usersTableAdapter.Update(controlSecurityDataSet.Users);
            //    MessageBox.Show("تم التعديل بنجاح");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        
   
        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            BL.ADD user = new BL.ADD();
            if ( UserName.Text != "")
            {
                 int active = 0;
                        if (activeCheckEdit.Checked == true)
                        {
                            active = 1;
                        }
                        try
                        {
                            if (RolesJops.CheckedItems.Count > 0)
                            {
                                BL.Show_Class role = new BL.Show_Class();
                                int user_phone;
                                if (Phone.Text == "")
                                {
                                    user_phone = 0;
                                }
                                else
                                {
                                 user_phone=Convert.ToInt32(Phone.Text);
                                }
                                user.Update_User(UserName.Text,user_id, Convert.ToInt32(Dept.SelectedValue.ToString()), JopName.Text, user_phone, active);
                                user.Clear_User_Roles(user_id);
                                for (int i = 0; i < RolesJops.CheckedItems.Count; i++)
                                {
                                    user.Add_User_Roles(user_id,Convert.ToInt32(RolesJops.CheckedItems[i]));
                                    //MessageBox.Show("dd");
                                }
                                MessageBox.Show("تم تعديل البيانات بنجاح!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("الرجاء تحديد الدور الوظيفي");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
            }
            else
            {
                ClearInputColor();
                MessageBox.Show("الرجاء ملء الحقول المطلوبة");
                if (UserName.Text == "")
                {
                   UserName.Properties.Appearance.BorderColor=Color.Red;
                  // MessageBox.Show("UserName");
                }
                
            }



        }
        private void ClearInputColor()
        {
            UserName.Properties.Appearance.BorderColor = Color.MediumSeaGreen;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
