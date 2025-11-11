using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly IRepository<Leave> _repo;
        public LeaveService(IRepository<Leave> repo) { _repo = repo; }
        public IEnumerable<Leave> GetAll() => _repo.GetAll();
        public Leave Get(int id) => _repo.Get(id);
        public void Create(Leave Leave) { _repo.Add(Leave); _repo.Save(); }
        public void Update(Leave Leave) { _repo.Update(Leave); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}