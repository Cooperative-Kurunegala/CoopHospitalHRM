using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartySalaryService : IRelatedPartySalaryService
    {
        private readonly IRepository<RelatedPartySalary> _repo;
        public RelatedPartySalaryService(IRepository<RelatedPartySalary> repo) { _repo = repo; }
        public IEnumerable<RelatedPartySalary> GetAll() => _repo.GetAll();
        public RelatedPartySalary Get(int id) => _repo.Get(id);
        public void Create(RelatedPartySalary RelatedPartySalary) { _repo.Add(RelatedPartySalary); _repo.Save(); }
        public void Update(RelatedPartySalary RelatedPartySalary) { _repo.Update(RelatedPartySalary); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}