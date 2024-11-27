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
using System.IO;

namespace MBOS_Full_System
{
    public partial class showImageattach : DevExpress.XtraEditors.XtraForm
    {
        public int task_id;
        public string attachment_path;
        public string attache_title;
     
        public bool prcessing_btn_click;
        public string IS_image;
        public showImageattach(string path , string title, int id, bool prcessing_click,string is_image)
        {
            InitializeComponent();
            attachment_path = path;
        
            string executableloc = Path.GetDirectoryName(Application.ExecutablePath) + @"\attach\";
            string imagr = Path.Combine(executableloc, attachment_path);
            pictureBox1.Image = Image.FromFile(imagr);

           // this.pictureBox1.Load(path);
            attache_title = title;
            this.label_attachttille.Text = "عنوان المرفق : " + title;
            attachment_path = path;
            task_id = id;
            prcessing_btn_click = prcessing_click;
            IS_image = is_image;
        }
        public showImageattach()
        {
            InitializeComponent();
        }

        private void showImageattach_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            this.pictureBox1.Refresh();
            if (prcessing_btn_click == true)
            {
                simpleButton_saveattachment.Visible = true;
            }
            else
            {
                simpleButton_saveattachment.Visible = false;
            }
        }

        private void simpleButton_saveattachment_Click(object sender, EventArgs e)
        {
            BL.ADD add_attche = new BL.ADD();
            try
            {

               
                
                //  MessageBox.Show(IS_image);
                add_attche.ADD_Task_Attachment(task_id, attachment_path, attache_title, IS_image);
                //  MessageBox.Show("تم");
                //  det.gridControl_attachment.DataSource = show_attche.Get_Task_Attachemnt(task_id);
               // TasksDetails ts = new TasksDetails();
              
                this.Close();
                MessageBox.Show("تم حفظ المرفق");
               // ts.buttonEdit_attachment.Text = "";
                //ts.textEdit3_attachtitle.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}