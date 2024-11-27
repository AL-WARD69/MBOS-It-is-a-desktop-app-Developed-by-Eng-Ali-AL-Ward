using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MBOS_Full_System
{
    public partial class Header : Form
    {

       
       
        settings.all_class u = new settings.all_class();
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataTable dt = new DataTable();
        public Header()
        {
            InitializeComponent();
           
           // comboBox1.DataSource = u.get_id_header();
           // comboBox1.DisplayMember = "name";
           //comboBox1.ValueMember = "id";
        }
       // SqlConnection connect = new SqlConnection("server=.; Database=MBOS; integrated security=true");
        string imgLocation = "";
        SqlCommand cmd;
        public void filldatagrud()
        {
            dataGridView1.DataSource = data.get_headers() ;
                    }
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png filter(*.JPG)|*.jpg|ALL files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                logo.ImageLocation = imgLocation;
                flag = 1;
            }
            
        }
        void loodinc()
        {
            
           
        }
        private void Header_Load(object sender, EventArgs e)
        {
            txt_headerid.Text = u.get_id_header().Rows[0][0].ToString();
            txt_headerid.Enabled = false;
            filldatagrud();
            txt_deptname.Text = Program.department_name;
            txt_deptid.Text = Program.send_dept_id;
        }
        settings.all_class data = new settings.all_class();
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brt = new BinaryReader(streem);
            images = brt.ReadBytes((int)streem.Length);


            data.add_Header(Convert.ToInt32(txt_headerid.Text.ToString()), txt_ar_name.Text ,txt_en_name.Text , Convert.ToInt32(txt_deptid.Text.ToString()) ,images);
            //SqlConnection mycon = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            //mycon.Open();

            //SqlCommand query = new SqlCommand();
            //query.Connection = mycon;

            //query.CommandText = "insert into HeaderTbl(id_header,name_arbic,name_english,dept_id,logo)" + "values('" + txt_headerid.Text + "','" + txt_ar_name.Text + "','" + txt_en_name.Text + "','" + txt_deptid.Text.ToString() + "',@images)";
            //query.Parameters.Add(new SqlParameter("@images",images));
            //int i = query.ExecuteNonQuery();
            //if (i > 0)
            //{
                MessageBox.Show("تم أدارج وأدخال البيانات ");
                filldatagrud();

            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_headerid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_ar_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_en_name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_deptid.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_deptname.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           // pictureBox1.Image = dataGridView1.SelectedRows[0].Cells[4].Value;
            //var data=(byte[])(row.c)
            //MemoryStream ms = new MemoryStream();
            //Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[4].Value;
            //img.Save(ms);
            //pictureBox1.Image = Image.FromStream(ms);
            byte[] bytes=(byte[])
                dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(bytes);
            logo.Image = Image.FromStream(ms);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection mycon = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            //    //string ch = "";
            //    mycon.Open();
            byte[] images = null;
            // imgLocation = logo.ImageLocation;
            if (flag == 1)
            {



                Image img = (Bitmap)logo.Image;
                //  byte[] bytes =;
                //   MemoryStream ms = new MemoryStream();
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brt = new BinaryReader(streem);
                images = brt.ReadBytes((int)streem.Length);
            }
            else
            {
                byte[] bytes = (byte[])dataGridView1.CurrentRow.Cells[5].Value;


                MemoryStream ms = new MemoryStream(bytes);
                BinaryReader brt = new BinaryReader(ms);
                images = brt.ReadBytes((int)ms.Length);
            }    // object sel = comboBox1.SelectedValue;
                //  if (checkBox1.Checked)
                //  {
                //      ch = "تم الارشفة ";
                //  }
                //  else
                //  {
                //      ch = "لم تم الارشفة ";
                //  }
   
            data.update_Header(Convert.ToInt32(txt_headerid.Text.ToString()), txt_ar_name.Text, txt_en_name.Text, Convert.ToInt32(txt_deptid.Text.ToString()), images);
            //special_id,room_id,no_sequence,s,folder_name,cupboard_id,no_shelf,jeha_id
            //query.CommandText = ("update  HeaderTbl set dept_id='" + txt_deptid.Text + "',name_arbic='" + txt_ar_name.Text + "',name_english='" + txt_en_name.Text + "', logo= @images   where id_header = '" + txt_headerid.Text + "'");
            //query.Parameters.Add(new SqlParameter("@images", images));
            //// query.CommandText += "insert into specail_mailing(m_special_id)" + "values('" + textBox1.Text + "')";
            //int i = query.ExecuteNonQuery();
            //if (i > 0)
            //{
                MessageBox.Show("تم التعديل بنجاح ");
                filldatagrud();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_ar_name.Text = "";
            txt_en_name.Text = "";
            logo.Image=null;
          //  txt_deptname.t

            this.OnLoad(e);
        }
    }
}
