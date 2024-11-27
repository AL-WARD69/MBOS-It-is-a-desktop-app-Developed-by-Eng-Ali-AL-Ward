using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MBOS_Full_System.BL
{
    class ChartData
    {

        public DataTable getChart(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GetTaskanduser_chart2", parem);
            DAL.close();
            return DT;
        }
        public DataTable get_establishedDept_task(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("established_dept_task", parem);
            DAL.close();
            return DT;
        }
      
            public DataTable get_in_implemenation_task(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("inimplemnation_dept_task", parem);
            DAL.close();
            return DT;
        }
            
            public DataTable get_non_implemenation_task(int id)
            {
                SqlParameter[] parem = new SqlParameter[1];
                parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
                parem[0].Value = id;
                // object of data accss layer 
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

                // to return the data 
                DataTable DT = new DataTable();
                DT = DAL.SelectData("non_esatablished_task", parem);
                DAL.close();
                return DT;
            }
        public DataTable get_all_dept()
        {
        //    SqlParameter[] parem = new SqlParameter[1];
        //    parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
        //    parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_DEPARTMENTS", null);
            DAL.close();
            return DT;
        }
             public DataTable get_task_type(int id ,string task_type)
        {
            SqlParameter[] parem = new SqlParameter[2];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            parem[1] = new SqlParameter("@task_type", SqlDbType.VarChar, 50);
            parem[1].Value = task_type;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("get_taskType_chart", parem);
            DAL.close();
            return DT;
             }
    }
}

