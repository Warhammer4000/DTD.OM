using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class MonthlyAllocation
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string ViewName => new DateTimeFormatInfo().GetMonthName(Month) + "," + Year;

        public List<Statement> Statements { get; set; }

        public MonthlyAllocation(List<string> statementNames,int month,int year)
        {
            Statements=new List<Statement>();
            Month = month;
            Year = year;
            foreach (string statementName in statementNames)
            {
                Statements.Add(new Statement(Month,Year){Name =statementName});
            }


        }

        public MonthlyAllocation(List<Statement> statements)
        {
            Statements = statements;
        }
        public MonthlyAllocation()
        {
            Statements = new List<Statement>();
           
        }


    }
}
