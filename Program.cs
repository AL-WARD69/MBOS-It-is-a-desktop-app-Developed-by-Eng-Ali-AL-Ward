using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBOS_Full_System
{
    static class Program
    {
        public static string username;
        public static string FullName;
        public static string send_dept_id;
        public static string department_name;
        public static string job;
        public static string no;
        public static string time_login;
        public static string manage;
        public static string dept;
        public static int Jop_ID;
        public static int RoleID;
        public static string RoleName;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.login());
        }
    }
}
