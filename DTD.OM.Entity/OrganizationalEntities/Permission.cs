using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.Entity.OrganizationalEntities
{
    public class Permission
    {
        public string FeatureId { get; set; }
        public string FeatureName { get; set; }
        public bool Add { get; set; }
        public bool Edit { get; set; }
        public bool View { get; set; }
    }
}
