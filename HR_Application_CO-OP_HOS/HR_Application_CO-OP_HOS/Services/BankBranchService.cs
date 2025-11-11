using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BankBranchService : IBankBranchService
    {
        private readonly IRepository<BankBranch> _repo;
        public BankBranchService(IRepository<BankBranch> repo) { _repo = repo; }
        public IEnumerable<BankBranch> GetAll() => _repo.GetAll();
        public BankBranch Get(int id) => _repo.Get(id);
        public void Create(BankBranch bankBranch) { _repo.Add(bankBranch); _repo.Save(); }
        public void Update(BankBranch bankBranch) { _repo.Update(bankBranch); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}