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
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraEditors.Designer.Utils;

namespace MBOS_Full_System
{
    public partial class AssignTask : DevExpress.XtraEditors.XtraForm
    {
        int task_id;
        string assigend_type;
        string task_name;
        bool IS_Reduriect;
        DataTable Assignee = new DataTable();
        DataTable dy = new DataTable();
      //  List<int> wheight = new List<int>();
        public AssignTask(int Task_Id,string Task_Name ,bool is_reduriect)
        {
            InitializeComponent();
            task_id = Task_Id;
            IS_Reduriect = is_reduriect;
            task_name= Task_Name;
           // this.Text = task_name;
        }
        public AssignTask()
        {
            InitializeComponent();
        }
        
        private void Assign_Task_Load(object sender, EventArgs e)
        {
           
            BL.Show_Class GetLevel = new BL.Show_Class();
            BL.Assign_Task Assign = new BL.Assign_Task();
            BL.ADD a = new BL.ADD();
           
            if (GetLevel.Get_Dept_Level() == 2)
            {
                
               try
                {
                    if(IS_Reduriect == true)
                    {
                        // mean is assifn task 
                        BL.Show_Class show = new BL.Show_Class();
                        BL.Show_Class department = new BL.Show_Class();
                        DataTable dt = new DataTable();
                      
                        dt = show.Show_Task_Dept(task_id);
                        this.Text = " :إعادة توجية المهمة" + task_name;
                        Assignee = Assign.Users();
                        Users.DataSource = Assignee;
                        Users.DisplayMember = "name";
                        Users.ValueMember = "UserID";
                        dy = Assign.Users();

                        //DataTable dx = new DataTable();
                        //dx = Assign.Users();
                        //textEdit1.Text = dx.Rows.Count.ToString();
                        /*MessageBox.Show(dx.Rows.Count.ToString())*/
                        // to determine the cheked item 
                        Users.CheckAll();
                        int count = Users.CheckedItems.Count;
                        for (int x = count - 1; x > 0; x--)
                        {
                            bool result = false;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i][0].ToString() == Users.CheckedItems[x].ToString())
                                {
                                    result = true;
                                    // MessageBox.Show(Users.CheckedItems[x].ToString());
                                    //Users.Items[x+1].CheckState = CheckState.Unchecked;
                                }

                                //MessageBox.Show(dt.Rows[i][1].ToString());
                            }
                            if (!result)
                            {
                                Users.SetItemChecked(x, false);
                            }
                        }



                       

                    }
                    else
                    {
                          
                            this.Text = ": إسناد المهمه " + task_name;
                            BL.Show_Class department = new BL.Show_Class();
                            int parent_id = department.Get_Dept_Id();
                            Assignee = Assign.Users();
                            Users.DataSource = Assignee;
                            Users.DisplayMember = "name";
                            Users.ValueMember = "UserID";
                            dy = Assign.Users();

                    }
                    // is assign task 
                    //for (int i = 0; i< Assign.Users().Rows.Count; i++)
                    //{
                    //    wheight.Add(100);
                    //}


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               assigend_type = "emplyees";
            }
            else 
            {
             
                try
                {
                   // int parent_id;
                    if (IS_Reduriect == true)
                    {
                        BL.Show_Class show = new BL.Show_Class();
                        BL.Show_Class department = new BL.Show_Class();
                        DataTable dt = new DataTable();
                      //  parent_id = department.Get_Dept_Id();
                        dt = show.Show_Task_Dept(task_id);


                        //  MessageBox.Show("uuuu");
                        DataTable dx = new DataTable();
                        this.Text =" :إعادة توجية المهمة" +task_name;
                        int parent_id = department.Get_Dept_Id();
                        Assignee = Assign.Departments(parent_id);
                       Users.DataSource = Assign.Departments(parent_id);
                        Users.DisplayMember = "name";
                        Users.ValueMember = "id";
                     //  Users.Des

                       // MessageBox.Show("uyryu");
                     //   DataTable dy = new DataTable();
                        dy = Assign.Departments(parent_id);
                       // textEdit1.Text = dy.Rows[0][0].ToString();
                     
                        // to determine the cheked item 
                        Users.CheckAll();
                        int count = Users.CheckedItems.Count;
                       
                        
                        
                        for (int x = count-1; x >=0 ; x--)
                        {
                            bool result = false;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i][0].ToString() == Users.CheckedItems[x].ToString())
                                {
                                    result = true;
                                   
                                   // MessageBox.Show(Users.CheckedItems[x].ToString());
                                    //Users.Items[x+1].CheckState = CheckState.Unchecked;
                                }
                               
                                 //MessageBox.Show(dt.Rows[i][1].ToString());
                            }
                            if (!result)
                            {
                                Users.SetItemChecked(x, false);
                            }
                        }

                        

