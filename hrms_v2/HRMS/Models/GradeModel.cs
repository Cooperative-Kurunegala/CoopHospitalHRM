using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class GradeModel
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string GradeSalary { get; set; }

        // Collections (1-to-Many)
        public List<EmployeeModel> Employees { get; set; }
    }
}