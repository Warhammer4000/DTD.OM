using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTD.OM.FormsControl.CustomControls
{
    public partial class PersonnelControl : MetroFramework.Controls.MetroUserControl
    {
        public PersonnelControl(ViewModels.Personnel.Personnel personnel)
        {
            InitializeComponent();
            NameLable.Text = personnel.Name;
            OfficeEmail.Text = personnel.OfficeMail + @"@iquantile.com";
            PersonalEmail.Text = personnel.PersonalEmail;
            MobileNo.Text = personnel.MobileNo;
            NID.Text = @"NID:" + personnel.NID;
            Department.Text = personnel.Department+@"Department";
            Designation.Text = personnel.Designation;
            OfficeID.Text = @"ID:"+personnel.Id;
            Salary.Text = @"Salary:" + personnel.Salary + @"/= BDT";
            JoinDate.Text = @"Join Date:" + personnel.JoinDate.ToString("yyyy MMMM dd");
        }
    }
}
