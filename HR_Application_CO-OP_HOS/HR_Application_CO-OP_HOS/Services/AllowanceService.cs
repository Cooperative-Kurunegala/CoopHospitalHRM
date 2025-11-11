using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AllowanceService : IAllowanceService
    {
        private readonly IRepository<Allowance> _repo;
        public AllowanceService(IRepository<Allowance> repo) { _repo = repo; }
        public IEnumerable<Allowance> GetAll() => _repo.GetAll();
        public Allowance Get(int id) => _repo.Get(id);
        public void Create(Allowance allowance) { _repo.Add(allowance); _repo.Save(); }
        public void Update(Allowance allowance) { _repo.Update(allowance); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}