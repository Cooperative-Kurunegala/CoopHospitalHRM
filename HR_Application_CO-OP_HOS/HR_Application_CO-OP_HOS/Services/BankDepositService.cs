using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BankDepositService : IBankDepositService
    {
        private readonly IRepository<BankDeposit> _repo;
        public BankDepositService(IRepository<BankDeposit> repo) { _repo = repo; }
        public IEnumerable<BankDeposit> GetAll() => _repo.GetAll();
        public BankDeposit Get(int id) => _repo.Get(id);
        public void Create(BankDeposit bankDeposit) { _repo.Add(bankDeposit); _repo.Save(); }
        public void Update(BankDeposit bankDeposit) { _repo.Update(bankDeposit); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}