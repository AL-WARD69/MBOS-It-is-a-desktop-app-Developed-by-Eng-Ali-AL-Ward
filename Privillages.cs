using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraEditors;
using DevExpress;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace MBOS_Full_System
{
    public partial class Privillages : DevExpress.XtraEditors.XtraForm
    {
        private Form workingForm;
        int loading = 0;
        DataTable Pages = new DataTable();
        DataTable MyControls = new DataTable();
        DataTable HiddenControl = new DataTable();
        DataTable DisabledControl = new DataTable();
        SimpleButton s = new SimpleButton();
        BL.Show_Class fill = new BL.Show_Class();
        public Privillages()
        {
            InitializeComponent();
        }

        private void PrivillagesForm_Load(object sender, EventArgs e)
        {
            RoleCompobox.DataSource = fill.Get_Roles();
            RoleCompobox.DisplayMember = "اسم الدور";
            RoleCompobox.ValueMember = "رقم الدور";
            Pages = fill.Get_Forms();
            FormsCombobox.DataSource = Pages;
            FormsCombobox.DisplayMember = "FormText";
            FormsCombobox.ValueMember = "id";
            loading = 1;
            RoleCompobox.SelectedIndex = -1;
            //// TODO: This line of code loads data into the 'controlSecurityDataSet.Controls' table. You can move, or remove it, as needed.
            //this.controlsTableAdapter.Fill(this.controlSecurityDataSet.Controls);
            //// TODO: This line of code loads data into the 'controlSecurityDataSet.Controls' table. You can move, or remove it, as needed.
            ////this.controlsTableAdapter.Fill(this.controlSecurityDataSet.Controls);
            //// TODO: This line of code loads data into the 'controlSecurityDataSet.Roles' table. You can move, or remove it, as needed.
            //this.rolesTableAdapter.Fill(this.controlSecurityDataSet.Roles);
        }


        private void workingForm_MouseEnter(object sender, EventArgs e)
        {
            workingForm.Enabled = false;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            BL.ADD roles = new BL.ADD();
            //roles.Add_
            //insertt();
            //for (int i = 0; i < gridView1.GetSelectedRows().Count(); i++)
            //{
            //    DataRow row = gridView1.GetDataRow(i);
            //    object cellValue = View.GetRowCellValue(i, col);
            //}
                               //conn.Close();
                // PopulatePermissionTree();
           // PL.login frm = new PL.login();
           // frm.Enabled = false;
           // frm.MdiParent = this;
           //// frm.Dock = DockStyle.Left;
           // frm.Show();
            // = panelControl1;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Form[] childs = this.MdiChildren;
            for (int i = 0; i < childs.Length; i++)
            {
              //  MessageBox.Show(childs[i].Text);
                childs[i].Close();
            }
            string PageName=Pages.Rows[FormsCombobox.SelectedIndex]["FormFullName"].ToString();
           // MessageBox.Show(PageName);

            Type tt = Type.GetType(PageName);
            workingForm = (Form)Activator.CreateInstance(tt);
            // usrcontrol = (UserControl)Activator.CreateInstance(tt);
            workingForm.IsMdiContainer = false;
            workingForm.MdiParent = this;
            workingForm.StartPosition = FormStartPosition.CenterParent;
          //  workingForm.Enabled = false;
            workingForm.MouseEnter += workingForm_MouseEnter;
           // workingForm.MouseLeave += workingForm_MouseLeave;
            workingForm.Show();
            fill_controles();
            //MessageBox.Show(comboBox2.SelectedValue.ToString());
        }

        

        private void controlscheckedlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(controlscheckedlistbox.SelectedValue.ToString());
     
        }

        private void controlscheckedlistbox_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            workingForm.Enabled = true;
            string ControlName = MyControls.Rows[all_elements.SelectedIndex]["ControlName"].ToString();
           // MessageBox.Show(controlscheckedlistbox.GetItemCheckState(controlscheckedlistbox.SelectedIndex).ToString());
            
            if (all_elements.GetItemCheckState(all_elements.SelectedIndex).ToString() == "Checked")
            {
                SelectControl(workingForm.Controls,ControlName);
            }
            else
            {
                UnSelectControl(workingForm.Controls,ControlName);
            }
            //MessageBox.Show(ControlName);
        }

        private void InVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (InVisible.Checked)
            {
                all_elements.CheckAll();
            }
            else
            {
                all_elements.UnCheckAll();
            }
        }
        ////////////////////////////////////////////////////////////////////////////
        private void SelectControl(Control.ControlCollection controlCollection,string ControlName)
        {
            foreach (Control m in controlCollection)
            {
                if (m.HasChildren)
                {
                    //MessageBox.Show("no");
                    SelectControl(m.Controls, ControlName);
                }
               if (m is DevExpress.XtraBars.Navigation.AccordionControl)
                {
                    //MessageBox.Show("heelo");
                    DevExpress.XtraBars.Navigation.AccordionControl ac = m as DevExpress.XtraBars.Navigation.AccordionControl;
                    ac.ForEachElement((el) =>
                    {
                        if (el.Name == ControlName)
                        {
                            el.Appearance.Normal.BackColor = Color.FromArgb(1, 115, 199);
                            el.Appearance.Normal.ForeColor = Color.White;
                        }
                        //control.Add_Control(id, el.Text, el.Name);
                    });
                }
                else if (m is MenuStrip)
                {
                    MenuStrip menuStrip = m as MenuStrip;
                    SelectStipItems(menuStrip.Items,ControlName);
                }
                else if (m is Button )
                {
                    //MessageBox.Show("but");
                   
                    Button b=m as Button;
                    if (b.Name == ControlName)
                    {
                        b.FlatAppearance.BorderColor = Color.Red;
                        b.ForeColor = Color.Red;
                        b.BackColor = Color.White;
                    }
                }
               else if(m is SimpleButton)
                {
                    //MessageBox.Show("simbut");
                    SimpleButton b = m as SimpleButton;
                    if (b.Name == ControlName)
                    {
                        b.Appearance.BorderColor = Color.Red;
                        b.ForeColor = Color.Red;
                        b.Appearance.BackColor = Color.White;
                    }
                }
            }
        }
        private void UnSelectControl(Control.ControlCollection controlCollection,string ControlName)
        {

            foreach (Control m in controlCollection)
            {
                if (m.HasChildren)
                {
                    UnSelectControl(m.Controls, ControlName);
                }
               if (m is DevExpress.XtraBars.Navigation.AccordionControl)
                {
                    DevExpress.XtraBars.Navigation.AccordionControl ac = m as DevExpress.XtraBars.Navigation.AccordionControl;
                    ac.ForEachElement((el) =>
                    {
                        if (el.Name == ControlName)
                        {
                            el.Appearance.Normal.BackColor = Color.White;
                            el.Appearance.Normal.ForeColor = Color.FromArgb(1, 115, 199);
                        }
                        //control.Add_Control(id, el.Text, el.Name);
                    });
                }
                else if (m is MenuStrip)
                {
                    MenuStrip menuStrip = m as MenuStrip;
                    UnSelectStipItems(menuStrip.Items,ControlName);
                }
               else if (m is Button)
               {
                   //MessageBox.Show("but");
                   Button b = m as Button;
                   if (b.Name == ControlName)
                   {
                       b.FlatAppearance.BorderColor=Color.Green;
                       b.ForeColor = Color.FromArgb(1, 115, 199);
                       b.BackColor = Color.White;
                   }
                   
               }
               else if (m is SimpleButton)
               {
                   SimpleButton b = m as SimpleButton;
                   if (b.Name == ControlName)
                   {
                       b.Appearance.BorderColor= Color.Green;
                       b.ForeColor = Color.FromArgb(1, 115, 199);
                       b.Appearance.BackColor = Color.White;
                   }
               }
            }
            
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        private void SelectStipItems(ToolStripItemCollection toolStripItems,string  ControlName)
        {
            
            foreach (ToolStripMenuItem mi in toolStripItems)
            {
                if (mi.DropDownItems.Count > 0)
                {
                    SelectStipItems(mi.DropDownItems, ControlName);
                }
                if (mi.Name == ControlName)
                {
                    mi.BackColor = Color.FromArgb(1, 115, 199);
                    mi.ForeColor = Color.White;
                }
            }
        }
        private void UnSelectStipItems(ToolStripItemCollection toolStripItems, string ControlName)
        {

            foreach (ToolStripMenuItem mi in toolStripItems)
            {
                if (mi.DropDownItems.Count > 0)
                {
                    UnSelectStipItems(mi.DropDownItems, ControlName);
                }
                if (mi.Name == ControlName)
                {
                    mi.BackColor = Color.White;
                    mi.ForeColor = Color.FromArgb(1, 115, 199);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (RoleCompobox.SelectedValue.ToString() != "0")
            {
                BL.ADD add = new BL.ADD();
                int role_id = (int)RoleCompobox.SelectedValue;
                if (all_elements.CheckedItems.Count > 0)
                {
                    for (int x = 0; x < all_elements.CheckedItems.Count; x++)
                    {
                        add.Add_Roles(role_id, (int)all_elements.CheckedItems[x], 0);
                    }
                    fill_controles();
                }
                else
                {
                    MessageBox.Show("يرجى تحديد العناصر من القائمة");
                }

            }
            else
            {
                MessageBox.Show("الرجاء تحديد الدور الوظيفي");
            }
        }

        private void RoleCompobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_controles();   
        }
        //////////////////////////////////////////////////////////////////////////////
        private void fill_controles()
        {
         if (loading ==1)
            {
            MyControls = fill.Get_Controls((int)RoleCompobox.SelectedValue, (int)FormsCombobox.SelectedValue);
            all_elements.DataSource = MyControls;
            all_elements.DisplayMember = "ControlText";
            all_elements.ValueMember = "Control_ID";
            HiddenControl = fill.Get_Hidden_Control((int)RoleCompobox.SelectedValue, (int)FormsCombobox.SelectedValue);
            hidden_elements.DataSource = HiddenControl;
            hidden_elements.DisplayMember = "ControlText";
            hidden_elements.ValueMember = "Control_ID";
            DisabledControl = fill.Get_Disabled_Control((int)RoleCompobox.SelectedValue, (int)FormsCombobox.SelectedValue);
            disabled_elements.DataSource = DisabledControl;
            disabled_elements.DisplayMember = "ControlText";
            disabled_elements.ValueMember = "Control_ID";
            HideElenments(workingForm.Controls);
            DisableElements(workingForm.Controls);
            ShowElements(workingForm.Controls);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (RoleCompobox.SelectedValue.ToString() != "0")
            {
                BL.ADD add = new BL.ADD();
                int role_id = (int)RoleCompobox.SelectedValue;
                if (all_elements.CheckedItems.Count > 0)
                {
                    for (int x = 0; x < all_elements.CheckedItems.Count; x++)
                    {
                        add.Add_Roles(role_id, (int)all_elements.CheckedItems[x], 1);
                    }
                    fill_controles();
                }
                else
                {
                    MessageBox.Show("يرجى تحديد العناصر من القائمة");
                }

            }
            else
            {
                MessageBox.Show("الرجاء تحديد الدور الوظيفي");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                hidden_elements.CheckAll();
            }
            else
            {
                hidden_elements.UnCheckAll();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                disabled_elements.CheckAll();
            }
            else
            {
                disabled_elements.UnCheckAll();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (RoleCompobox.SelectedValue.ToString() != "0")
            {
                BL.Del del = new BL.Del();
                int role_id = (int)RoleCompobox.SelectedValue;
                if (hidden_elements.CheckedItems.Count > 0)
                {
                    for (int x = 0; x < hidden_elements.CheckedItems.Count; x++)
                    {
                        del.Remove_Roles(role_id, (int)hidden_elements.CheckedItems[x], 0);
                    }
                    fill_controles();
                }
                else
                {
                    MessageBox.Show("يرجى تحديد العناصر من القائمة");
                }

            }
            else
            {
                MessageBox.Show("الرجاء تحديد الدور الوظيفي");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (RoleCompobox.SelectedValue.ToString() != "0")
            {
                BL.Del Del = new BL.Del();
                int role_id = (int)RoleCompobox.SelectedValue;
                if (disabled_elements.CheckedItems.Count > 0)
                {
                    for (int x = 0; x < disabled_elements.CheckedItems.Count; x++)
                    {
                        Del.Remove_Roles(role_id, (int)disabled_elements.CheckedItems[x], 1);
                    }
                    fill_controles();
                }
                else
                {
                    MessageBox.Show("يرجى تحديد العناصر من القائمة");
                }

            }
            else
            {
                MessageBox.Show("الرجاء تحديد الدور الوظيفي");
            }
        }
        private void HideElenments(Control.ControlCollection controlcollection)
        {
            foreach (Control c in controlcollection)
            {
                if (c.HasChildren)
                {
                    HideElenments(c.Controls);
                }
                if (c is DevExpress.XtraBars.Navigation.AccordionControl)
                {
                    DevExpress.XtraBars.Navigation.AccordionControl ac = c as DevExpress.XtraBars.Navigation.AccordionControl;
                    ac.ForEachElement((el) =>
                    {
                        for (int i = 0; i < HiddenControl.Rows.Count; i++)
                        {
                            string this_name = HiddenControl.Rows[i]["ControlName"].ToString();
                            if (el.Name == this_name)
                            {
                                el.Visible = false;
                            }
                        }
                    });
                }
                else if (c is MenuStrip)
                {
                    MenuStrip menuStrip = c as MenuStrip;
                    HideStipItems(menuStrip.Items);
                }
                else if (c is Button)
                {
                    Button b = c as Button;
                    for (int i = 0; i < HiddenControl.Rows.Count; i++)
                    {
                        string this_name = HiddenControl.Rows[i]["ControlName"].ToString();
                        if (b.Name == this_name)
                        {
                            b.Visible = false;
                        }
                    }
                }
                else if (c is SimpleButton)
                {
                    SimpleButton b = c as SimpleButton;
                    for (int i = 0; i < HiddenControl.Rows.Count; i++)
                    {
                        string this_name = HiddenControl.Rows[i]["ControlName"].ToString();
                        if (b.Name == this_name)
                        {
                            b.Visible = false;
                        }
                    }
                }
                
             }
        }    
         
        private void HideStipItems(ToolStripItemCollection toolStripItems)
        {

            foreach (ToolStripMenuItem mi in toolStripItems)
            {
                if (mi.DropDownItems.Count > 0)
                {
                    HideStipItems(mi.DropDownItems);
                }
                for (int i = 0; i < HiddenControl.Rows.Count; i++)
                {
                    string this_name = HiddenControl.Rows[i]["ControlName"].ToString();
                    if (mi.Name == this_name)
                    {
                        mi.Visible = false;
                    }
                }
            }
            
        }
        private void DisableElements(Control.ControlCollection controlcollection)
        {
            foreach (Control c in controlcollection)
            {
                if (c.HasChildren)
                {
                    DisableElements(c.Controls);
                }
                if (c is DevExpress.XtraBars.Navigation.AccordionControl)
                {
                    DevExpress.XtraBars.Navigation.AccordionControl ac = c as DevExpress.XtraBars.Navigation.AccordionControl;
                    ac.ForEachElement((el) =>
                    {
                        for (int i = 0; i < DisabledControl.Rows.Count; i++)
                        {
                            string this_name = DisabledControl.Rows[i]["ControlName"].ToString();
                            if (el.Name == this_name)
                            {
                                el.Enabled = false;
                            }
                        }
                    });
                }
                else if (c is MenuStrip)
                {
                    MenuStrip menuStrip = c as MenuStrip;
                    HideStipItems(menuStrip.Items);
                }
                else if (c is Button)
                {
                    Button b = c as Button;
                    for (int i = 0; i < DisabledControl.Rows.Count; i++)
                    {
                        string this_name = DisabledControl.Rows[i]["ControlName"].ToString();
                        if (b.Name == this_name)
                        {
                            b.Enabled = false;
                        }
                    }
                }
                else if (c is SimpleButton)
                {
                    SimpleButton b = c as SimpleButton;
                    for (int i = 0; i < DisabledControl.Rows.Count; i++)
                    {
                        string this_name = DisabledControl.Rows[i]["ControlName"].ToString();
                        if (b.Name == this_name)
                        {
                            b.Enabled = false;
                        }
                    }
                }

            }
        }
        private void DisableStipItems(ToolStripItemCollection toolStripItems)
        {

            foreach (ToolStripMenuItem mi in toolStripItems)
            {
                if (mi.DropDownItems.Count > 0)
                {
                    DisableStipItems(mi.DropDownItems);
                }
                for (int i = 0; i < DisabledControl.Rows.Count; i++)
                {
                    string this_name = DisabledControl.Rows[i]["ControlName"].ToString();
                    if (mi.Name == this_name)
                    {
                        mi.Enabled = false;
                    }
                }
            }

        }
        private void ShowElements(Control.ControlCollection controlcollection)
        {
            foreach (Control c in controlcollection)
            {
                if (c.HasChildren)
                {
                    ShowElements(c.Controls);
                }
                if (c is DevExpress.XtraBars.Navigation.AccordionControl)
                {
                    DevExpress.XtraBars.Navigation.AccordionControl ac = c as DevExpress.XtraBars.Navigation.AccordionControl;
                    ac.ForEachElement((el) =>
                    {
                        for (int i = 0; i < MyControls.Rows.Count; i++)
                        {
                            string this_name = MyControls.Rows[i]["ControlName"].ToString();
                            if (el.Name == this_name)
                            {
                                el.Enabled = true;
                                el.Visible = true;
                            }
                        }
                    });
                }
                else if (c is MenuStrip)
                {
                    MenuStrip menuStrip = c as MenuStrip;
                    HideStipItems(menuStrip.Items);
                }
                else if (c is Button)
                {
                    Button b = c as Button;
                    for (int i = 0; i < MyControls.Rows.Count; i++)
                    {
                        string this_name = MyControls.Rows[i]["ControlName"].ToString();
                        if (b.Name == this_name)
                        {
                            b.Enabled = true;
                            b.Visible = true;
                        }
                    }
                }
                else if (c is SimpleButton)
                {
                    SimpleButton b = c as SimpleButton;
                    for (int i = 0; i < MyControls.Rows.Count; i++)
                    {
                        string this_name = MyControls.Rows[i]["ControlName"].ToString();
                        if (b.Name == this_name)
                        {
                            b.Enabled = true;
                            b.Visible=true;
                        }
                    }
                }

            }
        }
        private void ShowStipItems(ToolStripItemCollection toolStripItems)
        {

            foreach (ToolStripMenuItem mi in toolStripItems)
            {
                if (mi.DropDownItems.Count > 0)
                {
                    ShowStipItems(mi.DropDownItems);
                }
                for (int i = 0; i < MyControls.Rows.Count; i++)
                {
                    string this_name = MyControls.Rows[i]["ControlName"].ToString();
                    if (mi.Name == this_name)
                    {
                        mi.Enabled = true;
                        mi.Visible = true;
                    }
                }
            }

        }
        
    }
}
