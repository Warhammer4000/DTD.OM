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
    public partial class NewStatement : MetroFramework.Forms.MetroForm
    {
        public MonthlyAllocation MonthlyAllocation { get; set; }
        
        public NewStatement(List<string> statementsList,int month,int year)
        {
            InitializeComponent();
            MonthlyAllocation= new MonthlyAllocation(statementsList,month,year);
            var info = new DateTimeFormatInfo();
            MonthBox.Items.AddRange(info.MonthNames.ToArray<Object>());
            MonthBox.Items.RemoveAt(MonthBox.Items.Count - 1);
            foreach (int y in Enumerable.Range(2017, 2055))
            {
                YearBox.Items.Add(y.ToString());
            }

            MonthBox.SelectedIndex = DateTime.Now.Month - 1;
            YearBox.Text = DateTime.Now.Year.ToString();


        }

        public NewStatement()
        {
            InitializeComponent();
            MonthlyAllocation = new MonthlyAllocation();
            var info = new DateTimeFormatInfo();
            MonthBox.Items.AddRange(info.MonthNames.ToArray<Object>());
            MonthBox.Items.RemoveAt(MonthBox.Items.Count - 1);
            foreach (int y in Enumerable.Range(2017, 2055))
            {
                YearBox.Items.Add(y.ToString());
            }

            MonthBox.SelectedIndex = DateTime.Now.Month - 1;
            YearBox.Text = DateTime.Now.Year.ToString();


        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthlyAllocation.Month = MonthBox.SelectedIndex + 1;
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthlyAllocation.Year = int.Parse(YearBox.Text);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

     
    }
}
