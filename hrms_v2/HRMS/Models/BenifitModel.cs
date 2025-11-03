using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class BenifitModel
    {
        public int BenefitId { get; set; }
        public string BenefitName { get; set; }
        public string BenefitDescription { get; set; }
        public string BenefitAmount { get; set; }
        //Create A Relationship With Employee
        public virtual ICollection<EmployeeBenefitModel> EmployeeBenefits { get; set; }
    }
}