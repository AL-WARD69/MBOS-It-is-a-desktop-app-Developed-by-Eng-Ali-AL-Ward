using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace MBOS_Full_System.general_archive
{
    class allclass
    {
        public static DataTable dt;
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
        public DataTable get_alldoc()
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();

            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = dal.SelectData("get_alldoc", null);
            dal.Close();
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
        public DataTable get_docsubject(int doc_id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = dal.SelectData("get_docsubject", param);
            dal.Close();
            return dt;
        }
        public DataTable get_general_archiveid()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_general_archiveid", null);
            DAL.Close();
            return dt;

        }

        public DataTable employeees()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("employeees", null);
            DAL.Close();
            return dt;

        }
        public DataTable get_userspecial_archive(int dept_id, int userid)
        //  @general_id int,@doc_id int
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = dept_id;

            param[1] = new SqlParameter("@userid ", SqlDbType.Int);
            param[1].Value = userid;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_userspecial_archive", param);
            DAL.Close();
            return dt;
        }
        public DataTable get_documentinfolderspecialarchive(int special_id, string folder_name)

        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@special_id", SqlDbType.Int);
            param[0].Value = special_id;

            param[1] = new SqlParameter("@folder_name", SqlDbType.NVarChar, 2024);
            param[1].Value = folder_name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_documentinfolderspecialarchive", param);
            DAL.Close();
            return dt;
        }
        public void delete_document_genaralarchive(int general_id, int doc_id)
        //  @general_id int,@doc_id int
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@general_id", SqlDbType.Int);
            param[0].Value = general_id;

            param[1] = new SqlParameter("@doc_id ", SqlDbType.Int);
            param[1].Value = doc_id;
            DAL.ExecuteCommand("delete_document_genaralarchive", param);
            DAL.Close();
        }


        public void add_a(int general_id, DateTime archive_date, int receiving_jeha_id, int arch_doc_id, int arch_special_id, string folder_name, int no_shelf, int section_send, int send_employee, int section_recieve, int recieve_employee, int send_jeha_id, string mosul_person, string archive_electronic, string archive_hand, string morfag, int loc_id, string al_asl, string arch_doc_subject, int room_id, int cupboard_id)//,Boolean sendto//
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[21];

            param[0] = new SqlParameter("general_id", SqlDbType.Int);
            param[0].Value = general_id;

            param[1] = new SqlParameter("archive_date", SqlDbType.DateTime);
            param[1].Value = archive_date;

            //param[1] = new SqlParameter("receiving_jeha_id2", SqlDbType.VarChar, 50);
            //param[1].Value = receiving_jeha_id2;
            param[2] = new SqlParameter("receiving_jeha_id", SqlDbType.Int);
            param[2].Value = receiving_jeha_id;


            param[3] = new SqlParameter("arch_doc_id", SqlDbType.Int);
            param[3].Value = arch_doc_id;



            //param[3] = new SqlParameter("Send_no", SqlDbType.Int);
            //param[3].Value = Send_no;



            DAL.ExecuteCommand("add_archive", param);
            DAL.Close();
        }





        public void add_archive(int general_id, DateTime archive_date, int doc_id, int special_id, string folder_name,
            int no_shelf, int section_send, int send_employee, int section_recieve, int recieve_employee, string mosul_person,
            string archive_hand, string al_asl, string doc_subject, int room_id,
            int cupboard_id)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@general_id", SqlDbType.Int);
            param[0].Value = general_id;
            param[1] = new SqlParameter("@archive_date", SqlDbType.DateTime);
            param[1].Value = archive_date;
            param[2] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[2].Value = doc_id;
            param[3] = new SqlParameter("@special_id", SqlDbType.Int);
            param[3].Value = special_id;
            param[4] = new SqlParameter("@folder_name", SqlDbType.NVarChar, 250);
            param[4].Value = folder_name;
            param[5] = new SqlParameter("@no_shelf", SqlDbType.Int);
            param[5].Value = no_shelf;
            param[6] = new SqlParameter("@department_send", SqlDbType.Int);
            param[6].Value = section_send;
            param[7] = new SqlParameter("@send_employee", SqlDbType.Int);
            param[7].Value = send_employee;
            param[8] = new SqlParameter("@department_recieve", SqlDbType.Int);
            param[8].Value = section_recieve;
            param[9] = new SqlParameter("@recieve_employee", SqlDbType.Int);
            param[9].Value = recieve_employee;
            param[10] = new SqlParameter("@cary_person", SqlDbType.NVarChar, 250);
            param[10].Value = mosul_person;
            param[11] = new SqlParameter("@archive_hand", SqlDbType.NVarChar, 50);
            param[11].Value = archive_hand;
            param[12] = new SqlParameter("@al_asl", SqlDbType.NVarChar, 50);
            param[12].Value = al_asl;
            param[13] = new SqlParameter("@doc_subject", SqlDbType.NVarChar, 250);
            param[13].Value = doc_subject;
            param[14] = new SqlParameter("@room_id", SqlDbType.Int);
            param[14].Value = room_id;
            param[15] = new SqlParameter("@cupboard_id", SqlDbType.NVarChar, 50);
            param[15].Value = cupboard_id;
            DAL.ExecuteCommand("add_archive", param);
            DAL.Close();
        }

        public void update_archive(int general_id, DateTime archive_date, int doc_id, int special_id, string folder_name,
        int no_shelf, int section_send, int send_employee, int section_recieve, int recieve_employee, string mosul_person,
        string archive_hand, string al_asl, string doc_subject, int room_id,
        int cupboard_id)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[16];
            param[0] = new SqlParameter("@general_id", SqlDbType.Int);
            param[0].Value = general_id;
            param[1] = new SqlParameter("@archive_date", SqlDbType.DateTime);
            param[1].Value = archive_date;
            param[2] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[2].Value = doc_id;
            param[3] = new SqlParameter("@special_id", SqlDbType.Int);
            param[3].Value = special_id;
            param[4] = new SqlParameter("@folder_name", SqlDbType.NVarChar, 250);
            param[4].Value = folder_name;
            param[5] = new SqlParameter("@no_shelf", SqlDbType.Int);
            param[5].Value = no_shelf;
            param[6] = new SqlParameter("@department_send", SqlDbType.Int);
            param[6].Value = section_send;
            param[7] = new SqlParameter("@send_employee", SqlDbType.Int);
            param[7].Value = send_employee;
            param[8] = new SqlParameter("@department_recieve", SqlDbType.Int);
            param[8].Value = section_recieve;
            param[9] = new SqlParameter("@recieve_employee", SqlDbType.Int);
            param[9].Value = recieve_employee;
            param[10] = new SqlParameter("@cary_person", SqlDbType.NVarChar, 250);
            param[10].Value = mosul_person;
            param[11] = new SqlParameter("@archive_hand", SqlDbType.NVarChar, 50);
            param[11].Value = archive_hand;
            param[12] = new SqlParameter("@al_asl", SqlDbType.NVarChar, 50);
            param[12].Value = al_asl;
            param[13] = new SqlParameter("@doc_subject", SqlDbType.NVarChar, 250);
            param[13].Value = doc_subject;
            param[14] = new SqlParameter("@room_id", SqlDbType.Int);
            param[14].Value = room_id;
            param[15] = new SqlParameter("@cupboard_id", SqlDbType.NVarChar, 50);
            param[15].Value = cupboard_id;
            DAL.ExecuteCommand("update_archive", param);
            DAL.Close();
        }
        public void add_archive1(int general_id, DateTime archive_date,
            int hand_doc_id, string folder_name, int no_shelf,
            int section_send,
            int send_employee, int section_recieve, int recieve_employee,
            string mosul_person, string @archive_hand, string morfag,
             string al_asl, string arch_doc_subject, int room_id, int cupboard_id)//,Boolean sendto//
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[20];

            param[0] = new SqlParameter("general_id", SqlDbType.Int);
            param[0].Value = general_id;

            param[1] = new SqlParameter("archive_date", SqlDbType.DateTime);
            param[1].Value = archive_date;

            //param[1] = new SqlParameter("receiving_jeha_id2", SqlDbType.VarChar, 50);
            //param[1].Value = receiving_jeha_id2;



            param[2] = new SqlParameter("hand_doc_id", SqlDbType.Int);
            param[2].Value = hand_doc_id;

            //param[3] = new SqlParameter("Send_no", SqlDbType.Int);
            //param[3].Value = Send_no;
            param[3] = new SqlParameter("folder_name", SqlDbType.VarChar, 50);
            param[3].Value = folder_name;


            param[4] = new SqlParameter("no_shelf", SqlDbType.Int);
            param[4].Value = no_shelf;

            param[5] = new SqlParameter("section_send", SqlDbType.Int);
            param[5].Value = section_send;


            param[6] = new SqlParameter("send_employee", SqlDbType.Int);
            param[6].Value = send_employee;

            param[7] = new SqlParameter("section_recieve", SqlDbType.Int);
            param[7].Value = section_recieve;


            param[8] = new SqlParameter("recieve_employee", SqlDbType.Int);
            param[8].Value = recieve_employee;




            param[9] = new SqlParameter("mosul_person", SqlDbType.VarChar, 50);
            param[9].Value = mosul_person;



            param[10] = new SqlParameter("archive_hand", SqlDbType.VarChar, 50);
            param[10].Value = archive_hand;

            param[11] = new SqlParameter("morfag", SqlDbType.VarChar, 50);
            param[11].Value = morfag;

            //param[15] = new SqlParameter("loc_id", SqlDbType.VarChar, 50);
            //param[15].Value = loc_id;

            param[12] = new SqlParameter("al_asl", SqlDbType.VarChar, 50);
            param[12].Value = al_asl;

            param[13] = new SqlParameter("arch_doc_subject", SqlDbType.VarChar, 50);
            param[13].Value = arch_doc_subject;

            param[14] = new SqlParameter("room_id", SqlDbType.VarChar, 50);
            param[14].Value = room_id;

            param[15] = new SqlParameter("cupboard_id", SqlDbType.VarChar, 50);
            param[15].Value = cupboard_id;



            DAL.ExecuteCommand("add_archive1", param);
            DAL.Close();
        }



        public void add_general_archive(int general_id, DateTime archive_date, int department_id, int User_id, string folder_name)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@general_id", SqlDbType.Int);
            param[0].Value = general_id;

            param[1] = new SqlParameter("@archive_date", SqlDbType.DateTime);
            param[1].Value = archive_date;
            param[2] = new SqlParameter("@department_id", SqlDbType.Int);
            param[2].Value = department_id;
            param[3] = new SqlParameter("@User_id", SqlDbType.Int);
            param[3].Value = User_id;
            param[4] = new SqlParameter("@folder_name", SqlDbType.NVarChar, 150);
            param[4].Value = folder_name;
            DAL.ExecuteCommand("add_general_archive", param);
            DAL.Close();
        }





        public DataTable verifyarchive(string general_id)
        {
            settings.DataAccessLayer f = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[0];
            param[0] = new SqlParameter("@ID", SqlDbType.Int, 50);
            param[0].Value = general_id;

            Dt = f.SelectData("verifyarchive", param);
            f.Close();
            return Dt;
        }
        public DataTable special()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();


            Dt = DAL.SelectData("special", null);
            DAL.Close();
            return Dt;
        }

        public DataTable document_general_archive2()
{
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        DataTable Dt = new DataTable();


        Dt = DAL.SelectData("document_general_archive2", null);
            DAL.Close();
            return Dt;
        }
    public DataTable all_doc()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();


            Dt = DAL.SelectData("all_doc", null);
            DAL.Close();
            return Dt;
        }


        public DataTable search_general_archive(string search)
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            //  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("search_general_archive", param);
            DAL.Close();
            return dt;

            //DAL.dataAccessLayer f = new DAL.dataAccessLayer();
            //DataTable Dt = new DataTable();
            //SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            //param[0].Value = search;

            //Dt = f.SelectData("search_general_archive", param);
            //f.Close();
            //return Dt;
        }

    }
    }




















