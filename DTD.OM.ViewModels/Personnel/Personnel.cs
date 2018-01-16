using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTD.OM.ViewModels.Personnel
{
    public class Personnel
    {
        public string Name { get; set; }
        public string OfficeMail { get; set; }
        public string PersonalEmail { get; set; }
        public string Designation { get; set; }
        public string MobileNo { get; set; }
        public string NID { get; set; }

        public string Department { get; set; }
        public string Id { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public string ImagePath { get; set; }

        public Personnel()
        {
            JoinDate=DateTime.Today;
        }

        public bool IsValid => !string.IsNullOrEmpty(Designation) && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(OfficeMail) && !string.IsNullOrEmpty(PersonalEmail) && !string.IsNullOrEmpty(MobileNo) && !string.IsNullOrEmpty(Department) && !string.IsNullOrEmpty(Id);
    }
}
