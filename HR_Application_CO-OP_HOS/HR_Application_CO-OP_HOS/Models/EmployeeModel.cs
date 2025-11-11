using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("RelatedParty")]
    public class EmployeeModel
    {
        [Key] public int ID { get; set; }
        [StringLength(100)] public string RegistrationNumber { get; set; }
        [StringLength(100)] public string RelatedPartyName { get; set; }
        [StringLength(1000)] public string RelatedPartyAddress { get; set; }
        [StringLength(50)] public string RelatedPartyNIC { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte? Gender { get; set; }
        public int? DivisionMasterID { get; set; }
        public int? RelatedPartyTypeID { get; set; }
        public int? DesignationID { get; set; }
        public int? RelatedPartyCategoryID { get; set; }
        public int? CompanyID { get; set; }
        public DateTime? RegisteredDate { get; set; }
        [StringLength(200)] public string TelephoneNumberList { get; set; }
        [StringLength(200)] public string MobileNoList { get; set; }
        public DateTime? DateofJoin { get; set; }
        public DateTime? DateofResignation { get; set; }
        [StringLength(50)] public string UserName { get; set; }
        [StringLength(100)] public string RelatedPartyPassword { get; set; }
        public int? RelatedPartyRoleID { get; set; }
        public int? DefaultSplashScreenItemID { get; set; }
        public int? LocationID { get; set; }
        [StringLength(100)] public string Weight { get; set; }
        [StringLength(100)] public string Height { get; set; }
        public bool? IsDivisionHead { get; set; }
        [Column(TypeName = "decimal")] public decimal? BasicSalary { get; set; }
        [StringLength(100)] public string RelatedPartyEmail { get; set; }
        public bool? IsActive { get; set; }

        // payroll fields omitted here for brevity - add as needed
        public virtual ICollection<RelatedPartyBankAccount> BankAccounts { get; set; } = new HashSet<RelatedPartyBankAccount>();
        public virtual ICollection<SalaryModel> Salaries { get; set; } = new HashSet<SalaryModel>();
        public virtual ICollection<RelatedPartyOrder> Orders { get; set; } = new HashSet<RelatedPartyOrder>();
    }
}