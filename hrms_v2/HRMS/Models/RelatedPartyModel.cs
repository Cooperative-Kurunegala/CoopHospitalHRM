using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RelatedPartyModel
    {
        public int ID { get; set; }
        public string RegistrationNumber { get; set; }
        public string RelatedPartyName { get; set; }
        public string RelatedPartyAddress { get; set; }
        public string RelatedPartyNIC { get; set; }
        public string DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int DivisionMasterID { get; set; }
        public int RelatedPartyTypeID { get; set; }
        public int DesignationID { get; set; }
        public int RelatedPartyCategoryID { get; set; }
        public int CompanyID { get; set; }
        public string RegisteredDate { get; set; }
        public string TelephoneNumberList { get; set; }
        public string MobileNoList { get; set; }
        public string DateofJoin { get; set; }
        public string DateofResignation { get; set; }
        public string UserName { get; set; }
        public string RelatedPartyPassword { get; set; }
        public int RelatedPartyRoleID { get; set; }
        public double BasicSalary { get; set; }
        public string RelatedPartyEmail { get; set; }
        public bool IsActive { get; set; }

        // Navigation Properties
        public CompanyModel Company { get; set; }
        public DesignationModel Designation { get; set; }
        public List<RelatedPartySessionModel> Sessions { get; set; }
        public List<RelatedPartySalaryModel> Salaries { get; set; }
        public List<RelatedPartyLoanModel> Loans { get; set; }
    }
}