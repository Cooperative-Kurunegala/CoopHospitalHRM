using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RelatedPartyLoanModel
    {
        public int ID { get; set; }
        public int RelatedPartyID { get; set; }
        public double LoanTotalAmount { get; set; }
        public double MonthlyAmount { get; set; }
        public int NoOfInstallments { get; set; }
        public string LoanStartDate { get; set; }
        public int LoanCategoryID { get; set; }
        public bool IsActive { get; set; }
        public string LoanEndDate { get; set; }

        // Navigation Properties
        public RelatedPartyModel RelatedParty { get; set; }
        public LoanCategoryModel LoanCategory { get; set; }
    }

}