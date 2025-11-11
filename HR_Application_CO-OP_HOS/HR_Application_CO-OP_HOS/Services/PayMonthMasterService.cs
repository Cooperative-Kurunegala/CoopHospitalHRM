using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PayMonthMasterService : IPayMonthMasterService
    {
        private readonly IRepository<PayMonthMaster> _repo;
        public PayMonthMasterService(IRepository<PayMonthMaster> repo) { _repo = repo; }
        public IEnumerable<PayMonthMaster> GetAll() => _repo.GetAll();
        public PayMonthMaster Get(int id) => _repo.Get(id);
        public void Create(PayMonthMaster PayMonthMaster) { _repo.Add(PayMonthMaster); _repo.Save(); }
        public void Update(PayMonthMaster PayMonthMaster) { _repo.Update(PayMonthMaster); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}