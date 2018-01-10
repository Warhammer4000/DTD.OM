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
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.Dialogues
{
    public partial class StatementBreakdownForm : Form
    {
        public BreakDown Breakdown { get; set; }
        public StatementBreakdownForm(BreakDown breakDown, int month,int year)
        {
            InitializeComponent();
            Breakdown = breakDown;
            MonthLable.Text = @","+new DateTimeFormatInfo().GetMonthName(month)+ @",";
            YearLable.Text = year.ToString();

            for (int i=1;i<=DateTime.DaysInMonth(year,month);i++)
            {
                DayBox.Items.Add(i);
            }

            DayBox.SelectedIndex = DateTime.Today.Day-1;

            InitializeData(DateTime.Today.Day);
        }

        private void InitializeData(int day)
        {
            var dailyExpense = Breakdown.DailyExpenseList[day];
            Total.Value = dailyExpense.Total;
            foreach (var itemExpense in dailyExpense.ItemExpenses)
            {
                var itemExpenseControl = new ItemExpenseControl(itemExpense) { Dock = DockStyle.Top };
                ViewPanel.Controls.Add(itemExpenseControl);
            }
            dailyThreashold.Value = dailyExpense.Threshold;
           


        }


        private void AddItem_Click(object sender, EventArgs e)
        {
            var dailyExpense= new ItemExpenseControl(){Dock = DockStyle.Top};
            ViewPanel.Controls.Add(dailyExpense);
        }
    }
}
