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
    public partial class search : Form
    {
       
        DataTable dt = new DataTable();
        general_archive.allclass prd = new general_archive.allclass();
        public search()
        {
            InitializeComponent();
            filldatagrud();
        }

        public void filldatagrud()
        {
            dataGridView2.DataSource = prd.document_general_archive2();



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = prd.search_general_archive(textBox1.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
