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


namespace MBOS_Full_System
{
    public partial class SelectRole : DevExpress.XtraEditors.XtraForm
    {
        int Selected_Jop_ID;
        public SelectRole(int Jop_Id)
        {
            InitializeComponent();
            Selected_Jop_ID = Jop_Id;
        }
      
     
        private void simpleButton1_Click(object sender, EventArgs e)
        {
          login();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    login_check();
            //}
        }
       
        public void login()
        {
            Home frmmain = new Home();
            Program.RoleName = RolecomboBox.SelectedText;
            Program.RoleID = Convert.ToInt32(RolecomboBox.SelectedValue.ToString());
            frmmain.ShowDialog();
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            BL.Show_Class role = new BL.Show_Class();
           // DataTable DT = new DataTable();
            //MessageBox.Show(Jop_ID.Text);
           // DT = role.Get_User_Roles(Selected_Jop_ID);
            RolecomboBox.DataSource = role.Get_User_Roles(Selected_Jop_ID);
            RolecomboBox.DisplayMember = "RoleName";
            RolecomboBox.ValueMember = "FKRoleID";
            // TODO: This line of code loads data into the 'controlSecurityDataSet.Roles' table. You can move, or remove it, as needed.
           // this.rolesTableAdapter.Fill(this.controlSecurityDataSet.Roles);

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //labelControl4.Text = CreatePassword(6);
        }
       

        private void simpleButton2_Click_2(object sender, EventArgs e)
        {

               
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Jop_ID_KeyDown(object sender, KeyEventArgs e)
        {
            //if (Jop_ID.Text != "" && txt_pass.Text != "")
            //{
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        login_check();
            //    }
            //}
        }
    }
}
