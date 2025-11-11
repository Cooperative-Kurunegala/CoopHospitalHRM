using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services 
{
    public class AdmissionCategoryService : IAdmissionCategoryService
    {
        private readonly IRepository<AdmissionCategory> _repo;
        public AdmissionCategoryService(IRepository<AdmissionCategory> repo) { _repo = repo; }
        public IEnumerable<AdmissionCategory> GetAll() => _repo.GetAll();
        public AdmissionCategory Get(int id) => _repo.Get(id);
        public void Create(AdmissionCategory ac) { _repo.Add(ac); _repo.Save(); }
        public void Update(AdmissionCategory ac) { _repo.Update(ac); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}