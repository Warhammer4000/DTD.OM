using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels
{
    public class Log
    {
        public DateTime TimeStamp { get;}
        public string Message { get; set; }
        public string LogObject { get; set; }
        public Log()
        {
            TimeStamp=DateTime.Now;
        }

    }
}
