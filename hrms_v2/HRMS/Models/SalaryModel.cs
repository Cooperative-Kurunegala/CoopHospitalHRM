using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class SalaryModel
    {
        public int SalaryId { get; set; }
        public string SalaryHeadName { get; set; }
        public string IssuedDate { get; set; }
        public int EmployeeId { get; set; }
        public int CategoryId { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int GradeId { get; set; }
        public double GrossSalary { get; set; }
        public double Increments { get; set; }
        public double Deductions { get; set; }
        public double NetSalary { get; set; }

        // Navigation Properties
        public EmployeeModel Employee { get; set; }
        public CategoryModel Category { get; set; }
        public DepartmentModel Department { get; set; }
        public DesignationModel Designation { get; set; }
        public GradeModel Grade { get; set; }
    }
}