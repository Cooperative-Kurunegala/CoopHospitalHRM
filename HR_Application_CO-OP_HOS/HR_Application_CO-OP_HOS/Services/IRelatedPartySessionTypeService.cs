using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartySessionTypeService
    {
        IEnumerable<RelatedPartySessionType> GetAll();
        RelatedPartySessionType Get(int id);
        void Create(RelatedPartySessionType RelatedPartySessionType);
        void Update(RelatedPartySessionType RelatedPartySessionType);
        void Delete(int id);
    }
}