using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PayeeTaxService : IPayeeTaxService
    {
        private readonly IRepository<PayeeTax> _repo;
        public PayeeTaxService(IRepository<PayeeTax> repo) { _repo = repo; }
        public IEnumerable<PayeeTax> GetAll() => _repo.GetAll();
        public PayeeTax Get(int id) => _repo.Get(id);
        public void Create(PayeeTax PayeeTax) { _repo.Add(PayeeTax); _repo.Save(); }
        public void Update(PayeeTax PayeeTax) { _repo.Update(PayeeTax); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}