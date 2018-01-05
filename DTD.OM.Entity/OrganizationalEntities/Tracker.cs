using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.Entity.OrganizationalEntities
{
    public class Tracker
    {
        public int Serial { get; set; }
        public string UserId { get; set; }
        public DateTime StaDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Comment { get; set; }
    }
}
