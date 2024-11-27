using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBOS_Full_System.BL
{
    class Show_Class
    {
        public DataTable Show_Task(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Show_Task", parem);
            DAL.close();
            return DT;
        }
        public bool Is_Dept_Assignee(int Task_Id)
        {
            bool State=false;
            int dept_id = Get_Dept_Id();
            SqlParameter[] parem = new SqlParameter[2];
            parem[0] = new SqlParameter("@task_id", SqlDbType.Int);
            parem[0].Value = Task_Id;
            parem[1] = new SqlParameter("@dept_id", SqlDbType.Int);
            parem[1].Value = dept_id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Is_Dept_Assignee", parem);
            if (Dt.Rows.Count > 0)
            {
                State = true;
            }
            DAL.close();
            return State;
        }
        public bool Is_Dept_Assuer(int Task_Id)
        {
            bool State = false;
            int dept_id = Get_Dept_Id();
            SqlParameter[] parem = new SqlParameter[2];
            parem[0] = new SqlParameter("@task_id", SqlDbType.Int);
            parem[0].Value = Task_Id;
            parem[1] = new SqlParameter("@dept_id", SqlDbType.Int);
            parem[1].Value = dept_id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Is_Dept_Assuer", parem);
            if (Dt.Rows.Count > 0)
            {
                State = true;
            }
            DAL.close();
            return State;
        }
        public string Check_Type(int task_id)
        {
            string user_task_type;
            BL.Show_Class check = new BL.Show_Class();
            if (check.Get_Dept_Id() != 0)
            {
                if (check.Is_Dept_Assignee(task_id))
                {
                    user_task_type = "assignee";
                }
                else if (check.Is_Dept_Assuer(task_id))
                {
                    user_task_type = "assuer";
                }
                else
                {
                    user_task_type = "parent";
                }
            }
            else
            {
                user_task_type = "assignee";
            }
            return user_task_type;
        }
        public DataTable Users()
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Users", null);
            DAL.close();
            return DT;
        }
        public DataTable Show_Task_Emp(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Show_Task_Emp", parem);
            DAL.close();
            return DT;
        }
        public DataTable Show_Task_Dept(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Show_Task_Dept", parem);
            DAL.close();
            return DT;
        }
        public DataTable Show_Assigend_User_Tasks(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Show_Assigend_User_Tasks", parem);
            DAL.close();
            return DT;
        }
        public DataTable Show_Assigend_Dept_Tasks(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Show_Assigend_Dept_Tasks", parem);
            DAL.close();
            return DT;
        }
        
        public DataTable Show_Assuers_Tasks(int id)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@id", SqlDbType.Int, 50);
            parem[0].Value = id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Show_Assuers_Tasks", parem);
            DAL.close();
            return DT;
        }
        public DataTable Get_User_Info(int Jop_ID)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Jop_ID", SqlDbType.Int, 50);
            parem[0].Value = Jop_ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_User_Info", parem);
            return DT;
        }
        public DataTable Get_User_Info_By_Id(int ID)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            parem[0].Value = ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_User_Info_By_Id", parem);
            return DT;
        }
        public DataTable Get_User_Roles(int Jop_ID)
        {
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Jop_ID", SqlDbType.Int, 50);
            parem[0].Value = Jop_ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_User_Roles", parem);
            return DT;
        }
        public int Get_User_Id()
        {
            int id;
            int Jop_ID = Program.Jop_ID;
            //Properties.Settings.Default["User"].ToString();
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Jop_ID", SqlDbType.Int, 50);
            parem[0].Value = Jop_ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_User_Id", parem);
            DAL.close();
            if (DT.Rows.Count > 0)
            {

                 id = Convert.ToInt32(DT.Rows[0][0].ToString());
            }
            else
            {
                id = 0;
            }
            return id;
        }
        public int Get_User_Id(int Jop_Id)
        {
            int id;
            int Jop_ID = Jop_Id;
            //Properties.Settings.Default["User"].ToString();
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Jop_ID", SqlDbType.Int, 50);
            parem[0].Value = Jop_ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_User_Id", parem);
            DAL.close();
            if (DT.Rows.Count > 0)
            {

                id = Convert.ToInt32(DT.Rows[0][0].ToString());
            }
            else
            {
                id = 0;
            }
            return id;
        }
        public int Get_Dept_Id()
        {
            int id;
            int User_ID = Get_User_Id();
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Manager_Id", SqlDbType.Int, 50);
            parem[0].Value = User_ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Id", parem);
            DAL.close();
            if (DT.Rows.Count > 0)
            {
                 id = Convert.ToInt32(DT.Rows[0][0].ToString());
            }
            else
            {
                id = 0;
            }
           
            return id;
        }
        public DataTable Get_Dept_Name()
        {
            int User_ID = Get_User_Id();
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Manager_Id", SqlDbType.Int, 50);
            parem[0].Value = User_ID;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Name", parem);
            DAL.close();
            return DT;
        }
        public DataTable Get_Roles()
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Roles", null);
            DAL.close();
            return DT;
        }
        public DataTable Get_Forms()
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Forms", null);
            DAL.close();
            return DT;
        }
        public DataTable Get_Controls(int role_id,int form_id)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            SqlParameter[] parem = new SqlParameter[2];
            parem[0] = new SqlParameter("@form_id", SqlDbType.Int);
            parem[0].Value = form_id;
            parem[1] = new SqlParameter("@role_id", SqlDbType.Int);
            parem[1].Value = role_id;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Controls", parem);
            DAL.close();
            return DT;
        }
        public int Get_Dept_Level()
        {
            int Dept_Id = Get_Dept_Id();
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Dept_Id", SqlDbType.Int, 50);
            parem[0].Value = Dept_Id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Level", parem);
            DAL.close();
            int id = Convert.ToInt32(DT.Rows[0][0].ToString());
            return id;
        }
        public int Get_Task_Level(int task_id)
        {
            
            SqlParameter[] parem = new SqlParameter[1];
            parem[0] = new SqlParameter("@Task_Id", SqlDbType.Int, 50);
            parem[0].Value = task_id;
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Task_Level", parem);
            DAL.close();
            int id = Convert.ToInt32(DT.Rows[0][0].ToString());
            return id;
        }
        public DataTable Get_UserComment(int task_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.NVarChar, 191);
            param[0].Value = task_id;

            // param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            // param[1].Value = show.Get_User_Id();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("get_comment", param);
            DAL.close();
            return DT;

        }
        public DataTable Get_TasKexpense(int task_id)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 191);
            param[0].Value = task_id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("getTask_expense", param);
            DAL.close();
            return DT;


        }
        public DataTable Fill_TaskExpense(int task_id)
        {
            // BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 191);
            param[0].Value = task_id;

            // param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            // param[1].Value = show.Get_User_Id();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("fill_TaskExpense", param);
            DAL.close();
            return DT;

        }
        public DataTable Get_TaskStep(int task_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.NVarChar, 191);
            param[0].Value = task_id;

            // param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            // param[1].Value = show.Get_User_Id();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("get_task_step", param);
            DAL.close();
            return DT;

        }

        public DataTable Get_ReportTaskExecute(int task_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_ReportTaskExecute", param);
            DAL.close();
            return DT;

        }

        public DataTable Get_SubTask_Childs(int task_parent_id, int dept_id)
        { 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            ///////////////////////////////////////
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@task_parent_id", SqlDbType.Int);
            param[0].Value = task_parent_id;
            param[1] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[1].Value = dept_id;
            ////////////////////////////////////
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_SubTask_Childs", param);
            DAL.close();
            return DT;

        }
        public DataTable Get_Task_Childs(int parent_id)
        { 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parent_id", SqlDbType.NVarChar, 191);
            param[0].Value = parent_id;

            // param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            // param[1].Value = show.Get_User_Id();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Task_Childs", param);
            DAL.close();
            return DT;

        }
        public int Get_Sum_Task_Childs_Wheight(int task_parent_id, int dept_id)
        {
            int sum_wheight = 0;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            ////////////////////////////////////////
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@task_parent_id", SqlDbType.Int);
            param[0].Value = task_parent_id;
            param[1] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[1].Value = dept_id;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Sum_Task_Childs_Wheight", param);
            if (DT.Rows[0][0].ToString() != "")
            {
                sum_wheight=Convert.ToInt32(DT.Rows[0][0].ToString());
            }
            DAL.close();
            return sum_wheight;
        }

        public DataTable Get_Task_Attachemnt(int task_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.NVarChar, 191);
            param[0].Value = task_id;

            // param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            // param[1].Value = show.Get_User_Id();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Task_Attachemnt ", param);
            DAL.close();
            return DT;
            //Get_Task_Attachemnt 
            //get_doc_data
        }
        public DataTable get_doc_data(int doc_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@doc_id", SqlDbType.Int, 50);
            param[0].Value = doc_id;

            // param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            // param[1].Value = show.Get_User_Id();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("get_doc_data ", param);
            DAL.close();
            return DT;
            //Get_Task_Attachemnt 
            //get_doc_data
        }
        public DataTable Get_Dept_Notify(int dept_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            ///////////////////////////
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dept_id", SqlDbType.NVarChar, 191);
            param[0].Value = dept_id;
            ////////////////////////////
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Notify", param);
            DAL.close();
            return DT;

        }
       
        /// <summary>
        /// chartControl_procedure
        /// </summary>
        /// <returns></returns>
        public DataTable show_chart_task_user()
        {

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = dal.SelectData("GetTaskanduser_chart1", null);
            dal.close();
            return DT;

        }
        public DataTable GetTask_andDept_asigned()
        {

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = dal.SelectData("GetTask_and_assigeneddept", null);
            dal.close();
            return DT;

        }
        public DataTable assuer_department()
        {

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = dal.SelectData("assuer_department", null);
            dal.close();
            return DT;

        }



        public DataTable Get_Hidden_Control(int role_id, int form_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            ///////////////////////////
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@role_id", SqlDbType.Int);
            param[0].Value = role_id;
            param[1] = new SqlParameter("@form_id", SqlDbType.Int);
            param[1].Value = form_id;
            ////////////////////////////
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Hidden_Control", param);
            DAL.close();
            return DT;   
        }
        public DataTable Get_Disabled_Control(int role_id, int form_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            ///////////////////////////
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@role_id", SqlDbType.Int);
            param[0].Value = role_id;
            param[1] = new SqlParameter("@form_id", SqlDbType.Int);
            param[1].Value = form_id;
            ////////////////////////////
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Disabled_Control", param);
            DAL.close();
            return DT;   
        }
        public int Get_Form_Id_By_Name(string FormName)
        {
            int form_id=0;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            ///////////////////////////
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@FormName", SqlDbType.NVarChar,50);
            param[0].Value = FormName;
           
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Form_Id_By_Name", param);
            if (DT.Rows.Count > 0)
            {
                form_id = Convert.ToInt32(DT.Rows[0][0].ToString());
            }
            DAL.close();
            return form_id;
        }
        public DataTable Get_Managers(int Manager_id)
        {
            DataTable DT = new DataTable();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Manager_id", SqlDbType.Int);
            param[0].Value = Manager_id;
            DT = DAL.SelectData("Get_Managers", param);
            DAL.close();
            return DT;
        }
        /////////////////////////////////////////////////
        public DataTable GetLastComment()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dt = dal.SelectData("LastFourComment", null);
            return dt;
        }

        public DataTable GetUnLimetedTaskExecution()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dt = dal.SelectData("UnLimitedTaskExcution", null);
            return dt;
        }

        public DataTable GetTaskReportDetailForDept(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("TaskReportDetailForDept", param);

            return dt;
        }

        public DataTable GetTaskReportDetailForUser(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("TaskReportDetailForUser", param);

            return dt;
        }

        public DataTable GetAssureTask(int taskId, int assureId)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@taskID", SqlDbType.Int);
            param[0].Value = taskId;

            param[1] = new SqlParameter("@AssureID", SqlDbType.Int);
            param[1].Value = assureId;

            dt = dal.SelectData("GetAssureTask", param);

            return dt;
        }

        public DataTable GetLastComment(int dep_id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dep_id", SqlDbType.Int);
            param[0].Value = dep_id;
            dt = dal.SelectData("LastFourComment", param);
            return dt;
        }


        public DataTable LastFourUserComment(int user_id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;
            dt = dal.SelectData("LastFourUserComment", param);
            return dt;
        }

        //public DataTable GetUnLimetedTaskExecution()
        //{
        //    DataTable dt = new DataTable();
        //    DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //    dt = dal.SelectData("UnLimitedTaskExcution", null);
        //    return dt;
        //}

    }
}
