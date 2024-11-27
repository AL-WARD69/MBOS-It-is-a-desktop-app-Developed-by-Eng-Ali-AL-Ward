
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace MBOS_Full_System.mailing
{
    class add
    {

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

        //public DataTable get_type()
        //{

        //    settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[2];
        //    DAL.Open();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("get_type", null);
        //    DAL.Close();
        //    return dt;
        //}


        //public void add_mailings(int mailing_id,  DateTime send_date,  string m_receiver_name, string mailing_type, string mailing_state, Boolean show
        //   , int mdoc_id , int send_jeha_id , int receiving_jeha_id, int Send_no, int Receiving_no,string send, int send_dept_id, int receiving_dept_id, Boolean archive)//,Boolean sendto//
        //{
        //    settings.DataAccessLayer dal = new settings.DataAccessLayer();
        //    dal.Open();
        //    SqlParameter[] param = new SqlParameter[15];


        //    param[0] = new SqlParameter("mailing_id", SqlDbType.Int);
        //    param[0].Value = mailing_id;



        //    param[1] = new SqlParameter("send_date", SqlDbType.DateTime);
        //    param[1].Value = send_date;

        //    //param[1] = new SqlParameter("receiving_jeha_id2", SqlDbType.VarChar, 50);
        //    //param[1].Value = receiving_jeha_id2;

        //    param[2] = new SqlParameter("m_receiver_name", SqlDbType.VarChar, 20);
        //    param[2].Value = m_receiver_name;

        //    param[3] = new SqlParameter("mailing_type", SqlDbType.VarChar, 20);
        //    param[3].Value = mailing_type;

        //    //param[3] = new SqlParameter("Send_no", SqlDbType.Int);
        //    //param[3].Value = Send_no;

        //    param[4] = new SqlParameter("mailing_state", SqlDbType.VarChar, 20);
        //    param[4].Value = mailing_state;


        //    param[5] = new SqlParameter("show", SqlDbType.Bit);
        //    param[5].Value = show;


        //    param[6] = new SqlParameter(" mdoc_id", SqlDbType.Int);
        //    param[6].Value = mdoc_id;


        //    param[7] = new SqlParameter("send_jeha_id", SqlDbType.Int);
        //    param[7].Value = send_jeha_id;

        //    param[8] = new SqlParameter("receiving_jeha_id", SqlDbType.Int);
        //    param[8].Value = receiving_jeha_id;


        //    param[9] = new SqlParameter("int Send_no", SqlDbType.Int);
        //    param[9].Value =  Send_no;

        //    param[10] = new SqlParameter("Receiving_no", SqlDbType.Int);
        //    param[10].Value = Receiving_no;


        //    param[11] = new SqlParameter("send", SqlDbType.VarChar,20);
        //    param[11].Value = send;

        //    param[12] = new SqlParameter(" send_dept_id", SqlDbType.Int);
        //    param[12].Value = send_dept_id;

        //     param[13] = new SqlParameter(" receiving_dept_id", SqlDbType.Int);
        //    param[13].Value = receiving_dept_id;

        //    param[14] = new SqlParameter("archive", SqlDbType.Bit);
        //    param[14].Value = archive;

        //    dal.ExecuteCommand("add_mailings", param);
        //    dal.Close();
        //}


















        // , Boolean receive_status
        public void add_mailing(int mailing_id, int doc_id, string mailing_type, string m_receiver_name, DateTime send_date, int Receiving_User_id, int Send_User_id, string send_signatute, int receiving_dept_id, int send_dept_id, Boolean show, Boolean archive, string Writingnote, int priority, string send)//,Boolean sendto//
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@mailing_id", SqlDbType.Int);
            param[0].Value = mailing_id;

            param[1] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[1].Value = doc_id;

            //param[1] = new SqlParameter("receiving_jeha_id2", SqlDbType.VarChar, 50);
            //param[1].Value = receiving_jeha_id2;
            param[2] = new SqlParameter("@mailing_type", SqlDbType.NVarChar, 30);
            param[2].Value = mailing_type;


            param[3] = new SqlParameter("@m_receiver_name", SqlDbType.NVarChar, 20);
            param[3].Value = m_receiver_name;

            param[4] = new SqlParameter("@send_date", SqlDbType.DateTime);
            param[4].Value = send_date;

            param[5] = new SqlParameter("@Receiving_User_id", SqlDbType.Int);
            param[5].Value = Receiving_User_id;

            param[6] = new SqlParameter("@Send_User_id", SqlDbType.Int);
            param[6].Value = Send_User_id;


            param[7] = new SqlParameter("@send_signatute", SqlDbType.NText);
            param[7].Value = send_signatute;

            param[8] = new SqlParameter("@receiving_dept_id", SqlDbType.Int);
            param[8].Value = receiving_dept_id;


            param[9] = new SqlParameter("@send_dept_id", SqlDbType.Int);
            param[9].Value = send_dept_id;


            param[10] = new SqlParameter("@show", SqlDbType.Bit);
            param[10].Value = show;


            param[11] = new SqlParameter("@archive", SqlDbType.Bit);
            param[11].Value = archive;

            param[12] = new SqlParameter("@Writingnote", SqlDbType.NText);
            param[12].Value = Writingnote;

            //param[13] = new SqlParameter("receive_status", SqlDbType.Bit);
            //param[13].Value = receive_status;

            param[13] = new SqlParameter("@priority", SqlDbType.Int);
            param[13].Value = priority;

            param[14] = new SqlParameter("@send", SqlDbType.NVarChar, 20);
            param[14].Value = send;

            dal.ExecuteCommand("add_mailing", param);
            dal.Close();
        }
     public void   add_attachmentdocument(String attachment_path ,int doc_id ,string file_name ,int mail_id,int userid)//,Boolean sendto//
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@attachment_path", SqlDbType.NVarChar,1024);
            param[0].Value = attachment_path;

            param[1] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[1].Value = doc_id;

            param[2] = new SqlParameter("@file_name", SqlDbType.NVarChar, 1024);
            param[2].Value = file_name;


            param[3] = new SqlParameter("@mail_id", SqlDbType.Int);
            param[3].Value = mail_id;
            param[4] = new SqlParameter("@userid", SqlDbType.Int);
            param[4].Value = userid;
         dal.ExecuteCommand("add_attachmentdocument", param);
            dal.Close();
        }



        public DataTable display()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("receiving", null);
            DAL.Close();
            return dt;

        }
        public DataTable send(int id )
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("sending", param);
            DAL.Close();
            return dt;

        }
        public DataTable getmaillingid()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
          DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getmaillingid", null);
            DAL.Close();
            return dt;

        }
        //read from database

        //كود البحث
        public DataTable searchtype(string id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = dal.SelectData("m_search", param);

            dal.Close();
            return dt;
        }
        public DataTable searchmailling(int id,string name)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar,250);
            param[1].Value = name;
            dt = dal.SelectData("searchmailling", param);

            dal.Close();
            return dt;
        }
        public DataTable searchmailling22(int id, string name)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;
            dt = dal.SelectData("searchmailling22", param);

            dal.Close();
            return dt;
        }
        public DataTable all_recievemailling (int id,int rdeptid)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
        DataTable dt = new DataTable();
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@id", SqlDbType.Int);
        param[0].Value = id;
            param[1] = new SqlParameter("@rdeptid", SqlDbType.Int);
           param[1].Value = rdeptid;
            dt = dal.SelectData("all_recievemailling", param);

            dal.Close();
            return dt;
        }

        public DataTable all_recievemaillinguser(int id, int rdeptid)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@rdeptid", SqlDbType.Int);
            param[1].Value = rdeptid;
            dt = dal.SelectData("all_recievemaillinguser", param);

            dal.Close();
            return dt;
        }
        public DataTable maillingarchive(int id)
        {

            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.SelectData("maillingarchive", param);

            dal.Close();
            return dt;
        }

        public void updatemaillingarchive(int id)
        {

            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
             dal.ExecuteCommand("updatemaillingarchive", param);

            dal.Close();
          
        }
        public DataTable displaymailling22(int id)
        {

            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.SelectData("displaymailling22", param);

            dal.Close();
            return dt;
        }
        public DataTable all_recievemailling1(int id, int rdeptid,string name)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@rdeptid", SqlDbType.Int);
            param[1].Value = rdeptid;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar,200);
            param[1].Value = name;
            dt = dal.SelectData("all_recievemailling1", param);

            dal.Close();
            return dt;
        }
        public DataTable all_recievemaillinguser1(int id, int rdeptid, string name)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@rdeptid", SqlDbType.Int);
            param[1].Value = rdeptid;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 200);
            param[1].Value = name;
            dt = dal.SelectData("all_recievemaillinguser1", param);

            dal.Close();
            return dt;
        }

        public DataTable all_sendingmaillinguser1(int id, int deptid, string name)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@deptid", SqlDbType.Int);
            param[1].Value = deptid;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 200);
            param[1].Value = name;
            dt = dal.SelectData("all_sendingmaillinguser1", param);

            dal.Close();
            return dt;
        }

        public DataTable all_sendingmaillinguser(int id, int deptid)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@deptid", SqlDbType.Int);
            param[1].Value = deptid;
            dt = dal.SelectData("all_sendingmaillinguser", param);

            dal.Close();
            return dt;
        }
        public DataTable displaymailling(int id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.SelectData("displaymailling", param);
            dal.Close();
            return dt;
        }
        public DataTable GET_userdata(int id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.SelectData("GET_userdata", param);
            dal.Close();
            return dt;
        }

        public DataTable getdept_document(int id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.SelectData("getdept_document", param);
            dal.Close();
            return dt;
        }

        public DataTable getuser_senddocument(int docid ,int deptid ,int userid )
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
        DataTable dt = new DataTable();
        SqlParameter[] param = new SqlParameter[3];
        param[0] = new SqlParameter("@docid", SqlDbType.Int);
        param[0].Value = docid;
            param[1] = new SqlParameter("@deptid", SqlDbType.Int);
            param[1].Value = deptid;
            param[2] = new SqlParameter("@userid", SqlDbType.Int);
            param[2].Value = userid;
            dt = dal.SelectData("getuser_senddocument", param);
            dal.Close();
            return dt;
        }

        public DataTable getsenddocumentinsignature(int docid ,int suserid ,int sdeptid ,int ruserid,int rdeptid)
            {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
        DataTable dt = new DataTable();
        SqlParameter[] param = new SqlParameter[5];
       param[0] = new SqlParameter("@docid", SqlDbType.Int);
       param[0].Value = docid;
       param[1] = new SqlParameter("@suserid", SqlDbType.Int);
       param[1].Value = suserid;
       param[2] = new SqlParameter("@sdeptid", SqlDbType.Int);
       param[2].Value = sdeptid;
       param[3] = new SqlParameter("@ruserid", SqlDbType.Int);
       param[3].Value = ruserid;
       param[4] = new SqlParameter("@rdeptid", SqlDbType.Int);
       param[4].Value = rdeptid;
      dt = dal.SelectData("getsenddocumentinsignature", param);
            dal.Close();
            return dt;
        }
    public DataTable searchtype2(string id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = dal.SelectData("m2_search", param);
            dal.Close();
            return dt;
        }


        public void DEL(string id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dal.ExecuteCommand("DEL", param);
            dal.Close();
        }
    }
}
