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
using System.Text.RegularExpressions;


namespace MBOS_Full_System.PL
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {

        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public login()
        {
            InitializeComponent();
        }
        private bool LoginUser(object JopID, object password)
        {
            ConnectionStringSettingsCollection connectionStrings =
            ConfigurationManager.ConnectionStrings;
            string connString = connectionStrings[
               "MBOS_Full_System.Properties.Settings.MBOSConnectionString"].
                   ToString();
            SqlConnection conn = new SqlConnection(connString);
           


            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "Select Count(*) From [Users] Where [Jop_ID]=@JopID and [password]=@password";
            sqlCommand.Connection = conn;
            sqlCommand.Parameters.AddWithValue("@JopID",JopID);
            sqlCommand.Parameters.AddWithValue("@password", password);
            conn.Open();

            object obj = sqlCommand.ExecuteScalar();
            conn.Close();
            if (obj == null || obj.ToString() != "1")
                return false;
            else
                return true;
        }

        private void get_details(int Jop_Id)
        {
            BL.Show_Class user = new BL.Show_Class();
//            ConnectionStringSettingsCollection connectionStrings =
//            ConfigurationManager.ConnectionStrings;
//            string connString = connectionStrings[
//            "MBOS_Full_System.Properties.Settings.MBOSConnectionString"].
//                ToString();
//            SqlConnection conn = new SqlConnection(connString);
//            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT users.FullName ,users.userid,departments.id,departments.name,users.job
//                        FROM  users  INNER JOIN  departments ON users.department_id =  departments.id
//                        AND  users.Jop_ID='" + Jop_ID.Text + "' and users.password='" + txt_pass.Text + "'", conn);
//            DataTable dt = new DataTable();
//            sda.Fill(dt);

            //if (dt.Rows.Count == 1)
            //{//dt.Rows[0][0].ToString())
            DataTable DT =new DataTable();
            DT = user.Get_User_Info(Jop_Id);
            Program.no = DT.Rows[0]["UserID"].ToString();
            Program.FullName = DT.Rows[0]["fullname"].ToString();
            Program.job = DT.Rows[0]["job"].ToString();
            Program.Jop_ID = Convert.ToInt32(Jop_ID.Text);
            Program.department_name= DT.Rows[0]["name"].ToString();
            Program.send_dept_id = DT.Rows[0]["id"].ToString();
            //}
        }

        public static login lgi = null;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
            login_check();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_check();
            }
        }
       
        public void login_check()
        {

            if (LoginUser(Jop_ID.Text, txt_pass.Text))
            {
                BL.Show_Class role = new BL.Show_Class();
                Jop_ID.Properties.Appearance.BorderColor = Color.Black;
                txt_pass.Properties.Appearance.BorderColor = Color.Black;
                //Program.role = Convert.ToInt32(comboBox1.SelectedValue.ToString());
               // Program.username = txt_name.Text;
               // BL.Show_Class d = new BL.Show_Class();
                int Jop_Id=Convert.ToInt32(Jop_ID.Text);
                get_details(Jop_Id);
                DataTable DT = new DataTable();
                //MessageBox.Show(Jop_ID.Text);
                DT = role.Get_User_Roles(Convert.ToInt32(Jop_ID.Text));
                if (DT.Rows.Count == 1)
                {
                    Home frmmain = new Home();
                    Program.RoleName = DT.Rows[0][1].ToString();
                    Program.RoleID = Convert.ToInt32(DT.Rows[0][0].ToString());
                    frmmain.barHeaderItem3.Caption = Program.FullName.ToString();
                    frmmain.barHeaderItem5.Caption = Program.job.ToString();
                    //MessageBox.Show(DT.Rows[0][1].ToString());
                    frmmain.ShowDialog();

                    this.Close();
                }
                else
                {
                    SelectRole frm = new SelectRole(Jop_Id);
                    frm.ShowDialog();
                    this.Close();
                }
               // FormMain frmmain = new FormMain();
               
            }
            else if (Jop_ID.Text == "" || txt_pass.Text == "")
            {
                if (Jop_ID.Text == "")
                {
                    Jop_ID.Properties.Appearance.BorderColor = Color.Red;
                    txt_pass.Properties.Appearance.BorderColor = Color.Transparent;
                   
                }
                else
                {
                    txt_pass.Properties.Appearance.BorderColor = Color.Red;
                    Jop_ID.Properties.Appearance.BorderColor = Color.Transparent;
                }
                lbl_err.Text = "الرجاء ملء الحقول المطلوبة";

            }
            else
            {
               lbl_err.Text = "الرجاء التأكد من المعلومات التي ادخلتها";
               Jop_ID.Properties.Appearance.BorderColor = Color.Red;
               txt_pass.Properties.Appearance.BorderColor = Color.Red;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlSecurityDataSet.Roles' table. You can move, or remove it, as needed.
           // this.rolesTableAdapter.Fill(this.controlSecurityDataSet.Roles);

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //labelControl4.Text = CreatePassword(6);
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
            
        }

        private void simpleButton2_Click_2(object sender, EventArgs e)
        {

               
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Jop_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (Jop_ID.Text != "" && txt_pass.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    login_check();
                }
            }
        }
    }
}
