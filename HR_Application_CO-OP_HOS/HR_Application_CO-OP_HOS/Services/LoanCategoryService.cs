using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LoanCategoryService : ILoanCategoryService
    {
        private readonly IRepository<LoanCategory> _repo;
        public LoanCategoryService(IRepository<LoanCategory> repo) { _repo = repo; }
        public IEnumerable<LoanCategory> GetAll() => _repo.GetAll();
        public LoanCategory Get(int id) => _repo.Get(id);
        public void Create(LoanCategory LoanCategory) { _repo.Add(LoanCategory); _repo.Save(); }
        public void Update(LoanCategory LoanCategory) { _repo.Update(LoanCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}
