using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class SalaryTypeModel
    {
        public int ID { get; set; }
        public string SalaryTypeName { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        // Collections (1-to-Many)
        public List<RelatedPartySalaryModel> Salaries { get; set; }
    }
}