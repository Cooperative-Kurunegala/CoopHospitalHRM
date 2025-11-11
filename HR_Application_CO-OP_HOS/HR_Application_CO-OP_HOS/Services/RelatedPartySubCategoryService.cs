using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartySubCategoryService : IRelatedPartySubCategoryService
    {
        private readonly IRepository<RelatedPartySubCategory> _repo;
        public RelatedPartySubCategoryService(IRepository<RelatedPartySubCategory> repo) { _repo = repo; }
        public IEnumerable<RelatedPartySubCategory> GetAll() => _repo.GetAll();
        public RelatedPartySubCategory Get(int id) => _repo.Get(id);
        public void Create(RelatedPartySubCategory RelatedPartySubCategory) { _repo.Add(RelatedPartySubCategory); _repo.Save(); }
        public void Update(RelatedPartySubCategory RelatedPartySubCategory) { _repo.Update(RelatedPartySubCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}