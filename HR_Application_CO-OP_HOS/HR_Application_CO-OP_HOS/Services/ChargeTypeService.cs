using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChargeTypeService : IChargeTypeService
    {
        private readonly IRepository<ChargeType> _repo;
        public ChargeTypeService(IRepository<ChargeType> repo) { _repo = repo; }
        public IEnumerable<ChargeType> GetAll() => _repo.GetAll();
        public ChargeType Get(int id) => _repo.Get(id);
        public void Create(ChargeType chargeType) { _repo.Add(chargeType); _repo.Save(); }
        public void Update(ChargeType chargeType) { _repo.Update(chargeType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}