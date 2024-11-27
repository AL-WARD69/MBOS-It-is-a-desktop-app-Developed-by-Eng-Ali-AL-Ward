using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MBOS_Full_System.BL
{
    class Del
    {
        public void Delete_Comment(int comment_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@comment_id", SqlDbType.Int,50);
            param[0].Value = comment_id;

            DAL.ExecuteCommand("delete_comment", param);
            DAL.close();
        
        }

        public void Delete_deptassigned_task(int task_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;

            DAL.ExecuteCommand("Delete_deptassigned_task", param);
            DAL.close();

        }

        public void Delete_usertassigned_task(int task_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@task_id", SqlDbType.Int, 50);
            param[0].Value = task_id;

            DAL.ExecuteCommand("Delete_usertassigned_task", param);
            DAL.close();

        }
        public void Remove_Roles(int role_id,int control_id,int type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@role_id", SqlDbType.Int);
            param[0].Value = role_id;
            param[1] = new SqlParameter("@control_id", SqlDbType.Int);
            param[1].Value = control_id;
            param[2] = new SqlParameter("@type", SqlDbType.Int);
            param[2].Value = type;
            DAL.ExecuteCommand("Remove_Roles", param);
            DAL.close();
        }
        

    }
}
