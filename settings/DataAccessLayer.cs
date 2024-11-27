using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MBOS_Full_System.settings
{
    class DataAccessLayer
    {//وهو كائن الاتصال الذي يمكنا من ربط مع قاعد البيانات ||انشاء قناه الاتصال  
        SqlConnection sqlconnection;

        //   ننشى  الكائن في الكنستر  ونعطيه قيمه الذي راح يتنفذ عند اول استنساخ الكلاس ولاتعيد القيمه 
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server=.; Database=MBOS; Integrated Security= true");
        }
        //public static  SqlConnection getconnection()
        //{
        //    SqlConnection conn= new SqlConnection(@"Server=.; Database=MBOS; Integrated Security= true");
        //    return conn;
        //}
        // اجراء الذي يقوم بفتح الاتصال 

        public SqlConnection getconnection()
        {
            return sqlconnection;
        }

        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        
      
        //   اجراء الذي يقو بغلق ااتصال 
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        // الداله التي تقوم بقراءه البيانات من قاعده البيانات نحتاج الى فنكش انها ترجع القيمه بعكس الاغلاق والفتح التي لاتحتاج 
        //   هذا الداله تقوم بتخزين اثنين من  البارمتر الاول الاجراء المخزن الذي يقوم بجمع البيانات والمتغير الثاني الذي يحتوي ع البارامترات التي يحتاجه الاجراء المخزن

        public DataTable SelectData(String stored_procedure, SqlParameter[] param)
        {// لامر الذي يقوم بتنفيذ ااجراء المخزن السطر الثاني نحدد نوع المتغير تبع الكمود من نوع بروسجرالسطر الثالث النص تبع الكومد نفس نص الاجراء المخزن 
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            //اذا كان يحتوي ع البارامترات نضيف كل البارامترات في المتغير الذي انشانه اسكيوكمود 
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);

                }
            }
            //اسكيو داتا ادبتر الذي يقوم بقراء وتنفيذ اسيكو ال كمود
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            //تخزين القيمه الموجود في داتا ادبتر في داتا تيبل
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

            // return null;
        }
        // الداله الذي يقوم بالادخال والتحديث والحذف من قاعده البيانات 

        public void ExecuteCommand(string stores_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stores_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {// نستخم هذاالداله بدلا من لوب والتي تعيد مصفوفه ع طول 
                sqlcmd.Parameters.AddRange(param);
            }
            // امر لايعيد شي تقوم بتنفيذ الاجراء لجلب البيانات او يقوم بتنفيذ العمليات 
            sqlcmd.ExecuteNonQuery();
        }



    }
}
