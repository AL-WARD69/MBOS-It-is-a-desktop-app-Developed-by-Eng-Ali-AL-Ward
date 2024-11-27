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
    public partial class arch_puplic : Form
    {
       
        general_archive.allclass emp = new general_archive.allclass();
        general_archive.allclass emp1 = new general_archive.allclass();

        SqlDataAdapter da;
        // SqlCommandBuilder scb;
        DataTable dt = new DataTable();
        general_archive.allclass prd = new general_archive.allclass();
        //public DataTable get_jeha()
        //{

        //    settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[2];
        //    DAL.Open();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("GET_J", null);
        //    DAL.Close();
        //    return dt;
        //}

        //public DataTable get_docs()
        //{

        //    settings.dataAccessLayers DAL = new settings.dataAccessLayers();
        //    SqlParameter[] param = new SqlParameter[2];
        //    DAL.Open();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("get_docs", null);
        //    DAL.Close();
        //    return dt;

        //}





        public DataTable GET_no()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_no", null);
            DAL.Close();
            return dt;

        }
        public DataTable general_archive_info()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("general_archive_info", null);
            DAL.Close();
            return dt;

        }
        
              public DataTable documents_general()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
           DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("documents_general", null);
            DAL.Close();
            return dt;
        }
        public DataTable documents_general_hand()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("documents_general_hand", null);
            DAL.Close();
            return dt;
        }

        public DataTable documentsgeneral()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("documentsgeneral", null);
            DAL.Close();
            return dt;
        }
        public DataTable special_Archive_number()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("special_Archive_number", null);
            DAL.Close();
            return dt;
        }

        public DataTable get_archive_no_shelf()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_archive_no_shelf", null);
            DAL.Close();
            return dt;

        }

        public DataTable general_archive_folder_name()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("general_archive_folder_name", null);
            DAL.Close();
            return dt;

        }
        //string administration, string employee_name, int jeha_id, int no, int section_recieve, string department_name
        public arch_puplic()
        {
            InitializeComponent();
           

        }
        public void filldatagrud()
        {
            //da.Clear();
            loodinc();
            //            //da = new SqlDataAdapter("select g.general_id as 'رقم الارشيف العام',g.archive_date as 'تاريخ الارشفه',g.send_jeha_id as 'رقم الجهة المرسلة',g.receiving_jeha_id as 'رقم الجهة المستقبلة',g.arch_doc_id 'رقم الوثيقة',g.arch_special_id as 'رقم الارشيف الخاص',g.arch_no as 'رقم الموظف',g.folder_name as 'اسم المجلد',g.no_shelf as 'رقم الدرج' from general_Archive g    ", con);

            //            //inner join mailing m on sm.s_mailing_id =m.mailing_id
            //           // da = new SqlDataAdapter(" SELECT d.general_id as 'رقم الارشيف العام'  ,d.archive_date  as  'تاريخ الارشفه' ,d.doc_subject as ' الموضوع',special_id as'رقم الارشيف الخاص' ,folder_name as ' المجلد' ,no_shelf as 'رقم الرف',dp.department_name as 'القسم المرسل' ,g.employee_name as'الموظف المرسل' ,d.archive_electronic as 'الارشفه الالكتونية',g.archive_hand as 'الارشفه اليدويه',j.administration  as 'الجهه المرسلة' FROM documents d inner join general_archive g on d.doc_id=g.arch_doc_id inner join users e on e.no=g.send_employee  inner join departments dp  on dp.department_id=g.section_send inner join jeha j on j.jeha_id=g.send_jeha_id ", con);
            //         //   da = new SqlDataAdapter(" SELECT g.general_id as 'رقم الارشيف العام'  ,g.archive_date  as  'تاريخ الارشفه ',  g.arch_doc_id as 'رقم الوثيقة',special_id as 'رقم الارشيف الخاص' ,folder_name as 'اسم المجلد',no_shelf as 'رقم الرف',j.administration  as 'الجهه المرسلة ,                                              d.doc_subject as ' الموضوع',no_shelf as 'رقم الرف',dp.department_name as 'القسم المرسل' ,e.employee_name as'الموظف المرسل' ,g.archive_electronic as 'الارشفه الالكتونية',g.archive_hand as 'الارشفه اليدويه',j.administration  as 'الجهه المرسلة' FROM documents d inner join general_archive g on d.doc_id=g.arch_doc_id inner join users e on e.no=g.send_employee  inner join departments dp  on dp.department_id=g.section_send inner join jeha j on j.jeha_id=g.send_jeha_id ", con);
            //          //  SqlDataAdapter da = new SqlDataAdapter("SELECT        jeha.administration, general_archive.general_id, general_archive.archive_date, general_archive.arch_doc_id, general_archive.special_id,  general_archive.folder_name, general_archive.no_shelf,  general_archive.mosul_person, general_archive.archive_electronic, general_archive.archive_hand, general_archive.morfag, general_archive.al_asl,  general_archive.arch_doc_subject, general_archive.room_id, general_archive.cupboard_id, departments.department_name, users.employee_name FROM departments INNER JOIN users ON departments.department_id = users.department_id INNER JOIN general_archive ON users.userid = general_archive.send_employee AND users.userid = general_archive.recieve_employee INNER JOIN jeha ON departments.jeha_id = jeha.jeha_id AND users.jeha_id = jeha.jeha_id AND general_archive.receiving_jeha_id = jeha.jeha_id");
            //            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");

            //            SqlDataAdapter da = new SqlDataAdapter(@"SELECT   g.general_id as'رقم القيد   ', g.archive_date as 'تارخ الارشفة', dg.doc_id, dg.special_id, 
            //                 g.folder_name, dg.no_shelf, dg.archive_electronic, dg.archive_hand, dg.al_asl, dg.morfag ,
            //           dg.arch_doc_subject, dg.room_id, dg.cupboard_id, departments.name,users.FullName,dg.cary_person 

            //FROM     documents_general_archive dg  INNER JOIN   general_archive  g  on dg.general_id=g.general_id  INNER JOIN users  on g.User_id=users.userid  inner join departments ON g.department_id=departments.id  ", con);

            //DataTable dt = emp.get_alldoc();
            //doc_id.DataSource = dt;
            //doc_id.ValueMember = "doc_id";
            //doc_id.DisplayMember = "doc_id";
            //doc_id.SelectedIndex = -1;









            DataTable dt2 = documents_general();
          


            dataGridView1.DataSource = dt2;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {

                emp.add_archive(Convert.ToInt32(txtgenarlid.Text),
                 DateTime.Parse(txtarchivedate.Text),
                 Convert.ToInt32(doc_id.Text.ToString()),
                 Convert.ToInt32(txtspecialarchiveid.Text),
                 combo_folder.GetItemText(combo_folder.SelectedValue.ToString()),
                   Convert.ToInt32(combo_no_sl.Text.ToString()),
                  Convert.ToInt32(txt_deptsend_1.Text),
                  Convert.ToInt32(txt_usersend1.Text),
                    Convert.ToInt32(txtsendept1.Text),
                    Convert.ToInt32(txtuserid.Text),
                     txtcarypreson.Text
                    , elect
                    , doctype
                    , (txt_docsub.Text)
                    , Convert.ToInt32(txtnoroom.Text)
                   , Convert.ToInt32(txt_nod.Text));
                MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filldatagrud();

            }
            catch (Exception es) { }
         
           
               
            
        }


        void loodinc()
        {
            DataTable ff = general_archive_info();
            combo_folder.DataSource = ff;
            combo_folder.ValueMember = "general_id";
            combo_folder.DisplayMember = "folder_name";
            combo_folder.SelectedIndex = 0;
            txtgenarlid.Text = ff.Rows[0][0].ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try {
                
                DataTable dt = documents_general();
              
                dataGridView1.DataSource = dt;

                //this.dataGridView1.DataSource = prd.all_doc();
                txtgenarlid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtarchivedate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                doc_id.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                 txtspecialarchiveid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                combo_folder.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                combo_no_sl.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                txt_docsub.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
               txtnoroom.Text= dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txt_nod.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                txtcarypreson.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
               
                
            }
            catch (Exception fffff) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            



            DataTable dt = documents_general_hand();
           


            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            search frm = new search();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arch_puplic_Load(sender,e);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            documentsgeneral();
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.OKCancel);

               
               
                if (res == DialogResult.OK)
                {
                   emp.delete_document_genaralarchive(Convert.ToInt32( dataGridView1.CurrentRow.Cells[1].Value.ToString()), Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
           
            }

           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            //textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //send_jeha_id.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            // textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //textBox25.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //textBox24.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //textBox12.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            //comboBox6.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            //comboBox7.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtgenarlid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtarchivedate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            doc_id.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtspecialarchiveid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            combo_folder.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            combo_no_sl.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            txt_docsub.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtnoroom.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txt_nod.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtcarypreson.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

            // txtgenarlid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //doc_id.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            // txtspecialarchiveid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //combo_folder.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            // combo_no_sl.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            // txtcarypreson.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            // txt_docsub.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            // txtnoroom.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            // txt_nod.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            // txt_deptsend_1.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            // txt_usersend1.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();

        }



      

        private void s_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
                con.Open();
                SqlDataAdapter DT = new SqlDataAdapter(@"  SELECT     departments.id,departments.name, users.FullName,users.userid
FROM            users INNER JOIN departments on users.department_id = departments.id
                                           where userid = " + Convert.ToInt32(s_no.SelectedValue.ToString() )+ "", con);

                DT.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // m_no.Items.Add(Convert.ToInt32(dr["no"].ToString()));
                    //  m_no.Items.Add(dr["employee_name"].ToString());
                    // textBox12.Text = dr["department_name"].ToString();
                    // textBox22.Text = dr["administration"].ToString();
                    //  textBox10.Text = dr["jeha_id"].ToString();
                    txt_deptsend_1.Text = dr["id"].ToString();
                    txtdeptsend.Text = dr["name"].ToString();
                    txt_usersend1.Text = dr["userid"].ToString();

                }

         con.Close();   }
            catch (Exception fff) { }

            
        }

      
        public string z;
        private void arch_puplic_Load(object sender, EventArgs e)
        {
            z = @"SELECT *from  general_archive";
            timer1.Enabled = true;

            txt_recivedept.Text = Program.department_name;//department_name;
            txtfullname.Text = Program.FullName;//employee_name;
            txtsendept1.Text = Program.send_dept_id; //jeha_id.ToString();
            txtuserid.Text = Program.no;// no.ToString();


            loodinc();
           
            this.dataGridView1.DataSource = prd.all_doc();
            
            s_no.DataSource = GET_no();
            s_no.DisplayMember = "Fullname";
            s_no.ValueMember = "userid";
           combo_no_sl.DataSource = get_archive_no_shelf();
            combo_no_sl.DisplayMember = "no_shelf";
            combo_no_sl.ValueMember = "no_shelf";

            combo_folder.DataSource = general_archive_folder_name();
            combo_folder.DisplayMember = "folder_name";
            combo_folder.ValueMember = "folder_name";
            txtcarypreson.Text = "";
            txtarchivedate.Text = DateTime.Now.ToString();
            // textBox2.Text = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            //DataTable dsp = emp.get_userspecial_archive(Convert.ToInt32(txtsendept1.Text.ToString()), Convert.ToInt32(txtuserid.Text.ToString()));
            user_special.DataSource = emp.get_userspecial_archive(Convert.ToInt32(txtsendept1.Text.ToString()), Convert.ToInt32(txtuserid.Text.ToString()));
            user_special.ValueMember = "special_id";
            user_special.DisplayMember = "folder_name";
            user_special.SelectedIndex = 0;

        }
        string elect = "الكتروني";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //string ch;
            if (checkelectonic.Checked)
            {
                elect = "يدوي";
                txtspecialarchiveid.Text = "";
                txtspecialarchiveid.Visible = false;
                label6.Visible = false;


            }
            else
            {
                elect = "الكتروني";
                txtspecialarchiveid.Visible = true;
                label6.Visible = true;
            }
            }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //string ch1;
            //if (checkhand.Checked)
            //{
            //    ch1 = "يدوي";
            //    textBox15.Text = ch1;
            //    checkelectonic.Checked = false;
            //    textBox13.Text = "";

               
            //    txtdocid.Text = "";
            //    txt_docsub.Text = "";

            //    //textBox17.Visible = true;
            //    //label17.Visible = true;
            //    //SqlConnection connect = new SqlConnection("server=.; Database=MBOS; integrated security=true");
            //    //da = new SqlDataAdapter(" select * from special_Archive where special_id=" + int.Parse(textBox17.Text), connect);
            //    //dt = new DataTable();
            //    //da.Fill(dt);
            //    //string s = dt.Rows[0]["sub"].ToString();
            //    //textBoxX2.Text = s;
            //    // lood(textBox17.Text);
            //}
            //else
            //{

            //    txtspecialarchiveid.Visible = true;
            //    label6.Visible = true;
            //    // comboBox4.SelectedIndex = 0;

            //}
            ////lood(textBox10.Text
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try {
                object sel = txtgenarlid.Text;



                // query.CommandText = "insert into general_archive(general_id,archive_date,receiving_jeha_id,arch_doc_id,folder_name,no_shelf,section_send,send_employee,section_recieve,recieve_employee,send_jeha_id,mosul_person,arch_doc_subject,special_id,cupborad_id)" + "values('" + textBox1.Text + "','" + Convert.ToDateTime(textBox2.Text) + "','" + Convert.ToInt32(textBox15.Text) + "','" + textBox3.Text + "','" + textBoxX1.Text + "','" + comboBox7.GetItemText(comboBox7.SelectedItem) + "','" + Convert.ToInt32(textBox12.Text) + "','" + textBox13.Text + "','" + Convert.ToInt32(textBox16.Text) + "','" + textBox9.Text + "','" + Convert.ToInt32(textBox11.Text) + "','" + textBoxX5.Text + "','" + textBoxX2.Text + "','" + textBox17.Text + textBoxX6.Text + "')";
                emp.update_archive(Convert.ToInt32(txtgenarlid.Text),
                     DateTime.Parse(txtarchivedate.Text),
                     Convert.ToInt32(doc_id.SelectedValue.ToString()),
                     Convert.ToInt32(txtspecialarchiveid.Text),
                     combo_folder.GetItemText(combo_folder.SelectedValue.ToString()),
                       Convert.ToInt32(combo_no_sl.SelectedText.ToString()),
                      Convert.ToInt32(txt_deptsend_1.Text),
                      Convert.ToInt32(txt_usersend1.Text),
                        Convert.ToInt32(txtsendept1.Text),
                        Convert.ToInt32(txtuserid.Text),
                         txtcarypreson.Text
                        , elect
                        , doctype
                        , (txt_docsub.Text)
                        , Convert.ToInt32(txtnoroom.Text)
                       , Convert.ToInt32(txt_nod.Text));
                // query.CommandText = ("update  general_Archive set archive_date='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "' ,arch_doc_id='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "',special_id='" + textBox24.Text + "',folder_name='" + comboBox6.Text + "',no_shelf='" + comboBox7.Text + "',section_send='" + textBox4.Text + "' ,send_employee='" + textBox14.Text + "',send_jeha_id='" + textBox10.Text + "' ,mosul_person='" + textBox12.Text + "' ,archive_electronic='" + textBox13.Text + "', archive_hand='" + textBox15.Text + "',morfag='" + textBox16.Text + "',loc_id='" + textBox17.Text + "',al_asl='" + textBox18.Text + "',arch_doc_subject='" + textBox25.Text + "',room_id='" + textBox20.Text + "',cupboard_id='" + textBox21.Text + "'where general_id = '" + textBox1.Text + "'");

                MessageBox.Show("تم التعديل ");

                filldatagrud();
            }
            catch (Exception ff) { }
        }
        string doctype= "اصل";
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string ch2;
            if (checkgenaricdoc.Checked)
            {
                doctype = "صورة";
               
            }
            else
            {

                string doctype = "اصل";

            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void arch_puplic_Activated(object sender, EventArgs e)
        {
           
            DataTable dt = documents_general();
           
            // da.Fill(dt);


            dataGridView1.DataSource = dt;
            //            string ch;
            //            if (checkBox1.Checked)
            //            {     ch="الكتروني";
            //                textBox13.Text = ch;
            //                checkBox2.Checked = false;
            //                textBox15.Text = "";

            //                textBox24.Visible = true;
            //                label6.Visible = true;
            //                SqlConnection connect = new SqlConnection("server= . ; Database=MBOS; integrated security=true");
            //                da = new SqlDataAdapter(@" SELECT        documents.doc_id, documents.doc_subject
            //FROM            specail_mailing INNER JOIN
            //                         special_Archive ON specail_mailing.m_special_id = special_Archive.special_id INNER JOIN
            //                         mailing ON specail_mailing.s_mailing_id = mailing.mailing_id INNER JOIN
            //            documents ON mailing.mdoc_id = documents.doc_id where specail_mailing.m_special_id=" + int.Parse(textBox24.Text), con);
            //                dt = new DataTable();
            //                da.Fill(dt);
            //                string s = dt.Rows[0]["doc_subject"].ToString();
            //                textBox25.Text = s;

            //                string d = dt.Rows[0]["doc_id"].ToString();
            //                textBox19.Text = d;






            //", con);

            //           DataTable dt = new DataTable();
            //           da.Fill(dt);
            //          // da.Fill(dt);


           // dataGridView1.DataSource = dt;
            //            string ch;
            //            if (checkBox1.Checked)
            //            {     ch="الكتروني";
            //                textBox13.Text = ch;
            //                checkBox2.Checked = false;
            //                textBox15.Text = "";

            //                textBox24.Visible = true;
            //                label6.Visible = true;
            //                SqlConnection connect = new SqlConnection("server= . ; Database=MBOS; integrated security=true");
            //                da = new SqlDataAdapter(@" SELECT        documents.doc_id, documents.doc_subject
            //FROM            specail_mailing INNER JOIN
            //                         special_Archive ON specail_mailing.m_special_id = special_Archive.special_id INNER JOIN
            //                         mailing ON specail_mailing.s_mailing_id = mailing.mailing_id INNER JOIN
            //            documents ON mailing.mdoc_id = documents.doc_id where specail_mailing.m_special_id=" + int.Parse(textBox24.Text), con);
            //                dt = new DataTable();
            //                da.Fill(dt);
            //                string s = dt.Rows[0]["doc_subject"].ToString();
            //                textBox25.Text = s;

            //                string d = dt.Rows[0]["doc_id"].ToString();
            //                textBox19.Text = d;

            //                // lood(textBox17.Text);
            //            }
            //            else
            //            {

            //                //textBox24.Visible = false;
            //                //label6.Visible = false;
            //                // comboBox4.SelectedIndex = 0;

            //            }
            //            //lood(textBox10.Text
            //        }
            //        }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //archive_noti j = new archive_noti();
            //j.Show();
        }

        int nav(string z)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter("select * from  documents_general_archive  where g_show='false' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int no = dt.Rows.Count;


            return no;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label24.Text = nav(z).ToString();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter("select * from  documents_general_archive where  g_show='false'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int no = dt.Rows.Count;
            if (no > 0)
            {
                //general_archive.archive_noti j = new general_archive.archive_noti(textBox9.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, textBox3.Text);
                //j.Show();
                // MessageBox.Show(System.DateTime.Now.ToString("yyyy/MM/dd"));
                con.Open();
                SqlCommand cmd = new SqlCommand("update  documents_general_archive set g_show='true'", con);
                //receive_date=" +System.Time.Now.ToString("yyyy/MM/dd") + "   
                //, receive_date=" + System.DateTime.Now + "
                // cmd.Connection = con;

                // cmd.CommandText = "insert into mailing (receive_date)" + "values('" + DateTime.Parse(textBox5.Text) + "')";
                cmd.ExecuteNonQuery();

                con.Close();
                //SqlDataAdapter da1 = new SqlDataAdapter("update mailing set show='true' where receiving_jeha_id=" + textBox4.Text, con);
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try { 
            emp.update_archive(Convert.ToInt32(txtgenarlid.Text),
                DateTime.Parse(txtarchivedate.Text),
                Convert.ToInt32(doc_id.Text.ToString()),
                Convert.ToInt32(txtspecialarchiveid.Text),
                combo_folder.GetItemText(combo_folder.SelectedValue.ToString()),
                  Convert.ToInt32(combo_no_sl.Text.ToString()),
                 Convert.ToInt32(txt_deptsend_1.Text),
                 Convert.ToInt32(txt_usersend1.Text),
                   Convert.ToInt32(txtsendept1.Text),
                   Convert.ToInt32(txtuserid.Text),
                    txtcarypreson.Text
                   , elect
                   , doctype
                   , (txt_docsub.Text)
                   , Convert.ToInt32(txtnoroom.Text)
                  , Convert.ToInt32(txt_nod.Text));
          
                MessageBox.Show("تم التعديل ");
           

            filldatagrud();
            }
            catch (Exception ff) { MessageBox.Show("لم يتم التعديل "); }
        }


        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void doc_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_docsub.Text = emp.get_docsubject(Convert.ToInt32(doc_id.GetItemText(doc_id.SelectedValue))).Rows[0][1].ToString();
            }
            catch (Exception ss) { }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void user_special_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                txtspecialarchiveid.Text = user_special.SelectedValue.ToString();
                DataTable gg=emp.get_documentinfolderspecialarchive(Convert.ToInt32(txtspecialarchiveid.Text.ToString()), user_special.Text.ToString());
                doc_id.DataSource = gg;
                doc_id.ValueMember = "doc_id";
                doc_id.DisplayMember = "doc_id";
                doc_id.SelectedIndex = 0;
           //MessageBox.Show(user_special.Text.ToString());
            } catch (Exception fff) { }
        }
    }
    }

 

        
        
        

        
             

 