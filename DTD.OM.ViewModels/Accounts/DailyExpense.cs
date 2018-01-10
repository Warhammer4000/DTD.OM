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
        public List<ItemExpense> ItemExpenses { get; set; }

        public DailyExpense(List<ItemExpense> itemExpenses)
        {
            ItemExpenses = itemExpenses;
        }

        public DailyExpense()
        {
            ItemExpenses = new List<ItemExpense>();

        }
    }
}
