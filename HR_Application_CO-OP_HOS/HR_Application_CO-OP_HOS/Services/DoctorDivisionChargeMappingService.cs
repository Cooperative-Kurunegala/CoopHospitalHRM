using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DoctorDivisionChargeMappingService : IDoctorDivisionChargeMappingService
    {
        private readonly IRepository<DoctorDivisionChargeMapping> _repo;
        public DoctorDivisionChargeMappingService(IRepository<DoctorDivisionChargeMapping> repo) { _repo = repo; }
        public IEnumerable<DoctorDivisionChargeMapping> GetAll() => _repo.GetAll();
        public DoctorDivisionChargeMapping Get(int id) => _repo.Get(id);
        public void Create(DoctorDivisionChargeMapping doctorDivisionChargeMapping) { _repo.Add(doctorDivisionChargeMapping); _repo.Save(); }
        public void Update(DoctorDivisionChargeMapping doctorDivisionChargeMapping) { _repo.Update(doctorDivisionChargeMapping); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}