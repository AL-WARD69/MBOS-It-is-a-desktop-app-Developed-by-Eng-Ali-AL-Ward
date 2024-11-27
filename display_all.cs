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
    public partial class display_all : Form
    {
         string txtfullname, txtuserid, txtdeptid, txt_deptname, txtuserjob;
        //string administration, string employee_name, int jeha_id, int no, int send_dept_id, string section_name
        public display_all()
        {
            InitializeComponent();
           // textBox1.Text = administration;
            txtfullname = Program.FullName;
           // textBox3.Text = jeha_id.ToString();
            txtuserid = Program.no;
            txtdeptid = Program.send_dept_id;
            txt_deptname = Program.department_name;
            txtuserjob = Program.job;
            
            // textBox10.Text =job;)
        }
        mailing.add data = new mailing.add();
        private void display_all_Load(object sender, EventArgs e)
        {
            



            DataTable dt = data.all_recievemailling(Convert.ToInt32(txtdeptid), Convert.ToInt32(txtuserid));
                       this.dataGridView1.DataSource = dt;

           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            add_mailing ma = new add_mailing();

            ma.mailing_id.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ma.txt_p_id.Visible = true;
          //  ma.mdoc_id.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ma.txt_docid.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
          //  ma.textBox6.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ma.txtdoc_su.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ma.textBox28.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ma.m_receiver_name3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //ma.textbox10.text = datagridview1.currentrow.cells[1].value.tostring();
            ma.txtdoc_su.Visible= true;
            ma.textBox28.Visible = true;
            ma.label24.Visible = true;

            ma.label25.Visible = true;
          //  ma.dataGridView1.Visible = false;
            //ma.mailing_type3.selecteditem = datagridview1.currentrow.cells[3].value.tostring();
            // ma.textbox16.text = datagridview1.currentrow.cells[3].value.tostring();
            ma.m_receiver_name3.ReadOnly = true;
            //ma.textbox9.readonly = true;
            //ma.mdoc_id.enabled= false;
         //   ma.MdiParent = F;
            ma.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            if (e.ColumnIndex == 0)
            {
                fol ff = new fol();

                // ddd.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ff.textBox1.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                ff.textBox30.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // ddd.textBox2.Enabled = false;
                //  dd.richTextBox1.Enabled = false;

                ff.MdiParent =this;
                ff.Show();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = data.all_recievemailling1(Convert.ToInt32(txtdeptid), Convert.ToInt32(txtuserid),textBox11.Text);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
