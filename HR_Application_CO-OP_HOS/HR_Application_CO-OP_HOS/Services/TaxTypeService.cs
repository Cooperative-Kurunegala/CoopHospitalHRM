using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class TaxTypeService : ITaxTypeService
    {
        private readonly IRepository<TaxType> _repo;
        public TaxTypeService(IRepository<TaxType> repo) { _repo = repo; }
        public IEnumerable<TaxType> GetAll() => _repo.GetAll();
        public TaxType Get(int id) => _repo.Get(id);
        public void Create(TaxType TaxType) { _repo.Add(TaxType); _repo.Save(); }
        public void Update(TaxType TaxType) { _repo.Update(TaxType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}