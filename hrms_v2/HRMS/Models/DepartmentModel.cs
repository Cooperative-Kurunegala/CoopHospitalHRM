using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public int CategoryId { get; set; }

        // Navigation Properties
        public CategoryModel Category { get; set; }

        // Collections (1-to-Many)
        public List<EmployeeModel> Employees { get; set; }
        public List<DesignationModel> Designations { get; set; }
    }
}