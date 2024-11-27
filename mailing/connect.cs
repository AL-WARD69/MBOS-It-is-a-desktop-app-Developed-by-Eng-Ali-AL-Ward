using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace MBOS_Full_System.mailing
{
   public  class connect
    {
        public static SqlConnection con= new SqlConnection(@"server=.;Database=MBOS;Integrated Security=true");
       
    }
    //public static SqlConnection getconnection(){


//return con;}

}
