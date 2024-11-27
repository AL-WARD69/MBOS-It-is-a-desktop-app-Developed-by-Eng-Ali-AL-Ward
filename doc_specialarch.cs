using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MBOS_Full_System
{ 
    public partial class doc_specialarch : Form
    {
        public static string ar;
       archive_special.special u = new archive_special.special();
        SqlDataAdapter da;
        // SqlCommandBuilder scb;
        DataTable dt = new DataTable();
        public doc_specialarch()
        //int jeha_id, int department_id, int no, string adminstration, string department_name, string employee_name)
        {
            InitializeComponent();


        }

        public void filldatagrud()
        {

            
 dataGridView1.DataSource = u.getdocmailling() ;



        }
        private void button1_Click(object sender, EventArgs e)
        {


           
            string ch = "";
            string ch1 = "";
            string ch2 = "";
            string ch3 = "";
           // mycon.Open();
            // object sel = comboBox1.SelectedValue;
            //if (checkBox1.Checked)
            //{
            //    ch = " نعم  ";
            //}
            //else
            //{
            //    ch = "لا  ";
            //}

            if (archivetype.Checked)
            {
                ch1 = " نعم ";
            }
            else
            {
                ch1 = "لا ";
            }

            //if (checkBox3.Checked)
            //{
            //    ch2 = " نعم ";
            //}
            //else
            //{
            //    ch2 = "لا  ";
            //}
            if (doctype.Checked)
            {
                ch3 = "  نعم ";
                ch2 = "لا  ";
            }
            else
            {
                ch3 = "  لا  ";
                ch2 = " نعم ";
            }
          
            u.add_data_special_Archive(Convert.ToInt32(sp_idfolder.SelectedValue.ToString()), Convert.ToInt32(no_shlf.Text),
                doc_subject.Text ,foldernames.Text, Convert.ToInt32(Program.send_dept_id.ToString()),
                Convert.ToInt32(room_id.Text), Convert.ToInt32(no_ra.Text),ch1,ch2,
                Convert.ToInt32(doc_id.GetItemText(doc_id.SelectedItem)),ch3);
            // query.CommandText = "insert into special_Archive(special_id)" + "values('" + comboBox3.SelectedValue.ToString() + "')";
            u.add_specail_mailing(Convert.ToInt32(sp_idfolder.SelectedValue.ToString()),Convert.ToInt32(mai_id.Text.ToString()));
                MessageBox.Show("تم أدارج وأدخال البيانات ");
                filldatagrud();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Form1_Load(sender,e);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            u.updatedata_special_Archive(Convert.ToInt32(doc_id.SelectedValue),Convert.ToInt32(sp_idfolder.Text), Convert.ToInt32(no_ra.Text), Convert.ToInt32(room_id.Text), Convert.ToInt32(no_shlf.Text));
            //special_id,room_id,no_sequence,s,folder_name,cupboard_id,no_shelf,jeha_id
            //query.CommandText = ("update  data_special_Archive set room_id='" + room_id.Text + "',cupboard_id='" + no_shlf.Text + "',no_shelf='" + no_ra.Text + "'where special_id = '" + sp_idfolder.Text + "' and doc_id="+doc_id.GetItemText(doc_id.SelectedValue)+" ");
            //// query.CommandText += "insert into specail_mailing(m_special_id)" + "values('" + textBox1.Text + "')";
            //int i = query.ExecuteNonQuery();
            //if (i > 0)
            //{
                MessageBox.Show("تم التعديل بنجاح ");
                filldatagrud();
            //}
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = u.getdocmailling();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            docspecial_alldisplay fm = new docspecial_alldisplay();
            fm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            docspecial_display fm = new docspecial_display();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // MessageBox.Show("      "+e.RowIndex);
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

              
               
              
                DialogResult res = MessageBox.Show("هل تريد فعلا  حذف  هذا  السجل ؟  ", "Confirmation", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    u.delete_data_special_Archive(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()), Convert.ToInt32(doc_id.SelectedValue.ToString()));
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }

            }

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {


                u.send_to_general_special_Archive(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()), Convert.ToInt32(doc_id.SelectedValue.ToString()));
                // query.CommandText = "insert into special_Archive(send_to_general)" + " values('ارشفت')";
               
                MessageBox.Show("تم أرشفة ");
                //general_archive.arch_puplic ga = new general_archive.arch_puplic(textBox5.Text, textBox11.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox12.Text), textBox10.Text);
                //ga.Show();
                // mailing.fol ff = new mailing.fol();

                dataGridView1.DataSource = u.getdocmailling();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.special_ArchiveTableAdapter.Fill(this.mailingDataSet.special_Archive);
            //lood();

            txt_deptid.Text = Program.send_dept_id;
            //textBox5.Text = adminstration;
            deptname.Text = Program.department_name;
            // textBox11.Text = FullName;
            // textBox12.Text = send_dept_id.ToString();
            // textBox13.Text = no.ToString();
            filldatagrud();
            sp_idfolder.DataSource = u.get_folderspecial(Convert.ToInt32(Program.send_dept_id));
            sp_idfolder.DisplayMember = "folder_name";
            sp_idfolder.ValueMember = "special_id";
            loodcupboard();
            loodno_shelf();
            looddoc_id();
            //loodinc();
            loodroom();
        
           // loodno_speci();
    
        }
        void loodroom()
        {
            room_id.DataSource = u.specialroom();
        }
    
     
        void looddoc_id()
        {
            //SqlConnection conn = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            //conn.Open();
            //string Select_unit = "select * from documents where doc_id not in(select doc_id from data_special_Archive)";
            //SqlCommand unit = new SqlCommand(Select_unit, conn);
            //SqlDataReader dr = unit.ExecuteReader();
            //while (dr.Read())
            //{

            //    string item = dr["doc_id"].ToString();
            //    if (!doc_id.Items.Contains(item))
            //        doc_id.Items.Add(item);
            //}
            //dr.Close();
            //conn.Close();
            DataTable dt = u.get_deptdoc(Convert.ToInt32(Program.send_dept_id));
            doc_id.DataSource = dt;
            doc_id.ValueMember = "doc_id";
            doc_id.DisplayMember = "doc_id";
            doc_id.SelectedIndex = -1;
        }
        //void loodinc()
        //{
        //    connect.Open();
        //    string Select_accout = "Select max(special_id)  as max from special_Archive";
        //    SqlCommand acc = new SqlCommand(Select_accout, connect);
        //    SqlDataReader dr = acc.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        if (dr[0].ToString() != "")
        //        {
        //            long item = Convert.ToInt64(dr[0].ToString());
        //            item += 1;

        //            textBox1.Text = item.ToString();
        //            textBox1.Enabled = false;
        //        }
        //        else
        //        {
        //            textBox1.Text = Convert.ToString(" 1");
        //            textBox1.Enabled = false;

        //        }
        //        dr.Close();
        //        connect.Close();
        //    }
        //}

        //private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        //{

            //SqlConnection conn = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select doc_subject from documents where doc_subject='" + comboBox4.SelectedItem.ToString() + "'";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    textBox3.Text = dr["doc_subject"].ToString();
            //}
            //conn.Close();
        //}

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //SqlConnection conn = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select folder_name from special_Archive where folder_name='" + comboBox5.SelectedItem.ToString() + "'";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    textBox2.Text = dr["folder_name"].ToString();
            //}
            //conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var path2 = @"C:\Users\pc\Desktop\projectSS\3lastspecial\specialArchive\" + textBox5.Text;
            //Directory.CreateDirectory(path2 + "\\" + textBox4.Text);
            //MessageBox.Show("لقد تم اضافة مجلد فرعي   ");
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (archivetype.Checked)
            {
               // checkBox1.Checked = false;
                //textBox6.Visible = true;
                label3.Visible = true;
                mai_id.Visible = false;

                //textBox18.Visible = false;
                //textBox3.Visible = true;

            }
            else
            {
                // textBox6.Visible = false;
                label3.Visible = false;
                // textBox3.Visible = false;
            }

         
        }
        //void lood(string a)
        //{

        //    SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
        //    con.Open();
        //    //  string correctFileName = System.IO.Path.GetFileName(f.FileName);
        //    SqlCommand cmd = new SqlCommand("Select doc_follower_picture_name ,doc_follower_picture_path from follower inner join documents on documents.doc_id=follower.doc_id  inner join mailing on mailing.mdoc_id=documents.doc_id where mailing.mailing_id= " + int.Parse(a), con);
        //    SqlDataReader ss = cmd.ExecuteReader();
        //    //File  file = null;
        //    Image file = null;
        //    if (ss.Read())
        //    {
        //        filename = ss["doc_follower_picture_path"].ToString();
        //        file = Image.FromFile(filename);
        //        MessageBox.Show(ss["doc_follower_picture_path"].ToString());
        //        pictureBox1.Image = file;

        //        MessageBox.Show(" write");

        //    }



           // con.Close();
            //string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            //System.IO.File.Copy(f.FileName, paths + "\\images\\" + correctFileName);
            //file = Image.FromFile(f.FileName);
            //  pictureBox1.Image = file;
   
        string filename;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            mai_id.Text = add_mailing.aa;

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
                //fol ff = new fol();

                //// ddd.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //ff.textBox1.Text = textBox9.Text;
                //ff.textBox30.Text = textBox7.Text;

                //// ddd.textBox2.Enabled = false;
                ////  dd.richTextBox1.Enabled = false;


                //ff.Show();


            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox14.Text = selectedRow.Cells[3].Value.ToString();
            ar = textBox14.Text;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("لوسمحت ادخال رقم");
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loodno_shelf()
        {
            no_ra.DataSource = u.specialno_shelf();
        }
             void loodcupboard()
        {
            no_shlf.DataSource = u.specialno_specialcupboard_idshelf();
        }
        

             private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
             {
                 sp_idfolder.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                 //textBox18.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                 no_shlf.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                 room_id.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                 no_ra.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                 //textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                 //comboBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                 //textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();;
             }

             private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
             {
            foldernames.Text = sp_idfolder.Text;
             }


        private void doc_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { doc_subject.Text = u.get_docsubject(Convert.ToInt32(doc_id.GetItemText(doc_id.SelectedValue))).Rows[0][1].ToString();
            } catch (Exception ss) { } }
    }

       
    }


