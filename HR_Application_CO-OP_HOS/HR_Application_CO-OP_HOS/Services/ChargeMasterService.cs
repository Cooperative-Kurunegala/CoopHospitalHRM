using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChargeMasterService : IChargeMasterService
    {
        private readonly IRepository<ChargeMaster> _repo;
        public ChargeMasterService(IRepository<ChargeMaster> repo) { _repo = repo; }
        public IEnumerable<ChargeMaster> GetAll() => _repo.GetAll();
        public ChargeMaster Get(int id) => _repo.Get(id);
        public void Create(ChargeMaster chargeMaster) { _repo.Add(chargeMaster); _repo.Save(); }
        public void Update(ChargeMaster chargeMaster) { _repo.Update(chargeMaster); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}