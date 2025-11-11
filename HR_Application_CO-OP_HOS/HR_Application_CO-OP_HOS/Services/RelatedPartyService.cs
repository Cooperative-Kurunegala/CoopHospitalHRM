using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyService : IRelatedPartyService
    {
        private readonly IRepository<RelatedParty> _repo;
        public RelatedPartyService(IRepository<RelatedParty> repo) { _repo = repo; }
        public IEnumerable<RelatedParty> GetAll() => _repo.GetAll();
        public RelatedParty Get(int id) => _repo.Get(id);
        public void Create(RelatedParty rp) { _repo.Add(rp); _repo.Save(); }
        public void Update(RelatedParty rp) { _repo.Update(rp); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }

}