                        //Assignee = Assign.Departments(parent_id);
                        //Users.DataSource = Assign.Departments(parent_id);
                        //Users.DisplayMember = "name";
                        //Users.ValueMember = "id";

                    }
                    else
                    {
                        this.Text = ": إسناد المهمه " +task_name;
                        BL.Show_Class department = new BL.Show_Class();
                        int  parent_id = department.Get_Dept_Id();
                        Assignee = Assign.Departments(parent_id);
                        Users.DataSource = Assign.Departments(parent_id);
                        Users.DisplayMember = "name";
                        Users.ValueMember = "id";
                        dy = Assign.Departments(parent_id);

                    }
                    //  BL.Show_Class department = new BL.Show_Class();
                    //int parent_id = department.Get_Dept_Id();
                    //for (int i = 0; i < Assign.Departments(parent_id).Rows.Count; i++)
                    //{
                    //    wheight.Add(100);
                    //}

                    /*for (int i = 0; i < Users.ItemCount; i++)
                    {
                        MessageBox.Show(Users.SelectedItems[i].ToString());
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                assigend_type = "departments";
               // MessageBox.Show(Users.Items.Count.ToString());
            }
            //assignee_name.Text = Assignee.Rows[Users.SelectedIndex]["name"].ToString();
            //wheig.Text = wheight[Users.SelectedIndex].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
           
            if (Users.CheckedItems.Count != 0)
            {
                //int wheight_sum = 0;
                //for (int x = 0; x < Users.CheckedItems.Count; x++)
                //{
                //    wheight_sum += Convert.ToInt32(wheight[Users.CheckedIndices[x]]);
                //}
                BL.ADD assign_dept = new BL.ADD();
                //MessageBox.Show(wheight_sum.ToString());
                //if (wheight_sum == 100)
                //{

                    if (assigend_type == "emplyees")
                    {
                      if(IS_Reduriect == false)
                    {
                        for (int x = 0; x < Users.CheckedItems.Count; x++)
                        {
                           
                            // assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                            assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]));

                        }
                        MessageBox.Show("تم اسناد المهمة بنجاح");
                    }
                      else
                    {
                        BL.Del del = new BL.Del();
                        del.Delete_usertassigned_task(task_id);
                        for (int x = 0; x < Users.CheckedItems.Count; x++)
                        {
                            //  MessageBox.Show(Convert.ToInt32(Users.CheckedItems[x]).ToString());
                            // assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                            assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]));

                        }
                        MessageBox.Show("تم إعادة توجيه المهمه  بنجاح");
                    }
                      
                    }
                    else
                    {

                        if(IS_Reduriect == false)
                      {
                        for (int x = 0; x < Users.CheckedItems.Count; x++)
                         {
                            //MessageBox.Show(wheight[Users.CheckedIndices[x]].ToString());
                            //MessageBox.Show(Users.CheckedItems[x].ToString());
                            //assign_dept.Assign_To_Dept(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                            assign_dept.Assign_To_Dept(task_id, Convert.ToInt32(Users.CheckedItems[x]));
                           }
                        MessageBox.Show("تم اسناد المهمة بنجاح");
                    }
                        else
                    {
                        //// clear assignd task 
                        BL.Del del = new BL.Del();
                        del.Delete_deptassigned_task(task_id);
                        for (int x = 0; x < Users.CheckedItems.Count; x++)
                        {
                            // MessageBox.Show(Convert.ToInt32(Users.CheckedItems[x]).ToString());
                            // assign_dept.Assign_To_User(task_id, Convert.ToInt32(Users.CheckedItems[x]), wheight[Users.CheckedIndices[x]]);
                            assign_dept.Assign_To_Dept(task_id, Convert.ToInt32(Users.CheckedItems[x]));

                        }
                        MessageBox.Show("تم إعادة توجيه المهمه  بنجاح");
                    }

                       
                    }
                    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("يجب ان يكون الوزن الكلي 100");
                //}

            }
            else
            {
                if (assigend_type == "emplyees")
                {
                    MessageBox.Show("قم باختيار الموظفين  لاسناد المهمة لهم");
                }
                else
                {
                    MessageBox.Show("قم باختيار الاقسام  لاسناد المهمة لها");
                }
                
            }
            
        }
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            //if (Users.SelectedIndex >= 0)
            //{
            //    assignee_name.Text = Assignee.Rows[Users.SelectedIndex]["name"].ToString();
            //    wheig.Text = wheight[Users.SelectedIndex].ToString();
            //}
        }

        private void assuer_wheight_Click(object sender, EventArgs e)
        {
            //if (Users.SelectedIndex >= 0)
            //{
            //    if (comboBoxEdit1.SelectedText != "")
            //    {
            //        assignee_name.Text = Assignee.Rows[Users.SelectedIndex]["name"].ToString();
            //        wheight[Users.SelectedIndex] = Convert.ToInt32(comboBoxEdit1.SelectedText);
            //        wheig.Text = wheight[Users.SelectedIndex].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("الرجاء اختيار نسبة من القائمة المنسدلة");
            //    }
            //}
            
        }

        private void searchControl_assign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchControl1_QueryIsSearchColumn(object sender, QueryIsSearchColumnEventArgs args)
        {
           // MessageBox.Show(SearchControl.MouseButtons.ToString());
        }

        private void searchControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(searchControl1.Text.ToString());
        }

        private void searchControl1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(searchControl1.Text.ToString());
        }

        private void searchControl1_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
           // MessageBox.Show(searchControl1.Text.ToString());
        }

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(searchControl1.Text.ToString());
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(searchControl1.Text.ToString());
        }

        private void searchControl1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                // MessageBox.Show(searchControl1.Text.ToString());
                string serachText = searchControl1.Text.ToString();
                bool is_found = false;
                for (int i = 0; i< dy.Rows.Count; i++)
                {

                    try
                    {
                        DataRow r;
                        r = ((DataRowView)Users.SelectedItem).Row;
                        //MessageBox.Show(r.ToString());
                        string dis = (r[this.Users.DisplayMember]).ToString();
                        if(dis.Trim().Contains(serachText.Trim()))
                    {
                       // MessageBox.Show("yes");
                        Users.SetSelected(i, true);
                        Users.MakeItemVisible(i);
                        is_found = true;
                        break;
                    }
                    else
                    {

                        Users.SetSelected(i, false);
                        Users.SetSelected(i + 1, true);
                        
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   // MessageBox.Show(dis);
                    
                    
                }
                if (!is_found)
                {
                    MessageBox.Show("لابوجد نتائج مطابقة للبحث");
                    Users.SetSelected(0, true);
                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // textEdit1.Text = textEdit1.Text + ">" + Users.SelectedIndex.ToString();
            //textEdit1.Text = textEdit1.Text + ">" + Users.SelectedItem.ToString();
            // textEdit1.Text = textEdit1.Text + ">" + Users.SelectedValue.ToString();
            // Users.CheckAll();
            // int count = Users.CheckedItems.Count;
            //  Users.UnCheckAll();
            // MessageBox.Show(count.ToString());
           // textEdit1.Text = dy.Rows[0][0].ToString();

            for (int i = 0 ; i < dy.Rows.Count; i++)
            {

                DataRow r;
                r = ((DataRowView)Users.SelectedItem).Row;
                string dis = (r[this.Users.DisplayMember]).ToString();

                MessageBox.Show(dis);
                r = null;
              // Users.SetItemChecked(i, false);
                Users.SetSelected(i, false);
                Users.SetSelected(i + 1, true);
            }

        }
    }
}