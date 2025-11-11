using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class CreditCardTypeService : ICreditCardTypeService
    {
        private readonly IRepository<CreditCardType> _repo;
        public CreditCardTypeService(IRepository<CreditCardType> repo) { _repo = repo; }
        public IEnumerable<CreditCardType> GetAll() => _repo.GetAll();
        public CreditCardType Get(int id) => _repo.Get(id);
        public void Create(CreditCardType creditCardType) { _repo.Add(creditCardType); _repo.Save(); }
        public void Update(CreditCardType creditCardType) { _repo.Update(creditCardType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}