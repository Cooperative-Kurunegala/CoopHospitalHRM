using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class SalaryTypeService : ISalaryTypeService
    {
        private readonly IRepository<SalaryType> _repo;
        public SalaryTypeService(IRepository<SalaryType> repo) { _repo = repo; }
        public IEnumerable<SalaryType> GetAll() => _repo.GetAll();
        public SalaryType Get(int id) => _repo.Get(id);
        public void Create(SalaryType SalaryType) { _repo.Add(SalaryType); _repo.Save(); }
        public void Update(SalaryType SalaryType) { _repo.Update(SalaryType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}