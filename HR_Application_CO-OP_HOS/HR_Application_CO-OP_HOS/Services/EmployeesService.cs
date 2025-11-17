using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IRepository<Employee> _repo;
        public EmployeesService(IRepository<Employee> repo) { _repo = repo; }
        public IEnumerable<Employee> GetAll() => _repo.GetAll();
        public Employee Get(int id) => _repo.Get(id);
        public void Create(Employee Employee) { _repo.Add(Employee); _repo.Save(); }
        public void Update(Employee Employee) { _repo.Update(Employee); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}