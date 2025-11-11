using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartySessionService : IRelatedPartySessionService
    {
        private readonly IRepository<RelatedPartySession> _repo;
        public RelatedPartySessionService(IRepository<RelatedPartySession> repo) { _repo = repo; }
        public IEnumerable<RelatedPartySession> GetAll() => _repo.GetAll();
        public RelatedPartySession Get(int id) => _repo.Get(id);
        public void Create(RelatedPartySession RelatedPartySession) { _repo.Add(RelatedPartySession); _repo.Save(); }
        public void Update(RelatedPartySession RelatedPartySession) { _repo.Update(RelatedPartySession); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}