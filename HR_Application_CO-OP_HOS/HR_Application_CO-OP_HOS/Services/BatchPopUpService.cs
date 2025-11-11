using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class BatchPopUpService : IBatchPopUpService
    {
        private readonly IRepository<BatchPopup> _repo;
        public BatchPopUpService(IRepository<BatchPopup> repo) { _repo = repo; }
        public IEnumerable<BatchPopup> GetAll() => _repo.GetAll();
        public BatchPopup Get(int id) => _repo.Get(id);
        public void Create(BatchPopup batchPopup) { _repo.Add(batchPopup); _repo.Save(); }
        public void Update(BatchPopup batchPopup) { _repo.Update(batchPopup); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}