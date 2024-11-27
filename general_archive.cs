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
    public partial class general_archives : Form
    {
        public general_archives()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            con.Open();

            SqlDataAdapter DT = new SqlDataAdapter(@"select    d.id ,u.userid ,u.FullName ,d.name  FROM  users u inner join departments d
                          on u.department_id=d.id   where FullName= '" + Int32.Parse(comboBox1.SelectedValue.ToString()) + "'", con);
            // MessageBox.Show(comboBox1.SelectedValue.ToString());
            // textBox2.Text =Int32.Parse(comboBox1.SelectedValue.ToString();
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            DT.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                // textBox2.Text = dr["employee_name"].ToString();
                textBox2.Text = dr["name"].ToString();
                textBox3.Text = dr["id"].ToString();
                textBox6.Text = dr["userid"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
