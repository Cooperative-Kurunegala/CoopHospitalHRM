using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChargeMasterPriceService : IChargeMasterPriceService
    {
        private readonly IRepository<ChargeMasterPrice> _repo;
        public ChargeMasterPriceService(IRepository<ChargeMasterPrice> repo) { _repo = repo; }
        public IEnumerable<ChargeMasterPrice> GetAll() => _repo.GetAll();
        public ChargeMasterPrice Get(int id) => _repo.Get(id);
        public void Create(ChargeMasterPrice chargeMasterPrice) { _repo.Add(chargeMasterPrice); _repo.Save(); }
        public void Update(ChargeMasterPrice chargeMasterPrice) { _repo.Update(chargeMasterPrice); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}