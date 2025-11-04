using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class LoanCategoryModel
    {
        public int ID { get; set; }
        public double DefaultAllocation { get; set; }
        public string LoanCategoryName { get; set; }
        public bool IsFixedLoanInstallments { get; set; }

        // Collections (1-to-Many)
        public List<RelatedPartyLoanModel> Loans { get; set; }
    }
}