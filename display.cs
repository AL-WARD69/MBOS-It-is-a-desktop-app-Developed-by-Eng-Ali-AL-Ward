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
    public partial class display : Form
    {//string FullName, int no, int send_dept_id, string department_name, string job
        mailing.add dis = new mailing.add();
        public display()
        {
            InitializeComponent();
            //this.dataGridView1.DataSource =dis.display();
            //  textBox1.Text = jeha_id.ToString();
         //   textBox13.Text = Program.department_name;
           // section_namee.Text = Program.department_name;
         

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void display_Load(object sender, EventArgs e)
        {
         //   employee_namee.Text = Program.FullName;

            txt_userid.Text = Program.no;
            //   textBox17.Text =Program.send_dept_id;
            DataTable dt= dis.send(Convert.ToInt32(Program.send_dept_id));
            this.dataGridView1.DataSource = dt;
            //DataTable dt = dis.displaymailling(Convert.ToInt32(txt_userid.Text.ToString()));
            
            //this.dataGridView1.DataSource = dt;
        }

       




      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

              int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            if (e.ColumnIndex == 0)
            {
                fol ff = new fol();

                // ddd.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ff.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ff.textBox30.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                // ddd.textBox2.Enabled = false;
                //  dd.richTextBox1.Enabled = false;

                // MessageBox.Show(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                ff.MdiParent = this;
                ff.Show();

            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void section_namee_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            ////View_speca aa = new View_speca();
            //ff aa = new ff();
            ////name crystal report
            //Cryst_mailing_sup ff = new Cryst_mailing_sup();
            //ff.SetParameterValue("@d3", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            ////ff.SetDataSource(ds.Tables["student"]);
            //aa.crystalReportViewer1.ReportSource = ff;

            //aa.crystalReportViewer1.Refresh();
            //aa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //               SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;

        //    cmd.CommandText = (@"select d.doc_id, a.mailing_id as 'رقم المراسلة',sends.name as 'القسم المرسل',e.FullName as 'الموظف المرسل',rec.name as 'القسم المستقبل',s.FullName as 'الموظف المستقبل',d.doc_subject  as 'موضوع الوثيفة',a.send as 'الارسال',send_date as 'تاريخ الارسال',m_receiver_name as 'اسم الموصل' from   mailing a     inner join departments sends on (sends.id=a.send_dept_id) inner join departments rec on (rec.id=a.receiving_dept_id) inner join users s on (s.userid=a.Send_User_id) inner join users e on (a.Receiving_User_id=e.userid) 
        //      INNER JOIN  documents d ON d.doc_id = a.doc_id  where  d.doc_subject  like ('%" + txtdocsub.Text + "%') and   d.doc_id  like ('%" + txtdocid.Text + "%')and  e.FullName like ('%" + txtemprecive.Text + "%')and  d.doc_user_id like ('%" + txtmanagerecive.Text + "%')  and  s.FullName like ('%" + txtempsend.Text + "%')and  send_date like ('%" + txtsenddate.Text + "%')     ");//or no_shelf  like ('%" + textBox5.Text + "%') or no_sequence like ('%" + textBox5.Text + "%')  ";




        //    cmd.ExecuteNonQuery();


        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;


        //    con.Close();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            //View_speca aa = new View_speca();
            MessageBox.Show("" + int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            ff aa = new ff();
            //name crystal report
            mailing.Crystal_mailin_sub ff = new mailing.Crystal_mailin_sub();
            ff.SetParameterValue("@d3", int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            //   ff.SetDataSource(ds.Tables["student"]);
          //  ff.Parameter_d3=

           aa.crystalReportViewer1.ReportSource = ff;

            aa.crystalReportViewer1.Refresh();
            aa.MdiParent = this;
            aa.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ff aa = new ff();
            //name crystal report
           // all_student ff = new all_student();


            mailing.Crystal_malin_all ff = new mailing.Crystal_malin_all();
            //ff.SetDataSource(ds.Tables["student"]);
            aa.crystalReportViewer1.ReportSource = ff;
            aa.crystalReportViewer1.Refresh();
            aa.MdiParent = this;
            aa.Show();
        }

        private void txtempsend_TextChanged(object sender, EventArgs e)
        { DataTable dt= dis.searchmailling(Convert.ToInt32(Program.no), txtempsend.Text);
            dataGridView1.DataSource = dt;
                
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        DataTable dt = dis.searchmailling(Convert.ToInt32( Program.no), txtempsend.Text);
            dataGridView1.DataSource = dt;
        }
    }

} 

