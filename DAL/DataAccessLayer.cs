using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBOS_Full_System.DAL
{
    class DataAccessLayer
    {

        //object of connection 
        SqlConnection sqlconnection;
        // this constructor initailize the connection object to qlserver
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection("Server=.;Database=MBOS;Integrated Security=True");
           // Server=DESKTOP-Q1B3DVI;Database=MBOS;User Id=ali;Password=71171
        }
        // method to open the connection 
        public void open()
        {
            // if there is no connection so open it
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }

        }
        // method to close the connection
        public void close()
        {
            /// if is open so close it

            if (sqlconnection.State == ConnectionState.Open)
            {

                sqlconnection.Close();
            }

        }
        // method to read data from the database 
        // the first param is name of stored_procedure and the s second the number of params that in 
        //stored_procedure accept
        public DataTable SelectData(string stored_procedure, SqlParameter[] Parameters)
        {
            //the command that execute the stored procedure
            SqlCommand sqlcmd = new SqlCommand();
            // type of command
            sqlcmd.CommandType = CommandType.StoredProcedure;
            // text of command  is the stored procedure
            sqlcmd.CommandText = stored_procedure;

            sqlcmd.Connection = sqlconnection;

            if (Parameters != null)// if stored_procedure contain params 
            {
                // add all params to stored_procedure 
                sqlcmd.Parameters.AddRange(Parameters);
            }
            // read the data result from stored_procedure is its function to execute the stored_procedure
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            // put the data in datatable
            DataTable dt = new DataTable();
            //fill the datatable
            da.Fill(dt);
            // return datatable to use it in the program 
            return dt;
        }
        // method to insert,update,and delete data from the database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] Parameters)
        {
            //the command that execute the stored procedure
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (Parameters != null)
            {
                // add array of items == to for looping
                sqlcmd.Parameters.AddRange(Parameters);
            }
            // to execute the commeand and it does't return any thing 
            sqlcmd.ExecuteNonQuery();

        }

        internal void ExecuteCommand(Action<string, string, string, int, int, int, string> ADD_TASK, SqlParameter[] param)
        {
            throw new NotImplementedException();
        }
    }
}
