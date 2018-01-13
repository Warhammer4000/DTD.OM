using System;
using System.Collections.Generic;

namespace DTD.OM.ViewModels.Accounts
{
    public class Statement
    {
        public string Name { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal Allocated { get; set; }
        public decimal Left { get; set; }
        public MonthlyExpense MonthlyExpense { get; set; }
        public Stack<Log> StatementLogs { get; set; }


        public Statement(int month,int year)
        {
            Month = month;
            Year = year;
            MonthlyExpense=new MonthlyExpense(month,year);
            StatementLogs= new Stack<Log>();//TODO NOT YET IMPLEMENTED
            Month = 1;
        }


    }
}
