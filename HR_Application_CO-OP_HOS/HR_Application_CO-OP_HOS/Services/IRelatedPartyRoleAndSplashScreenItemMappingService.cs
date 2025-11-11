using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyRoleAndSplashScreenItemMappingService
    {
        IEnumerable<RelatedPartyRoleAndSplashScreenItemMapping> GetAll();
        RelatedPartyRoleAndSplashScreenItemMapping Get(int id);
        void Create(RelatedPartyRoleAndSplashScreenItemMapping RelatedPartyRoleAndSplashScreenItemMapping);
        void Update(RelatedPartyRoleAndSplashScreenItemMapping RelatedPartyRoleAndSplashScreenItemMapping);
        void Delete(int id);
    }
}