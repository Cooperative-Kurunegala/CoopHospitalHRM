using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyService
    {
        IEnumerable<RelatedParty> GetAll();
        RelatedParty Get(int id);
        void Create(RelatedParty rp);
        void Update(RelatedParty rp);
        void Delete(int id);
    }

}