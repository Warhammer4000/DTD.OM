using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class FundAllocation
    {
        public List<MonthlyAllocation> MonthlyAllocations { get; set; }

        public FundAllocation()
        {
            MonthlyAllocations=new List<MonthlyAllocation>();
        }

        public FundAllocation(List<MonthlyAllocation> monthlyAllocations)
        {
            MonthlyAllocations = monthlyAllocations;
        }

    }
}
