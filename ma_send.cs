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
    public partial class ma_send : Form
    {
        public static string aa;//
        string txtfullname, txtdeptname, txtuserid, txtdeptid, txtmaillingid;
        mailing.add data = new mailing.add();
        public ma_send()
        {
            InitializeComponent();
            //t textBox13.Text = administration;
            txtfullname =Program.FullName;
            txtdeptname = Program.department_name;
            //  textBox1.Text = jeha_id.ToString();
            txtuserid= Program.no;
            txtdeptid = Program.send_dept_id;

            
            this.dataGridView1.DataSource = data.displaymailling22(Convert.ToInt32(txtdeptid));

        }

        private void ma_send_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            if (e.ColumnIndex == 0)
            {

                txtmaillingid = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                DialogResult del = MessageBox.Show("هل تريد ارشفة هذه الوثيقة ", "ارشفة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (del == DialogResult.Yes)
                {
                  

                    DataTable dt1 = data.maillingarchive(Convert.ToInt32(txtmaillingid));
                        if (!(dt1.Rows.Count>0))
                        {

                     data.updatemaillingarchive( Convert.ToInt32(txtmaillingid) );
                     bool ch = true;
                 
                    //archive_special.Form1 v = new archive_special.Form1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox14.Text), textBox13.Text, textBox3.Text, textBox15.Text);
                
                        }

                        else
                        {
                            MessageBox.Show("هذه الوثيقة تمت ارشفتها مسبقا");
                        }
                    // MessageBox.Show displaydata();
                    // clear();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            
          DataTable dt=  data.searchmailling22(Convert.ToInt32(txtdeptid), txtsearch.Text);

            this.dataGridView1.DataSource = dt;

            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
