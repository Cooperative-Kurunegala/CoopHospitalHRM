using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyFixedRosterService : IRelatedPartyFixedRosterService
    {
        private readonly IRepository<RelatedPartyFixedRoster> _repo;
        public RelatedPartyFixedRosterService(IRepository<RelatedPartyFixedRoster> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyFixedRoster> GetAll() => _repo.GetAll();
        public RelatedPartyFixedRoster Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyFixedRoster RelatedPartyFixedRoster) { _repo.Add(RelatedPartyFixedRoster); _repo.Save(); }
        public void Update(RelatedPartyFixedRoster RelatedPartyFixedRoster) { _repo.Update(RelatedPartyFixedRoster); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}