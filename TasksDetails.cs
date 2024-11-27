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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraReports.UI;
using System.IO;

namespace MBOS_Full_System
{
    public partial class TasksDetails : DevExpress.XtraEditors.XtraForm
    {
        public bool is_update;
        int selected_task_id = 0;
        string selected_task_name;
        public int selected_comment_id;
        string user_task_role;
        public string iName;
        public TasksDetails(string user_type,int task_id)
        {
            selected_task_id = task_id;
            user_task_role = user_type;
            InitializeComponent();
        }
        public TasksDetails()
        {
            InitializeComponent();
        }
        private void Task_Details_Load(object sender, EventArgs e)
        {
            fill_details();
        }
        private void fill_task_comments()
        {
            BL.Show_Class task = new BL.Show_Class();
            ///////////////////////////////////////////////////task_comments///////////////////////////////////////
            gridControl3.DataSource = task.Get_UserComment(selected_task_id);
            gridView_comment.Columns["name"].Caption = "اسم الموضف";
            gridView_comment.Columns["comment"].Caption = "التعليق";
            gridView_comment.Columns["created_at"].Caption = "التاريخ";
            gridView_comment.Columns["id"].Visible = false;
            ///////////////////////////////////////////////////end_task_comments///////////////////////////////////////
        }
        private void fill_task_reportExecute()
        {

            BL.Show_Class task = new BL.Show_Class();
            ///////////////////////////////////////////////////task_steps///////////////////////////////////////
            gridControlreportExecute.DataSource = task.Get_ReportTaskExecute(selected_task_id);
            gridView_reperotExecu.Columns["id"].Visible = false;
            gridView_reperotExecu.Columns["report_data"].Caption = "ما تم إنجازة";
            gridView_reperotExecu.Columns["date"].Caption = "التاريخ";
            gridView_reperotExecu.Columns["report_status"].Caption = "حالة الانجاز";
            gridView_reperotExecu.Columns["name"].Caption = "بواسطة ";
            ///////////////////////////////////////////////////end_task_steps///////////////////////////////////////

        }
        private void fill_task_expenses()
        {
            BL.Show_Class task = new BL.Show_Class();
            ////////////////////////////task_expnese/////////////////////////
            gridControl1_expense.DataSource = task.Fill_TaskExpense(selected_task_id);
            gridView_expense.Columns["id"].Visible = false;
            gridView_expense.Columns["expense_title"].Caption = "بند المصروف";
            gridView_expense.Columns["expense_amount"].Caption = "مبلغ المصروف";
            gridView_expense.Columns["name"].Caption = " بواسطة";

        }

