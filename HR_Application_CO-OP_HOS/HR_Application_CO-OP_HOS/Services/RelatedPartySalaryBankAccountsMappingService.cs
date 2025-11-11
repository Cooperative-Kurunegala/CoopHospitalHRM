using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartySalaryBankAccountsMappingService : IRelatedPartySalaryBankAccountsMappingService
    {
        private readonly IRepository<RelatedPartySalaryBankAccountsMapping> _repo;
        public RelatedPartySalaryBankAccountsMappingService(IRepository<RelatedPartySalaryBankAccountsMapping> repo) { _repo = repo; }
        public IEnumerable<RelatedPartySalaryBankAccountsMapping> GetAll() => _repo.GetAll();
        public RelatedPartySalaryBankAccountsMapping Get(int id) => _repo.Get(id);
        public void Create(RelatedPartySalaryBankAccountsMapping RelatedPartySalaryBankAccountsMapping) { _repo.Add(RelatedPartySalaryBankAccountsMapping); _repo.Save(); }
        public void Update(RelatedPartySalaryBankAccountsMapping RelatedPartySalaryBankAccountsMapping) { _repo.Update(RelatedPartySalaryBankAccountsMapping); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}