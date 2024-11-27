using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBOS_Full_System.BL
{
    class Show
    {
        public DataTable Show_Task(int ID)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            param[0].Value = ID;
            // to return the data 
            DataTable DT = new DataTable();

            DT = DAL.SelectData("Show_Task", param);
            DAL.close();
            return DT;
        }
    }
}
