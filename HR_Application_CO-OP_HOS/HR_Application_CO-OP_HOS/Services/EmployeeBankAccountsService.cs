using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeBankAccountsService : IEmployeeBankAccountsService
    {
        private readonly IRepository<EmployeeBankAccount> _repo;
        public EmployeeBankAccountsService(IRepository<EmployeeBankAccount> repo) { _repo = repo; }
        public IEnumerable<EmployeeBankAccount> GetAll() => _repo.GetAll();
        public EmployeeBankAccount Get(int id) => _repo.Get(id);
        public void Create(EmployeeBankAccount EmployeeBankAccount) { _repo.Add(EmployeeBankAccount); _repo.Save(); }
        public void Update(EmployeeBankAccount EmployeeBankAccount) { _repo.Update(EmployeeBankAccount); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}