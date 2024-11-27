using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MBOS_Full_System.new_m
{
    public partial class @new : Form
    {

        SqlConnection CON = new SqlConnection(@"server=.;Database=Archive1;Integrated Security=true");
         SqlDataAdapter DA;
         DataTable DT = new DataTable();

        add_m add = new add_m();
        public @new()
        {
            InitializeComponent();
            m_no.DataSource = add.get_emp();
            m_no.DisplayMember = "employee_name";
            m_no.ValueMember = "userid";

            //send_jeha_id.DataSource = add.get_jeha();
            //send_jeha_id.DisplayMember = "administration";
            //send_jeha_id.ValueMember = "jeha_id";

            //receiving_jeha_id.DataSource = add.get_jeha();
            //receiving_jeha_id.DisplayMember = "administration";
            //receiving_jeha_id.ValueMember = "jeha_id";

            //receiving_jeha_id.DataSource = add.get_type();
            //receiving_jeha_id.DisplayMember = "type_name";
            //receiving_jeha_id.ValueMember = "type_id";

           // this.dataGridView1.DataSource = add.display();
           // filldatagrud();

        }
        //public void filldatagrud()
        //{
        //    DT.Clear();
        //    DA = new SqlDataAdapter("SELECT * FROM MAILING", CON);
        //    DA.Fill(DT);

        //    dataGridView1.DataSource = DT;
            
        
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
            add.add_mailing(Convert.ToInt32(mailing_id.Text), Convert.ToInt32(m_no.SelectedValue), Convert.ToInt32(send_jeha_id.SelectedValue), Convert.ToInt32(receiving_jeha_id.SelectedValue), mailing_type.GetItemText(mailing_type.SelectedItem),mailing_state.GetItemText(mailing_state.SelectedItem) , note.Text, m_receiver_name.Text);
            //add.add_doc(Convert.ToInt32(doc_id.Text), secure_doc.GetItemText(secure_doc.SelectedItem), doc_subject.Text, Convert.ToInt32(doc_type_id.SelectedValue)); 
           
            MessageBox.Show("done", "kkk", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0&&e.RowIndex>0)
            {
                DialogResult res = MessageBox.Show("Do you want to delete this record?","Confirmation",MessageBoxButtons.OKCancel);
                if(res==DialogResult.OK)
                {

                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                
                }
            
            
            
            }
            //if (e.ColumnIndex == 3 && e.RowIndex > 0)
            //{

            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    textBox11.Text = row.Cells[0].Value.ToString();
            //    textBox5.Text = row.Cells[1].Value.ToString();
            //    comboBox1.SelectedText = row.Cells[1].Value.ToString();

            //    //DialogResult res = MessageBox.Show("Do you want to update this record?", "Confirmation", MessageBoxButtons.OKCancel);
            //    //if (res == DialogResult.OK)
            //    //{

            //    //    dataGridView1.Rows.RemoveAt(e.RowIndex);

            //    //}



            //}
        
        }

        private void @new_Load(object sender, EventArgs e)
        {

        }
    }
}
