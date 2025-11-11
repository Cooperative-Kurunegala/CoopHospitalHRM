using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyOrderService : IRelatedPartyOrderService
    {
        private readonly IRepository<RelatedPartyOrder> _repo;
        public RelatedPartyOrderService(IRepository<RelatedPartyOrder> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyOrder> GetAll() => _repo.GetAll();
        public RelatedPartyOrder Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyOrder RelatedPartyOrder) { _repo.Add(RelatedPartyOrder); _repo.Save(); }
        public void Update(RelatedPartyOrder RelatedPartyOrder) { _repo.Update(RelatedPartyOrder); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}