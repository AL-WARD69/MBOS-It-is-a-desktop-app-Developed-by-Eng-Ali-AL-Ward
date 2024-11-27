using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MBOS_Full_System.settings
{
    class all_class
    {
        public static DataTable dt;
        public DataTable get_all_jeha()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_jeha", null);
            DAL.Close();
            return dt;
        }
        public DataTable doc2_email(int ID)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = ID;
            Dt = DAL.SelectData("doc2_email", param);
            DAL.Close();
            return Dt;
        }
        public DataTable doc_email()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            Dt = DAL.SelectData("doc_email", null);
            DAL.Close();
            return Dt;
        }
        public DataTable getemail()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            Dt = DAL.SelectData("getemail", null);
            DAL.Close();
            return Dt;
        }
        public DataTable get_all_dep_emp()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_employee", null);
            DAL.Close();
            return dt;
        }
        public DataTable get_id_header()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_id_header", null);
            DAL.Close();
            return dt;
        }

        public DataTable get_headers()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_headers", null);
            DAL.Close();
            return dt;
        }
        public DataTable get_all_dep_emp1(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.SelectData("get_all_employee2", param);
            DAL.Close();
            return dt;
        }
        public DataTable getheader(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@did", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.SelectData("getheader", param);
            DAL.Close();
            return dt;
        }
        
             public DataTable notmailling(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = DAL.SelectData("notmailling", param);
            DAL.Close();
            return dt;
        }

        public DataTable getdocumentid()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("getdocumentid", null);
            DAL.Close();
            return dt;
        }
        public DataTable getsignaturesid()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("getsignaturesid", null);
            DAL.Close();
            return dt;
        }

        // public static DataTable dt;
        public DataTable get_all_jeha_once()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_jeha_onec", null);
            DAL.Close();
            return dt;
        }




        public DataTable get_all_jeha_dep()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_jeha_dep", null);
            DAL.Close();
            return dt;
        }

        public DataTable documentsgeneral()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("documentsgeneral", null);
            DAL.Close();
            return dt;
        }







        public DataTable get_all_inf_j_dp_emp()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_inf_j_dp_emp", null);
            DAL.Close();
            return dt;
        }


        public DataTable GET_department_id()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("GET_department_id", null);
            DAL.Close();
            return dt;
        }


        public DataTable get_name_jeha()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_name_jeha", null);
            DAL.Close();
            return dt;
        }






        public DataTable get_per()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_per", null);
            DAL.Close();
            return dt;
        }


        public DataTable notgemeralarchive()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("notgemeralarchive", null);
            DAL.Close();
            return dt;
        }


        public DataTable get_all_dep_jeha_emp()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_dep_jeha_emp", null);
            DAL.Close();
            return dt;
        }






        public DataTable DELETE_jeha(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("DELETE_jeha", param);
            DAL.Close();
            return dt;
        }
        public void updatenotmailling(int id , DateTime rec)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@recivdate", SqlDbType.DateTime);
            param[1].Value = rec;
            DAL.ExecuteCommand("updatenotmailling", param);
            DAL.Close();
        }
        public void updatenotgemeralarchive(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.ExecuteCommand("updatenotgemeralarchive", param);
            DAL.Close();
        }

            public void add_Header(int id_header, string name_arbic, string name_english, int dept_id, byte[] logo)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_header", SqlDbType.Int);
            param[0].Value = id_header;

            param[1] = new SqlParameter("@name_arbic", SqlDbType.NVarChar, 1024);
            param[1].Value = name_arbic;

            param[2] = new SqlParameter("@name_english", SqlDbType.NVarChar,250);
            param[2].Value = name_english;

            param[3] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[3].Value = dept_id;

            param[4] = new SqlParameter("@logo", SqlDbType.Image);
            param[4].Value = logo;
            DAL.ExecuteCommand("add_Header", param);
            DAL.Close();



        }
       
        public void update_Header(int id_header, string name_arbic, string name_english, int dept_id, byte[] logo)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_header", SqlDbType.Int);
            param[0].Value = id_header;

            param[1] = new SqlParameter("@name_arbic", SqlDbType.NVarChar, 1024);
            param[1].Value = name_arbic;

            param[2] = new SqlParameter("@name_english", SqlDbType.NVarChar, 250);
            param[2].Value = name_english;

            param[3] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[3].Value = dept_id;

            param[4] = new SqlParameter("@logo", SqlDbType.Image);
            param[4].Value = logo;
            DAL.ExecuteCommand("update_Header", param);
            DAL.Close();



        }
        //  الداله التي تقوم بعمليه الاضافه
        public void ADDs_signatures(int p_id, int sequence_id, int Send_User_id, int doc_id, int Receiving_User_id, int send_dept_id, int receiving_dept_id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@p_id", SqlDbType.Int);
            param[0].Value = p_id;

            param[1] = new SqlParameter("@sequence_id", SqlDbType.NChar, 10);
            param[1].Value = sequence_id;

            param[2] = new SqlParameter("@Send_User_id", SqlDbType.Int);
            param[2].Value = Send_User_id;

            param[3] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[3].Value = doc_id;

            param[4] = new SqlParameter("@Receiving_User_id", SqlDbType.Int);
            param[4].Value = Receiving_User_id;

            param[5] = new SqlParameter("@send_dept_id", SqlDbType.Int);
            param[5].Value = send_dept_id;

            param[6] = new SqlParameter("@receiving_dept_id", SqlDbType.Int);
            param[6].Value = receiving_dept_id;
            DAL.ExecuteCommand("add_signatures", param);
            DAL.Close();



        }


        public void add_department(int department_id, string department_name, int jeha_id, Int64 department_phone)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@department_id", SqlDbType.Int);
            param[0].Value = department_id;

            param[1] = new SqlParameter("@department_name", SqlDbType.VarChar, 20);
            param[1].Value = department_name;

            param[2] = new SqlParameter("@jeha_id", SqlDbType.Int);
            param[2].Value = jeha_id;

            param[3] = new SqlParameter("@department_phone", SqlDbType.Int);
            param[3].Value = department_phone;

            DAL.ExecuteCommand("add_department", param);
            DAL.Close();



        }
        public void add_department(int department_id, string department_name, string descri, int typ, int mge_id, DateTime up, int parent, int created_right)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@department_id", SqlDbType.Int);
            param[0].Value = department_id;

            param[1] = new SqlParameter("@department_name", SqlDbType.NVarChar, 50);
            param[1].Value = department_name;

            param[2] = new SqlParameter("@description", SqlDbType.NVarChar, 200);
            param[2].Value = descri;

            param[3] = new SqlParameter("@type", SqlDbType.Int);
            param[3].Value = typ;

            param[4] = new SqlParameter("@manager_id", SqlDbType.Int);
            param[4].Value = mge_id;

            param[5] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[5].Value = up;

            param[6] = new SqlParameter("@parent_id", SqlDbType.Int);
            param[6].Value = parent;

            param[7] = new SqlParameter("@created_right", SqlDbType.Int);
            param[7].Value = created_right;
            DAL.ExecuteCommand("add_department", param);
            DAL.Close();



        }


        public void add_document(int doc_id, string doc_subject, string doc_text, string secure_doc, string doc_state, int doc_user_id,
            int doc_type_id, int departement_id, string person_name, DateTime date_person, string file_name, string file_path, string doc_code)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@doc_subject", SqlDbType.NVarChar, 50);
            param[1].Value = doc_subject;
            param[2] = new SqlParameter("@doc_text", SqlDbType.Text);
            param[2].Value = doc_text;
            param[3] = new SqlParameter("@secure_doc", SqlDbType.NVarChar, 50);
            param[3].Value = secure_doc;
            param[4] = new SqlParameter("@doc_state", SqlDbType.VarChar, 20);
            param[4].Value = doc_state;
            param[5] = new SqlParameter("@doc_user_id", SqlDbType.Int);
            param[5].Value = doc_user_id;
            param[6] = new SqlParameter("@doc_type_id", SqlDbType.Int);
            param[6].Value = doc_type_id;
            param[7] = new SqlParameter("@department_id", SqlDbType.Int);
            param[7].Value = departement_id;
            param[8] = new SqlParameter("@person_name", SqlDbType.NVarChar, 50);
            param[8].Value = person_name;
            param[9] = new SqlParameter("@date_person", SqlDbType.Date);
            param[9].Value = date_person;
            param[10] = new SqlParameter("@file_name", SqlDbType.NVarChar, 50);
            param[10].Value = file_name;
            param[11] = new SqlParameter("@file_path", SqlDbType.NVarChar, 50);
            param[11].Value = file_path;
            param[12] = new SqlParameter("@doc_code", SqlDbType.NVarChar, 50);
            param[12].Value = doc_code;
            DAL.ExecuteCommand("add_document", param);
            DAL.Close();



        }



        public void add_document1(int doc_id, string doc_subject, string doc_text, string barcode, string secure_doc)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@doc_subject", SqlDbType.NVarChar, 250);
            param[1].Value = doc_subject;
            param[2] = new SqlParameter("@doc_text", SqlDbType.NText);
            param[2].Value = doc_text;
            param[3] = new SqlParameter("@barcode", SqlDbType.NVarChar, 100);
            param[3].Value = barcode;
            param[4] = new SqlParameter("@secure_doc", SqlDbType.NVarChar, 250);
            param[4].Value = secure_doc;
            DAL.ExecuteCommand("add_document1", param);
            DAL.Close();



        }

        public void edit_document(int doc_id, string doc_subject, string doc_text, string secure_doc, DateTime doc_date, string doc_state, int doc_user_id,
            int doc_type_id, int departement_id, string person_name, DateTime date_person, int isarchive, int archive_electronic, string file_name, string file_path, string doc_code)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@doc_subject", SqlDbType.NVarChar, 50);
            param[1].Value = doc_subject;
            param[2] = new SqlParameter("@doc_text", SqlDbType.Text);
            param[2].Value = doc_text;
            param[3] = new SqlParameter("@secure_doc", SqlDbType.NVarChar, 50);
            param[3].Value = secure_doc;
            param[4] = new SqlParameter("@doc_date", SqlDbType.Date);
            param[4].Value = doc_date;
            param[5] = new SqlParameter("@doc_state", SqlDbType.VarChar, 20);
            param[5].Value = doc_state;
            param[6] = new SqlParameter("@doc_user_id", SqlDbType.Int);
            param[6].Value = doc_user_id;
            param[7] = new SqlParameter("@doc_type_id", SqlDbType.Int);
            param[7].Value = doc_type_id;
            param[8] = new SqlParameter("@department_id", SqlDbType.Int);
            param[8].Value = departement_id;
            param[9] = new SqlParameter("@person_name", SqlDbType.NVarChar, 50);
            param[9].Value = person_name;
            param[10] = new SqlParameter("@date_person", SqlDbType.Date);
            param[10].Value = date_person;
            param[11] = new SqlParameter("@isarchive", SqlDbType.Int);
            param[11].Value = isarchive;
            param[12] = new SqlParameter("@archive_electronic", SqlDbType.Int);
            param[12].Value = archive_electronic;
            param[13] = new SqlParameter("@file_name", SqlDbType.NVarChar, 50);
            param[13].Value = file_name;
            param[14] = new SqlParameter("@file_path", SqlDbType.NVarChar, 50);
            param[14].Value = file_path;
            param[15] = new SqlParameter("@doc_code", SqlDbType.NVarChar, 50);
            param[15].Value = doc_code;
            DAL.ExecuteCommand("edit_document", param);
            DAL.Close();
        }


        public void edit_document1(int doc_id, int doc_user_id, int departement_id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@doc_user_id", SqlDbType.Int);
            param[1].Value = doc_user_id;

            param[2] = new SqlParameter("@department_id", SqlDbType.Int);
            param[2].Value = departement_id;
            DAL.ExecuteCommand("edit_document1", param);
            DAL.Close();
        }

        public void update_doc(int doc_id, string filename, string filepath)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@filename", SqlDbType.NVarChar, 150);
            param[1].Value = filename;

            param[2] = new SqlParameter("@filepath", SqlDbType.NText);
            param[2].Value = filepath;
            DAL.ExecuteCommand("update_doc", param);
            DAL.Close();
        }



        public void edit_jeha(int jeha_ID, string adminstration, string type, int fax, int phone)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@jeha_ID", SqlDbType.Int);
            param[0].Value = jeha_ID;

            param[1] = new SqlParameter("@adminstration", SqlDbType.VarChar, 20);
            param[1].Value = adminstration;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 20);
            param[2].Value = type;

            param[3] = new SqlParameter("@fax", SqlDbType.Int);
            param[3].Value = fax;
            param[4] = new SqlParameter("@phone", SqlDbType.Int);
            param[4].Value = phone;

            DAL.ExecuteCommand("edit_jeha", param);
            DAL.Close();



        }

        public void edit_dep(int department_id, string department_name, Int64 phone_dep)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@department_id", SqlDbType.VarChar, 20);
            param[0].Value = department_id;

            param[1] = new SqlParameter("@department_name", SqlDbType.VarChar, 20);
            param[1].Value = department_name;

            param[2] = new SqlParameter("@phone_dep", SqlDbType.Int);
            param[2].Value = phone_dep;


            DAL.ExecuteCommand("edit_dep", param);
            DAL.Close();



        }



        public DataTable search(string search)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search", param);
            DAL.Close();
            return dt;
        }


        public DataTable search_jeha_administration(string search)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search_jeha_administration", param);
            DAL.Close();
            return dt;
        }

        public DataTable search_departments_department_name(string search)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search_departments_department_name", param);
            DAL.Close();
            return dt;
        }



        public DataTable search_users_employee_name(string search)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search_users_employee_name", param);
            DAL.Close();
            return dt;
        }







        public DataTable search_all_jh_dp_emp(string search)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search_all_jh_dp_emp", param);
            DAL.Close();
            return dt;
        }








        public DataTable verifiynumberid(string id)
        {

            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("verifiynumberid", param);
            DAL.Close();
            return dt;
        }

        public void add_emp(int no, string employee_name, string Qualifications, string gender, int employee_phone, string email_emp, int department_id, string job, int jeha_id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@no", SqlDbType.Int);
            param[0].Value = no;

            param[1] = new SqlParameter("@employee_name", SqlDbType.VarChar, 20);
            param[1].Value = employee_name;
            param[2] = new SqlParameter("@Qualifications", SqlDbType.VarChar, 40);
            param[2].Value = Qualifications;
            param[3] = new SqlParameter("@gender", SqlDbType.VarChar, 20);
            param[3].Value = gender;
            param[4] = new SqlParameter("@employee_phone", SqlDbType.Int);
            param[4].Value = employee_phone;

            param[5] = new SqlParameter("@email_emp ", SqlDbType.VarChar, 50);
            param[5].Value = email_emp;
            param[6] = new SqlParameter("@department_id ", SqlDbType.Int);
            param[6].Value = department_id;
            param[7] = new SqlParameter("@job ", SqlDbType.VarChar, 50);
            param[7].Value = job;

            param[8] = new SqlParameter("@jeha_id", SqlDbType.Int);
            param[8].Value = jeha_id;

            DAL.ExecuteCommand("add_emp", param);
            DAL.Close();



        }

        public void edit_emp(int no, string employee_name, string Qualifications, string gender, int employee_phone, string email_emp, int department_id, string job)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@no", SqlDbType.Int);
            param[0].Value = no;

            param[1] = new SqlParameter("@employee_name", SqlDbType.VarChar, 20);
            param[1].Value = employee_name;

            param[2] = new SqlParameter("@Qualifications", SqlDbType.VarChar, 40);
            param[2].Value = Qualifications;

            param[3] = new SqlParameter("@gender", SqlDbType.VarChar, 20);
            param[3].Value = gender;

            param[4] = new SqlParameter("@employee_phone", SqlDbType.Int);
            param[4].Value = employee_phone;

            param[5] = new SqlParameter("@email_emp ", SqlDbType.VarChar, 50);
            param[5].Value = email_emp;
            param[6] = new SqlParameter("@department_id ", SqlDbType.Int);
            param[6].Value = department_id;

            param[7] = new SqlParameter("@job ", SqlDbType.VarChar, 50);
            param[7].Value = job;

            DAL.ExecuteCommand("edit_emp", param);
            DAL.Close();



        }













        public DataTable GET_JEHA_id()
        {
            DataAccessLayer DAL = new DataAccessLayer();

            DataTable dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("GET_JEHA_id", null);
            DAL.Close();
            return dt;
        }



        public DataTable DELETE_dep(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("DELETE_dep", param);
            DAL.Close();
            return dt;
        }




        public DataTable DELETE_deps(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("DELETE_deps", param);
            DAL.Close();
            return dt;
        }

        public DataTable serearchdocuments(int sec_id, int user_id, string sub)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@sec_id", SqlDbType.Int);
            param[0].Value = sec_id;
            param[1] = new SqlParameter("@user_id", SqlDbType.Int);
            param[1].Value = user_id;
            param[2] = new SqlParameter("@sub", SqlDbType.NVarChar, 50);
            param[2].Value = sub;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("serearchdocuments", param);
            DAL.Close();
            return dt;
        }
        public DataTable GET_usermgr_info(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("GET_usermgr_info", param);
            DAL.Close();
            return dt;
        }
        //public void add_user_auther(int no, string user_name, string password, int no)
        //{
        //    dataAccessLayers DAL = new dataAccessLayers();
        //    DAL.Open();

        //    SqlParameter[] param = new SqlParameter[4];
        //    param[0] = new SqlParameter("@no", SqlDbType.Int);
        //    param[0].Value = no;
        //    param[1] = new SqlParameter("@user_name", SqlDbType.VarChar, 20);
        //    param[1].Value = user_name;
        //    param[2] = new SqlParameter("@password", SqlDbType.VarChar, 50);
        //    param[2].Value = password;
        //    param[3] = new SqlParameter("@no", SqlDbType.Int);
        //    param[3].Value = no;
        //    DAL.ExecuteCommand("add_user_auther", param);
        //    DAL.Close();



        //}
        public DataTable GET_no()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("GET_no", null);
            DAL.Close();
            return dt;
        }

        public DataTable search_user(string search)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search_user", param);
            DAL.Close();
            return dt;
        }


        public DataTable get_all_users()
        {
            DataAccessLayer DAL = new DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_all_users", null);
            DAL.Close();
            return dt;
        }


        public DataTable DELETE_users(int id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("DELETE_users", param);
            DAL.Close();
            return dt;
        }



        //public DataTable GET_no()
        //{
        //    dataAccessLayers DAL = new dataAccessLayers();
        //    dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
        //    dt = DAL.SelectData("GET_u", null);
        //    DAL.Close();
        //    return dt;
        //}





        public void add_user_permissions(int user_permissions_id, string user_permissions_name)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_permissions_id", SqlDbType.Int);
            param[0].Value = user_permissions_id;
            param[1] = new SqlParameter("@user_permissions_name", SqlDbType.VarChar, 50);
            param[1].Value = user_permissions_name;
            DAL.ExecuteCommand("add_user_permissions", param);
            DAL.Close();



        }

        public void add_user_permissions_middel(int user_permissions_id, int no, int cases)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_permissions_id", SqlDbType.Int);
            param[0].Value = user_permissions_id;
            param[1] = new SqlParameter("@no", SqlDbType.Int);
            param[1].Value = no;
            param[2] = new SqlParameter("@cases", SqlDbType.Bit);
            param[2].Value = cases;
            DAL.ExecuteCommand("add_user_permissions_maddile", param);
            DAL.Close();



        }


        public DataTable get_jeha()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_J", null);
            DAL.Close();
            return dt;
        }

    }

}
