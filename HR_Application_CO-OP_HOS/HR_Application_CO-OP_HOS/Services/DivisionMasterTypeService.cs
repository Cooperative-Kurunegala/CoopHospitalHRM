using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DivisionMasterTypeService : IDivisionMasterTypeService
    {
        private readonly IRepository<DivisionMasterType> _repo;
        public DivisionMasterTypeService(IRepository<DivisionMasterType> repo) { _repo = repo; }
        public IEnumerable<DivisionMasterType> GetAll() => _repo.GetAll();
        public DivisionMasterType Get(int id) => _repo.Get(id);
        public void Create(DivisionMasterType divisionMasterType) { _repo.Add(divisionMasterType); _repo.Save(); }
        public void Update(DivisionMasterType divisionMasterType) { _repo.Update(divisionMasterType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}