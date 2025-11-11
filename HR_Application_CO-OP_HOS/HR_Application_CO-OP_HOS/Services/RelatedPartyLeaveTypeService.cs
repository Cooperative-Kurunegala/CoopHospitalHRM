using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyLeaveTypeService : IRelatedPartyLeaveTypeService
    {
        private readonly IRepository<RelatedPartyLeaveType> _repo;
        public RelatedPartyLeaveTypeService(IRepository<RelatedPartyLeaveType> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyLeaveType> GetAll() => _repo.GetAll();
        public RelatedPartyLeaveType Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyLeaveType RelatedPartyLeaveType) { _repo.Add(RelatedPartyLeaveType); _repo.Save(); }
        public void Update(RelatedPartyLeaveType RelatedPartyLeaveType) { _repo.Update(RelatedPartyLeaveType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}