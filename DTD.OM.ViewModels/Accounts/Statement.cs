using System;

namespace DTD.OM.ViewModels.Accounts
{
    public class Statement
    {
        public string Name { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal Allocated { get; set; }
        public decimal Left { get; set; }
        public BreakDown BreakDown { get; set; }

        public Statement(int month,int year)
        {
            Month = month;
            Year = year;
            BreakDown=new BreakDown(DateTime.DaysInMonth(Year,Month));
            Month = 1;
        }


    }
}
