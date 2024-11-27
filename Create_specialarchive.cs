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
    public partial class Create_specialarchive : Form
    {
        archive_special.special u = new archive_special.special();
        SqlDataAdapter da;
        //SqlCommandBuilder scb;
        DataTable dt = new DataTable();
        string userid;
        public Create_specialarchive()
        {
            InitializeComponent();
            filldatagrud();


            //comboBox1.DataSource = u.get_user_name();
            //comboBox1.DisplayMember = "FullName";
            //comboBox1.ValueMember = "no";
            txtdeptname.Text = Program.department_name;
            txtfullname.Text = Program.FullName;
            txtdeptid.Text = Program.send_dept_id;
            userid = Program.no;
            txtuserid.Text = userid;

        }
        public void filldatagrud()
        {
           dataGridView1.DataSource = u.get_specialarchiveandlocations();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btnsavearchive.Enabled = true;
               loodinc();
            filldatagrud();
            btnsavelocation.Enabled = false;

        }
        void newloc() {
            DataTable dt = u.get_locationsid();
            txtlocid.Text = dt.Rows[0][0].ToString();
            txtlocid.Enabled = false;
            filldatagrud();
            txtfoldername.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            u.add_special_Archive( int.Parse(txtspecialid.Text) ,int.Parse(txtdeptid.Text) , int.Parse(userid ));
           // query.CommandText += "insert into special_locations(location_id,folder_name,special_id) values(" + int.Parse(textBox5.Text) + ",'" + textBox1.Text + "'," + int.Parse(textBox2.Text) + ")";
            // query.CommandText += "insert into special_Archive(special_id)" + "values('" + textBox2.Text + "')";
           
                MessageBox.Show("تم أدارج وأدخال البيانات ");

           
            DataTable dt = u.get_locationsid();
            txtlocid.Text = dt.Rows[0][0].ToString();
            txtlocid.Enabled = false;
            //  Form4_Load(sender, e);
            btnsavearchive.Enabled = false;
            btnsavelocation.Enabled = true;
        }
        void loodinc()
        {
            DataTable did = u.get_specialarchivedid();
            if (did.Rows.Count>0)
            {
                
                    txtspecialid.Text = did.Rows[0][0].ToString();
                    txtspecialid.Enabled = false;
                }
               
               
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection mycon = new SqlConnection("server=.; Database=MBOS; integrated security=true");
           
         try
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\special_Archive\\" + txtfoldername.Text.ToString().Trim();
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                   u.add_special_locations( int.Parse(txtlocid.Text) ,  path  , int.Parse(txtspecialid.Text), int.Parse(txtdeptid.Text)) ;
            // query.CommandText += "insert into special_Archive(special_id)" + "values('" + textBox2.Text + "')";
           
                MessageBox.Show("تم أدارج وأدخال البيانات ");
            newloc();
              }
           else { MessageBox.Show("المجلد تم انشائه مسبقا"); return; }
            }
            catch (Exception ff) { MessageBox.Show("لم تتم العملية" + ff.Message); }
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4_Load(sender, e);
        }
    }
}
