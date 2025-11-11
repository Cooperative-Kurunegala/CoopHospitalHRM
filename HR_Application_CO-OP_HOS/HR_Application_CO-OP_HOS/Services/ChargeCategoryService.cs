using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChargeCategoryService : IChargeCategoryService
    {
        private readonly IRepository<ChargeCategory> _repo;
        public ChargeCategoryService(IRepository<ChargeCategory> repo) { _repo = repo; }
        public IEnumerable<ChargeCategory> GetAll() => _repo.GetAll();
        public ChargeCategory Get(int id) => _repo.Get(id);
        public void Create(ChargeCategory chargeCategory) { _repo.Add(chargeCategory); _repo.Save(); }
        public void Update(ChargeCategory chargeCategory) { _repo.Update(chargeCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}