using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class DesignationModel
    {
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }

        // Navigation Properties
        public DepartmentModel Department { get; set; }

        // Collections (1-to-Many)
        public List<EmployeeModel> Employees { get; set; }
        public List<RelatedPartyModel> RelatedParties { get; set; }
    }
}