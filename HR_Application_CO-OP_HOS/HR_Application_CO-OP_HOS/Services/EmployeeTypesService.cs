using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeTypesService : IEmployeeTypesService
    {
        private readonly IRepository<EmployeeType> _repo;
        public EmployeeTypesService(IRepository<EmployeeType> repo) { _repo = repo; }
        public IEnumerable<EmployeeType> GetAll() => _repo.GetAll();
        public EmployeeType Get(int id) => _repo.Get(id);
        public void Create(EmployeeType EmployeeType) { _repo.Add(EmployeeType); _repo.Save(); }
        public void Update(EmployeeType EmployeeType) { _repo.Update(EmployeeType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}