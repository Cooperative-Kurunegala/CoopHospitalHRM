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
        //Get Foreign Key Relationship With Department
        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
        //Create A Relationship With Employee
        public virtual ICollection<EmployeeModel> Employees { get; set; }
    }
}