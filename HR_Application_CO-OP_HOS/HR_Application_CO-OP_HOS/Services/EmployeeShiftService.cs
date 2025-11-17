using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeShiftService : IEmployeeShiftService
    {
        private readonly IRepository<EmployeeShift> _repo;
        public EmployeeShiftService(IRepository<EmployeeShift> repo) { _repo = repo; }
        public IEnumerable<EmployeeShift> GetAll() => _repo.GetAll();
        public EmployeeShift Get(int id) => _repo.Get(id);
        public void Create(EmployeeShift EmployeeShift) { _repo.Add(EmployeeShift); _repo.Save(); }
        public void Update(EmployeeShift EmployeeShift) { _repo.Update(EmployeeShift); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}