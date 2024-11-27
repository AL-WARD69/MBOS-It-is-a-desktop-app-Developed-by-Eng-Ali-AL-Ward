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
    public partial class doc_setting_rep : Form
    {
        int counter = 0;
        SqlConnection con = new SqlConnection(@"Server=.; Database=MBOS; Integrated Security= true");
        // public static string sig_id;
        // int counter = 0;
        // SqlConnection con = new SqlConnection(@"Server=.; Database=MBOS; Integrated Security= true");
        // public static string sig_id;
        public static int taskid, mgrid;
        string task_name;
        BL.Show_Class sh = new BL.Show_Class();

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
        public static int aa;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public doc_setting_rep()
        {


            InitializeComponent();
            loadPriv();

            //textBox18.Text = jeha_id.ToString();
            txt_jobuser.Text = Program.job;
            txtusename.Text = Program.FullName;
            txt_deptname.Text = Program.department_name;

        }



        string pubstr;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //  MessageBox.Show(txtData);
                data.add_document1(Convert.ToInt32(txt_docid.Text.ToString()), txt_docsubject.Text.ToString(), txt_docdetail.Text.ToString(), txtData, txt_docimgr.Text.ToString());
                btn_savedoc.Visible = false;
               save();

            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            counter++;


        }
        settings.all_class data = new settings.all_class();
        string p_id, rdeptid;

        private void doc_setting_Load(object sender, EventArgs e)
        {
            txt_docimgto.Text = "الاخ"; txt_docim_hg.Text = "المحترم"; txt_MGr.Text = "المحترم";
            DataTable ddt = new DataTable();
            ddt = sh.Show_Task(taskid);
            mgrid = Convert.ToInt32(ddt.Rows[0][0].ToString());
            task_name = ddt.Rows[0][1].ToString();
            DataTable dd = data.getdocumentid();
            txt_docid.Text = dd.Rows[0][0].ToString();

            DataTable w1 = data.getsignaturesid();
            p_id = w1.Rows[0][0].ToString();
            allemp2 = data.GET_usermgr_info(mgrid);
            txtusermgr.Text = allemp2.Rows[0][1].ToString();
            txt_recivdept.Text = allemp2.Rows[0][3].ToString();
            txtreciv_job.Text = allemp2.Rows[0][4].ToString();
            rdeptid = allemp2.Rows[0][2].ToString();
            txt_docheadergreate.Text = txtusermgr.Text + "    " + txtreciv_job.Text;
            txt_docsubject.Text = "   تقرير عن المهمه " + task_name + "(" + taskid + ")";
            //  lood2();
            // lood_emp2();
            errorProvider1.Clear();
            txtData = getbarnu();

            loodbarcode();

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
                MessageBox.Show(ex.Message + "" + filename);
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







        DataTable allemp = new DataTable();
        DataTable allemp2 = new DataTable();






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
            //label20.Text = textBox17.Text;

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
            //query.CommandText = "update   signature set(sequence_id,p_id,send_id ,send_dept_id,Send_no,recieve_id,receiving_dept_id,Receiving_no,data_id,state) values('" + i + "','" + Convert.ToInt32(textBox10.Text) + "','" + Convert.ToInt32(textBox4.Text) + "','" + Convert.ToInt32(textBox8.Text) + "','" + Convert.ToInt32(textBox9.Text) + "','" + Convert.ToInt32(textBox5.Text) + "','" + Convert.ToInt32(textBox6.Text) + "','" + Convert.ToInt32(textBox7.Text) + "','" + Convert.ToInt32(textBox3.Text) + "','" + "false" + "')";

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

        //private void button3_Click_1(object sender, EventArgs e)
        //{

        //    Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
        //    panel1.DrawToBitmap(bmp, panel1.Bounds);
        //    // MessageBox.Show(Application.StartupPath);
        //    string y = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\docimg";

        //    string s = "file" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + ".bmp";
        //    string m = y + "\\" + s;
        //    bmp.Save(m);



        //    //  MessageBox.Show(dd);
        //    //  MessageBox.Show(s);
        //    // query1.Connection = con;
        //    // update data set pic_name='" +s.ToString() + "', pic_path='" + dd + "' where data_id='" + Convert.ToInt32(textBox3.Text) + "'");
        //    //query.CommandText = "insert into documents(doc_id, doc_subject,doc_text) values('" + Convert.ToInt32(textBox3.Text) + "','" + textBox2.Text + "','" + richTextBox1.Text + "')";
        //    data.update_doc(Convert.ToInt32(txt_docid.Text), s.ToString(), m);

        //    MessageBox.Show("تم أدارج وأدخال البيانات ");
        //    //dataGridView1.Rows.Clear();
        //    // button1.Visible = false;

        //}

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

        }
        void save()
        {
            textBox2.Text = txt_deptname + txt_jobuser.Text;
            textBox3.Text = txtusename.Text;
            textBox6.Text = txt_recivdept.Text + txtreciv_job.Text;
            textBox5.Text = txtusermgr.Text;
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, panel1.Bounds);
            // 
            string y = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\docimg";

            string s = "file" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + ".bmp";
            string m = y + "\\" + s;
            bmp.Save(m);
           



            data.update_doc(Convert.ToInt32(txt_docid.Text), s.ToString(), m);
            data.ADDs_signatures(Convert.ToInt32(p_id), 1, Convert.ToInt32(Program.no), Convert.ToInt32(txt_docid.Text), mgrid, Convert.ToInt32(Program.send_dept_id), Convert.ToInt32(rdeptid));


            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
            con.Open();
            string dd = m;
            // MessageBox.Show(dd);
            // MessageBox.Show(s);
            // query1.Connection = con;
            // update data set pic_name='" +s.ToString() + "', pic_path='" + dd + "' where data_id='" + Convert.ToInt32(textBox3.Text) + "'");
            //query.CommandText = "insert into documents(doc_id, doc_subject,doc_text) values('" + Convert.ToInt32(textBox3.Text) + "','" + textBox2.Text + "','" + richTextBox1.Text + "')";
            string CommandText = "update documents set file_name='" + s.ToString() + "', file_path='" + dd + "' where doc_id='" + Convert.ToInt32(txt_docid.Text) + "'";

            SqlCommand query1 = new SqlCommand(CommandText, con);
            int j3 = query1.ExecuteNonQuery();
            if (j3 > 0)
            {
                
               
                MessageBox.Show("تم حفظ الوثيقه ");
            }
            else MessageBox.Show("لم يتم الحفظ");
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

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
         //   label41.Text = txt_docbody.Text;
        }



        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            txt_docimgr.Text = txt_docheadergreate.Text;
        }


    } 
    
}
