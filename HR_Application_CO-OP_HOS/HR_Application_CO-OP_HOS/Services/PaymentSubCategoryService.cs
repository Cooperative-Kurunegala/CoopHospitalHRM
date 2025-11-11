using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PaymentSubCategoryService : IPaymentSubCategoryService
    {
        private readonly IRepository<PaymentSubCategory> _repo;
        public PaymentSubCategoryService(IRepository<PaymentSubCategory> repo) { _repo = repo; }
        public IEnumerable<PaymentSubCategory> GetAll() => _repo.GetAll();
        public PaymentSubCategory Get(int id) => _repo.Get(id);
        public void Create(PaymentSubCategory PaymentSubCategory) { _repo.Add(PaymentSubCategory); _repo.Save(); }
        public void Update(PaymentSubCategory PaymentSubCategory) { _repo.Update(PaymentSubCategory); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}