using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBOS_Full_System.BL
{
   public class NotificationData
    {
       private static string m_ConnectionString = "Server=./;Database=MBOS;Integrated Security=true";
        private SqlConnection m_sqlConn = null;
        Show_Class show = new Show_Class();
        public delegate void NewMessage();
        public event NewMessage OnNewMessage;

        /// <summary>
        /// Constructor
        /// </summary>
        public NotificationData()
        {
            // Stop an existing services on this connection string
            // just be sure
          //  DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlDependency.Stop(m_ConnectionString);

            // Start the dependency
            // User must have SUBSCRIBE QUERY NOTIFICATIONS permission
            // Database must also have SSB enabled
            // ALTER DATABASE Chatter SET ENABLE_BROKER
            SqlDependency.Start(m_ConnectionString);

            // Create the connection
            m_sqlConn = new SqlConnection(m_ConnectionString);
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~NotificationData()
        {
            // Stop the dependency before exiting
            SqlDependency.Stop(m_ConnectionString);
        }

        /// <summary>
        /// Retreive messages from database
        /// </summary>
        /// <returns></returns>
        public DataTable GetMessages()
        {
            DataTable dt = new DataTable();
         

            try
            {
                // Create command
                // Command must use two part names for tables
                // SELECT <field> FROM dbo.Table rather than 
                // SELECT <field> FROM Table
                // Query also can not use *, fields must be designated
                BL.Show_Class IsManager = new BL.Show_Class();
                if (IsManager.Get_Dept_Id() != 0)
                {
                    int Dept_Id = show.Get_Dept_Id();
                    SqlCommand cmd = new SqlCommand("Get_Dept_notification", m_sqlConn);
                    cmd.Parameters.AddWithValue("@userid", Dept_Id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Clear any existing notifications
                    cmd.Notification = null;

                    // Create the dependency for this command
                    SqlDependency dependency = new SqlDependency(cmd);
                    // Add the event handler
                    dependency.OnChange += new OnChangeEventHandler(OnChange);

                    // Open the connection if necessary
                    if (m_sqlConn.State == ConnectionState.Closed)
                        m_sqlConn.Open();

                    // Get the messages
                    dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));  
                }
                else
                {
                    int user_id = show.Get_User_Id();
                    SqlCommand cmd = new SqlCommand("Get_User_notification", m_sqlConn);
                    cmd.Parameters.AddWithValue("@userid", user_id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Clear any existing notifications
                    cmd.Notification = null;

                    // Create the dependency for this command
                    SqlDependency dependency = new SqlDependency(cmd);
                    // Add the event handler
                    dependency.OnChange += new OnChangeEventHandler(OnChange);

                    // Open the connection if necessary
                    if (m_sqlConn.State == ConnectionState.Closed)
                        m_sqlConn.Open();

                    // Get the messages
                    dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
                
                }
 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        /// <summary>
        /// Handler for the SqlDependency OnChange event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency dependency = sender as SqlDependency;

            // Notices are only a one shot deal
            // so remove the existing one so a new 
            // one can be added
            dependency.OnChange -= OnChange;

            // Fire the event
            if (OnNewMessage != null)
            {
                OnNewMessage();
            }
        }
        public static void update_notification_status(int not_id, int dept_id)
        {

            SqlConnection Conn = new SqlConnection(m_ConnectionString);
            SqlCommand cmd = new SqlCommand("update_notification_status", Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@not_id", not_id);
            cmd.Parameters.AddWithValue("@dept_id", dept_id);
            Conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Conn.Close();

            }
        }
        public static void update_notification_User_status(int not_id, int User_id)
        {

            SqlConnection Conn = new SqlConnection(m_ConnectionString);
            SqlCommand cmd = new SqlCommand("update_notification_UserStatues", Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@not_id", not_id);
            cmd.Parameters.AddWithValue("@user_id", User_id);

            Conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Conn.Close();

            }
        }


    }
}
