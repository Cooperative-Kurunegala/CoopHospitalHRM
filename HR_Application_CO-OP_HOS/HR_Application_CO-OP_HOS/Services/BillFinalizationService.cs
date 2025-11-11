using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BillFinalizationService : IBillFinalizationService
    {
        private readonly IRepository<BillFinalization> _repo;
        public BillFinalizationService(IRepository<BillFinalization> repo) { _repo = repo; }
        public IEnumerable<BillFinalization> GetAll() => _repo.GetAll();
        public BillFinalization Get(int id) => _repo.Get(id);
        public void Create(BillFinalization billFinalization) { _repo.Add(billFinalization); _repo.Save(); }
        public void Update(BillFinalization billFinalization) { _repo.Update(billFinalization); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}