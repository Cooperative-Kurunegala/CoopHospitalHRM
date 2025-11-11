using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChargeDiscountService : IChargeDiscountService
    {
        private readonly IRepository<ChargeDiscount> _repo;
        public ChargeDiscountService(IRepository<ChargeDiscount> repo) { _repo = repo; }
        public IEnumerable<ChargeDiscount> GetAll() => _repo.GetAll();
        public ChargeDiscount Get(int id) => _repo.Get(id);
        public void Create(ChargeDiscount chargeDiscount) { _repo.Add(chargeDiscount); _repo.Save(); }
        public void Update(ChargeDiscount chargeDiscount) { _repo.Update(chargeDiscount); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}
