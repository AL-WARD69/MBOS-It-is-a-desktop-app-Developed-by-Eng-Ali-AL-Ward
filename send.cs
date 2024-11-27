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
    public partial class send : Form
    {
        string txtFullName, txtno, txtsend_dept_id, txtdeptname;
        mailing.add sen = new mailing.add();

        public send()
        {
            InitializeComponent();
            // textBox13.Text = administration;
           txtFullName = Program.FullName;
            txtdeptname = Program.department_name;
            //  textBox1.Text = jeha_id.ToString();
            txtno = Program.no;
            txtsend_dept_id = Program.send_dept_id;
            // this.dataGridView1.DataSource = sen.send();

            DataTable dt = sen.all_sendingmaillinguser(Convert.ToInt32( txtno), Convert.ToInt32(txtsend_dept_id));
           
            this.dataGridView1.DataSource = dt;


        }
    

        private void send_Load(object sender, EventArgs e)
        {
            //            
            DataTable dt = sen.all_sendingmaillinguser(Convert.ToInt32(txtno), Convert.ToInt32(txtsend_dept_id));

            this.dataGridView1.DataSource = dt;
        }

     

     
        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            
            DataTable dt = sen.all_sendingmaillinguser1(Convert.ToInt32(txtno), Convert.ToInt32(txtsend_dept_id), textBox5.Text);

            this.dataGridView1.DataSource = dt;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = sen.all_sendingmaillinguser1(Convert.ToInt32(txtno), Convert.ToInt32(txtsend_dept_id), textBox5.Text);

            this.dataGridView1.DataSource = dt;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

