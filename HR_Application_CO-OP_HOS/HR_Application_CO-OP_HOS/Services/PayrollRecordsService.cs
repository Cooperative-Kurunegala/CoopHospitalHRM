using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PayrollRecordsService : IPayrollRecordsService
    {
        private readonly IRepository<PayrollRecord> _repo;
        public PayrollRecordsService(IRepository<PayrollRecord> repo) { _repo = repo; }
        public IEnumerable<PayrollRecord> GetAll() => _repo.GetAll();
        public PayrollRecord Get(int id) => _repo.Get(id);
        public void Create(PayrollRecord PayrollRecord) { _repo.Add(PayrollRecord); _repo.Save(); }
        public void Update(PayrollRecord PayrollRecord) { _repo.Update(PayrollRecord); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}