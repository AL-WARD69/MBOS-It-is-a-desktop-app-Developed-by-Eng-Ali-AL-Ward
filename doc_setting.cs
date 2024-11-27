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
using BarcodeLib;
namespace MBOS_Full_System
{
    public partial class doc_setting : Form
    { int counter = 0;
    SqlConnection con = new SqlConnection(@"Server=.; Database=MBOS; Integrated Security= true");
      // public static string sig_id;

        public static int aa;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        string countersend=null;
//int no, int section_id, string department_name
        public doc_setting()
        {
          
        
            InitializeComponent();
            loadPriv();
            dataGridView1.ColumnCount = 9;
           // dataGridView1.Columns[2].Name = "الادارة المرسلة";
            dataGridView1.Columns[2].Name = "الجهة";
            dataGridView1.Columns[3].Name = "الموظف المرسل";
            dataGridView1.Columns[4].Name = "رقم الوثيقة";
            dataGridView1.Columns[5].Name = "موضوع الوثيقة";
            //dataGridView1.Columns[7].Name = "الادارة المستقبلة";
            dataGridView1.Columns[6].Name = "الجهة المستقبل";
            dataGridView1.Columns[7].Name = "الموظق المستقبل";
            dataGridView1.Columns[8].Name = "المفتاح";
            //textBox18.Text = jeha_id.ToString();
            //senddeptid = Program.send_dept_id;
            //txt_userid = Program.no;
            //deptname = Program.department_name;
            //txt_employeename.Text = Program.FullName;

        }



        public void generator3()
        { autoIncrement("select isnull(max(doc_id),0)+1   from documents", txt_docid); }

        public void generator2()
        { autoIncrement("select isnull(max(p_id),0)+1 from signatures", txt_p_id); }


