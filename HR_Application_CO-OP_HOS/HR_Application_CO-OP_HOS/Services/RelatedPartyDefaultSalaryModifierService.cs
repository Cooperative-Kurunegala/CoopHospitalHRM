using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyDefaultSalaryModifierService : IRelatedPartyDefaultSalaryModifierService
    {
        private readonly IRepository<RelatedPartyDefaultSalaryModifier> _repo;
        public RelatedPartyDefaultSalaryModifierService(IRepository<RelatedPartyDefaultSalaryModifier> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyDefaultSalaryModifier> GetAll() => _repo.GetAll();
        public RelatedPartyDefaultSalaryModifier Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyDefaultSalaryModifier RelatedPartyDefaultSalaryModifier) { _repo.Add(RelatedPartyDefaultSalaryModifier); _repo.Save(); }
        public void Update(RelatedPartyDefaultSalaryModifier RelatedPartyDefaultSalaryModifier) { _repo.Update(RelatedPartyDefaultSalaryModifier); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}