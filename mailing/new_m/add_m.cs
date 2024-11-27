
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace MBOS_Full_System.new_m
{
    class add_m
    {

        //public DataTable get_doc()
        //{

        //    settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[2];
        //    DAL.Open();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("get_doc", null);
        //    DAL.Close();
        //    return dt;
        //}

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

        public DataTable get_type()
        {

            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_type", null);
            DAL.Close();
            return dt;
        }
       


        public void add_mailing(int mailing_id,int m_no, int send_jeha_id, int receiving_jeha_id, string mailing_type, string mailing_state, string note, string m_receiver_name)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];

            
            param[0] = new SqlParameter("note", SqlDbType.Text);
            param[0].Value = note;

            param[1] = new SqlParameter("mailing_state", SqlDbType.VarChar, 50);
            param[1].Value = mailing_state;

            param[2] = new SqlParameter("mailing_type", SqlDbType.VarChar, 50);
            param[2].Value = mailing_type;


            param[3] = new SqlParameter("m_no", SqlDbType.Int);
            param[3].Value = m_no;

            param[4] = new SqlParameter("send_jeha_id", SqlDbType.Int);
            param[4].Value = send_jeha_id;

            param[5] = new SqlParameter("receiving_jeha_id", SqlDbType.Int);
            param[5].Value = receiving_jeha_id;

            param[6] = new SqlParameter("mailing_id", SqlDbType.Int);
            param[6].Value = mailing_id;


            //param[6] = new SqlParameter("send_date", SqlDbType.DateTime);
            //param[6].Value = send_date;

            param[7] = new SqlParameter("m_receiver_name", SqlDbType.VarChar, 50);
            param[7].Value = m_receiver_name;

            
            dal.ExecuteCommand("add_mailing", param);
            dal.Close();
        }
        public void add_doc(int doc_id, string secure_doc, string doc_subject, int doc_type_id)
        {

            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("doc_subject", SqlDbType.VarChar, 100);
            param[0].Value = doc_subject;

            param[1] = new SqlParameter("secure_doc", SqlDbType.VarChar, 10);
            param[1].Value = doc_subject;

            param[2] = new SqlParameter("doc_id", SqlDbType.Int);
            param[2].Value = doc_id;

            //param[3] = new SqlParameter("doc_date", SqlDbType.DateTime);
            //param[3].Value = doc_date;

            param[3] = new SqlParameter("doc_type_id", SqlDbType.Int);
            param[3].Value = doc_type_id;

            dal.ExecuteCommand("add_document", param);
            dal.Close();
        }
        public void add_document(int doc_id, string secure_doc, string doc_subject, int doc_type_id)
        {
            
        }

        //public DataTable display()
        //{

        //    settings.DataAccessLayer DAL = new settings.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[2];
        //    DAL.Open();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("get_mailing", null);
        //    DAL.Close();
        //    return dt;

        //}


        //read from database
       
        //كود البحث
        //public DataTable searchtype(string id)
        //{
        //    DataAccessLayer dal = new DataAccessLayer();
        //    DataTable dt = new DataTable();
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
        //    param[0].Value = id;
        //    dt = dal.SelectData("SSS", param);
        //    dal.Close();
        //    return dt;


        //}
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
