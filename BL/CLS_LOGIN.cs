using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBOS_Full_System.BL
{
    class CLS_LOGIN
    {
        // method to exexcute the stored procdeure log_in 
        public DataTable LOGIN(int Jop_ID, string PAWORD)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Jop_ID", SqlDbType.Int, 50);
            param[0].Value = Jop_ID;


            param[1] = new SqlParameter("@PAWORD", SqlDbType.VarChar, 50);
            param[1].Value = PAWORD;
            // NO NEED TO OPEN DATABASE BECAUSE SQL DATA ADAPTER WILL OPEN IT 
            // DAL.open();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("LOGIN", param);
            DAL.close();
            return DT;

        }
    }
}