        private void fill_task_attachment()
        {
            BL.Show_Class task = new BL.Show_Class();
            gridControl_attachment.DataSource = task.Get_Task_Attachemnt(selected_task_id);
            gridView1_attachement.Columns["id"].Visible = false;
            gridView1_attachement.Columns["attachment_title"].Caption = "عنوان المرفق";
          //  gridView1_attachement.Columns["attachment_path"].Visible = false;
           gridView1_attachement.Columns["created_at"].Caption = "تاريخ المرفق";
            gridView1_attachement.Columns["name"].Caption = "بواسطه الموظف";

        }
        private void fill_task_child()
        {
            ChildsTaskTree.ClearNodes();
            ChildsTaskTree.Columns.Clear();
            CreateColumns(ChildsTaskTree);
            CreateNodes(ChildsTaskTree);
        }
        private void CreateColumns(TreeList tl)
        {
            // Create three columns.
            tl.BeginUpdate();
            TreeListColumn col1 = tl.Columns.Add();
            col1.Caption = "رقم المهمة";
            col1.VisibleIndex = 0;
            TreeListColumn col2 = tl.Columns.Add();
            col2.Caption = "الاسم";
            col2.VisibleIndex = 1;
            TreeListColumn col3 = tl.Columns.Add();
            col3.Caption = "الوصف";
            col3.VisibleIndex = 2;
            TreeListColumn col4 = tl.Columns.Add();
            col4.Caption = "جهة الاصدار";
            col4.VisibleIndex = 3;
            TreeListColumn col5 = tl.Columns.Add();
            col5.Caption = "وزن المهمة";
            col5.VisibleIndex = 4;
            TreeListColumn col6 = tl.Columns.Add();
            col6.Caption = "الاب";
            col6.VisibleIndex = 5;
          //  tl.Columns[0].Visible = false;
            tl.Columns[5].Visible = false;
            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl)
        {
            BL.Show_Class show = new BL.Show_Class();
            DataTable DT = new DataTable();
            int dept_id=show.Get_Dept_Id();
            if (user_task_role == "assignee" && dept_id != 0)
            {
                DT = show.Get_SubTask_Childs(selected_task_id,dept_id );
            }
            else
            {
                DT = show.Get_Task_Childs(selected_task_id);
            }
            tl.BeginUnboundLoad();
            TreeListNode parentForRootNodes = null;
            // Create a root node .
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                TreeListNode rootNode = tl.AppendNode(
                            new object[] { DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][2].ToString(), DT.Rows[i][9].ToString(), DT.Rows[i][10].ToString(), DT.Rows[i][3].ToString() },
                            parentForRootNodes);
                int parent_id = Convert.ToInt32(DT.Rows[i][0].ToString());
                fill_child(rootNode, tl, parent_id);
            }
            tl.EndUnboundLoad();

        }
        private void fill_child(TreeListNode rootNode, TreeList tl, int parent_id)
        {

            BL.Show_Class show = new BL.Show_Class();
            DataTable DT = new DataTable();
            DT = show.Get_Task_Childs(parent_id);
            // Create a Child Nodes
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                TreeListNode inner_rootNode = tl.AppendNode(new object[] { DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][2].ToString(), DT.Rows[i][9].ToString(), DT.Rows[i][10].ToString(), DT.Rows[i][3].ToString() }, rootNode);
                int inner_parent_id = Convert.ToInt32(DT.Rows[i][0].ToString());
                fill_child(inner_rootNode, tl, inner_parent_id);
            }
           
        }
        private void fill_main_task_details()
        {
            //////////////////////////////////////////////////////////////////////////////
            BL.Show_Class task = new BL.Show_Class();
            DataTable task_info = new DataTable();
            task_info = task.Show_Task(selected_task_id);
            if (Convert.ToInt32(task_info.Rows[0][0].ToString()) == task.Get_Dept_Id())
            {
               // user_task_role = "assuer";
            }
            ///////////////////////////////////////////////////////////////////////////
            vGridControl1.Rows["name"].Properties.Value = task_info.Rows[0][1];
            selected_task_name = task_info.Rows[0][1].ToString();
            vGridControl1.Rows["assuer"].Properties.Value = task_info.Rows[0][2];
            vGridControl1.Rows["description"].Properties.Value = task_info.Rows[0][3];
            vGridControl1.Rows["priority"].Properties.Value = task_info.Rows[0][4];
            vGridControl1.Rows["progress"].Properties.Value = task_info.Rows[0][5];
            vGridControl1.Rows["budget"].Properties.Value = task_info.Rows[0][6];
            ////////////////////////////////////////////////////////////////////////
            if (task.Get_Task_Level(selected_task_id) == 2)
            {
                Fill_Task_Emp();
            }
            else
            {
                Fill_Task_Dept();
            }
            task_name_label.Text = selected_task_name;
            this.Text = selected_task_name;
           //////////////////////////////////////////////////////////////////////////
            fill_task_child();
            fill_progress_requests();
        }
        public void Fill_Task_Emp()
        {
            BL.Show_Class task = new BL.Show_Class();
            DataTable task_emp_info = new DataTable();
            departments.Visible = false;
            task_emp_info = task.Show_Task_Emp(selected_task_id);
            if (task_emp_info.Rows.Count == 0)
            {
                employees.Visible = false;
                if (task.Get_Dept_Id() != 0)
                {
                    assign_task_btn.Visible = true;
                }
                if (user_task_role != "assuer")
                {
                    //user_task_role = "parent_task";
                }
            }
            else
            {
                assign_task_btn.Visible = false;
                employees.Visible = true;
                employees.ChildRows.Clear();
                int user_id=task.Get_User_Id();
                for (int i = 0; i < task_emp_info.Rows.Count; i++)
                {

                    if (Convert.ToInt32(task_emp_info.Rows[i][0].ToString()) == user_id)
                    {
                        //user_task_role = "assignee";
                    }
                    DevExpress.XtraVerticalGrid.Rows.BaseRow rowl = vGridControl1.CreateRow(0);
                    //rowl.Properties.Value = task_emp_info.Rows[i][0];
                    rowl.Properties.Caption = task_emp_info.Rows[i][1].ToString();
                    /////////////////////////////////////////////////////////////////////
                    DevExpress.XtraVerticalGrid.Rows.BaseRow row1 = vGridControl1.CreateRow(1);
                    
                    
                    row1.Properties.Value = task_emp_info.Rows[i][2];
                    if (Convert.ToInt32(task_emp_info.Rows[i][2].ToString()) > 50)
                    {
                        task_progress.StartColor = Color.Green;
                        row1.Properties.RowEdit = task_progress;
                        //MessageBox.Show("hrll");
                    }
                    else
                    {
                        row1.Properties.RowEdit = task_progress;
                    }
                    row1.Properties.Caption = "نسبة الانجاز التي تمت اضافتها";
                    row1.Appearance.Options.UseTextOptions = true;
                    row1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

                    DevExpress.XtraVerticalGrid.Rows.BaseRow row2 = vGridControl1.CreateRow(1);
                    row2.Properties.Value = task_emp_info.Rows[i][3];
                    if (Convert.ToInt32(task_emp_info.Rows[i][3].ToString()) > 50)
                    {
                        task_progress.StartColor = Color.Green;
                        row2.Properties.RowEdit = task_progress;
                       // MessageBox.Show(task_emp_info.Rows[i][3].ToString());
                    }
                    else
                    {
                        task_progress.StartColor = Color.Orange;
                        row2.Properties.RowEdit = task_progress;
                        row2.Properties.RowEdit.Appearance.BackColor = Color.Black;
                    }
                    row2.Properties.Caption = "نسبة الانجاز التي تم قبولها";
                    row2.Appearance.Options.UseTextOptions = true;
                    row2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

                    //DevExpress.XtraVerticalGrid.Rows.BaseRow row3 = vGridControl1.CreateRow(1);
                    //row3.Properties.Value = task_emp_info.Rows[i][4];
                    //row3.Properties.Caption = "وزن الموظف";
                    //row3.Appearance.Options.UseTextOptions = true;
                    //row3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

                    ////////////////////////////////////////////////////////////////////
                    rowl.ChildRows.Add(row1);
                    rowl.ChildRows.Add(row2);
                    //rowl.ChildRows.Add(row3);
                    //catogry3.ChildRows.Add(rowl);
                    employees.ChildRows.Add(rowl);
                }
            }
        }
        public void Fill_Task_Dept()
        {
            BL.Show_Class task = new BL.Show_Class();
            DataTable task_emp_info = new DataTable();
            employees.Visible = false;
            task_emp_info = task.Show_Task_Dept(selected_task_id);
            if (task_emp_info.Rows.Count == 0)
            {
                departments.Visible = false;
                if (task.Get_Dept_Id() != 0)
                {
                    assign_task_btn.Visible = true;
                }
                if (user_task_role != "assuer")
                {
                   // user_task_role = "parent_task";
                }
            }
            else
            {

                assign_task_btn.Visible = false;
                departments.ChildRows.Clear();
                departments.Visible = true;
                int dep_id=task.Get_Dept_Id();
                for (int i = 0; i < task_emp_info.Rows.Count; i++)
                {
                    if (Convert.ToInt32(task_emp_info.Rows[i][0].ToString()) == dep_id)
                    {
                        //user_task_role = "assignee";
                    }
                    //MessageBox.Show(user_task_role);
                    DevExpress.XtraVerticalGrid.Rows.BaseRow rowl = vGridControl1.CreateRow(0);
                    //rowl.Properties.Value = task_emp_info.Rows[i][0];
                    rowl.Properties.Caption = task_emp_info.Rows[i][1].ToString();
                    /////////////////////////////////////////////////////////////////////
                    DevExpress.XtraVerticalGrid.Rows.BaseRow row1 = vGridControl1.CreateRow(1);
                    row1.Properties.Value = task_emp_info.Rows[i][2];
                    row1.Properties.Caption = "نسبة الانجاز التي تمت اضافتها";
                    row1.Appearance.Options.UseTextOptions = true;
                    row1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

                    DevExpress.XtraVerticalGrid.Rows.BaseRow row2 = vGridControl1.CreateRow(1);
                    row2.Properties.Value = task_emp_info.Rows[i][3];
                    row2.Properties.Caption = "نسبة الانجاز التي تم الموافقه عليها";
                    row2.Appearance.Options.UseTextOptions = true;
                    row2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                    //DevExpress.XtraVerticalGrid.Rows.BaseRow row3 = vGridControl1.CreateRow(1);
                    //row3.Properties.Value = task_emp_info.Rows[i][4];
                    //row3.Properties.Caption = "وزن القسم";
                    //row3.Appearance.Options.UseTextOptions = true;
                    //row3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                    ////////////////////////////////////////////////////////////////////
                    rowl.ChildRows.Add(row1);
                    rowl.ChildRows.Add(row2);
                   // rowl.ChildRows.Add(row3);
                    //catogry3.ChildRows.Add(rowl);
                    departments.ChildRows.Add(rowl);
                }
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {


            try
            {
                BL.ADD add_comment = new BL.ADD();
                BL.Show_Class task = new BL.Show_Class();
                add_comment.ADD_comment(textEdit1.Text, selected_task_id);
                textEdit1.Text = "";
                gridControl3.DataSource = task.Get_UserComment(selected_task_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           /* try
            {
                BL.Show_Class task = new BL.Show_Class();
                BL.ADD add_task_step = new BL.ADD();
                add_task_step.ADD_Task_Step(textEdit2.Text, selected_task_id);
                textEdit2.Text = "";
                gridControlsteps.DataSource = task.Get_TaskStep(selected_task_id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void simpleButton1_expensesave_Click(object sender, EventArgs e)
        {

        }

        private void add_sub_task_btn_Click(object sender, EventArgs e)
        {
           
            is_update = false;
            if (selected_task_id != 0)
            {
                AddSubTaskWizard frm = new AddSubTaskWizard(selected_task_id);
                frm.ShowDialog();
                //Fill_Assuers_Tasks();
            }
            else
            {
                MessageBox.Show("قم باختيار مهمة لاضافة مهام فرعية لها");
            }
        }
        private void check_user_task_role()
        {

            if (user_task_role == "assignee")
            {
                aprove_progress_panel.Visible = false;
                edit_progress_panel.Visible = true;
                 BL.Show_Class IsManager = new BL.Show_Class();
                 if (IsManager.Get_Dept_Id() != 0)
                 {
                     add_sub_task_btn.Visible = true;
                 }
                assign_task_btn.Visible = false;
                simpleButton_updatetaskdetalis.Visible = false;
                simpleButton_ReduriectTask.Visible = false;
                simpleButton_ReduriectTask.Visible = false;
                simpleButton_updatetaskdetalis.Visible = false;

            }
            else if (user_task_role == "assuer")
            {
                simpleButton_ReduriectTask.Visible = true;
                simpleButton_updatetaskdetalis.Visible = true;
                aprove_progress_panel.Visible = true;
                edit_progress_panel.Visible = false;
                add_sub_task_btn.Visible = false;

            }
            else
            {
                aprove_progress_panel.Visible = false;
                edit_progress_panel.Visible = false;
                add_sub_task_btn.Visible = false;
                assign_task_btn.Visible = false;
                simpleButton_ReduriectTask.Visible = false;
                simpleButton_updatetaskdetalis.Visible = false;
            }
        }

        private void task_deatils_back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assign_task_btn_Click(object sender, EventArgs e)
        {
            bool is_reduriect = false;
            AssignTask frm = new AssignTask(selected_task_id, selected_task_name, is_reduriect);
            frm.ShowDialog();
            fill_main_task_details();
            check_user_task_role();
        }

        private void task_deatils_xtratab_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            task_deatils_xtratab.SelectedTabPage.Appearance.HeaderActive.BackColor = Color.Red;
            //MessageBox.Show("ello");
        }

        private void ChildsTaskTree_RowClick(object sender, RowClickEventArgs e)
        {
            selected_task_id = Convert.ToInt32(ChildsTaskTree.GetRowCellValue(ChildsTaskTree.FocusedNode, ChildsTaskTree.Columns["رقم المهمة"]));
            //TreeListNode n=new TreeListNode();
            //n=ChildsTaskTree.GetNodeAt(e.Location);
            //int x = ChildsTaskTree.GetNodeIndex(n);
            //MessageBox.Show(x.ToString());
            //  MessageBox.Show(selected_task_id.ToString());
        }
        private void fill_details()
        {
            BL.ADD add = new BL.ADD();
            BL.Show_Class IsManager = new BL.Show_Class();
            try
            {
                int dept_id = IsManager.Get_Dept_Id();
                if (dept_id != 0)//رئيس قسم 
                {
                    if (add.Get_Dept_Childs(dept_id).Rows.Count > 0)
                    {
                        add_sub_task_btn.Text = "اضافة مهمة فرعية";
                    }
                    else
                    {
                        add_sub_task_btn.Text = "اضافة خطوة تنفيذ";
                        labelControl9.Text = "تحديث نسبة الانجاز للموظفين";
                    }
                    add_sub_task_btn.Visible = true;
                    assign_task_btn.Visible = true;
                    printTask.Visible = true;
                }
                else //موظف
                {
                    add_sub_task_btn.Visible = false;
                    assign_task_btn.Visible = false;
                    printTask.Visible = false;
                }
                fill_main_task_details();
                fill_task_comments();
                fill_task_expenses();
                fill_task_reportExecute();
                fill_task_attachment();
                check_user_task_role();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonEdit_attachment_Click(object sender, EventArgs e)
        {
            bool is_image;
            try
            {

               OpenFileDialog ofd = new OpenFileDialog();
                //  ofd.Multiselect = true;
                ofd.CheckFileExists = true;
                ofd.FilterIndex = 1;
                ofd.InitialDirectory = @"C:\";
                ofd.ShowReadOnly = true;
                ofd.ReadOnlyChecked = true;
                ofd.Title = "اختر  مرفق للمهمة  ";
                ofd.Filter = "ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP " + "|pdf files|*.pdf;";
                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\attach\";
                if (Directory.Exists(appPath) == false)
                {
                    Directory.CreateDirectory(appPath);
                }
                //
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iName = ofd.SafeFileName;
                        //  MessageBox.Show(iName);
                        string filepath = ofd.FileName;
                        //  MessageBox.Show(filepath);
                        File.Copy(filepath, appPath + iName);
                        if (ofd.FilterIndex == 1)
                        {
                            // MessageBox.Show("is images");
                            is_image = true;
                            label_isimage.Text = "true";

                        }
                        else
                        {
                            //  MessageBox.Show("is not image");
                            is_image = false;
                            label_isimage.Text = "false";
                        }
                        //var path = buttonEdit_attachment.Text;
                        //var title = "إضافة مرفق";
                        //showpdfattach pdf = new showpdfattach(path, title);
                        //pdf.Show();
                        //  pictureEdit_attachment.Image = Image.FromFile(ofd.FileName);
                        // MessageBox.Show("is not image");
                        // pdfViewer1.LoadDocument(ofd.FileName);
                        //axAcroPDF1.LoadFile(ofd.FileName);
                        // axAcroPDF1.src = ofd.FileName;

                        buttonEdit_attachment.Text = ofd.FileName;
                        //buttonEdit_addattachment.Text = ofd.FileName;


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("يوجد مرفق بهذا الاسم من فضك أعد تمسية المرفق");

                    }
                }
                else
                {
                    ofd.Dispose();
                }



                //    else
                //   {


                //
                // buttonEdit_addattachment.Text = ofd.FileName;

                //  }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton_attachProcessing_Click(object sender, EventArgs e)
        {
            if(buttonEdit_attachment.Text=="")
            {
                MessageBox.Show("من فضلك قم ب اختيار المرفق");
            }
            else
            { 
            BL.Show_Class show_attche = new BL.Show_Class();
                var path = iName;
            var title = textEdit3_attachtitle.Text;
            var id = selected_task_id;
            bool is_image = Convert.ToBoolean(label_isimage.Text);
            
            try
            {
                bool prcessing_click = true;
                if (is_image)
                {
                    // MessageBox.Show("yes_is_image");
                    showImageattach image_processing = new showImageattach(path, title, id, prcessing_click, is_image.ToString());
                    image_processing.ShowDialog();
                }
                else
                {
                    // MessageBox.Show("is not image is pdf");
                    showpdfattach processig = new showpdfattach(path, title, id, prcessing_click, is_image.ToString());
                    processig.ShowDialog();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridControl_attachment.DataSource = show_attche.Get_Task_Attachemnt(selected_task_id);
           // MessageBox.Show("yes return");
            }
        }

        private void simpleButton_addexecutereport_Click(object sender, EventArgs e)
        {
            if(memoEdit_reportExecute.Text=="")
            {
                MessageBox.Show("من فضلك قم بتعبئةتقارير التنفيذ");
                
            }
            else
            { 
            try
            {
                BL.Show_Class task = new BL.Show_Class();
                BL.ADD add_task_step = new BL.ADD();
                add_task_step.ADD_Task_ReportExecute(memoEdit_reportExecute.Text, task_status_comboBox.Text, selected_task_id);
                memoEdit_reportExecute.Text = "";
                gridControlreportExecute.DataSource = task.Get_ReportTaskExecute(selected_task_id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
        private void gridView1_attachement_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            BL.Show_Class dhow = new BL.Show_Class();


            int doc_id = Convert.ToInt32(gridView1_attachement.GetRowCellValue(gridView1_attachement.FocusedRowHandle, "id"));
            bool prcessing_click = false;
            // string is_image =  label_isimage.Text;
            DataTable dt = new DataTable();
            dt = dhow.get_doc_data(doc_id);
            //   MessageBox.Show(dt.Rows[0][1].ToString());
            var path = dt.Rows[0][0].ToString();
            var title = dt.Rows[0][1].ToString();
            string is_image = dt.Rows[0][2].ToString();
            //  MessageBox.Show(is_image);
            try
            {
                if (Convert.ToBoolean(is_image))
                {
                    showImageattach image_processing = new showImageattach(path, title, selected_task_id, prcessing_click, is_image);
                    image_processing.ShowDialog();
                }
                else
                {
                    showpdfattach pdf = new showpdfattach(path, title, selected_task_id, prcessing_click, is_image);
                    pdf.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //   showpdfattach pdf = new showpdfattach(path,title,selected_task_id, prcessing_click, is_image);
            //  pdf.Show();
            /*  byte[] binaryDataResult = null;
              using (MemoryStream memStream = new MemoryStream())
              {
                  BinaryFormatter brFormatter = new BinaryFormatter();
                  dt.RemotingFormat = SerializationFormat.Binary;
                  brFormatter.Serialize(memStream, dt);
                  binaryDataResult = memStream.ToArray();
                  //axAcroPDF1.LoadFile(binaryDataResult.ToString());
                

              }

      */
            // MessageBox.Show(x.ToString());
            //  string sFile = @"E:\testpdf.pdf"; //Path
            // File.WriteAllBytes(sFile, binaryDataResult);

            // REPORT_PL.reportView rep = new REPORT_PL.reportView();
            // rep.documentViewer1.
            //  rep.Show();

            // axAcroPDF1.LoadFile(sFile);
            // pdfViewer1.LoadDocument(memStream)
        }

        private void execuation_steps_tab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton_updatetaskdetalis_Click(object sender, EventArgs e)
        {
            is_update = true;
            if (selected_task_id != 0)
            {
                AddSubTask frm = new AddSubTask(selected_task_id, is_update);
                frm.ShowDialog();
                fill_details();
                //Fill_Assuers_Tasks();
            }
            else
            {
                MessageBox.Show("قم باختيار مهمة لتعديل على بيانتها");
            }
        }

        private void simpleButton_ReduriectTask_Click(object sender, EventArgs e)
        {

          bool is_reduriect = true;
            AssignTask frm = new AssignTask(selected_task_id, selected_task_name, is_reduriect);
           frm.ShowDialog();
          fill_main_task_details();
           check_user_task_role();
         //BL.Show task_show = new BL.Show();
         //   DataTable dt = new DataTable();
         //   dt = task_show.Show_Task(selected_task_id);
            // MessageBox.Show(dt.Rows[0][10].ToString());// show the paernt of task 
           // MessageBox.Show(selected_task_id.ToString());
           
        }

        private void vGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton9_Click_1(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                MessageBox.Show("الرجاء إدخال التعليق");
            }
            else
            {
                try
                {
                    BL.ADD add_comment = new BL.ADD();
                    BL.Show_Class task = new BL.Show_Class();
                    add_comment.ADD_comment(textEdit1.Text, selected_task_id);
                    textEdit1.Text = "";
                    gridControl3.DataSource = task.Get_UserComment(selected_task_id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void gridView_comment_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //BL.Show_Class show = new BL.Show_Class();
             selected_comment_id = Convert.ToInt32(gridView_comment.GetRowCellValue(gridView_comment.FocusedRowHandle,"id"));
           // MessageBox.Show(delet_comment + "delete comment id");
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                BL.Del delete_comment = new BL.Del();
                BL.Show_Class show = new BL.Show_Class();
                DialogResult dr = MessageBox.Show("هل انت متأكد من حذف التعليق", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //delete row from database or datagridview...
                    delete_comment.Delete_Comment(selected_comment_id);
                }
                else if (DialogResult == DialogResult.No)
                {
                    //Nothing to do
                }

                
                
                //.Show(selected_comment_id.ToString());
                //MessageBox.Show(selected_comment_id.ToString());
                gridControl3.DataSource = show.Get_UserComment(selected_task_id);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

       

        private void task_deatils_xtratab_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            try
            {
                BL.Show_Class show_expense = new BL.Show_Class();
                Dt = show_expense.Get_TasKexpense(selected_task_id);
                if (Dt.Rows.Count > 0)
                {
                    //  MessageBox.Show(selected_task_id.ToString());
                   
                    labelControl9_specialmony.Text = Convert.ToString(Dt.Rows[0]["budget"]);
                    if(Dt.Rows[0].IsNull(0))
                    {
                        //  MessageBox.Show("yes");

                        labelControl10.Text = Convert.ToString(Dt.Rows[0]["budget"]);


                    }
              else
                    {
                        labelControl10.Text = Convert.ToString(Dt.Rows[0][0]);
                    }
                   
                    //MessageBox.Show(Dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void textEdit4_monyexpense_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textEdit4_monyexpense.Text.Trim().ToString());
            int y = Convert.ToInt32(labelControl10.Text.ToString());
            if (textEdit4_monyexpense.Text=="")
            {

            }
           else if ( x > y)
            {
                simpleButton1_expensesave.Enabled = false;
                label_erroeexpense.Text = "يجب ات يكون المبغ اقل من المتبقي";
            }
            else 
            {
                simpleButton1_expensesave.Enabled = true;
                label_erroeexpense.Text = "";

            }
        }

        private void simpleButton1_expensesave_Click_1(object sender, EventArgs e)
        {
            BL.ADD add_expense = new BL.ADD();
            BL.Show_Class task = new BL.Show_Class();
           // MessageBox.Show(selected_task_id.ToString());

            try
            {
                add_expense.Add_ExpenseTask(selected_task_id, textEdit3_stateexpense.Text, Convert.ToInt32(textEdit4_monyexpense.Text), Convert.ToDateTime(dateEdit1_dateexpense.Text));
                gridControl1_expense.DataSource = task.Fill_TaskExpense(selected_task_id);

                // MessageBox.Show("ok");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEdit_attachment_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void main_details_tab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printTask_Click(object sender, EventArgs e)
        {
            DataTable rep = new DataTable();
            BL.Show_Class show = new BL.Show_Class();
            REPORT_PL.reportView viewer = new REPORT_PL.reportView();
            XtraReportTaskDetails rpt = new XtraReportTaskDetails();

            int assurId = Convert.ToInt32(show.Show_Task(selected_task_id).Rows[0][0].ToString());
            string assureName = show.GetAssureTask(selected_task_id, assurId).Rows[0][1].ToString();

            if (selected_task_id != 0)
            {
                if (show.Get_Task_Level(selected_task_id) == 2)
                {
                    rep = show.GetTaskReportDetailForUser(selected_task_id);
                    rpt.DataSource = rep;
                    rpt.DataMember = "TaskReportDetailForUser";

                    rpt.task_name.ExpressionBindings.Add(new ExpressionBinding("Text", "name"));
                    rpt.budget.ExpressionBindings.Add(new ExpressionBinding("Text", "budget"));
                    rpt.task_detail.ExpressionBindings.Add(new ExpressionBinding("Text", "description"));
                    rpt.start_date.ExpressionBindings.Add(new ExpressionBinding("Text", "start_date"));
                    rpt.end_date.ExpressionBindings.Add(new ExpressionBinding("Text", "end_date"));
                    rpt.priority.ExpressionBindings.Add(new ExpressionBinding("Text", "priority"));
                    rpt.task_type.ExpressionBindings.Add(new ExpressionBinding("Text", "type"));

                    rpt.assinedTo.ExpressionBindings.Add(new ExpressionBinding("Text", "user_name"));
                }
                else
                {
                    rep = show.GetTaskReportDetailForDept(selected_task_id);
                    rpt.DataSource = rep;
                    rpt.DataMember = "TaskReportDetailForDept";

                    rpt.task_name.ExpressionBindings.Add(new ExpressionBinding("Text", "name"));
                    rpt.budget.ExpressionBindings.Add(new ExpressionBinding("Text", "budget"));
                    rpt.task_detail.ExpressionBindings.Add(new ExpressionBinding("Text", "description"));
                    rpt.start_date.ExpressionBindings.Add(new ExpressionBinding("Text", "start_date"));
                    rpt.end_date.ExpressionBindings.Add(new ExpressionBinding("Text", "end_date"));
                    rpt.priority.ExpressionBindings.Add(new ExpressionBinding("Text", "priority"));
                    rpt.task_type.ExpressionBindings.Add(new ExpressionBinding("Text", "type"));

                    rpt.assinedTo.ExpressionBindings.Add(new ExpressionBinding("Text", "dept_name"));

                }

            }
            else
            {
                MessageBox.Show("قم باختيار المهمة لطباعتها");
            }

            for (int i = 0; i < rpt.Parameters.Count; i++)
            {
                rpt.Parameters[i].Visible = false;
            }

            rpt.Parameters["taskAssureName"].Value = assureName;

            viewer.documentViewer1.DocumentSource = rpt;
            viewer.ShowDialog();
        }
        private void fill_progress_requests()
        {
            update_progressgridView.Appearance.Row.Options.UseTextOptions = true;
            update_progressgridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            
            BL.ADD progress = new BL.ADD();
            BL.Show_Class task = new BL.Show_Class();
            if (progress.Get_Dept_Childs(task.Get_Dept_Id()).Rows.Count == 0)
            {
                if (progress.Get_User_Progress_Request(selected_task_id).Rows.Count > 0)
                {
                    update_progress_gridControl.DataSource = progress.Get_User_Progress_Request(selected_task_id);
                    update_progressgridView.Columns["UserID"].Visible = false;
                    if (update_progressgridView.RowCount == 0)
                    {
                        approve_progress_btn.Enabled = false;
                    }
                    else
                    {
                        approve_progress_btn.Enabled = true;
                    }
                }
            }
            else
            {
                if (progress.Get_Dept_Progress_Request(selected_task_id).Rows.Count > 0)
                {
                    update_progress_gridControl.DataSource = progress.Get_Dept_Progress_Request(selected_task_id);
                    update_progressgridView.Columns["id"].Visible = false;
                    if (update_progressgridView.RowCount == 0)
                    {
                        approve_progress_btn.Enabled = false;
                    }
                    else
                    {
                        approve_progress_btn.Enabled = true;
                    }
                }
            }


        }

        private void update_progressgridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            try
            {
                BL.Show_Class task = new BL.Show_Class();
                if (task.Get_Task_Level(selected_task_id) == 2)
                {
                    request_name_label.Text = update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "اسم الموظف").ToString();
                }
                else
                {
                    request_name_label.Text = update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "اسم القسم").ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            progress_request.Text = update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "طلب التحديث").ToString();
        }

        private void ChildsTaskTree_DoubleClick(object sender, EventArgs e)
        {
            fill_details();
        }
        private void approve_progress_btn_Click(object sender, EventArgs e)
        {

            BL.ADD progress = new BL.ADD();
            BL.Show_Class task = new BL.Show_Class();
            if (progress_request.Text != "قم بالاختيار من جدول التحديث" || progress_request.Text != " ")
            {
                if (progress.Get_Dept_Childs(task.Get_Dept_Id()).Rows.Count == 0)
                {
                    int user_id = Convert.ToInt32(update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "UserID"));
                    int last_approve_progress = Convert.ToInt32(update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "ماتم الموافقة علية"));
                    progress.Approve_User_Progress(selected_task_id, user_id, Convert.ToInt32(progress_request.Text), last_approve_progress);
                    //MessageBox.Show("hello");
                    //MessageBox.Show(user_id.ToString());
                    //MessageBox.Show(last_approve_progress.ToString());
                }
                else
                {
                    int dept_id = Convert.ToInt32(update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "id"));
                    int last_approve_progress = Convert.ToInt32(update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "ماتم الموافقة علية"));
                    progress.Approve_Dept_Progress(selected_task_id, dept_id, Convert.ToInt32(progress_request.Text), last_approve_progress);
                }
                fill_main_task_details();
            }
            else
            {

                if (progress.Get_Dept_Childs(task.Get_Dept_Id()).Rows.Count == 0)
                {

                    MessageBox.Show("قم بالتحديد على الموظف ");
                }
                else
                {
                    MessageBox.Show("قم بالتحديد على القسم ");
                }
            }

        }
        private void save_progress_Click(object sender, EventArgs e)
        {
            if (edit_progress_comboBoxEdit.Text != "")
            {
                BL.ADD add_progress = new BL.ADD();
                BL.Show_Class show=new BL.Show_Class();
                if (show.Get_Dept_Id() == 0)
                {
                    add_progress.Add_Emp_Progress(selected_task_id, Convert.ToInt32(edit_progress_comboBoxEdit.Text));
                }
                else
                {
                    add_progress.Add_Dept_Progress(selected_task_id, Convert.ToInt32(edit_progress_comboBoxEdit.Text));
                }
                fill_main_task_details();
            }
        }
    }
}