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
    public partial class docspecial_alldisplay : Form
    {
       
        archive_special.special u = new archive_special.special();
        public docspecial_alldisplay()
        {
            InitializeComponent();
            filldatagrud();
        }
        public void filldatagrud()
        {
            ;


            dataGridView1.DataSource = u.specialarchive_hand();



        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
          
            dataGridView1.DataSource = u.findspecialarchive_hand(textBox5.Text);


         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        //    connect.Open();
        //    SqlCommand cmd = connect.CreateCommand();
        //    cmd.CommandType = CommandType.Text;

        //    cmd.CommandText = "select special_id as 'رقم الخاص' ,doc_id as 'رقم الوثيقة',no_shelf as 'رقم الرف',folder_name as 'أسم المجلد',r.administration as  '  اسم الادارة',room_id as 'رقم الغرفة',sub as 'الموضوع',cupboard_id as 'رقم الدولاب',al_asl as 'أصل',morfag'صورة' from special_Archive inner join jeha as r on s.jeha_id=r.jeha_id where archive_hand='نعم' and   special_id like ('%" + textBox5.Text + "%') or folder_name  like ('%" + textBox5.Text + "%') or administration  like ('%" + textBox5.Text + "%') or sub like ('%" + textBox5.Text + "%')or doc_id like ('%" + textBox5.Text + "%')  ";



        //    cmd.ExecuteNonQuery();


        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;


        //    connect.Close();
        }
    }
}
