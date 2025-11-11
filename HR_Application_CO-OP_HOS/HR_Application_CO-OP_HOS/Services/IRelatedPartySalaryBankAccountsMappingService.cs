using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartySalaryBankAccountsMappingService
    {
        IEnumerable<RelatedPartySalaryBankAccountsMapping> GetAll();
        RelatedPartySalaryBankAccountsMapping Get(int id);
        void Create(RelatedPartySalaryBankAccountsMapping RelatedPartySalaryBankAccountsMapping);
        void Update(RelatedPartySalaryBankAccountsMapping RelatedPartySalaryBankAccountsMapping);
        void Delete(int id);
    }
}