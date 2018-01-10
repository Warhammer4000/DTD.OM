using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Accounts
{
    public class Statement
    {
        public string Name { get; set; }
        public decimal Allocated { get; set; }
        public decimal Left { get; set; }
        public BreakDown BreakDown { get; set; }

        public Statement()
        {
            BreakDown=new BreakDown();
        }


    }
}
