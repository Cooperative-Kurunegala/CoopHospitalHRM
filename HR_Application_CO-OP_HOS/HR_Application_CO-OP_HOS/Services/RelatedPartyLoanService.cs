using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyLoanService : IRelatedPartyLoanService
    {
        private readonly IRepository<RelatedPartyLoan> _repo;
        public RelatedPartyLoanService(IRepository<RelatedPartyLoan> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyLoan> GetAll() => _repo.GetAll();
        public RelatedPartyLoan Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyLoan RelatedPartyLoan) { _repo.Add(RelatedPartyLoan); _repo.Save(); }
        public void Update(RelatedPartyLoan RelatedPartyLoan) { _repo.Update(RelatedPartyLoan); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}