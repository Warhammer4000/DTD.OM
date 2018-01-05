using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTD.OM.Entity.LogEntities;
using DTD.OM.Entity.SettingsEntities;
using DTD.OM.Entity.UserEntities;

namespace DTD.OM.Entity.OrganizationalEntities
{
    public class Office
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
        public string Officelogo { get; set; }
        public List<User> Users { get; set; }
        public List<OrganizationalLog> Logs { get; set; }
        public OrganizationalSettings Settings { get; set; }
        public List<Tracker> TrackerList { get; set; }
    }
}
