using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IRepository<PaymentType> _repo;
        public PaymentTypeService(IRepository<PaymentType> repo) { _repo = repo; }
        public IEnumerable<PaymentType> GetAll() => _repo.GetAll();
        public PaymentType Get(int id) => _repo.Get(id);
        public void Create(PaymentType PaymentType) { _repo.Add(PaymentType); _repo.Save(); }
        public void Update(PaymentType PaymentType) { _repo.Update(PaymentType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}