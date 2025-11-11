using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class CurrentPayrollMonthService : ICurrentPayrollMonthService
    {
        private readonly IRepository<CurrentPayrollMonth> _repo;
        public CurrentPayrollMonthService(IRepository<CurrentPayrollMonth> repo) { _repo = repo; }
        public IEnumerable<CurrentPayrollMonth> GetAll() => _repo.GetAll();
        public CurrentPayrollMonth Get(int id) => _repo.Get(id);
        public void Create(CurrentPayrollMonth currentPayrollMonth) { _repo.Add(currentPayrollMonth); _repo.Save(); }
        public void Update(CurrentPayrollMonth currentPayrollMonth) { _repo.Update(currentPayrollMonth); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}