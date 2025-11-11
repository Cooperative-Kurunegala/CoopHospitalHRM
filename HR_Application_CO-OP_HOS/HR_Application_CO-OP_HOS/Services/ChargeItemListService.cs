using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ChargeItemListService : IChargeItemListService
    {
        private readonly IRepository<ChargeItemList> _repo;
        public ChargeItemListService(IRepository<ChargeItemList> repo) { _repo = repo; }
        public IEnumerable<ChargeItemList> GetAll() => _repo.GetAll();
        public ChargeItemList Get(int id) => _repo.Get(id);
        public void Create(ChargeItemList chargeItemList) { _repo.Add(chargeItemList); _repo.Save(); }
        public void Update(ChargeItemList chargeItemList) { _repo.Update(chargeItemList); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}