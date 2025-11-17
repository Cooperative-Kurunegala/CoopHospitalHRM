using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class EmployeeTrainingsService : IEmployeeTrainingsService
    {
        private readonly IRepository<EmployeeTraining> _repo;
        public EmployeeTrainingsService(IRepository<EmployeeTraining> repo) { _repo = repo; }
        public IEnumerable<EmployeeTraining> GetAll() => _repo.GetAll();
        public EmployeeTraining Get(int id) => _repo.Get(id);
        public void Create(EmployeeTraining EmployeeTraining) { _repo.Add(EmployeeTraining); _repo.Save(); }
        public void Update(EmployeeTraining EmployeeTraining) { _repo.Update(EmployeeTraining); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}