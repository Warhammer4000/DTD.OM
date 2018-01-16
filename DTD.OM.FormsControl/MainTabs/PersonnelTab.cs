using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.FormsControl.Dialogues;
using DTD.OM.ViewModels.Personnel;

namespace DTD.OM.FormsControl.MainTabs
{
    public partial class PersonnelTab : MetroFramework.Controls.MetroUserControl
    {
        public PersonnelTab()
        {
            InitializeComponent();
        }

        private void NewPersonnelButton_Click(object sender, EventArgs e)
        {
            NewUserForm form= new NewUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Personnel personnel = form.Personnel;
                PersonnelControl personnelControl=new PersonnelControl(personnel){Dock = DockStyle.Top};
                viewPanel.Controls.Add(personnelControl);
            }
        }
    }
}
