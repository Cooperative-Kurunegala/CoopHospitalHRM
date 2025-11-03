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

        // Navigation Properties (Many-to-Many junction)
        public EmployeeModel Employee { get; set; }
        public BenifitModel Benefit { get; set; }
    }
}