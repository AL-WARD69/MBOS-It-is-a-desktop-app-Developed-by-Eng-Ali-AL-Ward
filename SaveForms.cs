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
    public partial class SaveForms : DevExpress.XtraEditors.XtraForm
    {
        private Form workingForm;
        public SaveForms()
        {
            InitializeComponent();
        }
        private void SaveForms_Load(object sender, EventArgs e)
        {
            //splashScreenManager2.ShowWaitForm();
            //Fill_Forms();
            //splashScreenManager2.CloseWaitForm();
            //this.Close();
        }
        private void Fill_Forms()
        {
            foreach (Type t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.BaseType == typeof(Form) || t.BaseType == typeof(DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm) || t.BaseType == typeof(DevExpress.XtraEditors.XtraForm) || t.BaseType == typeof(DevExpress.XtraBars.Ribbon.RibbonForm))
                {
                    var emptyCtor = t.GetConstructor(Type.EmptyTypes);
                    if (emptyCtor != null)
                    {
                        BL.ADD form = new BL.ADD();
                        var f = (Form)emptyCtor.Invoke(new object[] { });
                        form.Add_Form(t.Name, f.Text, t.FullName);
                        int from_id = form.Get_Form_Id(t.FullName);
                        Type tt = Type.GetType(t.FullName);
                        workingForm = (Form)Activator.CreateInstance(tt);
                        Fill_Controls(workingForm.Controls, from_id);
                    }
                }

            }
        }
        private void Fill_Controls(Control.ControlCollection controlCollection, int form_id)
        {
            BL.ADD control = new BL.ADD();
            int id=form_id;
            foreach (Control c in controlCollection)
            {
                if (c.HasChildren)
                {
                    Fill_Controls(c.Controls, id);
                }
                if (c is DevExpress.XtraBars.Navigation.AccordionControl)
                {
                    DevExpress.XtraBars.Navigation.AccordionControl ac = c as DevExpress.XtraBars.Navigation.AccordionControl;
                    ac.ForEachElement((el) =>
                    {
                        control.Add_Control(id, el.Text, el.Name);
                    });
                }
                if (c is MenuStrip)
                {
                    MenuStrip menuStrip = c as MenuStrip;
                    FillToolStipItems(menuStrip.Items,id);
                }
                if (c is Button || //c is System.Windows.Forms.ComboBox || c is TextBox ||
                    //   c is ListBox || c is DataGridView || c is RadioButton ||
                    //   c is RichTextBox || c is TabPage ||
                    //   c is PanelControl || c is ComboBoxEdit || c is CheckedComboBoxEdit ||
                   c is SimpleButton
                    //c is TextEdit ||
                    //c is XtraUserControl || c is DevExpress.XtraGrid.GridControl ||
                    //c is UserControl)
                   )
                {
                    control.Add_Control(id, c.Text, c.Name);
                }
            }
        }
        private void FillToolStipItems(ToolStripItemCollection toolStripItems,int form_id)
        {
            int id = form_id;
            foreach (ToolStripMenuItem mi in toolStripItems)
            {
                BL.ADD control = new BL.ADD();
                if (mi.DropDownItems.Count > 0)
                {
                    FillToolStipItems(mi.DropDownItems,id);
                }
                control.Add_Control(id, mi.Text, mi.Name);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            Fill_Forms();
            splashScreenManager2.CloseWaitForm();
            MessageBox.Show("تم تحميل الواجهات بنجاح يتم الان اغلاق الفورم");
            this.Close();
        }
    }
}