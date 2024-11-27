using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBOS_Full_System.BL
{
    class Assign_Task
    {
        public DataTable Users()
        {
            BL.Show_Class Dept=new BL.Show_Class();
            int dep_id = Dept.Get_Dept_Id();
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@dept_id", SqlDbType.Int, 50);
            parem[0].Value = dep_id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Users", parem);
            DAL.close();
            return DT;
        }
        public DataTable Departments(int parent_id)
        {
           SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@parent_id", SqlDbType.Int, 50);
            parem[0].Value = parent_id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Departments",parem);
            DAL.close();
            return DT;
        }


    }
}
