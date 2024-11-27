using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MBOS_Full_System
{
    public partial class main : DevExpress.XtraEditors.XtraForm
    {
        public main()
        {
            InitializeComponent();

          //  DataTable comment = new DataTable();
          //  DataTable unLimitedTask = new DataTable();
          //  BL.Show_Class show = new BL.Show_Class();
          //  //     string user_id = Program.no;
          //int dep_id =   show.Get_Dept_Id();
          //  if(dep_id != 0)
          //  {
          //      comment = show.GetLastComment(dep_id);
          //  }
          //  else
          //  {
          //      try
          //      {
          //          int user_id = show.Get_User_Id();
          //          comment = show.LastFourUserComment(user_id);
          //      }
          //      catch (Exception Exception){
          //          MessageBox.Show(Exception.Message);
          //      }
          //  }
            // lastComment.DataSource = comment;
           //lastComment.DataSource = comment;
            //tileView1.Columns["الرقم"].Visible = false;
            //tileView1.Columns["comment"].Caption = "التعليق";
            //tileView1.Columns["name"].Caption = "من";
            //tileView1.Columns["name1"].Caption = "للمهمة";

            //tasksUnLimited.BeginUpdate();
          // unLimitedTask = show.GetUnLimetedTaskExecution();
           //tasksUnLimited.DataSource = unLimitedTask;

           // tasksUnLimited.EndUpdate();
            //tileView2.Columns["id"].Visible = false;


            //for (int i = 0; i < dt.Rows.Count ; i++)
            //{
            //    listBoxControl1.Items.Add(dt.Rows[i][1]);
            //}
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mBOSDataSet2.LastFourComment' table. You can move, or remove it, as needed.
          //  this.lastFourCommentTableAdapter1.Fill(this.mBOSDataSet2.LastFourComment);
            // TODO: This line of code loads data into the 'mBOSDataSet1.LastFourComment' table. You can move, or remove it, as needed.
          //  this.lastFourCommentTableAdapter.Fill(this.mBOSDataSet1.LastFourComment);

        }

        private void lastComment_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}