using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyRoleService
    {
        IEnumerable<RelatedPartyRole> GetAll();
        RelatedPartyRole Get(int id);
        void Create(RelatedPartyRole RelatedPartyRole);
        void Update(RelatedPartyRole RelatedPartyRole);
        void Delete(int id);
    }
}