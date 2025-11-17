using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeCategoriesService : IEmployeeCategoriesService
    {
        private readonly IRepository<EmployeeCategory> _repo;
        public EmployeeCategoriesService(IRepository<EmployeeCategory> repo) { _repo = repo; }
        public IEnumerable<EmployeeCategory> GetAll() => _repo.GetAll();
        public EmployeeCategory Get(int id) => _repo.Get(id);
        public void Create(EmployeeCategory EmployeeCategory) { _repo.Add(EmployeeCategory); _repo.Save(); }
        public void Update(EmployeeCategory EmployeeCategory) { _repo.Update(EmployeeCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}