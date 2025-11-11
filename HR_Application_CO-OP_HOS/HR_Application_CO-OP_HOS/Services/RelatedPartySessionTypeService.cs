using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartySessionTypeService : IRelatedPartySessionTypeService
    {
        private readonly IRepository<RelatedPartySessionType> _repo;
        public RelatedPartySessionTypeService(IRepository<RelatedPartySessionType> repo) { _repo = repo; }
        public IEnumerable<RelatedPartySessionType> GetAll() => _repo.GetAll();
        public RelatedPartySessionType Get(int id) => _repo.Get(id);
        public void Create(RelatedPartySessionType RelatedPartySessionType) { _repo.Add(RelatedPartySessionType); _repo.Save(); }
        public void Update(RelatedPartySessionType RelatedPartySessionType) { _repo.Update(RelatedPartySessionType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}