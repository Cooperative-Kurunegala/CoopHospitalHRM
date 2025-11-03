using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class CompanyModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }

        // Collections (1-to-Many)
        public List<EmployeeModel> Employees { get; set; }
        public List<RelatedPartyModel> RelatedParties { get; set; }
        public List<DepartmentModel> Departments { get; set; }
    }
}