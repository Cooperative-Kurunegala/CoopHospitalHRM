using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Collections (1-to-Many)
        public List<DepartmentModel> Departments { get; set; }
    }
}