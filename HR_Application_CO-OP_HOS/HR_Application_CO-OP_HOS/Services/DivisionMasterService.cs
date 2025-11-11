using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DivisionMasterService : IDivisionMasterService
    {
        private readonly IRepository<DivisionMaster> _repo;
        public DivisionMasterService(IRepository<DivisionMaster> repo) { _repo = repo; }
        public IEnumerable<DivisionMaster> GetAll() => _repo.GetAll();
        public DivisionMaster Get(int id) => _repo.Get(id);
        public void Create(DivisionMaster divisionMaster) { _repo.Add(divisionMaster); _repo.Save(); }
        public void Update(DivisionMaster divisionMaster) { _repo.Update(divisionMaster); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}