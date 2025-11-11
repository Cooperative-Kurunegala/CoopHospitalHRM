using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyBankAccountService : IRelatedPartyBankAccountService
    {
        private readonly IRepository<RelatedPartyBankAccount> _repo;
        public RelatedPartyBankAccountService(IRepository<RelatedPartyBankAccount> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyBankAccount> GetAll() => _repo.GetAll();
        public RelatedPartyBankAccount Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyBankAccount RelatedPartyBankAccount) { _repo.Add(RelatedPartyBankAccount); _repo.Save(); }
        public void Update(RelatedPartyBankAccount RelatedPartyBankAccount) { _repo.Update(RelatedPartyBankAccount); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}