using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LeaveMasterService : ILeaveMasterService
    {
        private readonly IRepository<LeaveMaster> _repo;
        public LeaveMasterService(IRepository<LeaveMaster> repo) { _repo = repo; }
        public IEnumerable<LeaveMaster> GetAll() => _repo.GetAll();
        public LeaveMaster Get(int id) => _repo.Get(id);
        public void Create(LeaveMaster LeaveMaster) { _repo.Add(LeaveMaster); _repo.Save(); }
        public void Update(LeaveMaster LeaveMaster) { _repo.Update(LeaveMaster); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}