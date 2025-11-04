using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RelatedPartySalaryModel
    {
        public int ID { get; set; }
        public int RelatedPartyEPF { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CompanyID { get; set; }
        public double NoPayDays { get; set; }
        public int LateMinutes { get; set; }
        public int OTMinutes { get; set; }
        public int RelatedPartyID { get; set; }
        public bool IsPayoutGenerated { get; set; }
        public bool IsLocked { get; set; }
        public int SalaryTypeID { get; set; }
        public double PayeeTaxRate { get; set; }
        public double WorkedDays { get; set; }

        // Navigation Properties
        public RelatedPartyModel RelatedParty { get; set; }
        public CompanyModel Company { get; set; }
        public SalaryTypeModel SalaryType { get; set; }

        // Collections (1-to-Many)
        public List<RelatedPartySalaryModifierMappingModel> SalaryModifiers { get; set; }
    }
}