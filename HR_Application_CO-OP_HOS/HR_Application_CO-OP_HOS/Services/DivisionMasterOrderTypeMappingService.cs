using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DivisionMasterOrderTypeMappingService : IDivisionMasterOrderTypeMappingService
    {
        private readonly IRepository<DivisionMasterOrderTypeMapping> _repo;
        public DivisionMasterOrderTypeMappingService(IRepository<DivisionMasterOrderTypeMapping> repo) { _repo = repo; }
        public IEnumerable<DivisionMasterOrderTypeMapping> GetAll() => _repo.GetAll();
        public DivisionMasterOrderTypeMapping Get(int id) => _repo.Get(id);
        public void Create(DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping) { _repo.Add(divisionMasterOrderTypeMapping); _repo.Save(); }
        public void Update(DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping) { _repo.Update(divisionMasterOrderTypeMapping); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}