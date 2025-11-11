using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SalaryModifierDefaultValueService : ISalaryModifierDefaultValueService
    {
        private readonly IRepository<SalaryModifierDefaultValue> _repo;
        public SalaryModifierDefaultValueService(IRepository<SalaryModifierDefaultValue> repo) { _repo = repo; }
        public IEnumerable<SalaryModifierDefaultValue> GetAll() => _repo.GetAll();
        public SalaryModifierDefaultValue Get(int id) => _repo.Get(id);
        public void Create(SalaryModifierDefaultValue SalaryModifierDefaultValue) { _repo.Add(SalaryModifierDefaultValue); _repo.Save(); }
        public void Update(SalaryModifierDefaultValue SalaryModifierDefaultValue) { _repo.Update(SalaryModifierDefaultValue); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}