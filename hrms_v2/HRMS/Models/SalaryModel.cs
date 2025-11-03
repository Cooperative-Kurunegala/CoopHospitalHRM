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
        public DateTime IssuedDate { get; set; }
        //Foreign Key Relationship
        public int EmployeeId { get; set; }
        public virtual EmployeeModel Employees { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryModel Categories { get; set; }
        public int DepartmentId { get; set; }
        public virtual DepartmentModel Departments { get; set; }
        public int DesignationId { get; set; }
        public virtual DesignationModel Designations { get; set; }
        public int GradeId { get; set; }
        public virtual GradeModel Grades { get; set; }
        public double GrossSalary { get; set; }
        public double Increments { get; set; }
        public double Deductions { get; set; }
        public double NetSalary { get; set; }

    }
}