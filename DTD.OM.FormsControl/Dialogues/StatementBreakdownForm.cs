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
        public Statement Statement { get; set; }
        public BreakDown Breakdown { get; set; }
        
        private DailyExpense DailyExpense { get; set; }
        public StatementBreakdownForm(Statement statement)
        {
            InitializeComponent();
            Statement = statement;
            Breakdown = Statement.BreakDown;
            
            Allocation.Value = Statement.Allocated;
            MonthLable.Text = @","+new DateTimeFormatInfo().GetMonthName(Breakdown.Month)+ @",";
            YearLable.Text = Breakdown.Year.ToString();
            int days = DateTime.DaysInMonth(Breakdown.Year, Breakdown.Month);
            for (int i=1;i<=days;i++)
            {
                DayBox.Items.Add(i);
            }

            DayBox.SelectedIndex = DateTime.Today.Day-1;

            InitializeData(DateTime.Today.Day);
        }

        private void InitializeData(int day)
        {
            DailyExpense = Breakdown.DailyExpenseList[day];
            Total.Value = DailyExpense.Total;
            foreach (var itemExpense in DailyExpense.ItemExpenses)
            {
                var itemExpenseControl = new ItemExpenseControl(itemExpense) { Dock = DockStyle.Top };
                itemExpenseControl.ItemNameBox.TextChanged += ValueChanged;
                itemExpenseControl.value.ValueChanged += ValueChanged;
                itemExpenseControl.RemoveButton.Click += ValueChanged;
                ViewPanel.Controls.Add(itemExpenseControl);
            }

            if (DailyExpense.Threshold == 0)
            {
                DailyExpense.Threshold=Statement.Allocated / DateTime.DaysInMonth(Breakdown.Year, Breakdown.Month);
            }
            dailyThreashold.Value = DailyExpense.Threshold;
            


        }

        private void ValueChanged(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (ItemExpenseControl itemExpense in ViewPanel.Controls)
            {
                sum += itemExpense.DailyExpense.Cost;
            }

            Total.Value = sum;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            var itemExpenseControl = new ItemExpenseControl(){Dock = DockStyle.Top};
            
            itemExpenseControl.ItemNameBox.TextChanged += ValueChanged;
            itemExpenseControl.value.ValueChanged += ValueChanged;
            itemExpenseControl.RemoveButton.Click += ValueChanged;
            DailyExpense.ItemExpenses.Add(itemExpenseControl.DailyExpense);
            ViewPanel.Controls.Add(itemExpenseControl);
        }

       

        private void Total_ValueChanged(object sender, EventArgs e)
        {
            Left.Value = Allocation.Value - Total.Value;
            Statement.Left = Left.Value;
            DailyExpense.Total = Total.Value;
        }

        private void dailyThreashold_ValueChanged(object sender, EventArgs e)
        {
            DailyExpense.Threshold = dailyThreashold.Value;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
     
            DialogResult = DialogResult.OK;
        }
    }
}
