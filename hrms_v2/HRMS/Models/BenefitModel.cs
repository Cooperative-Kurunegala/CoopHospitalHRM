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

        // Collections (Many-to-Many through EmployeeBenefitModel)
        public List<EmployeeBenefitModel> EmployeeBenefits { get; set; }
    }
}