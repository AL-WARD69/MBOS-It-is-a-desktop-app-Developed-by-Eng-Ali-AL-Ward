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
    public partial class archive_noti : Form
    {//int jeha_id, int department_id, int no, string adminstration, string department_name, string employee_name
        public archive_noti()
        {
            InitializeComponent();

            txtdept_id.Text = Program.send_dept_id;// jeha_id.ToString();
            txtdeptname.Text = Program.department_name;
            txtdept_name1.Text = Program.department_name;//department_name;
            txtusername.Text = Program.FullName;// employee_name;
            txt_deptid2.Text =  Program.send_dept_id;//department_id.ToString();
            txtuserid.Text = Program.no;//no.ToString();
              // textBox7.Text = employee_name;
          

        }

        private void archive_noti_Load(object sender, EventArgs e)
        {

        }
        general_archive.allclass data = new general_archive.allclass();
        private void archive_noti_Activated(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = data.documentsgeneral();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // //general_archive.arch_puplic ga = new general_archive.arch_puplic(textBox11.Text, Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox26.Text), textBox10.Text, textBox5.Text);
            // ga.checkBox1.Checked = true;
            // ga.textBox26.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            // ga.textBox25.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            // ga.textBox19.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //// ga.textBox24.ReadOnly = true;
            // ga.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
