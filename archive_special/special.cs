using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace MBOS_Full_System.archive_special
{
    class special
    {
        public static DataTable dt;
        public DataTable get_user_name()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_user_name", null);
            DAL.Close();
            return dt;
        }


        public DataTable getdocmailling()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("getdocmailling", null);
            DAL.Close();
            return dt;
        }

        public DataTable get_folder_special()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_folder_special", null);
            DAL.Close();
            return dt;
        }


        public DataTable get_deptdoc(int id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = dal.SelectData("get_deptdoc", param);
            dal.Close();
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
        public DataTable get_folderspecial(int id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = dal.SelectData("get_folderspecial", param);
            dal.Close();
            return dt;
        }
        public DataTable findmaillingspecialarchive_hand(string id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 250);
            param[0].Value = id;
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = dal.SelectData("findmaillingspecialarchive_hand", param);
            dal.Close();
            return dt;
        }
        public DataTable findspecialarchive_hand(string id)
        {
            settings.DataAccessLayer dal = new settings.DataAccessLayer();
        dal.Open();
            SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("@id", SqlDbType.NVarChar,250);
        param[0].Value = id;
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
        dt = dal.SelectData("findspecialarchive_hand", param);
            dal.Close();
            return dt;
        }
    public DataTable get_specialarchiveandlocations()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_specialarchiveandlocations", null);
            DAL.Close();
            return dt;

        }
        
 public DataTable specialarchive_hand()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("specialarchive_hand", null);
            DAL.Close();
            return dt;

        }
        public DataTable specialno_specialcupboard_idshelf()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("specialcupboard_id", null);
            DAL.Close();
            return dt;

        }
        public DataTable specialno_shelf()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("specialno_shelf", null);
            DAL.Close();
            return dt;

        }
        public DataTable specialroom()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("specialroom", null);
            DAL.Close();
            return dt;

        }
        public DataTable get_locationsid()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_locationsid", null);
            DAL.Close();
            return dt;
        }
        public DataTable get_specialarchivedid()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            dt = new DataTable();//  الاجراء المخزن يعيد بيانات لذلك نعرف من داتا تيبل 
            dt = DAL.SelectData("get_specialarchivedid", null);
            DAL.Close();
            return dt;
        }
        public void add_specail_mailing(int m_special_id, int s_mailing_id) {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@m_special_id", SqlDbType.Int);
            param[0].Value = m_special_id;

            param[1] = new SqlParameter("@s_mailing_id", SqlDbType.Int);
            param[1].Value = s_mailing_id;
            DAL.ExecuteCommand("add_specail_mailing", param);
            DAL.Close();
        }

        public void add_special_locations(int location_id, string folder_name, int special_id, int department_id)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@location_id", SqlDbType.Int);
            param[0].Value = location_id;

            param[1] = new SqlParameter("@folder_name", SqlDbType.NVarChar, 1024);
            param[1].Value = folder_name;
            param[2] = new SqlParameter("@special_id", SqlDbType.Int);
            param[2].Value = special_id;
            param[3] = new SqlParameter("@department_id", SqlDbType.Int);
            param[3].Value = department_id;
            DAL.ExecuteCommand("add_special_locations", param);
            DAL.Close();
        }
        public void updatedata_special_Archive(int doc_id, int special_id, int no_shelf, int room_id, int cupboard_id)
        {  settings.DataAccessLayer DAL = new settings.DataAccessLayer();
             DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@special_id", SqlDbType.Int);
            param[1].Value = special_id;
            param[2] = new SqlParameter("@no_shelf", SqlDbType.Int);
            param[2].Value = no_shelf;
            param[3] = new SqlParameter("@room_id", SqlDbType.Int);
            param[3].Value = room_id;
            param[4] = new SqlParameter("@cupboard_id", SqlDbType.Int);
            param[4].Value = cupboard_id;
            DAL.ExecuteCommand("updatedata_special_Archive", param);
            DAL.Close();}

        public void send_to_general_special_Archive(int doc_id, int special_id)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[0].Value = doc_id;
            param[1] = new SqlParameter("@special_id", SqlDbType.Int);
            param[1].Value = special_id;
           
            DAL.ExecuteCommand("send_to_general_special_Archive", param);
            DAL.Close();
        }

        public void delete_data_special_Archive(int special_id, int doc_id)
        //  @general_id int,@doc_id int
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@special_id", SqlDbType.Int);
            param[0].Value = special_id;

            param[1] = new SqlParameter("@doc_id ", SqlDbType.Int);
            param[1].Value = doc_id;
            DAL.ExecuteCommand("delete_data_special_Archive", param);
            DAL.Close();
        }

        public void add_special_Archive(int special_id, int department_id, int employee_id)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@special_id", SqlDbType.Int);
            param[0].Value = special_id;

            param[1] = new SqlParameter("@department_id", SqlDbType.Int);
            param[1].Value = department_id;
            param[2] = new SqlParameter("@employee_id", SqlDbType.Int);
            param[2].Value = employee_id;
           DAL.ExecuteCommand("add_special_Archive", param);
            DAL.Close();
        }
//@special_id int ,@department_id int,@employee_id int

 public void add_data_special_Archive(int special_id ,int no_shelf , string sub,string folder_name,int management_id ,int room_id ,int cupboard_id ,
     string  archive_hand,string al_asl ,int doc_id ,string morfag  )
        {
             settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@special_id", SqlDbType.Int);
            param[0].Value = special_id;

            param[1] = new SqlParameter("@no_shelf", SqlDbType.Int);
            param[1].Value = no_shelf;
            param[2] = new SqlParameter("@sub", SqlDbType.NVarChar, 250);
            param[2].Value = sub;
            param[3] = new SqlParameter("@folder_name", SqlDbType.NVarChar, 1024);
            param[3].Value = folder_name;
            param[4] = new SqlParameter("@management_id", SqlDbType.Int);
            param[4].Value = management_id;

            param[5] = new SqlParameter("@room_id ", SqlDbType.Int);
            param[5].Value = room_id;
            param[6] = new SqlParameter("@cupboard_id ", SqlDbType.Int);
            param[6].Value = cupboard_id;
            param[7] = new SqlParameter("@archive_hand", SqlDbType.NVarChar ,50);
            param[7].Value = archive_hand;

            param[8] = new SqlParameter("@al_asl", SqlDbType.NVarChar,50);
            param[8].Value = al_asl;

            param[9] = new SqlParameter("@doc_id", SqlDbType.Int);
            param[9].Value = doc_id;

            param[10] = new SqlParameter("@morfag", SqlDbType.NVarChar, 50);
            param[10].Value = morfag;

           
            DAL.ExecuteCommand("add_data_special_Archive", param);
            DAL.Close();



        }


    }
}
