using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyRoleService : IRelatedPartyRoleService
    {
        private readonly IRepository<RelatedPartyRole> _repo;
        public RelatedPartyRoleService(IRepository<RelatedPartyRole> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyRole> GetAll() => _repo.GetAll();
        public RelatedPartyRole Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyRole RelatedPartyRole) { _repo.Add(RelatedPartyRole); _repo.Save(); }
        public void Update(RelatedPartyRole RelatedPartyRole) { _repo.Update(RelatedPartyRole); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}