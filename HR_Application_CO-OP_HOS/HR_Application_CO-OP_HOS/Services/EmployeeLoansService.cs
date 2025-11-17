using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeLoansService : IEmployeeLoansService
    {
        private readonly IRepository<EmployeeLoan> _repo;
        public EmployeeLoansService(IRepository<EmployeeLoan> repo) { _repo = repo; }
        public IEnumerable<EmployeeLoan> GetAll() => _repo.GetAll();
        public EmployeeLoan Get(int id) => _repo.Get(id);
        public void Create(EmployeeLoan EmployeeLoan) { _repo.Add(EmployeeLoan); _repo.Save(); }
        public void Update(EmployeeLoan EmployeeLoan) { _repo.Update(EmployeeLoan); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}