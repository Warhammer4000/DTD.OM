using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.OM.ViewModels.Accounts;
using DTD.OM.ViewModels.Personnel;

namespace DTD.OM.Globals
{
    public static class ViewModelGlobals
    {
       //public static  FinancialStatements FinancialStatements { get; set; }
       public static FundAllocation FundAllocation { get; set; }
       public static List<Personnel> Personnels { get; set; }
    }
}
