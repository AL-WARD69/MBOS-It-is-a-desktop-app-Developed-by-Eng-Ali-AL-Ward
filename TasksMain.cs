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
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.Utils.Menu;

namespace MBOS_Full_System
{
    public partial class TasksMain : DevExpress.XtraEditors.XtraForm
    {
        TreeListNode SavedFocused;
        bool NeedRestoreFocused;
        int selected_task_id = 0;
        public TasksMain()
        {
            InitializeComponent();
        }
        private void TasksMain_Load(object sender, EventArgs e)
        {
            assigner_task_tree.ShowFindPanel();
            assuers_task_tree.ShowFindPanel();
            BL.Show_Class IsManager = new BL.Show_Class();
            try
            {
                if (IsManager.Get_Dept_Id() != 0)//مستوى روؤساء الاقسام والمدراء
                {
                    Fill_Assuers_Tasks();
                    if (IsManager.Get_Dept_Level() == 0) // مستوى الادارة العليا
                    {
                        tabPane1.Pages[1].PageVisible = false;
                    }
                    else
                    {
                        Fill_Assignes_Dept_Tasks();
                    }
                    
                }
                else //مستوى الموظف
                {
                    
                    tabPane1.Pages[0].PageVisible = false;
                    tabPane1.SelectedPage = tabNavigationPage2;
                    add_task_btn.Visible = false;
                    Fill_Assignes_User_Tasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        //private static Tasks _instance;
    //    public static Tasks Instance
    //    {
    //        get
    //        {
    //            if (_instance == null)
    //                _instance = new Tasks();
    //            return _instance;
    //        }
    //    }
        

        public void Fill_Assuers_Tasks()
        {
            assuers_task_tree.ClearNodes();
            assuers_task_tree.Columns.Clear();
            CreateColumns(assuers_task_tree);
            CreateNodes(assuers_task_tree,"assuer_task");
           
        }
        public void Fill_Assignes_User_Tasks()
        {
            assigner_task_tree.ClearNodes();
            assigner_task_tree.Columns.Clear();
            CreateColumns(assigner_task_tree);
            CreateNodes(assigner_task_tree,"assign_user_task");
        }
        public void Fill_Assignes_Dept_Tasks()
        {
            assigner_task_tree.ClearNodes();
            assigner_task_tree.Columns.Clear();
            CreateColumns(assigner_task_tree);
            CreateNodes(assigner_task_tree,"assign_dept_task");
        }

      
        

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            try
            {
                BL.Show_Class show_expense = new BL.Show_Class();
                Dt = show_expense.Get_TasKexpense(selected_task_id);
                if (Dt.Rows.Count > 0)
                {
                    //  MessageBox.Show(selected_task_id.ToString());
                    //labelControl9_specialmony.Enabled = true;
                    //labelControl9_specialmony.Text = Convert.ToString(Dt.Rows[0]["budget"]);
                    //labelControl10.Text = Convert.ToString(Dt.Rows[0][0]);
                    // MessageBox.Show(Dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }




        private void simpleButton9_Click(object sender, EventArgs e)
        {
            try
            {
                BL.ADD add_comment = new BL.ADD();
                BL.Show_Class task = new BL.Show_Class();
                //add_comment.ADD_comment(textEdit1.Text, selected_task_id);
                //textEdit1.Text = "";
                //gridControl3.DataSource = task.Get_UserComment(selected_task_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //selected_comment_id = Convert.ToInt32(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "id"));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Del delete_comment = new BL.Del();
               // delete_comment.Delete_Comment(selected_comment_id);
                //.Show(selected_comment_id.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Show_Class task = new BL.Show_Class();
                BL.ADD add_task_step = new BL.ADD();
                //add_task_step.ADD_Task_Step(textEdit2.Text, selected_task_id);
                //textEdit2.Text = "";
                //gridControlsteps.DataSource = task.Get_TaskStep(selected_task_id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



       
        private void assign_task_btn_Click(object sender, EventArgs e)
        {
            if (selected_task_id != 0)
            {
                //Assign_Task frm = new Assign_Task(selected_task_id, task_name_label.Text);
                //frm.ShowDialog();
                //BL.Show_Class task = new BL.Show_Class();
                //if (task.Get_Dept_Level() == 2)
                //{
                //    Fill_Task_Emp();
                //}
                //else
                //{
                //    Fill_Task_Dept();
                //}
               
            }
            else
            {
                MessageBox.Show("الرجاء التحديد على المهمة");
            }
        }

      
        private void task_deatils_back_btn_Click(object sender, EventArgs e)
        {
            selected_task_id = 0;
            //tasks_navigationframe.SelectedPage = tasks_index_navigationPage;
        }

        private void add_sub_task_btn_Click(object sender, EventArgs e)
        {
            bool is_update = false;
            if (selected_task_id != 0)
            {
                AddSubTask frm = new AddSubTask(selected_task_id, is_update);
                frm.ShowDialog();
                Fill_Assuers_Tasks();
            }
            else
            {
                MessageBox.Show("قم باختيار مهمة لاضافة مهام فرعية لها");
            }
        }
        private void CreateColumns(TreeList tl)
        {
            // Create three columns.
            tl.BeginUpdate();
            TreeListColumn col1 = tl.Columns.Add();
            col1.Caption = "رقم المهمة";
            col1.VisibleIndex = 0;
            TreeListColumn col2 = tl.Columns.Add();
            col2.Caption = "اسم المهمة";
            col2.VisibleIndex = 1;
            TreeListColumn col3 = tl.Columns.Add();
            col3.Caption = "جهة الاصدار";
            col3.VisibleIndex = 2;
            TreeListColumn col4 = tl.Columns.Add();
            col4.Caption = "تفاصيل المهمة";
            col4.VisibleIndex = 3;
            TreeListColumn col5 = tl.Columns.Add();
            col5.Caption = "نصنيف المهمة";
            col5.VisibleIndex = 4;
            TreeListColumn col6 = tl.Columns.Add();
            col6.Caption = " حالة المهمة";
            col6.VisibleIndex = 5;
            TreeListColumn col7 = tl.Columns.Add();
            col7.Caption = "درجة الاهمية";
            col7.VisibleIndex = 6;
            TreeListColumn col8 = tl.Columns.Add();
            col8.Caption = "نوع المهمة";
            col8.VisibleIndex = 7;
            TreeListColumn col9 = tl.Columns.Add();
            col9.Caption = "تاريخ البدء";
            col9.VisibleIndex = 8;
            TreeListColumn col10 = tl.Columns.Add();
            col10.Caption = "تاريخ الانتهاء";
            col10.VisibleIndex =9;
            
            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl,string type)
        {
            BL.Show_Class show = new BL.Show_Class();
            DataTable DT = new DataTable();
            if (type == "assuer_task")
            {
                DT = show.Show_Assuers_Tasks(show.Get_Dept_Id());
            }
            else if (type == "assign_dept_task")
            {
              DT = show.Show_Assigend_Dept_Tasks(show.Get_Dept_Id());
            }
            else 
            {
                DT = show.Show_Assigend_User_Tasks(show.Get_User_Id());
            }
            tl.BeginUnboundLoad();
            TreeListNode parentForRootNodes = null;
            // Create a root node.
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string taskclassify;
                if (DT.Rows[i][8].ToString() !="")
                {
                    taskclassify = "فرعية";
                }
                else
                {
                    taskclassify = "رئيسية";
                }
                  TreeListNode rootNode = tl.AppendNode(
                               new object[] { DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][9].ToString(), DT.Rows[i][2].ToString(), taskclassify, "لايوجد", DT.Rows[i][4].ToString(), DT.Rows[i][7].ToString(), DT.Rows[i][5].ToString(), DT.Rows[i][6].ToString() },
                               parentForRootNodes);
                  int parent_id = Convert.ToInt32(DT.Rows[i][0].ToString());
                  fill_child(rootNode,tl, parent_id);
            }
            tl.EndUnboundLoad();
             
        }
        private void fill_child(TreeListNode rootNode,TreeList tl,int parent_id)
        {

            BL.Show_Class show = new BL.Show_Class();
            DataTable DT = new DataTable();
            DT = show.Get_Task_Childs(parent_id);
            // Create a Child Nodes
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string taskclassify;
                if (DT.Rows[i][8].ToString() != "")
                {
                    taskclassify = "فرعية";
                }
                else
                {
                    taskclassify = "رئيسية";
                }
                TreeListNode inner_rootNode=tl.AppendNode(new object[] {DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][9].ToString(), DT.Rows[i][2].ToString(), taskclassify, "لايوجد", DT.Rows[i][4].ToString(), DT.Rows[i][7].ToString(), DT.Rows[i][5].ToString(), DT.Rows[i][6].ToString()}, rootNode);
                int inner_parent_id = Convert.ToInt32(DT.Rows[i][0].ToString());
                fill_child(inner_rootNode, tl, inner_parent_id);
            }
          /*  if (DT.Rows[i][3].ToString() == "")
            {
                TreeListNode rootNode = tl.AppendNode(
                           new object[] { DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][2].ToString(), DT.Rows[i][3].ToString() },
                           parentForRootNodes);
            }
            else
            {
                string parent_id = DT.Rows[i][3].ToString();
                TreeListNode rootNode = tl.FindNodeByFieldValue("الرقم", parent_id);
                // TreeListNode rootNode = tl.Nodes[i - 1];
                // Create a child of the rootNode
                tl.AppendNode(new object[] { DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][2].ToString(), DT.Rows[i][2].ToString() }, rootNode);
                // Creating more nodes

            } */  
        }
        private void show_task_details()
        {
            BL.Show_Class get = new BL.Show_Class();
            string user_type = get.Check_Type(selected_task_id);
            TasksDetails frm = new TasksDetails(user_type, selected_task_id);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            //task_name_label.Text = selected_task_name;
            //task_deatils_xtratab.SelectedTabPage = main_details_tab;
            //tasks_navigationframe.SelectedPage = tasks_details_navigationPage;
        }
        //private void fill_progress_requests()
        //{
        //    BL.ADD progress = new BL.ADD();
        //    BL.Show_Class task=new BL.Show_Class();
        //    if (task.Get_Task_Level(selected_task_id) == 2)
        //    {
        //        if (progress.Get_User_Progress_Request(selected_task_id).Rows.Count > 0)
        //        {
        //            update_progress_gridControl.DataSource = progress.Get_User_Progress_Request(selected_task_id);
        //            update_progressgridView.Columns["id"].Visible = false;
        //            if (update_progressgridView.RowCount == 0)
        //            {
        //                approve_progress_btn.Enabled = false;
        //            }
        //            else
        //            {
        //                approve_progress_btn.Enabled = true;
        //            }
        //        }

           
        //    }
        //       else
        //    {
        //        if (progress.Get_Dept_Progress_Request(selected_task_id).Rows.Count > 0)
        //        {

        //            update_progress_gridControl.DataSource = progress.Get_Dept_Progress_Request(selected_task_id);
        //            update_progressgridView.Columns["id"].Visible = false;
        //            if (update_progressgridView.RowCount == 0)
        //            {
        //                approve_progress_btn.Enabled = false;
        //            }
        //            else
        //            {
        //                approve_progress_btn.Enabled = true;
        //            }
        //        }
        //      }
            
            
        //}
       
        private void check_user_task_role()
        {
            //if (user_task_role == "assignee")
            //{
            //    aprove_progress_panel.Visible = false;
            //    edit_progress_panel.Visible = true;
            //}
            //else if (user_task_role == "assuer")
            //{
            //    aprove_progress_panel.Visible = true;
            //    edit_progress_panel.Visible = false;
            //    add_sub_task_btn.Visible = false;

            //}
            //else
            //{
            //    aprove_progress_panel.Visible = false;
            //    edit_progress_panel.Visible = false;
            //}
        }
      
       
  

        private void buttonEdit_attachment_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                //  ofd.Multiselect = true;
                ofd.CheckFileExists = true;
                // ofd.FilterIndex = 1;
                ofd.InitialDirectory = @"C:\";
                ofd.ShowReadOnly = true;
                ofd.ReadOnlyChecked = true;
                ofd.Title = "اختر  صوره مرفق للمهمة  ";
                ofd.Filter = "ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP; ";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //pictureEdit_attachment.Image = Image.FromFile(ofd.FileName);
                    // MessageBox.Show("is not image");
                    // pdfViewer1.LoadDocument(ofd.FileName);
                    //axAcroPDF1.LoadFile(ofd.FileName);
                    // axAcroPDF1.src = ofd.FileName;

                    //buttonEdit_addattachment.Text = ofd.FileName;


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

        private void simpleButton1_expensesave_Click(object sender, EventArgs e)
        {
            BL.ADD add_expense = new BL.ADD();
            BL.Show_Class task = new BL.Show_Class();


            try
            {
                //add_expense.Add_ExpenseTask(selected_task_id, textEdit3_stateexpense.Text, Convert.ToInt32(textEdit4_monyexpense.Text), Convert.ToDateTime(dateEdit1_dateexpense.Text));
                //gridControl1_expense.DataSource = task.Fill_TaskExpense(selected_task_id);

                // MessageBox.Show("ok");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textEdit4_monyexpense_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(textEdit4_monyexpense.Text) > Convert.ToInt32(labelControl10.Text))
            //{
            //    simpleButton1_expensesave.Enabled = false;
            //    label_erroeexpense.Text = "يجب ات يكون المبغ اقل من المتبقي";
            //}
            //else
            //{
            //    simpleButton1_expensesave.Enabled = true;
            //    label_erroeexpense.Text = "";

            //}
        }

        private void assuers_task_tree_MouseDown(object sender, MouseEventArgs e)
        {
          /*  if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                TreeList tree = sender as TreeList;
                TreeListViewInfo viewInfo = tree.ViewInfo;
                RowInfo rowInfo = viewInfo.GetRowInfoByPoint(e.Location);
                if (rowInfo != null)
                {
                    popupMenu1.ShowPopup(rowInfo.StateImageLocation);  
                }
            }*/
        }

        private void assuers_task_tree_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
           // popupMenu1.ShowPopup(Control.MousePosition);
           //// MessageBox.Show(selected_task_id.ToString());
           // TreeList tree = sender as TreeList;
           // TreeListViewInfo viewInfo = tree.ViewInfo;
           // RowInfo rowInfo = viewInfo.GetRowInfoByPoint(Control.MousePosition);
           // //MessageBox.Show(rowInfo.);
           // TreeListHitInfo hitInfo = (sender as TreeList).CalcHitInfo(e.Point);
           // TreeListNode node = null;
           // if (hitInfo.HitInfoType == HitInfoType.RowIndicator)
           // {
           //     node = hitInfo.Node;
           // }
           // if (node == null) return;
           // // Create a menu with a 'Delete Node' item.
           // DXMenuItem menuItem = new DXMenuItem("Delete Node", new EventHandler(deleteNodeMenuItemClick));
           // menuItem.Tag = node;
           // e.Menu.Items.Add(menuItem);
            TreeList treeList = sender as TreeList;
            TreeListHitInfo hInfo = treeList.CalcHitInfo(e.Point);
            TreeListNode n = new TreeListNode();
            if (hInfo.HitInfoType == HitInfoType.Cell && hInfo.Node == treeList.FocusedNode)
            {
                popupMenu1.ShowPopup(treeList.PointToScreen(e.Point));
            }
            
        }
        private void deleteNodeMenuItemClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            if (item == null) return;
            TreeListNode node = item.Tag as TreeListNode;
            if (node == null) return;
            node.TreeList.DeleteNode(node);

        }
       

        private void update_progressgridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //try
            //{
            //    BL.Show_Class task = new BL.Show_Class();
            //    if (task.Get_Task_Level(selected_task_id) == 2)
            //    {
            //        request_name_label.Text = update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "اسم الموظف").ToString();
            //    }
            //    else
            //    {
            //        request_name_label.Text = update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "اسم القسم").ToString();

            //    }
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //progress_request.Text = update_progressgridView.GetRowCellValue(update_progressgridView.FocusedRowHandle, "طلب التحديث").ToString();
        }

       

        private void buttonEdit_attachment_Click_1(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                //  ofd.Multiselect = true;
                ofd.CheckFileExists = true;
                // ofd.FilterIndex = 1;
                ofd.InitialDirectory = @"C:\";
                ofd.ShowReadOnly = true;
                ofd.ReadOnlyChecked = true;
                ofd.Title = "اختر  صوره مرفق للمهمة  ";
                ofd.Filter = "ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP " + "|pdf files|*.pdf;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //  pictureEdit_attachment.Image = Image.FromFile(ofd.FileName);
                    // MessageBox.Show("is not image");
                    // pdfViewer1.LoadDocument(ofd.FileName);
                    //axAcroPDF1.LoadFile(ofd.FileName);
                    // axAcroPDF1.src = ofd.FileName;

                    //buttonEdit_attachment.Text = ofd.FileName;
                    //buttonEdit_addattachment.Text = ofd.FileName;


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

        private void simpleButton_saveattachment_Click(object sender, EventArgs e)
        {
            BL.ADD add_attche = new BL.ADD();
            BL.Show_Class show_attche = new BL.Show_Class();
            // MemoryStream ms = new MemoryStream();


            try
            {
                //FileStream fs = File.OpenRead(buttonEdit_attachment.Text);
                //byte[] contents = new byte[fs.Length];
                //fs.Read(contents, 0, (int)fs.Length);

                //fs.Close();

                ////  add_attche.ADD_Task_Attachment(selected_task_id,buttonEdit_attachment.Text, textEdit3_attachtitle.Text, FileData);
                //add_attche.ADD_Task_Attachment(selected_task_id, buttonEdit_attachment.Text, textEdit3_attachtitle.Text, contents);
                //gridControl_attachment.DataSource = show_attche.Get_Task_Attachemnt(selected_task_id);
                // MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void add_task_btn_Click(object sender, EventArgs e)
        {
            AddTaskWizard taskwizard = new AddTaskWizard();
            taskwizard.ShowDialog();
            //AddTask newtask = new AddTask();
            //newtask.ShowDialog();
            Fill_Assuers_Tasks();
        }

        private void assuers_task_tree_RowClick(object sender, RowClickEventArgs e)
        {
            selected_task_id = Convert.ToInt32(assuers_task_tree.GetRowCellValue(assuers_task_tree.FocusedNode, assuers_task_tree.Columns["رقم المهمة"]));
        }

        private void assuers_task_tree_DoubleClick(object sender, EventArgs e)
        {
            if (selected_task_id != 0)
            {
                show_task_details();
            }
        }

        private void assigner_task_tree_RowClick(object sender, RowClickEventArgs e)
        {
            selected_task_id = Convert.ToInt32(assigner_task_tree.GetRowCellValue(assigner_task_tree.FocusedNode, assigner_task_tree.Columns["رقم المهمة"]));
        }

        private void assigner_task_tree_DoubleClick(object sender, EventArgs e)
        {
            if (selected_task_id != 0)
            {
                show_task_details();
            }
            
        }

        private void task_deatils_btn_Click(object sender, EventArgs e)
        {
            if (selected_task_id != 0)
            {
                show_task_details();
            }
            else
            {
                MessageBox.Show("قم بالتحديد على مهمة لرؤية التفاصيل");
            }
        }

        private void popupMenu1_CloseUp(object sender, EventArgs e)
        {

            if (NeedRestoreFocused)

                assuers_task_tree.FocusedNode = SavedFocused;
        }

        private void assuers_task_tree_MouseUp(object sender, MouseEventArgs e)
        {
            TreeList tree = sender as TreeList;

            if (e.Button == MouseButtons.Right && ModifierKeys == Keys.None && tree.State == TreeListState.Regular)
            {

                Point pt = tree.PointToClient(MousePosition);
                TreeListHitInfo info = tree.CalcHitInfo(pt);
                if (info.HitInfoType == HitInfoType.Cell)
                {

                    SavedFocused = tree.FocusedNode;

                    int SavedTopIndex = tree.TopVisibleNodeIndex;

                    tree.FocusedNode = info.Node;

                    NeedRestoreFocused = true;

                    popupMenu1.ShowPopup(MousePosition);
                }

            }
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_task_details();
        }

        private void assuers_task_tree_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            TreeListNode n=new TreeListNode();
            n = assuers_task_tree.GetNodeAt(e.X, e.Y);
            assuers_task_tree.SetFocusedNode(n);
            selected_task_id = Convert.ToInt32(assuers_task_tree.GetRowCellValue(assuers_task_tree.FocusedNode, assuers_task_tree.Columns["رقم المهمة"]));
            //MessageBox.Show(selected_task_id.ToString());  
        }

        private void assigner_task_tree_RowCellClick(object sender, RowCellClickEventArgs e)
        {
           
            TreeListNode n = new TreeListNode();
            n = assigner_task_tree.GetNodeAt(e.X, e.Y);
            assigner_task_tree.SetFocusedNode(n);
            selected_task_id = Convert.ToInt32(assigner_task_tree.GetRowCellValue(assigner_task_tree.FocusedNode, assigner_task_tree.Columns["رقم المهمة"]));
            //MessageBox.Show(selected_task_id.ToString());
            
        }

        private void assigner_task_tree_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            TreeList treeList = sender as TreeList;
            TreeListHitInfo hInfo = treeList.CalcHitInfo(e.Point);
            TreeListNode n = new TreeListNode();
            if (hInfo.HitInfoType == HitInfoType.Cell && hInfo.Node == treeList.FocusedNode)
            {
                popupMenu1.ShowPopup(treeList.PointToScreen(e.Point));
            }
        }

        private void assigner_task_tree_MouseUp(object sender, MouseEventArgs e)
        {
            TreeList tree = sender as TreeList;

            if (e.Button == MouseButtons.Right && ModifierKeys == Keys.None && tree.State == TreeListState.Regular)
            {

                Point pt = tree.PointToClient(MousePosition);
                TreeListHitInfo info = tree.CalcHitInfo(pt);
                if (info.HitInfoType == HitInfoType.Cell)
                {

                    SavedFocused = tree.FocusedNode;

                    int SavedTopIndex = tree.TopVisibleNodeIndex;

                    tree.FocusedNode = info.Node;

                    NeedRestoreFocused = true;

                    popupMenu1.ShowPopup(MousePosition);
                }

            }
        }
       
        
    }


}