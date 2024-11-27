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
    public partial class add_mailing : Form
    {
        Image file;
       mailing.add add_m = new mailing.add();
        settings.all_class dal = new settings.all_class();
        public static string aa;
        string txt_reciveuserid, txtuserid, txt_deptid;
        Image image; string path;
        int x = -1; int y = -1;
        public DataTable get_doc()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_doc", null);
            DAL.Close();
            return dt;

        }

        public DataTable get_emp()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_emp", null);
            DAL.Close();
            return dt;

        }

    

        public DataTable get_section()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_section", null);
            DAL.Close();
            return dt;
        }

        string ch = "";
        //string FullName, int no, int send_dept_id, string department_name, string job
        public add_mailing()
        {
            InitializeComponent();




        }
        string p_id = null;
        public void generator()
        { mailing_id.Text = add_m.getmaillingid().Rows[0][0].ToString(); }

        settings.all_class data = new settings.all_class();
        public void generator2()
        {
            txt_p_id.Text= data.getsignaturesid().Rows[0][0].ToString();
        }

        public void generator3()
        {
            txt_docid.Text = data.getdocumentid().Rows[0][0].ToString();
        }




        private void add_mailing_Load(object sender, EventArgs e)
        {


            try {
                //  textBox13.Text = administration;
                //textBox12.Text = textBox13.Text;
                txtdeptname.Text = Program.department_name;
                txt_fullname.Text = Program.FullName;
                // textBox4.Text = textBox15.Text;

                // textBox12.Text = jeha_id.ToString();
                //textBox11.Text = textBox12.Text;

                txtuserid = Program.no;
                // textBox4.Text = secure_doc.ToString();


                txtsenddept.Text = Program.send_dept_id;
                txtjob.Text = Program.job;

                m_no.DataSource = get_emp();
                m_no.DisplayMember = "FullName";
                m_no.ValueMember = "userid";


                // this.Location = new Point(1, 110);
                generator();
                generator2();
                generator3();



              


                DataTable dt = add_m.getuser_senddocument(Convert.ToInt32(txt_docid.Text), Convert.ToInt32(txtuserid), Convert.ToInt32(txtsenddept.Text));

                txtuserjob.Text = dt.Rows[0][4].ToString();
                txt_udeptnae.Text = dt.Rows[0][2].ToString();
                txt_userfullname.Text = dt.Rows[0][3].ToString();
            }
            catch (Exception r) { }


            
        }

      
        //public static void autoIncrement(string sqlquery, Control textbox)
        //{
        //    SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sqlquery, con);
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        string value = dr[0].ToString();
        //        if (value == "")
        //        {
        //            textbox.Text = "1";
        //        }
        //        else
        //        {
        //            int x = 1 + Convert.ToInt32(dr[0].ToString());
        //            textbox.Text = x.ToString();
        //        }

        //    }

        //}


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string save = "false";
       // bool receive_status = false;

        private void button10_Click(object sender, EventArgs e)
        {
           
                     bool archive = false;
        
           
                add_m.add_mailing(Convert.ToInt32(mailing_id.Text),
                    Convert.ToInt32(txt_docid.Text),
                     mailing_type3.GetItemText(mailing_type3.SelectedItem),
                      m_receiver_name3.Text,
                      DateTime.Parse(dtp_maillingdate.Text),
                       Convert.ToInt32(txt_reciveuserid),
                        Convert.ToInt32(txtuserid),
                        sendsigntute.Text,
                         Convert.ToInt32(txt_deptid),
                           Convert.ToInt32(txtsenddept.Text),
                            show,
                             archive,
                             writingnote.Text,
                            // receive_status,
                       Convert.ToInt32(txt_piror.Text),
                         save);//, sendto.Checked// , Convert.ToInt32(textBox17.Text)
            DataTable datase = add_m.getsenddocumentinsignature(Convert.ToInt32(txt_docid.Text), Convert.ToInt32(txtuserid), Convert.ToInt32(txtsenddept.Text), Convert.ToInt32(txt_reciveuserid), Convert.ToInt32(txt_deptid));
            for (int j = 0; j < datase.Rows.Count; j++) {
               DataTable mt = add_m.getmaillingid();
                add_m.add_mailing(Convert.ToInt32(mt.Rows[0][0].ToString()),
               Convert.ToInt32(txt_docid.Text),
                mailing_type3.GetItemText(mailing_type3.SelectedItem),
                 m_receiver_name3.Text,
                 DateTime.Parse(dtp_maillingdate.Text),
                  Convert.ToInt32(datase.Rows[j][4].ToString()),
                   Convert.ToInt32(datase.Rows[j][2].ToString()),
                   sendsigntute.Text,
                    Convert.ToInt32(datase.Rows[j][5].ToString()),
                      Convert.ToInt32(datase.Rows[j][3].ToString()),
                       show,
                        archive,
                        writingnote.Text,
                  // receive_status,
                  Convert.ToInt32(txt_piror.Text),
                    save);

            }
            if (data_attach.Rows.Count > 0)
            {
                for (int i = 0; i < data_attach.Rows.Count - 1; i++)
                    add_m.add_attachmentdocument(data_attach.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(data_attach.Rows[i].Cells[0].Value.ToString()), data_attach.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(mailing_id.Text.ToString()),Convert.ToInt32(txtuserid));

            }


            MessageBox.Show("حفظ", "تمت العملية بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_p_id.Text = "";
                generator2();
                mailing_id.Text = "";
                generator();

                txt_udeptnae.Clear();
                txt_userfullname.Clear();
                m_no.Visible = false;
              //  txt_jobuser.Visible = false;
                txt_udeptnae.Visible = false;

                  }
        string sends = "true";
        bool show = false;
        private void no_Click(object sender, EventArgs e)
        {
          try
            {

                bool archive = true;

                                     //تم التعديل على اسم text

                DialogResult del = MessageBox.Show("هل تريد ايضا ارشفة هذه المراسلة ", "ارشفة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (del == DialogResult.Yes)
                {

                    DataTable datase = add_m.getsenddocumentinsignature(Convert.ToInt32(txt_docid.Text), Convert.ToInt32(txtuserid), Convert.ToInt32(txtsenddept.Text), Convert.ToInt32(txt_reciveuserid), Convert.ToInt32(txt_deptid));


                    if (datase.Rows.Count > 0)
                    {

                        //query.CommandText = ("update signatures set state='true' where data_id='" + Convert.ToInt32(textBox6.Text) + "'and recieve_id='" + Convert.ToInt32(textBox3.Text) + "'  and receiving_dept_id ='" + Convert.ToInt32(textBox4.Text) + "' and Receiving_no='" + Convert.ToInt32(textBox14.Text) + "'");
                        // int i1 = query.ExecuteNonQuery();
                        //if (i1 > 0)
                        //{
                        //    MessageBox.Show("تم أدارج وأدخال البيانات ");
                        //    //dataGridView1.Rows.Clear();
                        //}
                        // SqlCommand query = new SqlCommand();

                        // bool archive = true;

                        add_m.add_mailing(Convert.ToInt32(mailing_id.Text),
                         Convert.ToInt32(txt_docid.Text),
                          mailing_type3.GetItemText(mailing_type3.SelectedItem),
                           m_receiver_name3.Text,
                           DateTime.Parse(dtp_maillingdate.Text),
                            Convert.ToInt32(txt_reciveuserid),
                             Convert.ToInt32(txtuserid),
                             sendsigntute.Text,
                              Convert.ToInt32(txt_deptid),
                                Convert.ToInt32(txtsenddept.Text),
                                 show,
                                  archive,
                                  writingnote.Text,
                            //receive_status,
                            Convert.ToInt32(txt_piror.Text),
                              sends);
                        //تعديييييييييل جديد//ناقص رقم المراسلة
                        //+ "','" + Convert.ToInt32(mailing_id.Text) 
                        //,mail_id

                        if (data_attach.Rows.Count > 0)
                        {
                            for (int i = 0; i < data_attach.Rows.Count - 1; i++)
                                add_m.add_attachmentdocument(data_attach.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(data_attach.Rows[i].Cells[0].Value.ToString()), data_attach.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(mailing_id.Text.ToString()), Convert.ToInt32(txtuserid));

                        }
                        //SqlCommand cmd = new SqlCommand("insert into attachments (id ,attachment_path,doc_id,file_name,mail_id) values((select isnull(MAX(id),0) + 1 from attachments ) ,'\\attachments\\" + correctFileName + "','" + Convert.ToInt32(txt_docid.Text) + "','" + correctFileName + "','" + Convert.ToInt32(mailing_id.Text) + "')", con);
                        //cmd.ExecuteNonQuery();

                        aa = mailing_id.Text;
                        ch = "غير متابع ";
                        Form1 ar = new Form1();
                        //archive_special.Form1 v = new archive_special.Form1();//
                        //Form3 f3 = new Form3();
                        ar.Show();



                    }
                    else
                    {
                        // DataTable datase = add_m.getsenddocumentinsignature(Convert.ToInt32(txt_docid.Text), Convert.ToInt32(txtuserid), Convert.ToInt32(txtsenddept.Text), Convert.ToInt32(txt_reciveuserid), Convert.ToInt32(txt_deptid));

                        archive = false;

                        add_m.add_mailing(Convert.ToInt32(mailing_id.Text),
                  Convert.ToInt32(txt_docid.Text),
                   mailing_type3.GetItemText(mailing_type3.SelectedItem),
                    m_receiver_name3.Text,
                    DateTime.Parse(dtp_maillingdate.Text),
                     Convert.ToInt32(txt_reciveuserid),
                      Convert.ToInt32(txtuserid),
                      sendsigntute.Text,
                       Convert.ToInt32(txt_deptid),
                         Convert.ToInt32(txtsenddept.Text),
                          show,
                           archive,
                           writingnote.Text,
                     //receive_status,
                     Convert.ToInt32(txt_piror.Text),
                       sends);
                        //  add_m.add_mailing(Convert.ToInt32(mailing_id.Text), Convert.ToInt32(textBox21.Text), Convert.ToInt32(textBox3.Text), mailing_type3.GetItemText(mailing_type3.SelectedItem), m_receiver_name3.Text, Convert.ToInt32(textBox12.Text), DateTime.Parse(textBox10.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox14.Text), sends, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox17.Text), show, archive, Convert.ToInt32(textBox6.Text));//, sendto.Checked// , Convert.ToInt32(textBox17.Text)
                        //  string correctFileName = System.IO.Path.GetFileName(f.FileName);

                        //تعديييييييييل جديد//ناقص رقم المراسلة
                        //+ "','" + Convert.ToInt32(mailing_id.Text) 
                        //,mail_id

                        if (data_attach.Rows.Count > 0)
                        {
                            for (int i = 0; i < data_attach.Rows.Count - 1; i++)
                                add_m.add_attachmentdocument(data_attach.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(data_attach.Rows[i].Cells[0].Value.ToString()), data_attach.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(mailing_id.Text.ToString()), Convert.ToInt32(txtuserid));

                        }
                        //  this.Show();
                    }



                    MessageBox.Show("ارسال", "تم الارسال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_p_id.Text = "";
                    generator2();
                    mailing_id.Text = "";
                    generator();
                    //  textBox11.Text = "";
                    // txt_jobuser.Clear();
                    txt_udeptnae.Clear();
                    txt_userfullname.Clear();
                    m_no.Visible = false;

                }


                else
                {


                    archive = false;

                    add_m.add_mailing(Convert.ToInt32(mailing_id.Text),
              Convert.ToInt32(txt_docid.Text),
               mailing_type3.GetItemText(mailing_type3.SelectedItem),
                m_receiver_name3.Text,
                DateTime.Parse(dtp_maillingdate.Text),
                 Convert.ToInt32(txt_reciveuserid),
                  Convert.ToInt32(txtuserid),
                  sendsigntute.Text,
                   Convert.ToInt32(txt_deptid),
                     Convert.ToInt32(txtsenddept.Text),
                      show,
                       archive,
                       writingnote.Text,
                 //receive_status,
                 Convert.ToInt32(txt_piror.Text),
                   sends);
                    //  add_m.add_mailing(Convert.ToInt32(mailing_id.Text), Convert.ToInt32(textBox21.Text), Convert.ToInt32(textBox3.Text), mailing_type3.GetItemText(mailing_type3.SelectedItem), m_receiver_name3.Text, Convert.ToInt32(textBox12.Text), DateTime.Parse(textBox10.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox14.Text), sends, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox17.Text), show, archive, Convert.ToInt32(textBox6.Text));//, sendto.Checked// , Convert.ToInt32(textBox17.Text)
                    //  string correctFileName = System.IO.Path.GetFileName(f.FileName);

                    //تعديييييييييل جديد//ناقص رقم المراسلة
                    //+ "','" + Convert.ToInt32(mailing_id.Text) 
                    //,mail_id

                    if (data_attach.Rows.Count > 0)
                    {
                        for (int i = 0; i < data_attach.Rows.Count - 1; i++)
                            add_m.add_attachmentdocument(data_attach.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(data_attach.Rows[i].Cells[0].Value.ToString()), data_attach.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(mailing_id.Text.ToString()), Convert.ToInt32(txtuserid));

                    }


                    MessageBox.Show("ارسال", "تم الارسال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_p_id.Text = "";
                    generator2();
                    mailing_id.Text = "";
                    generator();
                    // textBox11.Text = "";
                    // textBox19.Clear();
                    txt_udeptnae.Clear();
                    txt_userfullname.Clear();
                    m_no.Visible = false;

                    // textBox21.Text = "";
                    // generator3();

                    //  mdoc_id.Items.Clear(); 
                    // re_send v = new re_send();
                    //Form3 f3 = new Form3();
                    // v.Show();
                }
            }
            catch (Exception ee){MessageBox.Show(ee.Message);}
                
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m_no.Visible = true;
         //   textBox19.Visible = true;
            txt_udeptnae.Visible = true;
            txt_userfullname.Visible = false;
            txt_udeptnae.Text = "";
            txtuserjob.Text = "";
            //listBox1.Items.Clear();
            //listBox2.Items.Clear();
            //listBox3.Items.Clear();
        }

        private void m_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = add_m.GET_userdata(Convert.ToInt32(m_no.SelectedValue.ToString()));

                txt_udeptnae.Text = dt.Rows[0][2].ToString();
                txt_deptid = dt.Rows[0][0].ToString();
                txtuserjob.Text = dt.Rows[0][3].ToString();
                txt_reciveuserid = dt.Rows[0][1].ToString();

            }
            catch (Exception f) { }

           


        }



        private void button11_Click(object sender, EventArgs e)
        {
            data_attach.Visible = true;
                       try {

                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\attachments\\";
                f.Filter = "image files (*.JPG)|*.jpg|ALL files(*.*)|*.*";
                f.FilterIndex = 1;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.CheckFileExists)
                    {
                        
                        string correctFileName = System.IO.Path.GetFileName(f.FileName);
                       // string 
                        //تعديييييييييل جديد
                        //SqlCommand cmd = new SqlCommand("insert into follower (doc_follower_id ,doc_follower_picture_path,doc_id,doc_follower_picture_name,mail_id) values((select isnull(MAX(doc_follower_id),0) + 1 from follower) ,'\\images\\" + correctFileName + "','" + Convert.ToInt32(textBox21.Text) + "','" + correctFileName + "','" + Convert.ToInt32(mailing_id) + "')", con);
                        //cmd.ExecuteNonQuery();
                     
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\attachments\\";
                        string sss = "attach" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString()+".jpg";
                      //  System.IO.File.Copy(f.FileName, paths + "\\attachments\\" + correctFileName);
                       
                        file = Image.FromFile(f.FileName);
                        
                        System.IO.File.Copy(f.FileName, paths + sss );
                        pictureBox1.Image = file;
                        data_attach.Rows.Add(txt_docid.Text, sss , paths + "\\attachments\\");
                        MessageBox.Show("تم اضافه مرفق");
                    }

                }
            }
            catch (Exception gf) { MessageBox.Show(gf.Message); }
        }

        private void textBox24_KeyUp(object sender, KeyEventArgs e)
        {

            DataTable dt2 = new DataTable();

            dt2 = dal.serearchdocuments(Convert.ToInt16(txtsenddept.Text), Convert.ToInt16(txtuserid), txt_search.Text.ToString()); ;
            dataGridView1.DataSource = dt2;
            //con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
            int row = dataGridView1.CurrentCell.RowIndex;
            path = dataGridView1.Rows[row].Cells[3].Value.ToString();
          //  MessageBox.Show(path);

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            image = Image.FromStream(fs);
            fs.Close();
            pictureBox1.Image = image;


            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txt_docid.Text = selectedRow.Cells[0].Value.ToString();
          //  textBox20.Text = selectedRow.Cells[1].Value.ToString();
           
            DataTable dt = add_m.getuser_senddocument(Convert.ToInt32(txt_docid.Text), Convert.ToInt32(txtuserid), Convert.ToInt32(txtsenddept.Text));




            foreach (DataRow dr in dt.Rows)
            {
                txtuserjob.Clear();
                txt_udeptnae.Clear();
                txt_userfullname.Clear();
                txtuserjob.Text = dr["job"].ToString();
                txt_udeptnae.Text = dr["name"].ToString();
                txt_userfullname.Text = dr["FullName"].ToString();



                int section_id = Convert.ToInt32(dr["id"].ToString());
                txt_deptid = section_id.ToString();

                int employee_id = Convert.ToInt32(dr["userid"].ToString());
                txt_reciveuserid = employee_id.ToString();

               
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         


        }

        private void add_mailing_Activated(object sender, EventArgs e)
        {
            dtp_maillingdate.Text = DateTime.Now.ToString();
            DataTable dt = add_m.getdept_document(Convert.ToInt32(txtsenddept.Text.ToString()));
            this.dataGridView1.DataSource = dt;
            DataTable dt2 = add_m.getuser_senddocument(Convert.ToInt32(txt_docid.Text.ToString()), Convert.ToInt32(txtsenddept.Text.ToString()), Convert.ToInt32(txtuserid));
            txtuserjob.Clear();
            txt_userfullname.Clear();
            txt_udeptnae.Clear();



            foreach (DataRow dr in dt2.Rows)
            {
                txtuserjob.Text = dr["Job"].ToString();
                txt_udeptnae.Text = dr["name"].ToString();
                txt_userfullname.Text = dr["FullName"].ToString();
                int section_id = Convert.ToInt32(dr["id"].ToString());
                txt_deptid = section_id.ToString();
                int employee_id = Convert.ToInt32(dr["userid"].ToString());
                txt_reciveuserid = employee_id.ToString();

            }


            //SqlConnection mycon = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            //mycon.Open();
            //SqlCommand query = new SqlCommand();
            //query.Connection = mycon;
            //query.CommandText = ("update documents set creation='" + Convert.ToInt32(txtuserid) + "'   where doc_id='" + Convert.ToInt32(txt_docid.Text) + "'");
            //int i1 = query.ExecuteNonQuery();
            //if (i1 > 0)
            //{
            //    MessageBox.Show("تم أدارج وأدخال البيانات ");
            //}
            //mycon.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            x = me.X;
            y = me.Y;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }
        //تبع التقرير
        private void button2_Click(object sender, EventArgs e)
        {
          //  SqlConnection mycon = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
          //  mailing.DataSet2 ds = new mailing.DataSet2();
          //  // string sql = "select da.sub ,d.name,d.doc_text,sg.p_id  ,da.data_id1,d.doc_id, d.data_id2,j.administration as administration1 ,sends.department_name as department_name1 ,s.employee_name as employee_name1 ,r.administration as administration2  ,rec.department_name as department_name2  ,e.employee_name as employee_name2   from signatures sg inner join jeha j on (j.jeha_id =sg.send_id) inner join jeha r on (sg.recieve_id=r.jeha_id) inner join departments sends on (sends.department_id=sg.send_dept_id) inner join departments rec on (rec.department_id=sg.receiving_dept_id) inner join users s on (s.no=sg.Send_no) inner join users e on (sg.Receiving_no=e.no)  INNER JOIN  documents d ON d.doc_id = sg.doc_id   where d.doc_id='" + Int32.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString()) + "' and sg.p_id='" + Int32.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString()) + "'";
          //  string sql = @"  SELECT  documents.doc_subject,documents.person_name, documents.doc_text, sg.doc_id as data_id1 ,sg.doc_id,documents.doc_id as data_id2 ,
          //s.FullName as employee_name1 , e.FullName as employee_name2,s.job as job1,e.job as job2   FROM   documents INNER JOIN     signatures sg on documents.doc_id = sg.doc_id 
          //  inner join departments sends on (sends.id=sg.send_dept_id)  
          //  inner join departments rec on (rec.id=sg.receiving_dept_id) 
          //  inner join users s on (s.no=sg.Send_User_id) 
          //  inner join users e on (sg.Receiving_User_id=e.no)   where documents.doc_id='" + (txt_docid.Text) + "'";
          //  SqlDataAdapter dd = new SqlDataAdapter(sql, mycon);
          //  dd.Fill(ds.Tables["send1"]);
          //  // dataGridView2.DataSource = ds.Tables["send"];
          //    rpt aa = new rpt();
          //  mailing.CrystalReport1 ff = new mailing.CrystalReport1();
          //  ff.SetDataSource(ds.Tables["send1"]);
          //  aa.crystalReportViewer1.ReportSource = ff;
          //  aa.crystalReportViewer1.Refresh();
          //       aa.ShowDialog();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void archive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mailing_type3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_reciveuserid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
