using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MBOS_Full_System.document
{
    class CLS_decuments
    {
         public DataTable GET_ALL_TYPE()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_TYPE", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Get_ALL_Decument()
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_ALL_Decument" ,null);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchDocuments(string ID)
        {
            settings.DataAccessLayer DAL = new settings.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("SearchDocuments", param);
            DAL.Close();
            return Dt;
        } 
       
    
    }
}
