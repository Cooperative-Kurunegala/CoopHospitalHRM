using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SalaryModifierTypeService : ISalaryModifierTypeService
    {
        private readonly IRepository<SalaryModifierType> _repo;
        public SalaryModifierTypeService(IRepository<SalaryModifierType> repo) { _repo = repo; }
        public IEnumerable<SalaryModifierType> GetAll() => _repo.GetAll();
        public SalaryModifierType Get(int id) => _repo.Get(id);
        public void Create(SalaryModifierType SalaryModifierType) { _repo.Add(SalaryModifierType); _repo.Save(); }
        public void Update(SalaryModifierType SalaryModifierType) { _repo.Update(SalaryModifierType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}