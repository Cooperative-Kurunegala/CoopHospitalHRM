using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BankService : IBankService
    {
        private readonly IRepository<Bank> _repo;
        public BankService(IRepository<Bank> repo) { _repo = repo; }
        public IEnumerable<Bank> GetAll() => _repo.GetAll();
        public Bank Get(int id) => _repo.Get(id);
        public void Create(Bank bank) { _repo.Add(bank); _repo.Save(); }
        public void Update(Bank bank) { _repo.Update(bank); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}