        public static void autoIncrement(string sqlquery, Control textbox)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //string value = dr[0].ToString();
                //if (value == "")
                //{
                //    textbox.Text = "0";
                //}
                //else
                //{
                    int x =Convert.ToInt32(dr[0].ToString());
                    textbox.Text = x.ToString();
               // }

            }
        }

        //        private void m_no_SelectedIndexChanged(object sender, EventArgs e)
        //        {
        //            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
        //            con.Open();

        //            SqlDataAdapter DT = new SqlDataAdapter(@"  SELECT  departments.id, users.userid
        //,       departments.name,users.job,users.FullName
        //   FROM  users INNER JOIN departments ON users.department_id = departments.id   where fullname = '" +( m_no.SelectedText )+ "'", con);

        //            DataTable dt = new DataTable();
        //            DT.Fill(dt);
        //            // m_no.Items.Clear();
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                // m_no.Items.Add(Convert.ToInt32(dr["no"].ToString()));
        //                //  m_no.Items.Add(dr["employee_name"].ToString());
        //                textBox12.Text = dr["name"].ToString();
        //                //textBox11.Text = dr["administration"].ToString();
        //               // textBox4.Text = dr["jeha_id"].ToString();
        //                textBox8.Text = dr["id"].ToString();
        //                textBox23.Text = dr["job"].ToString();
        //                textBox24.Text = dr["userid"].ToString();
        //                textBox27.Text = dr["FullName"].ToString();


        //            }



        //            //SqlConnection con = new SqlConnection(@"server=user-tosh;Database=ALIAA2;Integrated Security=true");
        //            //con.Open();

        //            SqlCommand cmd = con.CreateCommand();
        //            //cmd.CommandType = CommandType.Text;
        //            //cmd.CommandText = "select * from documents where doc_id= '" + comboBox1.Text + "');
        //            cmd = new SqlCommand("select * from users where FullName= '" + m_no.Text + "'", con);
        //            cmd.ExecuteNonQuery();
        //            SqlDataReader dr2;
        //            dr2 = cmd.ExecuteReader();

        //            while (dr2.Read())
        //            {
        //                //string doc_subject=(string)dr["doc_subject"].ToString();
        //                int doc_id = Convert.ToInt32(dr2["userid"].ToString());
        //                textBox9.Text = doc_id.ToString();
        //                string adm = dr2["FullName"].ToString();
        //                textBox13.Text = adm.ToString();
        //                //recivedeptid = doc_subject;
        //            }
        //         //   label18.Text = m_no.Text;

        //            con.Close();
        //        }
        string recivedeptid,recieveuserid,reciveusername;
        private void Combo3_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
                con.Open();

                SqlDataAdapter DT = new SqlDataAdapter(@" SELECT departments.id, users.userid, departments.name,users.job,users.FullName
   FROM  users INNER JOIN departments ON users.department_id = departments.id   where UserID = " + Combo3_recive.SelectedValue + "", con);

                DataTable dt = new DataTable();
                DT.Fill(dt);
                // m_no.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    // m_no.Items.Add(Convert.ToInt32(dr["no"].ToString()));
                    //  m_no.Items.Add(dr["employee_name"].ToString());
                    txt_recivedeptname.Text = dr["name"].ToString();
                    //  textBox15.Text = dr["administration"].ToString();
                    // textBox5.Text = dr["jeha_id"].ToString();
                    recivedeptid = dr["id"].ToString();
                    txt_recivejobs.Text = dr["job"].ToString();

                 reciveusername= dr["FullName"].ToString();
                    recieveuserid = dr["userid"].ToString();

                }


                SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from documents where doc_id= '" + comboBox1.Text + "');
                cmd = new SqlCommand("select * from users where FullName= '" + Combo3_recive.SelectedText + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr2;
                dr2 = cmd.ExecuteReader();

                while (dr2.Read())
                {
                    //string doc_subject=(string)dr["doc_subject"].ToString();
                    int doc_id = Convert.ToInt32(dr2["userid"].ToString());
                    //textBox14.Text = doc_id.ToString();
                    recieveuserid = doc_id.ToString();
                    //string adm = dr2["FullName"].ToString();
                    //label31.Text = Combo3_recive.Text;
                }

                con.Close();
            }
            catch (Exception fff) { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            if (e.ColumnIndex == 1)
            {

               // textBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
                con.Open();

                DialogResult del = MessageBox.Show("Are you Sure you want to delete the :" + recivedeptid + "", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (del == DialogResult.Yes)
                {


                    SqlCommand cmd = new SqlCommand("DELETE from signatures WHERE p_id='" + this.dataGridView1.CurrentRow.Cells[8].Value.ToString() + "' and doc_id=" + Convert.ToInt32(txt_docid.Text.ToString())+"", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Close();
                    MessageBox.Show("Record Deleed Successfully!");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    // MessageBox.Show displaydata();
                    // clear();
                }
                else
                {
                    this.Show();
                }
                //delete();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.add_document1(Convert.ToInt32(txt_docid.Text.ToString()), txt_docsubject.Text.ToString(), txt_docdetail.Text.ToString(), txtData, txt_docimgr.Text.ToString());
           btn_save .Visible = false;
            savedoc();
            //} mycon.Close();


        }
        settings.all_class data = new settings.all_class();
        /*  dataGridView1.Columns[2].Name = "الجهة";
            dataGridView1.Columns[3].Name = "الموظف المرسل";
            dataGridView1.Columns[4].Name = "رقم الوثيقة";
            dataGridView1.Columns[5].Name = "موضوع الوثيقة";
            //dataGridView1.Columns[7].Name = "الادارة المستقبلة";
            dataGridView1.Columns[6].Name = "الجهة المستقبل";
            dataGridView1.Columns[7].Name = "الموظق المستقبل";
            dataGridView1.Columns[8].Name = "المفتاح";*/
        private void addData(string add, string addd, string sec, string emp, string counter2, string sub, string sec2, string emp2, string name)
        {

            string[] row = { add, addd, sec, emp, counter2, sub, sec2, emp2, name };
            dataGridView1.Rows.Add(row);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter=counter+1;
           countersend = counter.ToString();
            addData(null, null, txt_deptname.Text, txt_employeename.Text, txt_docid.Text, txt_docsubject.Text, txt_recivedeptname.Text, reciveusername, txt_p_id.Text);


            SqlConnection mycon = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            mycon.Open();
            SqlCommand query = new SqlCommand();
            query.Connection = mycon;
            //ادخال بدون التاريخ....
            //query.CommandText = "insert into documents(doc_id, doc_subject,doc_text) values('" + Convert.ToInt32(textBox3.Text) + "','" + textBox2.Text + "','" + richTextBox1.Text + "')";
            //int iii = query.ExecuteNonQuery();
            //for (int i = 0; i < dataGridView1.RowCount-1; i++)
            //{//تم التعديل
                query.CommandText = "insert into signatures(sequence_id,p_id ,send_dept_id,Send_User_id,receiving_dept_id,Receiving_User_id,doc_id) values('" + countersend + "','" + Convert.ToInt32(txt_p_id.Text) + "','" + Convert.ToInt32(senddeptid) + "','" + Convert.ToInt32(txt_userid) + "','" + Convert.ToInt32(recivedeptid) + "','" + Convert.ToInt32(recieveuserid) + "','" + Convert.ToInt32(txt_docid.Text) + "')";

            //    if (i == 1)
            //    {

            //        query.CommandText = "insert into signatures(sequence_id,p_id ,send_dept_id,Send_User_id,receiving_dept_id,Receiving_User_id,doc_id) values('" + i + "','" + Convert.ToInt32(txt_p_id.Text) + "','" + Convert.ToInt32(senddeptid) + "','" + Convert.ToInt32(txt_userid) + "','" + Convert.ToInt32(recivedeptid) + "','" + Convert.ToInt32(recieveuserid) + "','" + Convert.ToInt32(txt_docid.Text) + "')";
                   
            //        //   query.CommandText += "insert into data_section(s_data_id, s_section_id)" + " values('" + Convert.ToInt32(textBox4.Text) + "','" + Convert.ToInt32(textBox8.Text) + "')";textBox24.Text

            //    }

            //}
            int i1 = query.ExecuteNonQuery();
            if (i1 > 0)
            {
                MessageBox.Show("تم حفظ خط السير  ");
                //dataGridView1.Rows.Clear();
            }
            
            if (countersend.Equals("1"))
            {
                textBox2.Text = txt_senderjob.Text;
                textBox3.Text = txt_employeename.Text;
                textBox6.Text = txt_recivejobs.Text+ txt_recivedeptname.Text;
                textBox5.Text = Combo3_recive.Text;

            }
            else if (countersend.Equals("2"))
            {

                textBox10.Text = txt_recivejobs.Text + txt_recivedeptname.Text;
                textBox7.Text = Combo3_recive.Text;
            }
            else if (countersend == "3")
            {
                textBox12.Text = txt_recivejobs.Text + txt_recivedeptname.Text;
                textBox11.Text = Combo3_recive.Text;
            }

            else if (countersend == "4")
            {
                textBox14.Text = txt_recivejobs.Text + txt_recivedeptname.Text;
                textBox13.Text = Combo3_recive.Text;
            }
            //else if (countersend == "5")
            //{
            //    label20.Text = txt_recivedeptname.Text + txt_recivejobs.Text;
            //    label35.Text = Combo3_recive.Text;
            //}

            //m_no.Items.Clear();
            txt_p_id.Text = "";
            generator2();
          //  loadPriv();
           
        }
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        string rot = "rotatenoneflipnone";
        string txtData;
        string txtEncoded;
        string lblEncodingTime;
        string tsslEncodedType;
        string txtWidth;
        string txtHeight;
        bool chkGenerateLabel;
        Color btnForeColor, btnBackColor;
        // string cbEncodeType= "UPC-A";
        int W = 200;
        int H = 50;
        string deptname, senddeptid, txt_userid, txt_sig_id, txtdoc_id;
        private void doc_setting_Load(object sender, EventArgs e)
        {
           
            // lood();
            senddeptid = Program.send_dept_id;
            txt_userid = Program.no;
            deptname = Program.department_name;
            txt_employeename.Text = Program.FullName;
            txt_deptname.Text= Program.department_name;
            txt_senderjob.Text = Program.job;
            generator3();
            generator2();
            //lood_sec();
           // lood2();
            lood_emp2();
          //  btnsavedocimg.Visible = false;
            errorProvider1.Clear();
            txtData = getbarnu();

            DataTable dt33 = data.getheader(Convert.ToInt32(senddeptid));
            txt_ar_headername.Text = dt33.Rows[0][0].ToString();
            txt_en_hname.Text= dt33.Rows[0][1].ToString();
            txt_dar_name.Text = dt33.Rows[0][3].ToString();
          //  txtd_enname.Text = dt33.Rows[0][0].ToString();
            byte[] bytes = (byte[])dt33.Rows[0][4];
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);
            loodbarcode();
        }

        void loodbarcode()
        {
            try
            {



                BarcodeLib.TYPE type = BarcodeLib.TYPE.CODE39;
                b.BarWidth = null;
                b.AspectRatio = null;
                b.IncludeLabel = true;
                b.Alignment = BarcodeLib.AlignmentPositions.CENTER;
                b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
                b.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), rot, true);
                barcode.Image = b.Encode(type, txtData, this.b.ForeColor, this.b.BackColor, W, H);
                //===================================

                //show the encoding time
                lblEncodingTime = "(" + Math.Round(b.EncodingTime, 0, MidpointRounding.AwayFromZero).ToString() + "ms)";

                txtEncoded = b.EncodedValue;

                tsslEncodedType = "Encoding Type: " + b.EncodedType.ToString();

                // Read dynamically calculated Width/Height because the user is interested.
                if (b.BarWidth.HasValue)
                    txtWidth = b.Width.ToString();
                if (b.AspectRatio.HasValue)
                    txtHeight = b.Height.ToString();
                // }//if

                //reposition the barcode image to the middle
                barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2, (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.PNG;

                filename = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\docimg\\" + "A" + txt_docid.Text.ToString() + ".png";
                //  MessageBox.Show(filename);
                b.SaveImage(filename, savetype);
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//catch
        }
        string filename = "";

        string getbarnu()
        {
            string s;
            string ss = System.DateTime.Now.Year.ToString().Substring(2, 2);
            string ss1 = System.DateTime.Now.Month.ToString();
            string ss2 = System.DateTime.Now.Day.ToString();
            string ss3 = System.DateTime.Now.Hour.ToString();
            string ss4 = System.DateTime.Now.Minute.ToString();
            string ss5 = System.DateTime.Now.Second.ToString();
            if (ss.Length < 2) ss = "0" + ss;
            if (ss1.Length < 2) ss1 = "0" + ss1;
            if (ss2.Length < 2) ss2 = "0" + ss2;
            if (ss3.Length < 2) ss3 = "0" + ss3;
            if (ss4.Length < 2) ss4 = "0" + ss4;
            if (ss5.Length < 2) ss5 = "0" + ss5;
            s = ss + ss1 + ss2 + ss3 + ss4 + ss5;
            return s;
        }







        void loadPriv()
        {
            //Da = new SqlDataAdapter("select Priv_Add , Priv_Edit,Priv_Delete from TB_Priv where Priv_Screen_ID=1  and Priv_no=" + Convert.ToInt32(Program.no) + " ", con);

            //Da.Fill(Dt);

            //if (Dt.Rows[0][0].ToString() == "False" || Dt.Rows[0][0].ToString() == string.Empty)
            //    button1.Enabled = false;

            //if (Dt.Rows[0][1].ToString() == "False" || Dt.Rows[0][1].ToString() == string.Empty)
            //    button4.Enabled = false;

            ////if (Dt.Rows[0][2].ToString() == "False" || Dt.Rows[0][2].ToString() == string.Empty)
                //btn_delet.Enabled = false;


        }







        //void lood()
        //{
        //    NewFolder1.DataAccessLayer DAL = new NewFolder1.DataAccessLayer();
        //    SqlConnection conn = DAL.getconnection();
        //    conn.Open();
        //    string Select_unit = "Select administration from jeha";
        //    SqlCommand unit = new SqlCommand(Select_unit, conn);
        //    SqlDataReader dr = unit.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        string item = dr["administration"].ToString();
        //        if (!receiving_jeha_id.Items.Contains(item))
        //            receiving_jeha_id.Items.Add(item);

        //    }
        //    dr.Close();
        //    conn.Close();
        //}

        //void lood_emp()
        //{
        //    settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        //    SqlConnection conn = DAL.getconnection();
        //    conn.Open();
        //    string Select_unit = "Select * from users";
        //    SqlCommand unit = new SqlCommand(Select_unit, conn);
        //    SqlDataAdapter dr = new SqlDataAdapter(unit);
        //    DataTable dt = new DataTable();
        //    dr.Fill(dt);
        //    m_no.DataSource = dt;
        //    m_no.DisplayMember = "fullname";
        //    m_no.ValueMember = "Userid";
        //    //while (dr.Read())
        //    //{

        //    //    string item = dr["FullName"].ToString();
        //    //    if (!m_no.Items.Contains(item))
        //    //        m_no.Items.Add(item);

        //    //}
        //    //dr.Close();
        //    //conn.Close();
        //}

        void lood_emp2()
        {



            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlConnection conn = DAL.getconnection();
            conn.Open();
            string Select_unit = "Select * from users";
            SqlCommand unit = new SqlCommand(Select_unit, conn);
            SqlDataAdapter dd = new SqlDataAdapter(unit);
            DataTable dt = new DataTable();
              dd.Fill(dt);
            Combo3_recive.DataSource = dt;
            Combo3_recive.ValueMember = "UserID";
            Combo3_recive.DisplayMember = "FullName";

            //SqlDataReader dr = unit.ExecuteReader();
            //while (dr.Read())
            //{

            //    string item = dr["FullName"].ToString();
            //    if (!Combo3_recive.Items.Contains(item))
            //        Combo3_recive.Items.Add(item);

            //}


            //dr.Close();
            conn.Close();
        }

        //void lood_sec()
        //{
        //    settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        //    SqlConnection conn = DAL.getconnection();
        //    conn.Open();
        //    string Select_unit = "Select name from departments";
        //    SqlCommand unit = new SqlCommand(Select_unit, conn);
        //    SqlDataReader dr = unit.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        string item = dr["name"].ToString();
        //        if (!receiving_section.Items.Contains(item))
        //            receiving_section.Items.Add(item);

        //    }
        //    dr.Close();
        //    conn.Close();
        //}

        //void lood2()
        //{
        //    NewFolder1.DataAccessLayer DAL = new NewFolder1.DataAccessLayer();
        //    SqlConnection conn = DAL.getconnection();
        //    conn.Open();
        //    string Select_unit = "Select administration from jeha";
        //    SqlCommand unit = new SqlCommand(Select_unit, conn);
        //    SqlDataReader dr = unit.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        string item = dr["administration"].ToString();
        //        if (!comboBox1.Items.Contains(item))
        //            comboBox1.Items.Add(item);

        //    }
        //    dr.Close();
        //    conn.Close();
        //}

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textsub.Text = txt_docsubject.Text;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            txt_docbody.Text = txt_docdetail.Text;

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
           // label20.Text = textBox23.Text;

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            //label20.Text =reciveusername;

        }

        private void doc_setting_FormClosed(object sender, FormClosedEventArgs e)
        {

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadPriv();
            // SqlConnection mycon = new SqlConnection(@"server=user-tosh;Database=ALIAA2;Integrated Security=true");
            //mycon.Open();
            //SqlCommand query = new SqlCommand();
            //query.Connection = mycon;
            //query.CommandText = "update   signature set(sequence_id,p_id,send_id ,send_dept_id,Send_no,recieve_id,receiving_dept_id,Receiving_no,data_id,state) values('" + i + "','" + Convert.ToInt32(textBox10.Text) + "','" + Convert.ToInt32(textBox4.Text) + "','" + Convert.ToInt32(textBox8.Text) + "','" + Convert.ToInt32(textBox9.Text) + "','" + Convert.ToInt32(textBox5.Text) + "','" + Convert.ToInt32(recivedeptid) + "','" + Convert.ToInt32(recieveuserid) + "','" + Convert.ToInt32(textBox3.Text) + "','" + "false" + "')";

            //SqlCommand udt=new SqlCommand("update table set id='"+dataGridView1.CurrentRow.Cells["Aid"].ToString()+"', ")
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, panel1.Bounds);
            string y = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\docimg"; 
            string s = "file" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + ".bmp";
            string m = y + "\\" + s;
            bmp.Save(m);

            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            con.Open();
            string dd = System.IO.Path.GetFullPath(m);
            MessageBox.Show(dd);
            MessageBox.Show(s);
            // query1.Connection = con;
            // update data set pic_name='" +s.ToString() + "', pic_path='" + dd + "' where data_id='" + Convert.ToInt32(textBox3.Text) + "'");
            //query.CommandText = "insert into documents(doc_id, doc_subject,doc_text) values('" + Convert.ToInt32(textBox3.Text) + "','" + textBox2.Text + "','" + richTextBox1.Text + "')";
            string CommandText = "update documents set file_name='" + s.ToString() + "', file_path='" + dd + "' where doc_id='" + Convert.ToInt32(txt_docid.Text) + "'";

            SqlCommand query1 = new SqlCommand(CommandText, con);
            int j3 = query1.ExecuteNonQuery();
            if (j3 > 0)
            {
                MessageBox.Show("تم أدارج وأدخال البيانات ");
                //dataGridView1.Rows.Clear();
                // button1.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            savedoc();
           
        }
void savedoc()
        {


            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, panel1.Bounds);
            string y = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\docimg";

            string s = "file" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + ".bmp";
            string m = y + "\\" + s;
            bmp.Save(m);

            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            con.Open();
            string dd = m;
          //  MessageBox.Show(dd);
          //  MessageBox.Show(s);
            // query1.Connection = con;
            // update data set pic_name='" +s.ToString() + "', pic_path='" + dd + "' where data_id='" + Convert.ToInt32(textBox3.Text) + "'");
            //query.CommandText = "insert into documents(doc_id, doc_subject,doc_text) values('" + Convert.ToInt32(textBox3.Text) + "','" + textBox2.Text + "','" + richTextBox1.Text + "')";
            string CommandText = "update documents set departement_id='" + Convert.ToInt32(senddeptid) + "',doc_user_id='" + Convert.ToInt32(txt_userid) + "'  ,file_name='" + s.ToString() + "', file_path='" + dd + "' where doc_id='" + Convert.ToInt32(txt_docid.Text) + "'";

            SqlCommand query1 = new SqlCommand(CommandText, con);
            int j3 = query1.ExecuteNonQuery();
            if (j3 > 0)
            {
                MessageBox.Show("تم حفظ الوثيقه ");
                //dataGridView1.Rows.Clear();
                // button1.Visible = false;
            }

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        //private void textBox29_TextChanged(object sender, EventArgs e)
        //{
        //    label41.Text = txt_docheadergreate.Text;
        //}

        private void chktoone_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoone.Checked == true) { txt_docimgto.Text = "الاخ"; txt_docim_hg.Text = "المحترم"; txt_MGr.Text = "المحترم"; chktogroup.Checked = false; }
            else { txt_docimgto.Text = "الاخوة"; txt_docim_hg.Text = "المحترمون"; txt_MGr.Text = "المحترمون"; chktoone.Checked = false; }
        }

        private void txt_docheadergreate_TextChanged(object sender, EventArgs e)
        {
            txt_docimgr.Text = txt_docheadergreate.Text;
        }

        private void txt_employeename_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            con.Open();

            SqlDataAdapter DT = new SqlDataAdapter(@"  SELECT  departments.id, users.userid
,       departments.name,users.job,users.FullName
   FROM  users INNER JOIN departments ON users.department_id = departments.id   where fullname = '" + (txt_employeename.Text) + "'", con);

            DataTable dt = new DataTable();
            DT.Fill(dt);
            // m_no.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                // m_no.Items.Add(Convert.ToInt32(dr["no"].ToString()));
                //  m_no.Items.Add(dr["employee_name"].ToString());
                txt_deptname.Text = dr["name"].ToString();
                //textBox11.Text = dr["administration"].ToString();
                // textBox4.Text = dr["jeha_id"].ToString();
                textBox8.Text = dr["id"].ToString();
                txt_senderjob.Text = dr["job"].ToString();
               // textBox24.Text 
               txt_userid= dr["userid"].ToString();
               // textBox27.Text = dr["FullName"].ToString();


            }



            //SqlConnection con = new SqlConnection(@"server=user-tosh;Database=ALIAA2;Integrated Security=true");
            //con.Open();

            SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from documents where doc_id= '" + comboBox1.Text + "');
            cmd = new SqlCommand("select * from users where FullName= '" + txt_employeename.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr2;
            dr2 = cmd.ExecuteReader();

            while (dr2.Read())
            {
                //string doc_subject=(string)dr["doc_subject"].ToString();
                int doc_id = Convert.ToInt32(dr2["userid"].ToString());
                textBox9.Text = dr2["userid"].ToString();
               // string adm = dr2["FullName"].ToString();
              //  textBox13.Text = adm.ToString();
                //recivedeptid = doc_subject;
            }
            //   label18.Text = m_no.Text;

            con.Close();
        }

        private void chktogroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chktogroup.Checked == false) { txt_docimgto.Text = "الاخ"; txt_docim_hg.Text = "المحترم"; txt_MGr.Text = "المحترم"; chktogroup.Checked = false; }
            else { txt_docimgto.Text = "الاخوة"; txt_docim_hg.Text = "المحترمون"; txt_MGr.Text = "المحترمون"; chktoone.Checked = false; }
        }
    }
       
    
}
