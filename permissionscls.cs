using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraEditors;


namespace MBOS_Full_System
{
    class permissionscls
    {
        DataTable HiddenControl = new DataTable();
        DataTable DisabledControl = new DataTable();
        BL.Show_Class fill = new BL.Show_Class();
        //private Dictionary<string, string> oldMenuToolTips =
        //   new Dictionary<string, string>();
        //DataSet ds = new DataSet();
        //SqlDataAdapter dataAdapter = null;
        //DataTable dt = null;
        
       // private DevExpress.XtraEditors.BaseCheckedListBoxControl cc;

       // int parent;
        public void CheckUserActiveRole(int Role_ID, string FormName,Form frm)
        {
           // MessageBox.Show("البداية");
            int form_id = fill.Get_Form_Id_By_Name(FormName);
            if (form_id != 0)
            {
                HiddenControl = fill.Get_Hidden_Control(Role_ID, form_id);
                DisabledControl = fill.Get_Disabled_Control(Role_ID, form_id);
                HideElenments(frm.Controls);
                DisableElements(frm.Controls);
               // MessageBox.Show("ff");
            }
            else
            {
                //MessageBox.Show("no");
            }
            //ConnectionStringSettingsCollection connectionStrings =
            //ConfigurationManager.ConnectionStrings;
            //string connString = connectionStrings[
            //   "MBOS_Full_System.Properties.Settings.MBOSConnectionString"].
            //       ToString();
            //SqlConnection conn = new SqlConnection(connString);



            //try
            //{
            //    dataAdapter = new SqlDataAdapter("Select * From [vew_UserList] Where [Jop_ID]=@Jop_ID and [RoleName]=@RoleName and [Invisible]=1", conn);
            //    dataAdapter.SelectCommand.Parameters.AddWithValue("@Jop_ID", Jop_ID);
            //    dataAdapter.SelectCommand.Parameters.AddWithValue("@RoleName", RoleName);
            //    dataAdapter.Fill(ds, "vew_UserList");
            //    dt = ds.Tables[0];
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("يتعذر الحصول على البيانات: " + e.Message,
            //        "حدث خطأ",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            ////}
            //foreach (DataRow row in dt.Rows)
            //{
            //    object n = (row["FKControlID"]);
            //    string n1 = Convert.ToString(row["FKPage"]);
            //    HideControls(frm.Controls,n);
            //}
            ////dt.Clear();
            ////dataAdapter.Dispose();
            //conn.Close();
            // return obj;

        }

        //private void HideControls( Control.ControlCollection controlCollection, object con)
        //{

        //    foreach (Control c in controlCollection)
        //    {
        //        if (c.Controls.Count > 0)
        //        {

        //            HideControls( c.Controls, con);
        //        }
        //        if (c is DevExpress.XtraBars.Navigation.AccordionControl)
        //        {

        //            DevExpress.XtraBars.Navigation.AccordionControl ac = c as DevExpress.XtraBars.Navigation.AccordionControl;

        //            ac.ForEachElement((el) => {

        //                if (el.Text==Convert.ToString(con))
        //                {
        //                    el.Visible = false;
        //                }
                       

        //            });

        //        }
        //        if (c is MenuStrip)
        //        {
        //            MenuStrip menuStrip = c as MenuStrip;
        //            HideToolStipItems(menuStrip.Items, con);
        //        }

        //        if (c is Button || c is ComboBox || c is TextBox || c is DevExpress.XtraBars.Navigation.AccordionControl ||
        //            c is ListBox || c is DataGridView || c is RadioButton ||
        //            c is RichTextBox || c is TabPage || c is DevExpress.XtraGrid.GridControl || c is DevExpress.XtraEditors.SimpleButton
        //            || c is DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm)
        //        {
        //            if (c.Text ==Convert.ToString( con))
        //            {
        //                c.Visible = false;
        //                break;
        //            }
                   
        //        }

        //    }
            
        //}
        //private void hidedevcontrols(DevExpress.XtraBars.Navigation.AccordionControl.ControlCollection devcollection ,object con)
        //{
        //    foreach(Control c in devcollection)
        //    {
        //        if (c.Controls.Count>0)

        //        {
        //            hidedevcontrols(c.Controls, con);
        //        }
        //        if (c is DevExpress.XtraEditors.SimpleButton ||
        //            c is DevExpress.XtraEditors.TextEdit || 
        //            c is DevExpress.XtraEditors.XtraUserControl)
        //        { 
                
        //            if (c.Name == Convert.ToString(con))
        //            {
        //                c.Visible = false;
        //                break;
        //            }
        //        }
        //        if (c.Name == Convert.ToString(con))
        //        {
        //            c.Visible = false;
        //            break;
        //        }
        //    }

        //}
        //private void HideToolStipItems(ToolStripItemCollection toolStripItems, object con)
        //{
        //    foreach (ToolStripMenuItem mi in toolStripItems)
        //    {

        //        ToolStripMenuItem subMenu = mi as ToolStripMenuItem;
               
        //        bool found = false;
               
        //        if (subMenu.HasDropDownItems == true) // if subMenu has children
        //        {
        //            HideToolStipItems(subMenu.DropDownItems, con);

        //            subMenu.DropDownItems.Find(Convert.ToString(con), found);
        //            if (found)
        //            {
        //                if (subMenu.Text == Convert.ToString(con))
        //                {
        //                    subMenu.Visible = false;
        //                    break;
        //                }// Call recursive Method.
        //            }
        //           else if (subMenu.Text == Convert.ToString(con))
        //            {
        //                subMenu.Visible = false;
        //                break;
        //            }

        //        }
        //        else // Do the desired operations here.
        //        {
        //            if (subMenu.Text == Convert.ToString(con))
        //            {
        //                subMenu.Visible = false;
        //                break;
        //            }
        //        }
               
        //    }
        //}

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
      

    }
}
