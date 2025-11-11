using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyBankAccountService
    {
        IEnumerable<RelatedPartyBankAccount> GetAll();
        RelatedPartyBankAccount Get(int id);
        void Create(RelatedPartyBankAccount RelatedPartyBankAccount);
        void Update(RelatedPartyBankAccount RelatedPartyBankAccount);
        void Delete(int id);
    }
}