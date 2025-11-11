using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly IRepository<LeaveType> _repo;
        public LeaveTypeService(IRepository<LeaveType> repo) { _repo = repo; }
        public IEnumerable<LeaveType> GetAll() => _repo.GetAll();
        public LeaveType Get(int id) => _repo.Get(id);
        public void Create(LeaveType LeaveType) { _repo.Add(LeaveType); _repo.Save(); }
        public void Update(LeaveType LeaveType) { _repo.Update(LeaveType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}