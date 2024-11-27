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
    public partial class AddDept : DevExpress.XtraEditors.XtraForm
    {
        //int id;
        public AddDept()
        {
            InitializeComponent();
            try
            {
                    BL.ADD add_dept = new BL.ADD();
                    dept_type_cb.DataSource = add_dept.GET_ALL_DEPARTMENTS();
                    dept_type_cb.DisplayMember = "name";
                    dept_type_cb.ValueMember = "id";

                //if (dept.typequery == "add")
                //{
                    if (add_dept.GET_ALL_DEPARTMENTS().Rows.Count > 0)
                    {
                        dept_type_radiogrp.Enabled = false;
                        dept_type_radiogrp.SelectedIndex = 1;
                        dept_type_cb.Enabled = true;
                    }
                    else
                    {
                        dept_type_radiogrp.Enabled = false;
                        dept_type_radiogrp.SelectedIndex = 0;
                        dept_type_cb.Enabled = false;
                    }
                //}
                //else
                //{
                //    dept_type_radiogrp.Visible = false;
                //}
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public addDepartment(int ID)
        //{
        //    InitializeComponent();
        //    id = ID;

        //    try
        //    {
               

        //        dept_type_radiogrp.Enabled = false;
        //        dept_type_radiogrp.SelectedIndex = 1;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_dept_btn_Click(object sender, EventArgs e)
        {
            BL.ADD add_dept = new BL.ADD();
            Departments dep = new Departments();

            //if (dep.typequery == "add")
            //{
                MessageBox.Show("add");
                if (dept_type_radiogrp.SelectedIndex == 0)
                {
                    int dept_level = 0;
                    add_dept.Add_Dept(textEdit1.Text, textEdit2.Text, dept_level);
                    this.Close();
                }
                else
                {
                    int dept_level = Convert.ToInt32(dept_type_cb.SelectedValue.ToString());
                    add_dept.Add_Dept(textEdit1.Text, textEdit2.Text, dept_level);
                    this.Close();
                }
            //}
            
            
        }

        private void addDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}