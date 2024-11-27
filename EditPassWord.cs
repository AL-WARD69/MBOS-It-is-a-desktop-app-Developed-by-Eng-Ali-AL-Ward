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
    public partial class EditPassWord : DevExpress.XtraEditors.XtraForm
    {
        int selected_user_id;
        public EditPassWord(int user_id)
        {
            InitializeComponent();
            selected_user_id = user_id;

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlSecurityDataSet);

        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            
            BL.Show_Class fill = new BL.Show_Class();
            this.Text="تعديل كلمة المرور ل" +fill.Get_User_Info_By_Id(selected_user_id).Rows[0][0].ToString();
            //// TODO: This line of code loads data into the 'mBOSDataSet.departments' table. You can move, or remove it, as needed.
            //this.departmentsTableAdapter.Fill(this.mBOSDataSet.departments);
            //// TODO: This line of code loads data into the 'controlSecurityDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.controlSecurityDataSet.Users);
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
            usersBindingSource.AddNew();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                usersBindingSource.EndEdit();
                usersTableAdapter.Update(controlSecurityDataSet.Users);
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PassWord_EditValueChanged(object sender, EventArgs e)
        {
            if (PassWord.Text == "")
            {
                SaveUserBtn.Enabled = false;
                check_complex();
            }
            else
            {
                SaveUserBtn.Enabled = true;
                check_complex();
            }
        }
        private void check_complex()
        {
            string string1 = PassWord.Text;
            string patdi = @"\d+"; //match digits
            string patupp = @"[A-Z]+"; //match upper cases
            string patlow = @"[a-z]+"; //match lower cases
            // string patsym = @"[`~!@$%^&\\-\\+*/_=,;.':|\\(\\)\\[\\]\\{\\}]+"; //match symbols
            Match id = Regex.Match(string1, patdi);
            Match upp = Regex.Match(string1, patupp);
            Match low = Regex.Match(string1, patlow);
            //Match sym = Regex.Match(string1, patsym );
            //if(sym.Success)
            //{
            //    checkBox4.ForeColor = Color.Black;
            //    checkBox4.Checked = true;
            //    MessageBox.Show("hh");
            //}
            //else
            //{
            //   // MessageBox.Show(sym.Success.ToString());
            //    checkBox4.ForeColor = Color.Red;
            //    checkBox4.Checked = false;
            //}
            if (id.Success)
            {
                checkBox1.ForeColor = Color.Blue;
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.ForeColor = Color.Red;
                checkBox1.Checked = false;
            }
            if (upp.Success)
            {
                checkBox2.ForeColor = Color.Blue;
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.ForeColor = Color.Red;
                checkBox2.Checked = false;
            }
            if (low.Success)
            {
                checkBox3.ForeColor = Color.Blue;
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.ForeColor = Color.Red;
                checkBox3.Checked = false;
            }
            if (id.Success && upp.Success && low.Success)
            {
                SaveUserBtn.Enabled = true;
            }
            else
            {
                SaveUserBtn.Enabled = false;
            }

        }

        //private void UserName_Validating(object sender, CancelEventArgs e)
        //{

        //}

        //private void UserName_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        //{
        //    e.ErrorText = "الرجاء تعبئة اسم المستخدم";
        //}

        //private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = false;
        //}

        //private void JopID_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        //{
        //    e.ErrorText = "الرجاء تعبئة الرقم الوظيفي";
        //}

        //private void JopID_Validating(object sender, CancelEventArgs e)
        //{

        //}

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
           BL.ADD user = new BL.ADD();
           if (PassWord.Text != "")
           {
               if (PassWord.Text == ConfirmPassWord.Text && PassWord.Text.Length >= 6)
               {
                   try
                   {
                       user.Change_PassWord(selected_user_id, PassWord.Text);
                       MessageBox.Show("تم تعديل كلمة المرور بنجاح !");
                       this.Close();
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.ToString());
                   }
               }
               else
               {
                   if (PassWord.Text.Length < 6)
                   {
                       MessageBox.Show("يجب ان لايقل طول كلمة المرور عن 6 احرف");
                   }
                   else
                   {
                       MessageBox.Show("كلمتي المرور غير متطابقتين");
                   }
               }
           }
           else
           {
               ClearInputColor();
               MessageBox.Show("الرجاء ملء الحقول المطلوبة");
               if (PassWord.Text == "")
               {
                   PassWord.Properties.Appearance.BorderColor = Color.Red;
                   //MessageBox.Show("PassWord");
               }
           }
        }
        private void ClearInputColor()
        {
            PassWord.Properties.Appearance.BorderColor = Color.MediumSeaGreen;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
