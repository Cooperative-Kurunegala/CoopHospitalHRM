using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyCategoryService : IRelatedPartyCategoryService
    {
        private readonly IRepository<RelatedPartyCategory> _repo;
        public RelatedPartyCategoryService(IRepository<RelatedPartyCategory> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyCategory> GetAll() => _repo.GetAll();
        public RelatedPartyCategory Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyCategory RelatedPartyCategory) { _repo.Add(RelatedPartyCategory); _repo.Save(); }
        public void Update(RelatedPartyCategory RelatedPartyCategory) { _repo.Update(RelatedPartyCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}