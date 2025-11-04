using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class BankBranchesModel
    {
        public int ID { get; set; }
        public string BranchName { get; set; }
        public int BankID { get; set; }
        public string BranchCode { get; set; }
        public bool IsEnabled { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        // Navigation Properties
        public BankModel Bank { get; set; }

        // Collections (1-to-Many)
        public List<RelatedPartyBankAccountsModel> BankAccounts { get; set; }
    }
}