using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class LoanInstallmentsService : ILoanInstallmentsService
    {
        private readonly IRepository<LoanInstallment> _repo;
        public LoanInstallmentsService(IRepository<LoanInstallment> repo) { _repo = repo; }
        public IEnumerable<LoanInstallment> GetAll() => _repo.GetAll();
        public LoanInstallment Get(int id) => _repo.Get(id);
        public void Create(LoanInstallment LoanInstallment) { _repo.Add(LoanInstallment); _repo.Save(); }
        public void Update(LoanInstallment LoanInstallment) { _repo.Update(LoanInstallment); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}