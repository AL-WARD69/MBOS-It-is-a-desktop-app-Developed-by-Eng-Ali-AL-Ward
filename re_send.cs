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
    public partial class re_send : Form
    {
        String txtuserid, txtdeptid;
        public re_send()
        {
            InitializeComponent();
            // textBox1.Text = jeha_id.ToString();
            txtdeptid = Program.send_dept_id;
            txtuserid = Program.no;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        mailing.add data = new mailing.add();
        private void re_send_Load(object sender, EventArgs e)
        {


            DataTable dt=data.all_recievemaillinguser(Convert.ToInt32(txtuserid), Convert.ToInt32(txtdeptid));

            this.dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

            DataTable dt = data.all_recievemaillinguser1(Convert.ToInt32(txtuserid), Convert.ToInt32(txtdeptid),txtsearch.Text);

            this.dataGridView1.DataSource = dt;

         


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
