using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MBOS_Full_System.BL
{
    class ShowReport
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable deptGetReportWithPirod(DateTime datFrom, DateTime datTo, int deptId)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@dateFrom", SqlDbType.Date);
            param[0].Value = datFrom;

            param[1] = new SqlParameter("@dateTo", SqlDbType.Date);
            param[1].Value = datTo;

            param[2] = new SqlParameter("@deptID", SqlDbType.Int);
            param[2].Value = deptId;

            DataTable dt = new DataTable();
            dt = dal.SelectData("DEPARTMENT_REPORT_WITH_PIROD", param);
            dal.close();

            return dt;
        }

        public DataTable deptGetReport(int deptId)
        {
            SqlParameter[] param = new SqlParameter[1];
     
            param[0] = new SqlParameter("@deptID", SqlDbType.Int);
            param[0].Value = deptId;

            DataTable dt = new DataTable();
            dt = dal.SelectData("DEPARTMENT_REPORT", param);
            dal.close();

            return dt;
        }

        public DataTable UserGetReport(int deptId)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@userID", SqlDbType.Int);
            param[0].Value = deptId;

            DataTable dt = new DataTable();
            dt = dal.SelectData("USER_REPORT", param);
            dal.close();

            return dt;
        }

        public DataTable UserGetReportWithPirode(int deptId, DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@userID", SqlDbType.Int);
            param[0].Value = deptId;

            param[1] = new SqlParameter("@from", SqlDbType.Date);
            param[1].Value = from;

            param[2] = new SqlParameter("@to", SqlDbType.Date);
            param[2].Value = to;

            DataTable dt = new DataTable();
            dt = dal.SelectData("USER_REPORT_WITH_PIRODE", param);
            dal.close();

            return dt;
        }

        public DataTable GET_DEPARTMENTS_NAME(int level)
        {
            // object of data accss layer 
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@deptLevel", SqlDbType.Int);
            param[0].Value = level;
            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("GET_ALL_DEPARTMENTS_NAME", param);
            dal.close();
            return DT;

        }

        public DataTable GET_ALL_USERS_NAME()
        {
            // object of data accss layer 

            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("GET_ALL_USER_NAME", null);
            dal.close();
            return DT;

        }

        //return task priorty report
        public DataTable TASK_PRIORTY_REPORT(string Priorty)
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@priority", SqlDbType.VarChar,50);
            param[0].Value = Priorty;
            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_PRIORITY_REPORT", param);
            dal.close();
            return DT;

        }

        //public DataTable taskPirodeReport(DateTime datFrom, DateTime datTo)
        //{
        //    SqlParameter[] param = new SqlParameter[2];
        //    param[0] = new SqlParameter("@dateFrom", SqlDbType.Date);
        //    param[0].Value = datFrom;

        //    param[1] = new SqlParameter("@dateTo", SqlDbType.Date);
        //    param[1].Value = datTo;

        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("TASK_REPORT_WITH_PIRODE", param);
        //    dal.close();

        //    return dt;
        //}

        public DataTable TaskProgressReport(float progress)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@progress", SqlDbType.Float);
            param[0].Value = progress;
            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_PROGRESS_REPORT", param);
            dal.close();
            return DT;

        }

        //return task priorty report with pirode
        public DataTable TASK_PRIORTY_REPORT_WITH_PIRODE(string Priorty, DateTime from, DateTime to)
        {

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@priority", SqlDbType.VarChar, 50);
            param[0].Value = Priorty;

            param[1] = new SqlParameter("@dateFrom", SqlDbType.Date);
            param[1].Value = from;

            param[2] = new SqlParameter("@dateTo", SqlDbType.Date);
            param[2].Value = to;

            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_PRIORITY_REPORT_WITH_PIRODE", param);
            dal.close();
            return DT;

        }

        //return task progress report with pirode
        public DataTable TaskProgressReportWithPirode(float progress, DateTime from, DateTime to)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@progress", SqlDbType.Float);
            param[0].Value = progress;

            param[1] = new SqlParameter("@dateFrom", SqlDbType.Date);
            param[1].Value = from;

            param[2] = new SqlParameter("@dateTo", SqlDbType.Date);
            param[2].Value = to;

            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_PROGRESS_REPORT_WITH_PIRODE", param);
            dal.close();
            return DT;

        }

        //return task type report
        public DataTable TASK_TYPE_REPORT(string type)
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Type", SqlDbType.VarChar, 50);
            param[0].Value = type;
            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_TYPE_REPORT", param);
            dal.close();
            return DT;

        }

        public DataTable TASK_TYPE_REPORT_WITH_PIRODE(string type, DateTime from, DateTime to)
        {

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TYPE", SqlDbType.VarChar, 50);
            param[0].Value = type;

            param[1] = new SqlParameter("@dateFrom", SqlDbType.Date);
            param[1].Value = from;

            param[2] = new SqlParameter("@dateTo", SqlDbType.Date);
            param[2].Value = to;

            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_TYPE_REPORT_WITH_PIRODE", param);
            dal.close();
            return DT;
        }

        //return task state report
        public DataTable TASK_STATE_REPORT(string state)
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@State", SqlDbType.VarChar, 50);
            param[0].Value = state;
            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_STATE_REPORT", param);
            dal.close();
            return DT;
        }

        public DataTable TASK_STATE_REPORT_WITH_PIRODE(string state, DateTime from, DateTime to)
        {

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@State", SqlDbType.VarChar, 50);
            param[0].Value = state;

            param[1] = new SqlParameter("@dateFrom", SqlDbType.Date);
            param[1].Value = from;

            param[2] = new SqlParameter("@dateTo", SqlDbType.Date);
            param[2].Value = to;

            // to return the data 
            DataTable DT = new DataTable();
            DT = dal.SelectData("TASK_STATE_REPORT_WITH_PIRODE", param);
            dal.close();
            return DT;
        }

        
    }
}
