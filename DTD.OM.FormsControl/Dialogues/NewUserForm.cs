using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.ViewModels.Personnel;
using MetroFramework;

namespace DTD.OM.FormsControl.Dialogues
{
    public partial class NewUserForm : MetroFramework.Forms.MetroForm
    {
        public Personnel Personnel { get; set; }
        public NewUserForm()
        {
            Personnel= new Personnel();
            InitializeComponent();
        }

        private void ImageAddButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Personnel.Name = NameTextBox.Text;
            Personnel.PersonalEmail = PersonalEmail.Text;
            Personnel.OfficeMail = EmailTextBox.Text;
            Personnel.MobileNo = MobileNo.Text;
            Personnel.NID = NIDTextBox.Text;
            Personnel.Department = DepartmentPicker.Text;
            Personnel.Id = IdTextbox.Text;
            Personnel.Salary = numericUpDown1.Value;
            Personnel.JoinDate = joinDate.Value;
            Personnel.Designation = DesignationPicker.Text;

            if (Personnel.IsValid)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MetroMessageBox.Show(this, "Invalid/Incomplete Data", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
