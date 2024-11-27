using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MBOS_Full_System
{
    public partial class add_general_archive : Form
    {
        public add_general_archive()
        {
            InitializeComponent();
        }



        //generalarchive

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_foldername.Text.ToString().Length > 0)
            {
                try
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\generalarchive\\"+txt_foldername.Text.ToString().Trim();
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                        dd.add_general_archive(Convert.ToInt32(txt_genaralid.Text.ToString()), Convert.ToDateTime(txt_date.Text.ToString()), Convert.ToInt32(txt_deptid.Text.ToString()), Convert.ToInt32(txt_userid.Text.ToString()), path);
                        MessageBox.Show("تمت العملية بنجاح");
                    }
                    else { MessageBox.Show("المجلد تم انشائه مسبقا"); return; }
                }
                catch (Exception ff) { MessageBox.Show("لم تتم العملية"+ff.Message); }
            }
        }
        general_archive.allclass dd = new general_archive.allclass();
        private void general_archives_Load(object sender, EventArgs e)
        {
            txt_deptid.Text = Program.send_dept_id;
            txt_userid.Text = Program.no;
            txt_username.Text = Program.FullName;
            txt_deptname.Text = Program.department_name;
            DataTable dt = dd.get_general_archiveid();
            txt_genaralid.Text = dt.Rows[0][0].ToString();
            if (!txt_genaralid.Text.ToString().Equals("1")) { MessageBox.Show("تم انشاء مجلد عام مسبقا");this.Close(); return; }
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
