using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyOrderDetailService : IRelatedPartyOrderDetailService
    {
        private readonly IRepository<RelatedPartyOrderDetail> _repo;
        public RelatedPartyOrderDetailService(IRepository<RelatedPartyOrderDetail> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyOrderDetail> GetAll() => _repo.GetAll();
        public RelatedPartyOrderDetail Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyOrderDetail RelatedPartyOrderDetail) { _repo.Add(RelatedPartyOrderDetail); _repo.Save(); }
        public void Update(RelatedPartyOrderDetail RelatedPartyOrderDetail) { _repo.Update(RelatedPartyOrderDetail); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}