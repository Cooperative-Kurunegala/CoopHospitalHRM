using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyLeaveAllocationService : IRelatedPartyLeaveAllocationService
    {
        private readonly IRepository<RelatedPartyLeaveAllocation> _repo;
        public RelatedPartyLeaveAllocationService(IRepository<RelatedPartyLeaveAllocation> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyLeaveAllocation> GetAll() => _repo.GetAll();
        public RelatedPartyLeaveAllocation Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyLeaveAllocation RelatedPartyLeaveAllocation) { _repo.Add(RelatedPartyLeaveAllocation); _repo.Save(); }
        public void Update(RelatedPartyLeaveAllocation RelatedPartyLeaveAllocation) { _repo.Update(RelatedPartyLeaveAllocation); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}