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

        public MonthlyAllocation(List<string> statementNames)
        {
            Statements=new List<Statement>();
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            foreach (string statementName in statementNames)
            {
                Statements.Add(new Statement(Month,Year){Name =statementName});
            }


        }

        public MonthlyAllocation(List<Statement> statements)
        {
            Statements = statements;
        }


    }
}
