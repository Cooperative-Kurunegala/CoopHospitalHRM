using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartySessionService
    {
        IEnumerable<RelatedPartySession> GetAll();
        RelatedPartySession Get(int id);
        void Create(RelatedPartySession RelatedPartySession);
        void Update(RelatedPartySession RelatedPartySession);
        void Delete(int id);
    }
}