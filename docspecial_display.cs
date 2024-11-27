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
    public partial class docspecial_display : Form
    {
       
        archive_special.special u = new archive_special.special();
        SqlDataAdapter da;
        //SqlCommandBuilder scb;
        DataTable dt = new DataTable();
        public docspecial_display()
        {
            InitializeComponent();
            filldatagrud();
        }
        public void filldatagrud()
        {
            dataGridView1.DataSource = u.getdocmailling();



        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            
            dataGridView1.DataSource = u.findmaillingspecialarchive_hand(textBox5.Text);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
