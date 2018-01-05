using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.Entity.OrganizationalEntities
{
    public class Designation
    {
       
        public int Serial { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
