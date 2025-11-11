using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyFixedRosterService
    {
        IEnumerable<RelatedPartyFixedRoster> GetAll();
        RelatedPartyFixedRoster Get(int id);
        void Create(RelatedPartyFixedRoster RelatedPartyFixedRoster);
        void Update(RelatedPartyFixedRoster RelatedPartyFixedRoster);
        void Delete(int id);
    }
}