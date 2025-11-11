using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AdmissionTypeService : IAdmissionType
    {
        private readonly IRepository<AdmissionType> _repo;
        public AdmissionTypeService(IRepository<AdmissionType> repo) { _repo = repo; }
        public IEnumerable<AdmissionType> GetAll() => _repo.GetAll();
        public AdmissionType Get(int id) => _repo.Get(id);
        public void Create(AdmissionType admissionType) { _repo.Add(admissionType); _repo.Save(); }
        public void Update(AdmissionType admissionType) { _repo.Update(admissionType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}