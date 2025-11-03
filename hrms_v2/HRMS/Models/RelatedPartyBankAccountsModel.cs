using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RelatedPartyBankAccountsModel
    {
        public int ID { get; set; }
        public int RelatedPartyID { get; set; }
        public int BankID { get; set; }
        public int BranchID { get; set; }
        public double StandingOrderAmount { get; set; }
        public string BankAccountNo { get; set; }
        public bool IsEnable { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        // Navigation Properties
        public RelatedPartyModel RelatedParty { get; set; }
        public BankModel Bank { get; set; }
        public BankBranchesModel BankBranch { get; set; }
    }
}