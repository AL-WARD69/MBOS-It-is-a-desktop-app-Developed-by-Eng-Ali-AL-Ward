using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MBOS_Full_System.BL
{
    class ADD
    {
        public DataTable Get_Dept()
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            BL.Show_Class dept = new Show_Class();
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept", null);
            DAL.close();
            return DT;
        }
        public void Update_Task_Wheight(int task_id,int wheight)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            ////////////////////////////////////////////////////////////
            param[0] = new SqlParameter("@task_id", SqlDbType.Int);
            param[0].Value = task_id;
            param[1] = new SqlParameter("@wheight", SqlDbType.Int);
            param[1].Value = wheight;
            /////////////////////////////////////////////////////
            DAL.ExecuteCommand("Update_Task_Wheight", param);
            DAL.close();
        }
        
        public void Add_Form(string FormName,string FormText,string FormFullName)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            ////////////////////////////////////////////////////////////
            param[0] = new SqlParameter("@FormName", SqlDbType.VarChar, 50);
            param[0].Value = FormName;
            param[1] = new SqlParameter("@FormText", SqlDbType.VarChar, 50);
            param[1].Value = FormText;
            param[2] = new SqlParameter("@FormFullName", SqlDbType.VarChar, 50);
            param[2].Value = FormFullName;
            /////////////////////////////////////////////////////
            DAL.ExecuteCommand("Add_Form", param);
            DAL.close();
        }
        public int Get_Form_Id(string FormFullName)
        {

            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            //////////////////////////////////////////////////
            param[0] = new SqlParameter("@FormFullName", SqlDbType.VarChar, 50);
            param[0].Value = FormFullName;
            // to return the data 
            ///////////////////////////////////////
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Form_Id", param);
            DAL.close();
            return Convert.ToInt32(DT.Rows[0][0].ToString());
        }
        public void Add_Control(int FormID, string ControlText, string ControlName)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            ////////////////////////////////////////////////////////////
            param[0] = new SqlParameter("@FormID", SqlDbType.Int, 50);
            param[0].Value = FormID;
            param[1] = new SqlParameter("@ControlText", SqlDbType.VarChar, 50);
            param[1].Value = ControlText;
            param[2] = new SqlParameter("@ControlName", SqlDbType.VarChar, 50);
            param[2].Value = ControlName;
            /////////////////////////////////////////////////////
            DAL.ExecuteCommand("Add_Control", param);
            DAL.close();
        }
        public DataTable Get_Dept_Childs(int parent_id)
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parent_id", SqlDbType.VarChar, 50);
            param[0].Value = parent_id;
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Childs", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_DEPARTMENTS()
        {
            // object of data accss layer 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_DEPARTMENTS", null);
            DAL.close();
            return DT;
        }
        public DataTable Get_Dept_Progress_Request(int task_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_Dept_Progress_Request", param);
            DAL.close();
            return DT;
        }
        public DataTable Get_User_Progress_Request(int task_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            // to return the data 
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_User_Progress_Request", param);
            DAL.close();
            return DT;
        }
        public void Approve_Dept_Progress(int task_id,int dept_id,int progress,int last_approve_progress)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            param[1] = new SqlParameter("@dept_id", SqlDbType.Int, 50);
            param[1].Value = dept_id;
            param[2] = new SqlParameter("@progress", SqlDbType.Int, 50);
            param[2].Value = progress;
            param[3] = new SqlParameter("@last_approve_progress", SqlDbType.Int, 50);
            param[3].Value = last_approve_progress;
           /////////////////////////////////////////////////////////////
            DAL.ExecuteCommand("Approve_Dept_Progress", param);
            DAL.close();
        }
        public void Approve_User_Progress(int task_id, int user_id, int progress, int last_approve_progress)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value =user_id;
            param[2] = new SqlParameter("@progress", SqlDbType.Int, 50);
            param[2].Value = progress;
            param[3] = new SqlParameter("@last_approve_progress", SqlDbType.Int, 50);
            param[3].Value = last_approve_progress;
            /////////////////////////////////////////////////////////////
            DAL.ExecuteCommand("Approve_User_Progress", param);
            DAL.close();
        }
        public void Add_User_Roles(int UserId, int RoleId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserId", SqlDbType.Int);
            param[0].Value = UserId;
            param[1] = new SqlParameter("@RoleId", SqlDbType.Int);
            param[1].Value = RoleId;
            /////////////////////////////////////////////////////////////
            DAL.ExecuteCommand("Add_User_Roles", param);
            DAL.close();
        }
        public void Add_User(string name, string password, int jop_id, int department_id,string jop,int phone,int active)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            DataTable Dt = new DataTable();
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = password;

            param[2] = new SqlParameter("@jop_id", SqlDbType.Int);
            param[2].Value = jop_id;

            param[3] = new SqlParameter("@department_id", SqlDbType.Int);
            param[3].Value = department_id;

            param[4] = new SqlParameter("@jop", SqlDbType.VarChar, 50);
            param[4].Value = jop;

            param[5] = new SqlParameter("@phone", SqlDbType.Int);
            param[5].Value = phone;

            param[6] = new SqlParameter("@active", SqlDbType.Int);
            param[6].Value = active;
            DAL.ExecuteCommand("Add_User", param);
            DAL.close();
        }
        public void Update_User(string name, int user_id, int department_id, string jop, int phone, int active)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            DataTable Dt = new DataTable();
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@user_id", SqlDbType.Int);
            param[1].Value = user_id;

            param[2] = new SqlParameter("@department_id", SqlDbType.Int);
            param[2].Value = department_id;

            param[3] = new SqlParameter("@jop", SqlDbType.VarChar, 50);
            param[3].Value = jop;

            param[4] = new SqlParameter("@phone", SqlDbType.Int);
            param[4].Value = phone;
            param[5] = new SqlParameter("@active", SqlDbType.Int);
            param[5].Value = active;
            DAL.ExecuteCommand("Update_User", param);
            DAL.close();
        }
        public void Change_PassWord( int user_id, string password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            DataTable Dt = new DataTable();
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@password", SqlDbType.NVarChar,50);
            param[1].Value = password;

            DAL.ExecuteCommand("Change_PassWord", param);
            DAL.close();
        }
        public void Clear_User_Roles(int user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            DataTable Dt = new DataTable();
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;
            DAL.ExecuteCommand("Clear_User_Roles", param);
            DAL.close();
        }
        public bool HasAccount(int JopID)
        {
            bool Result;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@JopID", SqlDbType.Int);
            param[0].Value = JopID;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("HasAccount", param);
            DAL.close();
            if (DT.Rows.Count > 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }
            return Result;
        }
        public void Add_Task(string Name, string Description, int Budget, DateTime StartDate, DateTime EndDate, string Type, string Priority)
        {
            BL.Show_Class Dept = new BL.Show_Class();
            int assuer_id = Dept.Get_Dept_Id();
            int level = Dept.Get_Dept_Level();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = Name;
           ////////////////////////////////////////
            param[1] = new SqlParameter("@description", SqlDbType.VarChar, 50);
            param[1].Value = Description;
            //////////////////////////////////////
            param[2] = new SqlParameter("@assuer_id", SqlDbType.Int, 50);
            param[2].Value = assuer_id;
            ///////////////////////////////////////
            //////////////////////////////////////
            param[3] = new SqlParameter("@level", SqlDbType.Int, 50);
            param[3].Value = level;
            ///////////////////////////////////////
            ///////////////////////////////////////
            param[4] = new SqlParameter("@priority", SqlDbType.VarChar, 50);
            param[4].Value = Priority;
            ///////////////////////////////////////
            param[5] = new SqlParameter("@budget", SqlDbType.Int, 50);
            param[5].Value = Budget;
            ///////
            param[6] = new SqlParameter("@end_date", SqlDbType.Date);
            param[6].Value = EndDate;
            ////////
            ///////
            param[7] = new SqlParameter("@start_date", SqlDbType.Date);
            param[7].Value = StartDate;
            ////////
            param[8] = new SqlParameter("@type", SqlDbType.VarChar, 255);
            param[8].Value = Type;
            /////////////////////////////////
            DAL.ExecuteCommand("add_task",param);
            DAL.close();
           // return DT;
        }
        public DataTable Add_Task2(string Name, string Description, int Budget, DateTime StartDate, DateTime EndDate, string Type, string Priority)
        {
            BL.Show_Class Dept = new BL.Show_Class();
            int assuer_id = Dept.Get_Dept_Id();
            int level = Dept.Get_Dept_Level();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = Name;
            ////////////////////////////////////////
            param[1] = new SqlParameter("@description", SqlDbType.VarChar, 50);
            param[1].Value = Description;
            //////////////////////////////////////
            param[2] = new SqlParameter("@assuer_id", SqlDbType.Int, 50);
            param[2].Value = assuer_id;
            ///////////////////////////////////////
            //////////////////////////////////////
            param[3] = new SqlParameter("@level", SqlDbType.Int, 50);
            param[3].Value = level;
            ///////////////////////////////////////
            ///////////////////////////////////////
            param[4] = new SqlParameter("@priority", SqlDbType.VarChar, 50);
            param[4].Value = Priority;
            ///////////////////////////////////////
            param[5] = new SqlParameter("@budget", SqlDbType.Int, 50);
            param[5].Value = Budget;
            ///////
            param[6] = new SqlParameter("@end_date", SqlDbType.Date);
            param[6].Value = EndDate;
            ////////
            ///////
            param[7] = new SqlParameter("@start_date", SqlDbType.Date);
            param[7].Value = StartDate;
            ////////
            param[8] = new SqlParameter("@type", SqlDbType.VarChar, 255);
            param[8].Value = Type;
            /////////////////////////////////
            DataTable DT = new DataTable();
            DT = DAL.SelectData("add_task2", param);
            DAL.close();
            return DT;
        }
        public DataTable ADD_Sub_TASK(int parentid, string name, string description, string priority
          , int budget,int wheight,  int assuer_id,
          DateTime Startdate,DateTime Enddate ,string type)
        {
            Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            ////////////////////////////////////////
            param[1] = new SqlParameter("@description", SqlDbType.VarChar, 50);
            param[1].Value = description;
            ///////////////////////////////////////
            param[2] = new SqlParameter("@priority", SqlDbType.VarChar, 50);
            param[2].Value = priority;
            ///////////////////////////////////////
            param[3] = new SqlParameter("@budget", SqlDbType.Int, 50);
            param[3].Value = budget;
            ///////
            param[4] = new SqlParameter("@end_date", SqlDbType.Date);
            param[4].Value = Enddate;
            ///////
            param[5] = new SqlParameter("@start_date", SqlDbType.Date);
            param[5].Value = Startdate;
           ////////////////
            param[6] = new SqlParameter("@parent_id", SqlDbType.Int, 50);
            param[6].Value = parentid;
           /////////////////////////////////
            param[7] = new SqlParameter("@task_level", SqlDbType.VarChar, 255);
            param[7].Value = show.Get_Dept_Level();
            ////////////////
            param[8] = new SqlParameter("@assuer_id", SqlDbType.Int, 50);
            param[8].Value = assuer_id;
            //////
            param[9] = new SqlParameter("@wheight", SqlDbType.Int, 50);
            param[9].Value = wheight;
            ////////////
            param[10] = new SqlParameter("@type", SqlDbType.VarChar, 191);
            param[10].Value = type;
            ////////////
            DataTable dt = new DataTable();
           dt= DAL.SelectData("addsub_task", param);

            DAL.close();
            return dt;
        }

        public void Update_Task_data(int task_id, string name, string description, string priority
         , int budget, int dept_id,
         DateTime Startdate, DateTime Enddate, string type)
        {
            Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            ////////////////////////////////////////
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 191);
            param[1].Value = name;


            param[2] = new SqlParameter("@description", SqlDbType.VarChar, 50);
            param[2].Value = description;
            ///////////////////////////////////////
            param[3] = new SqlParameter("@priority", SqlDbType.VarChar, 50);
            param[3].Value = priority;
            ///////////////////////////////////////
            param[4] = new SqlParameter("@budget", SqlDbType.Int, 50);
            param[4].Value = budget;
            ///////

            ///////
            //////
            param[5] = new SqlParameter("@dept_id", SqlDbType.Int, 50);
            param[5].Value = dept_id;
            ///////
            ///////////
            param[6] = new SqlParameter("@start_date", SqlDbType.Date);
            param[6].Value = Startdate;
            //
            param[7] = new SqlParameter("@end_date", SqlDbType.Date);
            param[7].Value = Enddate;


            ////////////////



            param[8] = new SqlParameter("@type", SqlDbType.VarChar, 191);
            param[8].Value = type;
            ////////////

            DAL.ExecuteCommand("Update_Task_data", param);

            DAL.close();
            // return DT;
            //Update_Task_data
        }
        // Update_Sub_Task


        public void Update_Sub_Task(int task_id, string name, string description, string priority
      , int budget, int dept_id,
      DateTime Startdate, DateTime Enddate, string type, int weight)
        {
            Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            ////////////////////////////////////////
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 191);
            param[1].Value = name;


            param[2] = new SqlParameter("@description", SqlDbType.VarChar, 50);
            param[2].Value = description;
            ///////////////////////////////////////
            param[3] = new SqlParameter("@priority", SqlDbType.VarChar, 50);
            param[3].Value = priority;
            ///////////////////////////////////////
            param[4] = new SqlParameter("@budget", SqlDbType.Int, 50);
            param[4].Value = budget;
            ///////

            ///////
            //////
            param[5] = new SqlParameter("@dept_id", SqlDbType.Int, 50);
            param[5].Value = dept_id;
            ///////
            ///////////
            param[6] = new SqlParameter("@start_date", SqlDbType.Date);
            param[6].Value = Startdate;
            //
            param[7] = new SqlParameter("@end_date", SqlDbType.Date);
            param[7].Value = Enddate;


            ////////////////



            param[8] = new SqlParameter("@type", SqlDbType.VarChar, 191);
            param[8].Value = type;
            ////////////

            param[9] = new SqlParameter("@weight", SqlDbType.Int, 50);
            param[9].Value = weight;
            DAL.ExecuteCommand("Update_Sub_Task", param);

            DAL.close();
            // return DT;
            //Update_Task_data
        }
        public void Assign_To_Dept(int task_id, int dept_id) //,int wheight
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            ////////////////////////////////////////
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            ////////////////////////////////////////
            param[1] = new SqlParameter("@dept_id", SqlDbType.Int, 50);
            param[1].Value = dept_id;
            ////////////////////////////////////////
            //param[2] = new SqlParameter("@wheight", SqlDbType.Int, 50);
            //param[2].Value = wheight;
            ////////////////////////////////////////
            DAL.ExecuteCommand("assign_to_dept", param);
            DAL.close();
            // return DT;
        }
        public void Assign_To_User(int task_id, int user_id) //,int wheight
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            ////////////////////////////////////////
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            ////////////////////////////////////////
            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value = user_id;
            ////////////////////////////////////////
            //param[2] = new SqlParameter("@wheight", SqlDbType.Int, 50);
            //param[2].Value = wheight;
            ////////////////////////////////////////
            DAL.ExecuteCommand("assign_to_user", param);
            DAL.close();
            // return DT;
        }

        public void ADD_comment(string comment, int task_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@comment", SqlDbType.NVarChar, 191);
            param[0].Value = comment;

            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value = show.Get_User_Id();

            param[2] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[2].Value = task_id;

            DAL.ExecuteCommand("add_comment", param);
            DAL.close();

        }

        public void ADD_Task_ReportExecute(string report_data, string status, int task_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@report_data", SqlDbType.NVarChar, 200);
            param[0].Value = report_data;

            param[1] = new SqlParameter("@report_status", SqlDbType.NVarChar, 50);
            param[1].Value = status;

            param[2] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[2].Value = show.Get_User_Id();

            param[3] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[3].Value = task_id;

            DAL.ExecuteCommand("ADD_Task_ReportExecute", param);
            DAL.close();

        }
        public void ADD_Task_Step(string step, int task_id)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@step", SqlDbType.NVarChar, 191);
            param[0].Value = step;

            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value = show.Get_User_Id();

            param[2] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[2].Value = task_id;

            DAL.ExecuteCommand("add_task_step", param);
            DAL.close();

        }


        public void Add_Dept(string dept_name, string dept_desc, int dept_parent)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            ////////////////////////////////
            param[0] = new SqlParameter("@dept_name", SqlDbType.NVarChar, 191);
            param[0].Value = dept_name;
            ////////////////////////////////
            param[1] = new SqlParameter("@dept_desc", SqlDbType.NVarChar, 191);
            param[1].Value = dept_desc;
            ///////////////////////////////
            param[2] = new SqlParameter("@dept_parent", SqlDbType.Int, 50);
            param[2].Value = dept_parent;
            ///////////////////////////////

            DAL.ExecuteCommand("add_dept", param);
            DAL.close();
        }
        public void Add_ExpenseTask(int task_id, string expense_title, int amount, DateTime date)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;

            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value = show.Get_User_Id();

            param[2] = new SqlParameter("@expense_title", SqlDbType.VarChar, 191);
            param[2].Value = expense_title;

            param[3] = new SqlParameter("@expense_amount", SqlDbType.Int, 50);
            param[3].Value = amount;

            param[4] = new SqlParameter("@expense_date", SqlDbType.DateTime);
            param[4].Value = date;

            DAL.ExecuteCommand("add_Taskexpense", param);
            DAL.close();
        }

        public void ADD_Task_Attachment(int task_id, string attach_path, string attache_title, string is_image)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;

            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value = show.Get_User_Id();

            param[2] = new SqlParameter("@file_name", SqlDbType.NVarChar, 191);
            param[2].Value = attach_path;

            param[3] = new SqlParameter("@attachment_title", SqlDbType.NVarChar, 50);
            param[3].Value = attache_title;

            param[4] = new SqlParameter("@is_image", SqlDbType.NVarChar, 50);
            param[4].Value = is_image;

            DAL.ExecuteCommand("Add_AttachmentTask", param);
            DAL.close();

        }
        public void Add_Emp_Progress(int task_id, int progress)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            param[1] = new SqlParameter("@user_id", SqlDbType.Int, 50);
            param[1].Value = show.Get_User_Id();
            param[2] = new SqlParameter("@progress", SqlDbType.Int, 50);
            param[2].Value = progress;
            DAL.ExecuteCommand("Add_Emp_Progress", param);
            DAL.close();
        }
        public void Add_Dept_Progress(int task_id, int progress)
        {
            BL.Show_Class show = new Show_Class();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;
            param[1] = new SqlParameter("@dept_id", SqlDbType.Int, 50);
            param[1].Value = show.Get_Dept_Id();
            param[2] = new SqlParameter("@progress", SqlDbType.Int, 50);
            param[2].Value = progress;
            DAL.ExecuteCommand("Add_Dept_Progress", param);
            DAL.close();
        }



        public void Add_Roles(int role_id,int control_id,int type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            ///////////////////////////////////////////////////////
            param[0] = new SqlParameter("@role_id", SqlDbType.Int);
            param[0].Value = role_id;
            ///////////////////////////////////////////////////
            param[1] = new SqlParameter("@control_id", SqlDbType.Int);
            param[1].Value = control_id;
            ///////////////////////////////////////////////////
            param[2] = new SqlParameter("@type", SqlDbType.Int);
            param[2].Value = type;
            ////////////////////////////////////////////////

            DAL.ExecuteCommand("Add_Roles", param);
            DAL.close();
        }
        public void Add_Role(string RoleName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@RoleName", SqlDbType.NVarChar, 50);
            param[0].Value = RoleName;
            DAL.ExecuteCommand("Add_Role", param);
            DAL.close();
        }
        public void Update_Role(string RoleName,int RoleId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@RoleName", SqlDbType.NVarChar, 50);
            param[0].Value = RoleName;
            param[1] = new SqlParameter("@RoleId", SqlDbType.Int);
            param[1].Value = RoleId;
            DAL.ExecuteCommand("Update_Role", param);
            DAL.close();
        }
        public void Edit_Dept(int id, string dept_name, string dept_desc, int managerId, int dept_parent)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            ////////////////////////////////
            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = id;
            ////////////////////////////////
            param[1] = new SqlParameter("@dept_name", SqlDbType.VarChar, 50);
            param[1].Value = dept_name;
            ///////////////////////////////
            param[2] = new SqlParameter("@dept_desc", SqlDbType.VarChar, 50);
            param[2].Value = dept_desc;
            ///////////////////////////////
            param[3] = new SqlParameter("@managerID", SqlDbType.Int);
            param[3].Value = managerId;
            ///////////////////////////////
            param[4] = new SqlParameter("@dept_parent", SqlDbType.Int);
            param[4].Value = dept_parent;
            ///////////////////////////////

            DAL.ExecuteCommand("Edit_Dept", param);
            DAL.close();
        }
    }
}
