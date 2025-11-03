using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RelatedPartySalaryModifierMappingModel
    {
        public int ID { get; set; }
        public int RelatedPartySalaryID { get; set; }
        public int SalaryModifierID { get; set; }
        public int OrderIndex { get; set; }
        public string GroupingForSlip { get; set; }
        public string ActualAmount { get; set; }
        public string SalaryModifierName { get; set; }
        public int SalaryModifierTypeID { get; set; }
        public bool IsNoPay { get; set; }
        public bool IsLateHours { get; set; }

        // Navigation Properties
        public RelatedPartySalaryModel RelatedPartySalary { get; set; }
        public SalaryModifiersModel SalaryModifier { get; set; }
    }
}