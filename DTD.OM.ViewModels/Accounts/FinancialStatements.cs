using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class FinancialStatements
    {
        public List<string> StatementNamesList { get; set; }

        public FinancialStatements()
        {
            StatementNamesList = new List<string>();
        }

        public FinancialStatements(List<string> statements)
        {
            StatementNamesList = statements;
        }


    }
}
