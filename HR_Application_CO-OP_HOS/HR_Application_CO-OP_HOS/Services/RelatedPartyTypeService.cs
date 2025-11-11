using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyTypeService : IRelatedPartyTypeService
    {
        private readonly IRepository<RelatedPartyType> _repo;
        public RelatedPartyTypeService(IRepository<RelatedPartyType> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyType> GetAll() => _repo.GetAll();
        public RelatedPartyType Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyType RelatedPartyType) { _repo.Add(RelatedPartyType); _repo.Save(); }
        public void Update(RelatedPartyType RelatedPartyType) { _repo.Update(RelatedPartyType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}