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
    public partial class fol : Form
    {
        public fol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");

            SqlDataAdapter sda = new SqlDataAdapter("select * from follower where doc_follower_id ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            pictureBox1.Image = Image.FromFile(paths + dt.Rows[0]["doc_follower_picture_path"].ToString());
        }

        private void fol_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT     follower.doc_follower_id,    follower.doc_follower_picture_path, documents.doc_subject, documents.doc_id,follower.mail_id
FROM            documents INNER JOIN
                         follower ON documents.doc_id = follower.doc_id  where  documents.doc_id='" + Convert.ToInt32(textBox1.Text) + "' and follower.mail_id= '" + Convert.ToInt32(textBox30.Text) + "'", con);
            // INNER JOIN follower f ON d.doc_id = f.doc_id ,f.doc_follower_picture_path as'll'

            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox2.Text = selectedRow.Cells[0].Value.ToString();
            //textBox20.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
