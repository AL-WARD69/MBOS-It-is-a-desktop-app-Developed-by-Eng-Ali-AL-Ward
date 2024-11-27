using DevExpress.Utils;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MBOS_Full_System
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BL.NotificationData N_Data = null;
      
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        DataTable dt = new DataTable();
      //  private static Home frm_home;
      /*  private static void frm_home_closed(object sender, FormClosedEventArgs e)
        {
            frm_home = null;
        }
        public static Home get_mainHome
        {
            get
            {
                if (frm_home == null)
                {
                    frm_home = new Home();
                    frm_home.FormClosed += new FormClosedEventHandler(frm_home_closed);
                }
                return frm_home;

            }

        }*/
        public Home()
        {
           // if (frm_home == null)
              //  frm_home = this;
            InitializeComponent();
            //this.accordionControlElement1.Visible = false;
           // labelControl1_Homeusername.Text = Program.username;
          /*  this.accordionControlElement1.Visible = true;
            this.accordionControlElement2.Visible = false;
            this.accordionControlElement3.Visible = false;
            this.accordionControlElement4.Visible = false;
            this.accordionControlElement5.Visible = false;
            this.accordionControlElement6.Visible = false;
            this.accordionControlElement7.Visible = false;
            this.accordionControlElement8.Visible = false;
            this.accordionControlElement9.Visible = false;
            this.accordionControlElement10.Visible = false;*/

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Form[] childs = this.MdiChildren;
            for (int i = 0; i < childs.Length; i++)
            {
                //  MessageBox.Show(childs[i].Text);
                childs[i].Close();
            }
            if (this.MdiParent == null)
            {
                
                Charts chartform = new Charts();
                chartform.MdiParent = this;
                chartform.Show();
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Form[] childs = this.MdiChildren;
            for (int i = 0; i < childs.Length; i++)
            {
                //  MessageBox.Show(childs[i].Text);
                childs[i].Close();
            }
            if (this.MdiParent == null)
            {
                TasksMain frm = new TasksMain();
                frm.MdiParent = this;
                frm.Show();
            }
            splashScreenManager1.CloseWaitForm();

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Form[] childs = this.MdiChildren;
            for (int i = 0; i < childs.Length; i++)
            {
                //  MessageBox.Show(childs[i].Text);
                childs[i].Close();
            }
            if (this.MdiParent == null)
            {
                Departments deptform = new Departments();
                deptform.MdiParent = this;
                deptform.Show();
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            Form[] childs = this.MdiChildren;
            for (int i = 0; i < childs.Length; i++)
            {
                //  MessageBox.Show(childs[i].Text);
                childs[i].Close();
            }
            main frm = new main();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
           
            if (this.HasChildren)
            {
                Form[] childs = this.MdiChildren;
                for (int i = 0; i < childs.Length; i++)
                {
                    //  MessageBox.Show(childs[i].Text);
                    childs[i].Close();
                }
            }
            if (this.MdiParent == null)
            {
                //employees emp = new employees();
                //emp.mdi
            }
            splashScreenManager1.CloseWaitForm();

        }

        private void employees1_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            PL.login frm = new PL.login();
            frm.ShowDialog();
            BL.Show_Class notify = new BL.Show_Class();
            DataTable DT = new DataTable();
            DT = notify.Get_Dept_Notify(notify.Get_Dept_Id());

            if (Convert.ToInt32(DT.Rows[0][0].ToString()) > 0)
            {
               // notify_icon.Caption = DT.Rows[0][0].ToString();
                MessageBox.Show(" لديك  " + DT.Rows[0][0].ToString() + " تنبيهات جديدة ");
            }
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                //this.Close();
                Application.Restart();
            }
        }
        string z1;
        int nav1(string z)
        {
            DataTable dt = data.notgemeralarchive();
         
            int no = dt.Rows.Count;


            return no;

        }
        private void Home_Load(object sender, EventArgs e)
        {
            z = "select * from departments where name='" + Program.department_name+ "'";
            z1 = @"SELECT *from  documents_general_archive";
            timer1.Enabled = true;

            //MessageBox.Show("هذا الللود");
            permissionscls per = new permissionscls();
            try
            {
               // MessageBox.Show("هذا الصلاحيات" + Program.RoleID);
                per.CheckUserActiveRole(Program.RoleID, this.Name, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            N_Data = new BL.NotificationData();

            // Hook up event
            N_Data.OnNewMessage += new BL.NotificationData.NewMessage(OnNewMessage);

            // Load existing message
            LoadMessages();
            if (N_Data.GetMessages().ToString() != "")
            {
                SMSCOMMS SMSEngine = new SMSCOMMS("COM1");
                SMSEngine.Open();
                SMSEngine.SendSMS("919888888888", N_Data.GetMessages().ToString());
            }

            /*sqlConnection = new SqlConnection("Server=DESKTOP-Q1B3DVI;Database=MBOS;Integrated Security=true");

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            //else if (sqlConnection.State == ConnectionState.Open)
            //{
            //    sqlConnection.Open();
            //}
            BL.Show_Class notify2 = new BL.Show_Class();
            if (Program.role == 2)
            {
                int userid = notify2.Get_User_Id();
                SqlDependency.Start(sqlConnection.ConnectionString);
                sqlCommand = new SqlCommand("select data from dbo.notifications p inner join dbo.task_notifications d on p.id=d.notify_id where d.user_id=@userid", sqlConnection);
                sqlCommand.Parameters.Add("@userid", userid);
            }
            else
            {
                int userid = notify2.Get_Dept_Id();
                SqlDependency.Start(sqlConnection.ConnectionString);
                sqlCommand = new SqlCommand("select data from dbo.notifications p inner join dbo.task_notifications d on p.id=d.notify_id where d.dept_id=@userid", sqlConnection);
                sqlCommand.Parameters.Add("@userid", userid);
            }
           
            
            SqlDependency sqlDependency = new SqlDependency(sqlCommand);// Also sets sqlCommand.Notification.
            sqlDependency.OnChange += SqlDependecy_OnChange;
            dt.Load(sqlCommand.ExecuteReader(CommandBehavior.CloseConnection));
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                popupMenu1.ItemLinks.Add(new BarButtonItem { Caption = dt.Rows[i][0].ToString() });
            }*/
            main frm = new main();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Properties.Settings.Default["User"].ToString();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                REPORT_PL.DeptReports rep = new REPORT_PL.DeptReports();
                rep.Show();
                //splashScreenManager1.ShowWaitForm();

                //if (!panelControl1.Controls.Contains(REPORT_PL.DeptReports.Instance))
                //{
                //    panelControl1.Controls.Add(REPORT_PL.DeptReports.Instance);
                //    REPORT_PL.DeptReports.Instance.Dock = DockStyle.Fill;
                //    REPORT_PL.DeptReports.Instance.BringToFront();
                //}
                //else
                //{
                //    REPORT_PL.DeptReport.Instance.BringToFront();
                //}
                //splashScreenManager1.CloseWaitForm();
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

            //SqlDependency.Stop(sqlConnection.ConnectionString);
            //sqlConnection.Close();
        }
      
        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                REPORT_PL.TasksReports rep = new REPORT_PL.TasksReports();
                rep.Show();
                //splashScreenManager1.ShowWaitForm();

                //if (!panelControl1.Controls.Contains(REPORT_PL.TasksReport.Instance))
                //{
                //    panelControl1.Controls.Add(REPORT_PL.TasksReport.Instance);
                //    REPORT_PL.TasksReport.Instance.Dock = DockStyle.Fill;
                //    REPORT_PL.TasksReport.Instance.BringToFront();
                //}
                //else
                //{
                //    REPORT_PL.TasksReport.Instance.BringToFront();
                //}
                //splashScreenManager1.CloseWaitForm();
            }
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                Users users = new Users();
                //users. = this;
                users.Show();
            }
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                Roles roles = new Roles();
                roles.MdiParent = this;
                roles.Show();
            }
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                //FormPermissions per = new FormPermissions();
                //per.Show();
                Privillages p = new Privillages();
                p.ShowDialog();
            }
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                //main_mail_sys frm = new main_mail_sys();
                //frm.ShowDialog();
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        void OnNewMessage()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // Check if the event was generated from another
            // thread and needs invoke instead
            if (i.InvokeRequired)
            {
                BL.NotificationData.NewMessage tempDelegate = new BL.NotificationData.NewMessage(OnNewMessage);
                i.BeginInvoke(tempDelegate, null);
                return;
            }

            // If not coming from a seperate thread
            // we can access the Windows form controls
            LoadMessages();
        }
        private void LoadMessages()
        {

            // Clear the listbox
            // lstHistory.Items.Clear();
            popupMenu1.ItemLinks.Clear();
            // Get the messages
            DataTable dt = N_Data.GetMessages();

            // Iterate through the records and add them
            // to the listbox
            foreach (DataRow row in dt.Rows)
            {

                string taskname = string.Format("{0}", row["name"]);
                string notify_data = string.Format("{0}", row["data"]);
                string created_at = string.Format("{0}", row["created_at"]);
                string task_id = string.Format("{0}", row["task_id"]);
                string proirity = string.Format("{0}", row["priority"]);

                if (proirity == "عاجلة")
                {

                    popupMenu1.ItemLinks.Add(new BarSubItem
                    {
                        Caption = taskname + "\n" + notify_data + "\n" + created_at,
                       Glyph = MBOS_Full_System.Properties.Resources.important.ToBitmap(),
                        Id = Convert.ToInt32(task_id),
                        Description = taskname
                    });

                }
                else
                {
                    popupMenu1.ItemLinks.Add(new BarSubItem
                    {
                        Caption = taskname + "\n" + notify_data + "\n" + created_at,
                        Glyph = MBOS_Full_System.Properties.Resources.new_notification.ToBitmap(),
                        Id = Convert.ToInt32(task_id),
                        Description = taskname
                    });
                }

            }

            //  MessageBox.Show(id.ToString());
            badgeNotificatoinCount.Properties.Text = dt.Rows.Count.ToString();
            if (dt.Rows.Count != 0)
            {
                labelControl1.Text = dt.Rows.Count.ToString();
                flyoutPanel1.ShowPopup();
            }
            else
            {
                flyoutPanel1.HidePopup();
            }
           // notify_countbadge.Properties.Text = dt.Rows.Count.ToString();

            // notificaion_countLabel.Text = dt.Rows.Count.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarButtonItemLink link = e.Link as BarButtonItemLink;
            Point p = link.Bounds.Location;
            p.Y += link.Bounds.Height;
            this.popupMenu1.ShowPopup(barButtonItem1.Manager, link.LinkPointToScreen(p));
        }

        private void barButtonItem1_ItemPress(object sender, ItemClickEventArgs e)
        {

        }

        private void flyoutPanel1_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            string tag = e.Button.Tag.ToString();
            switch (tag)
            {
                case "hide":
                    (sender as FlyoutPanel).HidePopup();
                    break;
            }
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {

        }

        private void قائمالمهامToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تهئةالاداراتوالاقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments dept = new Departments();
            dept.MdiParent = this;
            dept.Show();
        }

        private void تهئةالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.MdiParent = this;
            user.Show();
        }

        private void الادوارالوظيفيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void الصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privillages privlege = new Privillages();
            privlege.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ribbonControl1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (e.Item is BarSubItem)
            {
                BarSubItem item = e.Item as BarSubItem;
                int id = item.Id;
                BL.Show_Class IsManager = new BL.Show_Class();
                int dept_id = IsManager.Get_Dept_Id();
                BL.NotificationData.update_notification_status(id, dept_id);
                if (this.HasChildren)
                {
                    Form[] childs = this.MdiChildren;
                    for (int i = 0; i < childs.Length; i++)
                    {
                        //  MessageBox.Show(childs[i].Text);
                        childs[i].Close();
                    }
                }
                BL.Show_Class get = new BL.Show_Class();
                string user_type = get.Check_Type(id);
                splashScreenManager1.ShowWaitForm();
                TasksDetails frm = new TasksDetails(user_type, id);
                frm.MdiParent = this;
                frm.Show();
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void accordionControlElement22_Click(object sender, EventArgs e)
        {
            doc_setting d = new doc_setting();
            d.MdiParent = this;
            d.Show();
        }

        private void accordionControlElement23_Click(object sender, EventArgs e)
        {
            Header h = new Header();
            h.MdiParent = this;
            h.Show();
        }

        private void accordionControlElement13_Click_1(object sender, EventArgs e)
        {
            add_mailing add = new add_mailing();
            add.MdiParent = this;
            add.Show();
        }

        private void accordionControlElement15_Click_1(object sender, EventArgs e)
        {
            display_all d = new display_all();
            d.MdiParent = this;
            d.Show();
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            ma_send dis = new ma_send();
            dis.MdiParent = this;
            dis.Show();
        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            display rs = new display();
            rs.MdiParent = this;
            rs.Show();
        }

        private void accordionControlElement24_Click(object sender, EventArgs e)
        {
            send s = new send();
            s.MdiParent = this;
            s.Show();
        }

        private void accordionControlElement25_Click(object sender, EventArgs e)
        {
            add_general_archive ff = new add_general_archive();
            ff.MdiParent = this;
            ff.Show();
        }

        private void accordionControlElement26_Click(object sender, EventArgs e)
        {
            archive_noti j = new archive_noti();
            j.MdiParent = this;
            j.Show();
        }

        private void accordionControlElement27_Click(object sender, EventArgs e)
        {
            arch_puplic pl = new arch_puplic();
            pl.MdiParent = this;
            pl.Show();
        }

        private void accordionControlElement28_Click(object sender, EventArgs e)
        {
            search frm = new search();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accordionControlElement29_Click(object sender, EventArgs e)
        {
            Create_specialarchive c = new Create_specialarchive();
            c.MdiParent = this;
            c.Show();
        }

        private void accordionControlElement30_Click(object sender, EventArgs e)
        {
            doc_specialarch f = new doc_specialarch();
            f.MdiParent = this;
            f.Show();
        }

        private void accordionControlElement31_Click(object sender, EventArgs e)
        {
            docspecial_display f = new docspecial_display();
            f.MdiParent = this;
            f.Show();
        }

        private void accordionControlElement32_Click(object sender, EventArgs e)
        {
            add_general_archive ff = new add_general_archive();
            ff.Show();
        }

        private void accordionControlElement33_Click(object sender, EventArgs e)
        {
            arch_puplic frm = new arch_puplic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accordionControlElement34_Click(object sender, EventArgs e)
        {
            search frm = new search();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accordionControlElement35_Click(object sender, EventArgs e)
        {
            archive_noti j = new archive_noti();
            j.MdiParent = this;
            j.Show();
        }
        settings.all_class data = new settings.all_class();
        private void not_lable_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            DataTable dt = new DataTable();
           dt=data.notmailling(Convert.ToInt32(Program.send_dept_id));
            int no = dt.Rows.Count;
            if (no > 0)
            {
                re_send dis = new re_send();
                dis.MdiParent = this;
                dis.Show();

                data.updatenotmailling(Convert.ToInt32(Program.send_dept_id),Convert.ToDateTime(System.DateTime.Now.ToString("yyyy/MM/dd")));
                
                //SqlDataAdapter da1 = new SqlDataAdapter("update mailing set show='true' where receiving_jeha_id=" + textBox4.Text, con);
            }
        }
        public string z;
        int nav(string z)
        {
            DataTable dt = new DataTable();
            dt = data.notmailling(Convert.ToInt32(Program.send_dept_id));
            int no = dt.Rows.Count;


            return no;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            not_lable.Caption = nav(z).ToString();
            gen_lables.Caption = nav1(z1).ToString();
        }

        private void barHeaderItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

           
                  DataTable dt = data.notgemeralarchive();
         
            int no = dt.Rows.Count;
            if (no > 0)
            {
                archive_noti j = new archive_noti();
                j.MdiParent = this;
                j.Show();
                // MessageBox.Show(System.DateTime.Now.ToString("yyyy/MM/dd"));
                
                data.updatenotgemeralarchive(Convert.ToInt32(Program.no));
              
                //SqlDataAdapter da1 = new SqlDataAdapter("update mailing set show='true' where receiving_jeha_id=" + textBox4.Text, con);
            }
        }

        private void accordionControlElement36_Click(object sender, EventArgs e)
        {

            email s = new email();
            s.MdiParent = this;
            s.Show();
        }

        private void accordionControlElement37_Click(object sender, EventArgs e)
        {
            backup b = new backup();
            b.MdiParent = this;
            b.Show();
        }
    }
}
