using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class DailyExpense
    {
        public int Day { get; set; }
        public decimal Threshold { get; set; }
        public decimal Total { get; set; }
        public Stack<Log> DailyLogs { get; set; }
        public List<ItemExpense> ItemExpenses { get; set; }

        //For Database fetched design
        public DailyExpense(List<ItemExpense> itemExpenses,Stack<Log> dailyLogs)
        {
            ItemExpenses = itemExpenses;
            DailyLogs = dailyLogs;
        }

        public DailyExpense()
        {
            ItemExpenses = new List<ItemExpense>();
            DailyLogs=new Stack<Log>();
        }
    }
}
