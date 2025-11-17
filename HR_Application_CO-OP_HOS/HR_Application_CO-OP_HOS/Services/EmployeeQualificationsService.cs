using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeQualificationsService : IEmployeeQualificationsService
    {
        private readonly IRepository<EmployeeQualification> _repo;
        public EmployeeQualificationsService(IRepository<EmployeeQualification> repo) { _repo = repo; }
        public IEnumerable<EmployeeQualification> GetAll() => _repo.GetAll();
        public EmployeeQualification Get(int id) => _repo.Get(id);
        public void Create(EmployeeQualification EmployeeQualification) { _repo.Add(EmployeeQualification); _repo.Save(); }
        public void Update(EmployeeQualification EmployeeQualification) { _repo.Update(EmployeeQualification); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}