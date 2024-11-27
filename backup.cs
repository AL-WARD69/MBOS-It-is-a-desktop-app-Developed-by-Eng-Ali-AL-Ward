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
    public partial class backup : Form
    {
        SqlConnection connect = new SqlConnection("server=.; Database=sasa; integrated security=true");
        //SqlConnection con = new SqlConnection("server=.; Database=master; integrated security=true");
        SqlCommand cmd;
        public backup()
        {
            InitializeComponent();
        }

        private void backup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup file (*.bak)|*.bak";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                cmd = new SqlCommand("Backup Database sasa to disk ='" + sf.FileName + "'", connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //op.Filter = "Backup file (*.bak)|*.bak";
            //if (op.ShowDialog() == DialogResult.OK)
            //{
            //    cmd = new SqlCommand("Restore Database sasa from disk  ='" + op.FileName + "'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();

            //    con.Close();
            //    MessageBox.Show("Restore succded", "restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
