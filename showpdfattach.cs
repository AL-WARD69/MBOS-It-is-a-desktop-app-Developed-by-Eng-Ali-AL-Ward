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
    public partial class showpdfattach : DevExpress.XtraEditors.XtraForm
    {
         public int  task_id ;
        public string attachment_path;
        public string attache_title;
        public bool prcessing_btn_click;
        public string IS_image;
        public showpdfattach(string path , string title ,int id,bool prcessing_click,string is_image)
        {
            InitializeComponent();
            attachment_path = path;
            string executableloc = Path.GetDirectoryName(Application.ExecutablePath) + @"\attach\";
            string imagr = Path.Combine(executableloc, attachment_path);
            //   this.axAcroPDF1.LoadFile(path);
            this.axAcroPDF1.LoadFile(imagr);
            attache_title = title;
            this.label_attachttille.Text = "عنوان المرفق : " + title ;
            attachment_path = path;
             task_id = id;
            prcessing_btn_click = prcessing_click;
            IS_image = is_image;
            //this.axAcroPDF1.Refresh();
        }
        public showpdfattach()
        {
            InitializeComponent();
        }
        
        

        private void showpdfattach_Load(object sender, EventArgs e)
        {
            //this.axAcroPDF1.LoadFile(path);
            axAcroPDF1.Show();
            this.axAcroPDF1.Refresh();
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
           // int task_id;
          //Task_Details det = new Task_Details(task_id);
          //  BL.Show_Class show_attche = new BL.Show_Class();

            BL.ADD add_attche = new BL.ADD();
            try
            {
              //  MessageBox.Show(IS_image);
                add_attche.ADD_Task_Attachment(task_id,attachment_path,attache_title, IS_image);
                MessageBox.Show("تم حغظ المرفق بنجاح");
                //  det.gridControl_attachment.DataSource = show_attche.Get_Task_Attachemnt(task_id);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}