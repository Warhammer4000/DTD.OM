using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class BreakDown
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public List<DailyExpense> DailyExpenseList { get; set; }

        public BreakDown(List<DailyExpense> dailyExpense)
        {
            DailyExpenseList = dailyExpense;
        }

        public BreakDown(int month,int year)
        {
            Month = month;
            Year = year;
            DailyExpenseList=new List<DailyExpense>();
            for (int i = 0; i < DateTime.DaysInMonth(Year, Month); i++)
            {
                DailyExpenseList.Add(new DailyExpense());
            }
        }
    }
}
