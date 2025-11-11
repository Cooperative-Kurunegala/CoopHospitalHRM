using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class OPDSquenceService : IOPDSquenceService
    {
        private readonly IRepository<OPDSquence> _repo;
        public OPDSquenceService(IRepository<OPDSquence> repo) { _repo = repo; }
        public IEnumerable<OPDSquence> GetAll() => _repo.GetAll();
        public OPDSquence Get(int id) => _repo.Get(id);
        public void Create(OPDSquence OPDSquence) { _repo.Add(OPDSquence); _repo.Save(); }
        public void Update(OPDSquence OPDSquence) { _repo.Update(OPDSquence); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}