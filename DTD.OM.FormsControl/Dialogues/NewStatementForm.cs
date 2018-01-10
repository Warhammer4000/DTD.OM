using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.Dialogues
{
    public partial class NewStatementForm : Form
    {
        public Statement Statement { get; set; }
        public NewStatementForm()
        {
            InitializeComponent();
            Statement= new Statement(1,DateTime.Now.Year);
            var info= new DateTimeFormatInfo();
            MonthBox.Items.AddRange(info.MonthNames.ToArray<Object>());
            MonthBox.Items.RemoveAt(MonthBox.Items.Count-1);
            foreach (int year in Enumerable.Range(2017, 2055))
            {
                YearBox.Items.Add(year.ToString());
            }


        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Statement.Month = MonthBox.SelectedIndex + 1;
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Statement.Year = int.Parse(YearBox.Text);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }
    }
}
