using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyLoan1Service : IRelatedPartyLoan1Service
    {
        private readonly IRepository<RelatedPartyLoan1> _repo;
        public RelatedPartyLoan1Service(IRepository<RelatedPartyLoan1> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyLoan1> GetAll() => _repo.GetAll();
        public RelatedPartyLoan1 Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyLoan1 RelatedPartyLoan1) { _repo.Add(RelatedPartyLoan1); _repo.Save(); }
        public void Update(RelatedPartyLoan1 RelatedPartyLoan1) { _repo.Update(RelatedPartyLoan1); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}