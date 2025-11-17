using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeAllowancesService : IEmployeeAllowancesService
    {
        private readonly IRepository<EmployeeAllowance> _repo;
        public EmployeeAllowancesService(IRepository<EmployeeAllowance> repo) { _repo = repo; }
        public IEnumerable<EmployeeAllowance> GetAll() => _repo.GetAll();
        public EmployeeAllowance Get(int id) => _repo.Get(id);
        public void Create(EmployeeAllowance EmployeeAllowance) { _repo.Add(EmployeeAllowance); _repo.Save(); }
        public void Update(EmployeeAllowance EmployeeAllowance) { _repo.Update(EmployeeAllowance); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}