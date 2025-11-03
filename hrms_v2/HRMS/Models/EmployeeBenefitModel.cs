using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class EmployeeBenefitModel
    {
        public int EmployeeBenefitId { get; set; }
        public int EmployeeId { get; set; }
        public int BenefitId { get; set; }
        public virtual EmployeeModel Employee { get; set; }
        public virtual BenifitModel Benefit { get; set; }
    }
}