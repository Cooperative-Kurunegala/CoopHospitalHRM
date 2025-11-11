using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LeaveCategoryService : ILeaveCategoryService
    {
        private readonly IRepository<LeaveCategory> _repo;
        public LeaveCategoryService(IRepository<LeaveCategory> repo) { _repo = repo; }
        public IEnumerable<LeaveCategory> GetAll() => _repo.GetAll();
        public LeaveCategory Get(int id) => _repo.Get(id);
        public void Create(LeaveCategory LeaveCategory) { _repo.Add(LeaveCategory); _repo.Save(); }
        public void Update(LeaveCategory LeaveCategory) { _repo.Update(LeaveCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}