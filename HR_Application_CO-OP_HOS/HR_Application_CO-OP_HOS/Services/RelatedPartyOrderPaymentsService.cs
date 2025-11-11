using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyOrderPaymentService : IRelatedPartyOrderPaymentService
    {
        private readonly IRepository<RelatedPartyOrderPayment> _repo;
        public RelatedPartyOrderPaymentService(IRepository<RelatedPartyOrderPayment> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyOrderPayment> GetAll() => _repo.GetAll();
        public RelatedPartyOrderPayment Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyOrderPayment RelatedPartyOrderPayment) { _repo.Add(RelatedPartyOrderPayment); _repo.Save(); }
        public void Update(RelatedPartyOrderPayment RelatedPartyOrderPayment) { _repo.Update(RelatedPartyOrderPayment); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}