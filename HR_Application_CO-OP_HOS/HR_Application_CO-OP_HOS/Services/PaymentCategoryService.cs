using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PaymentCategoryService : IPaymentCategoryService
    {
        private readonly IRepository<PaymentCategory> _repo;
        public PaymentCategoryService(IRepository<PaymentCategory> repo) { _repo = repo; }
        public IEnumerable<PaymentCategory> GetAll() => _repo.GetAll();
        public PaymentCategory Get(int id) => _repo.Get(id);
        public void Create(PaymentCategory PaymentCategory) { _repo.Add(PaymentCategory); _repo.Save(); }
        public void Update(PaymentCategory PaymentCategory) { _repo.Update(PaymentCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}