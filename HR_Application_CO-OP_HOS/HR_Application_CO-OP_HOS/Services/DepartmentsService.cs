using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DepartmentsService : IDepartmentsService
    {
        private readonly IRepository<Department> _repo;
        public DepartmentsService(IRepository<Department> repo) { _repo = repo; }
        public IEnumerable<Department> GetAll() => _repo.GetAll();
        public Department Get(int id) => _repo.Get(id);
        public void Create(Department Department) { _repo.Add(Department); _repo.Save(); }
        public void Update(Department Department) { _repo.Update(Department); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}