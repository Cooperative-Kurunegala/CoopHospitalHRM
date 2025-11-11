using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartySalaryModifierMappingService : IRelatedPartySalaryModifierMappingService
    {
        private readonly IRepository<RelatedPartySalaryModifierMapping> _repo;
        public RelatedPartySalaryModifierMappingService(IRepository<RelatedPartySalaryModifierMapping> repo) { _repo = repo; }
        public IEnumerable<RelatedPartySalaryModifierMapping> GetAll() => _repo.GetAll();
        public RelatedPartySalaryModifierMapping Get(int id) => _repo.Get(id);
        public void Create(RelatedPartySalaryModifierMapping RelatedPartySalaryModifierMapping) { _repo.Add(RelatedPartySalaryModifierMapping); _repo.Save(); }
        public void Update(RelatedPartySalaryModifierMapping RelatedPartySalaryModifierMapping) { _repo.Update(RelatedPartySalaryModifierMapping); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}