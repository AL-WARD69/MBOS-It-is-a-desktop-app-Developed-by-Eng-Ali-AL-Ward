using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;


namespace MBOS_Full_System
{
    public partial class Departments : Form
    {
        public int selected_dept_id;
        string selected_dept_name;

        public string typequery;
        int id;
        public Departments()
        {
            InitializeComponent();
            fill_dept();
        }
        public void fill_dept()
        {
            dept_tree_list.ClearNodes();
            dept_tree_list.Columns.Clear();
            CreateColumns(dept_tree_list);
            CreateNodes(dept_tree_list);
        }
        private void CreateColumns(TreeList tl)
        {
            // Create three columns.
            tl.BeginUpdate();
            TreeListColumn col1 = tl.Columns.Add();
            col1.Caption = "الرقم";
            col1.VisibleIndex = 0;
            TreeListColumn col2 = tl.Columns.Add();
            col2.Caption = "الاسم";
            col2.VisibleIndex = 1;
            TreeListColumn col3 = tl.Columns.Add();
            col3.Caption = "الوصف";
            col3.VisibleIndex = 2;
            TreeListColumn col4 = tl.Columns.Add();
            col4.Caption = "رئيس القسم/الادارة";
            col4.VisibleIndex = 3;
            TreeListColumn col5 = tl.Columns.Add();
            col5.Caption = "الاب";
            col5.VisibleIndex = 4;
            TreeListColumn col6 = tl.Columns.Add();
            col6.Caption = "رقم المدير";
            col6.VisibleIndex = 5;
            tl.Columns[0].Visible = false;
            tl.Columns[4].Visible = false;
            tl.Columns[5].Visible = false;
            //tl.Columns[3].Visible = false;
            tl.EndUpdate();
        }

        private void CreateNodes(TreeList tl)
        {
            BL.ADD getDep = new BL.ADD();
            DataTable DT = new DataTable();
            DT = getDep.Get_Dept();
            tl.BeginUnboundLoad();
            TreeListNode parentForRootNodes = null;
            // Create a root node .
            for (int i = 0; i < DT.Rows.Count; i++)
            {

                TreeListNode rootNode = tl.AppendNode(
                            new object[] { DT.Rows[i][0].ToString(), DT.Rows[i][1].ToString(), DT.Rows[i][2].ToString(), DT.Rows[i][4].ToString(), DT.Rows[i][3].ToString(), DT.Rows[i][5].ToString() },
                            parentForRootNodes);
                int parent_id = Convert.ToInt32(DT.Rows[i][0].ToString());
                fill_child(rootNode, tl, parent_id);
            }
            tl.EndUnboundLoad();

        }
        private void fill_child(TreeListNode rootNode, TreeList tl, int parent_id)
        {
            BL.ADD show = new BL.ADD();
            DataTable ChildDT = new DataTable();
            ChildDT = show.Get_Dept_Childs(parent_id);
            // Create a Child Nodes
            for (int i = 0; i < ChildDT.Rows.Count; i++)
            {
                TreeListNode inner_rootNode = tl.AppendNode(new object[] { ChildDT.Rows[i][0].ToString(), ChildDT.Rows[i][1].ToString(), ChildDT.Rows[i][2].ToString(), ChildDT.Rows[i][4].ToString(), ChildDT.Rows[i][3].ToString(), ChildDT.Rows[i][5].ToString() }, rootNode);
                int inner_parent_id = Convert.ToInt32(ChildDT.Rows[i][0].ToString());
                fill_child(inner_rootNode, tl, inner_parent_id);
            }

        }

        private void dept_details_btn_Click(object sender, EventArgs e)
        {
            if (selected_dept_id != 0)
            {
                //dept_navigationframe.SelectedPage = dept_navigationPage2;
            }
            else
            {
                MessageBox.Show("قم باختيار القسم لرؤية التفاصيل");
            }
            
        }

        private void dept_back_btn_Click(object sender, EventArgs e)
        {

            selected_dept_id = 0;
            //dept_navigationframe.SelectedPage = dept_navigationPage1;
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void treeList1_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {

        }

        private void dept_tree_list_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            selected_dept_id = Convert.ToInt32(dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["الرقم"]));
            selected_dept_name = dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["الاسم"]).ToString();
            //labelControl4.Text = selected_dept_name;
        }

        private void add_dept_btn_Click(object sender, EventArgs e)
        {
            AddDept adddep = new AddDept();
            typequery = "add";
            adddep.ShowDialog();
            try
            {
                fill_dept();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_dept_Click(object sender, EventArgs e)
        {
            if (selected_dept_id != 0)
            {
                //typequery = "modify";
                id = Convert.ToInt32(dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["الرقم"]));
                string Parent_id = dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["الاب"]).ToString();
                string Manager_id = dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["رقم المدير"]).ToString();
              
                EditDept updatdept = new EditDept(id);
                updatdept.textEdit1.Text = dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["الاسم"]).ToString();
                updatdept.textEdit2.Text = dept_tree_list.GetRowCellValue(dept_tree_list.FocusedNode, dept_tree_list.Columns["الوصف"]).ToString();
                BL.ADD add_dept = new BL.ADD();
                BL.Show_Class user = new BL.Show_Class();
                if (Manager_id != "")
                {
                    updatdept.add_dept_manager.DataSource = user.Get_Managers(Convert.ToInt32(Manager_id));
                }
                else
                {
                    updatdept.add_dept_manager.DataSource = user.Get_Managers(0);
                
                }
                updatdept.add_dept_manager.DisplayMember = "name";
                updatdept.add_dept_manager.ValueMember = "UserID";
                updatdept.dept_type_cb.DataSource = add_dept.GET_ALL_DEPARTMENTS();
                updatdept.dept_type_cb.DisplayMember = "name";
                updatdept.dept_type_cb.ValueMember = "id";
              if (Parent_id != "")
                {
                    int parent_id = Convert.ToInt32(Parent_id);
                    for (int i = 0; i < add_dept.GET_ALL_DEPARTMENTS().Rows.Count; i++)
                    {
                        if (add_dept.GET_ALL_DEPARTMENTS().Rows[i][5].ToString() != "")
                        {
                            if (parent_id ==  Convert.ToInt32(add_dept.GET_ALL_DEPARTMENTS().Rows[i][0]))
                            {
                                //MessageBox.Show(add_dept.GET_ALL_DEPARTMENTS().Rows[i][5].ToString());
                                updatdept.dept_type_cb.SelectedIndex = i;
                            }
                        }

                    }
                  //  MessageBox.Show("yes");
                    updatdept.IsPrimary = false;
                }
                else
                {
                   // MessageBox.Show("no");
                    updatdept.IsPrimary = true;
                    updatdept.dept_type_cb.Enabled = false;
                    updatdept.labelControl5.Text = "النوع رئيسي";
                }
                if (Manager_id != "")
                {
                    int manager_id = Convert.ToInt32(Manager_id);
                    DataTable Dt = user.Get_Managers(manager_id);
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        if (Dt.Rows[i][0].ToString() != "")
                        {
                            if (manager_id == Convert.ToInt32(Dt.Rows[i][0]))
                            {
                                //MessageBox.Show(Dt.Rows[i][0].ToString());
                                updatdept.add_dept_manager.SelectedIndex = i;
                            }
                        }


                    }
                    //  MessageBox.Show("yes");
                    //updatdept.IsPrimary = false;
                }
                else
                {
                    updatdept.add_dept_manager.SelectedIndex = -1;
                }

                updatdept.ShowDialog();
                try
                {
                    fill_dept();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("يجب اختيار القسم");
            }
            
            
            
        }

        
    }
}
