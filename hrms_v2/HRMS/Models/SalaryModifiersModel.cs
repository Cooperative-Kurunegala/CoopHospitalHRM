using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class SalaryModifiersModel
    {
        public int ID { get; set; }
        public string SalaryModifierName { get; set; }
        public int SalaryModifierTypeID { get; set; }
        public bool IsNoPay { get; set; }
        public bool IsLateHours { get; set; }
        public int TaxTypeID { get; set; }
        public bool IsEnabled { get; set; }
        public int OrderIndex { get; set; }
        public int OTTypeID { get; set; }
        public bool IsBasicSalary { get; set; }
        public bool IsAllawance { get; set; }

        // Collections (1-to-Many)
        public List<RelatedPartySalaryModifierMappingModel> SalaryMappings { get; set; }
    }
}