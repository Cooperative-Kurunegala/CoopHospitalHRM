using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class RelatedPartyRoleAndSplashScreenItemMappingService : IRelatedPartyRoleAndSplashScreenItemMappingService
    {
        private readonly IRepository<RelatedPartyRoleAndSplashScreenItemMapping> _repo;
        public RelatedPartyRoleAndSplashScreenItemMappingService(IRepository<RelatedPartyRoleAndSplashScreenItemMapping> repo) { _repo = repo; }
        public IEnumerable<RelatedPartyRoleAndSplashScreenItemMapping> GetAll() => _repo.GetAll();
        public RelatedPartyRoleAndSplashScreenItemMapping Get(int id) => _repo.Get(id);
        public void Create(RelatedPartyRoleAndSplashScreenItemMapping RelatedPartyRoleAndSplashScreenItemMapping) { _repo.Add(RelatedPartyRoleAndSplashScreenItemMapping); _repo.Save(); }
        public void Update(RelatedPartyRoleAndSplashScreenItemMapping RelatedPartyRoleAndSplashScreenItemMapping) { _repo.Update(RelatedPartyRoleAndSplashScreenItemMapping); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}