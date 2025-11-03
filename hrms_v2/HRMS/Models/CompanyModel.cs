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

        //Create A Relationship With Employee
        public virtual ICollection<EmployeeModel> Employees { get; set; }
    }
}