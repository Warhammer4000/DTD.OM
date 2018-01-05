using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.OM.Entity.LogEntities;
using DTD.OM.Entity.OrganizationalEntities;
using DTD.OM.Entity.SettingsEntities;

namespace DTD.OM.Entity.UserEntities
{
    public class User
    {
        //DB PK
        public int Serial { get; set; }

        //User Profile
        public string UserId { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Designation Designation { get; set; }
        public UserSettings Settings { get; set; }

        public List<Permission> Permissions { get; set; }
        public List<UserLog> Logs { get; set; }

        

    }
}
