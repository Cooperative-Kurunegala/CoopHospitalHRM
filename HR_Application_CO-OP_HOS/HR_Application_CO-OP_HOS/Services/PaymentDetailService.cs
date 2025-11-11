using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PaymentDetailService : IPaymentDetailService
    {
        private readonly IRepository<PaymentDetail> _repo;
        public PaymentDetailService(IRepository<PaymentDetail> repo) { _repo = repo; }
        public IEnumerable<PaymentDetail> GetAll() => _repo.GetAll();
        public PaymentDetail Get(int id) => _repo.Get(id);
        public void Create(PaymentDetail PaymentDetail) { _repo.Add(PaymentDetail); _repo.Save(); }
        public void Update(PaymentDetail PaymentDetail) { _repo.Update(PaymentDetail); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}