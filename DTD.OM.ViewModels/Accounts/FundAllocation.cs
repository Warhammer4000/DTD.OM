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
        public Stack<Log> AllocationLog { get; set; }

        //Serializing oriented
        public FundAllocation()
        {
            MonthlyAllocations=new List<MonthlyAllocation>();
            AllocationLog=new Stack<Log>();
        }
        //Database oriented
        public FundAllocation(List<MonthlyAllocation> monthlyAllocations,Stack<Log> allocationLog)
        {
            MonthlyAllocations = monthlyAllocations;
            AllocationLog = allocationLog;
        }

    }
}
