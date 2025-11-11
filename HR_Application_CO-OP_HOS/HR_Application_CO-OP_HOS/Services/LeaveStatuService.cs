using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LeaveStatuService : ILeaveStatuService
    {
        private readonly IRepository<LeaveStatu> _repo;
        public LeaveStatuService(IRepository<LeaveStatu> repo) { _repo = repo; }
        public IEnumerable<LeaveStatu> GetAll() => _repo.GetAll();
        public LeaveStatu Get(int id) => _repo.Get(id);
        public void Create(LeaveStatu LeaveStatu) { _repo.Add(LeaveStatu); _repo.Save(); }
        public void Update(LeaveStatu LeaveStatu) { _repo.Update(LeaveStatu); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}