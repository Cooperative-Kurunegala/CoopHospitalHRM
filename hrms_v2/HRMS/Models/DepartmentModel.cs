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
        //Get Foreign Key Relationship With Category Table
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        //Create A Relationship Join With Employee Table
        public virtual ICollection<EmployeeModel> Employees { get; set; }
        //Create A Relationship Join With Designation Table
        public virtual ICollection<DesignationModel> Designations { get; set; }
    }
}