using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BillFinalization_LastService : IBillFinalization_LastService
    {
        private readonly IRepository<BillFinalization_Last> _repo;
        public BillFinalization_LastService(IRepository<BillFinalization_Last> repo) { _repo = repo; }
        public IEnumerable<BillFinalization_Last> GetAll() => _repo.GetAll();
        public BillFinalization_Last Get(int id) => _repo.Get(id);
        public void Create(BillFinalization_Last billFinalization_Last) { _repo.Add(billFinalization_Last); _repo.Save(); }
        public void Update(BillFinalization_Last billFinalization_Last) { _repo.Update(billFinalization_Last); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}