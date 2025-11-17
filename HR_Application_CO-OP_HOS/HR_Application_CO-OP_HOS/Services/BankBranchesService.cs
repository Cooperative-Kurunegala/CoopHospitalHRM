using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BankBranchesService : IBankBranchesService
    {
        private readonly IRepository<BankBranch> _repo;
        public BankBranchesService(IRepository<BankBranch> repo) { _repo = repo; }
        public IEnumerable<BankBranch> GetAll() => _repo.GetAll();
        public BankBranch Get(int id) => _repo.Get(id);
        public void Create(BankBranch BankBranche) { _repo.Add(BankBranche); _repo.Save(); }
        public void Update(BankBranch BankBranche) { _repo.Update(BankBranche); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}