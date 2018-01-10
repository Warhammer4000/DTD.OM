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
       
        public List<DailyExpense> DailyExpenseList { get; set; }

        public BreakDown(List<DailyExpense> dailyExpense)
        {
            DailyExpenseList = dailyExpense;
        }

        public BreakDown(int days)
        {
            DailyExpenseList=new List<DailyExpense>();
            for (int i = 0; i < days; i++)
            {
                DailyExpenseList.Add(new DailyExpense());
            }
        }
    }
}
