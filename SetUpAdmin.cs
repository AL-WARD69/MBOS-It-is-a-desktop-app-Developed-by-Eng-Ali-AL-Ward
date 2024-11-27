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
using System.Text.RegularExpressions;

namespace MBOS_Full_System
{
    public partial class SetUpAdmin : DevExpress.XtraEditors.XtraForm
    {
        public SetUpAdmin()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
             BL.ADD user = new BL.ADD();
             if (JopID.Text != "")
             {
                 if (user.HasAccount(Convert.ToInt32(JopID.Text)) == false)
                 {
                     if (PassWord.Text == ConfirmPassWord.Text)
                     {
                         int active = 0;
                         if (activeCheckEdit.Checked == true)
                         {
                             active = 1;
                         }
                         user.Add_User(UserName.Text, PassWord.Text, Convert.ToInt32(JopID.Text), Convert.ToInt32(Dept.SelectedValue.ToString()), JopName.Text, Convert.ToInt32(Phone.Text), active);
                         
                     }
                     else
                     {
                         MessageBox.Show("كلمتي المرور غير متطابقتين");
                     }
                 }
                 else
                 {
                     MessageBox.Show("يوجد حساب بهذا الرقم الوظيفي");
                 }
             }
             else
             {
                 MessageBox.Show("الرجاء ملء حقل الرقم الوظيفي");
             }
             
    }

        private void SetUpAdmin_Load(object sender, EventArgs e)
        {
            BL.ADD dept = new BL.ADD();
            Dept.DataSource = dept.GET_ALL_DEPARTMENTS();
            Dept.DisplayMember = "name";
            Dept.ValueMember = "id";
        }

        private void PassWord_EditValueChanged(object sender, EventArgs e)
        {
            check_complex();
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
                Save.Enabled = true;
            }
            else
            {
                Save.Enabled = false;
            }

        }
    }
}