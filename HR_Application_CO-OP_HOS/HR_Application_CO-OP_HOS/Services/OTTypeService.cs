using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class OTTypeService : IOTTypeService
    {
        private readonly IRepository<OTType> _repo;
        public OTTypeService(IRepository<OTType> repo) { _repo = repo; }
        public IEnumerable<OTType> GetAll() => _repo.GetAll();
        public OTType Get(int id) => _repo.Get(id);
        public void Create(OTType OTType) { _repo.Add(OTType); _repo.Save(); }
        public void Update(OTType OTType) { _repo.Update(OTType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}