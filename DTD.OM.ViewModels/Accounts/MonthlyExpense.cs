using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class MonthlyExpense
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public List<DailyExpense> DailyExpenseList { get; set; }
        public Stack<Log> MonthlyLog { get; set; }

        //For Database Oriented
        public MonthlyExpense(List<DailyExpense> dailyExpense)
        {
            DailyExpenseList = dailyExpense;
        }

        //For Serializing 
        public MonthlyExpense()
        {
            
        }

        public MonthlyExpense(int month,int year)
        {
            Month = month;
            Year = year;
            DailyExpenseList=new List<DailyExpense>();
            for (int i = 0; i < DateTime.DaysInMonth(Year, Month); i++)
            {
                DailyExpenseList.Add(new DailyExpense(){Day = i+1});
            }
        }
    }
}
