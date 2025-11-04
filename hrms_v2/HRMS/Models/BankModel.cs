using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class BankModel
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public bool IsEnabled { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        // Collections (1-to-Many)
        public List<BankBranchesModel> BankBranches { get; set; }
        public List<RelatedPartyBankAccountsModel> BankAccounts { get; set; }
    }
}