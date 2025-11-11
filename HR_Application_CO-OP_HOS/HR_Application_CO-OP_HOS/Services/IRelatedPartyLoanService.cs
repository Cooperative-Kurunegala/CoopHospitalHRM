using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyLoanService
    {
        IEnumerable<RelatedPartyLoan> GetAll();
        RelatedPartyLoan Get(int id);
        void Create(RelatedPartyLoan RelatedPartyLoan);
        void Update(RelatedPartyLoan RelatedPartyLoan);
        void Delete(int id);
    }
}