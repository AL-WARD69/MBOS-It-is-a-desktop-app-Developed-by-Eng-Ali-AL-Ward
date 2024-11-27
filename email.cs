using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace MBOS_Full_System
{
    public partial class email : Form
    {
        SmtpClient client;
        MailMessage mail;
        Attachment data;
        string FROM = "BMMS9090@gmail.com";
        string PASS = "bmms9090System77771111";
        settings.all_class data1 = new settings.all_class();
        public email()
        {
            InitializeComponent();
            try
            {
                client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
               // client.Credentials = new NetworkCredential(FROM, PASS);
                mail = new MailMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        void doc() {
            try
            {

                dataGridView1.DataSource = data1.doc_email();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                //  dataGridView1.Columns[2].Visible = false;
                //  dataGridView1.Columns[3].Visible = false;

                DataGridViewColumn column = dataGridView1.Columns[1];
                column.Width = 420;
                DataGridViewColumn column3 = dataGridView1.Columns[2];
                column3.Width = 90;

            }
            catch (SqlException exp) { MessageBox.Show(exp.Message); }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            DataTable dt = data1.doc2_email(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            doc_sub.Text = dt.Rows[0][1].ToString() ;
            doc_body.Text = dt.Rows[0][2].ToString();
       

        }

        private void email_Load(object sender, EventArgs e)
        {



            DataTable dt = data1.getemail();
          //  reader = c1.ExecuteReader();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                lstRecipients.Items.Add(dt.Rows[0][0].ToString());
            }
            doc();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!this.txtemail.Text.Contains('@') || !this.txtemail.Text.Contains(".com"))
            {
                MessageBox.Show("صيغة الإيميل خاطئة");

            }
            else
            {
                lstRecipients.Items.Add(txtemail.Text);
                txtemail.Clear();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                //Adding all recpeints                
                foreach (String recipent in lstRecipients.Items)
                {
                    mail.To.Add(recipent.ToString());
                }//end foreach

                mail.From = new MailAddress(FROM);
                mail.Subject = doc_sub.Text;
                mail.Body = doc_body.Text;

                client.Send(mail);
                MessageBox.Show("تمت عملية الارسال بنجاح .");
            }
            catch (Exception)
            {
                MessageBox.Show("فشل الارسال ");
            }//end try catch

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                data = new Attachment(dlg.FileName);
                mail.Attachments.Add(data);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstRecipients.Items.Remove(lstRecipients.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstRecipients.Items.Clear();
            DataTable dt = data1.getemail();
            //  reader = c1.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstRecipients.Items.Add(dt.Rows[0][0].ToString());
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstRecipients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtemail.Text = lstRecipients.SelectedItem.ToString();
        }
    }
}
