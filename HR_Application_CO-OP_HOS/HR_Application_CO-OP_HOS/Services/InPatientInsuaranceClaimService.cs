using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class InPatientInsuaranceClaimService : IInPatientInsuaranceClaimService
    {
        private readonly IRepository<InPatientInsuranceClaim> _repo;
        public InPatientInsuaranceClaimService(IRepository<InPatientInsuranceClaim> repo) { _repo = repo; }
        public IEnumerable<InPatientInsuranceClaim> GetAll() => _repo.GetAll();
        public InPatientInsuranceClaim Get(int id) => _repo.Get(id);
        public void Create(InPatientInsuranceClaim inPatientInsuaranceClaim) { _repo.Add(inPatientInsuaranceClaim); _repo.Save(); }
        public void Update(InPatientInsuranceClaim inPatientInsuaranceClaim) { _repo.Update(inPatientInsuaranceClaim); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}