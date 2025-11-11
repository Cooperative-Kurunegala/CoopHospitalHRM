using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyTypeService
    {
        IEnumerable<RelatedPartyType> GetAll();
        RelatedPartyType Get(int id);
        void Create(RelatedPartyType RelatedPartyType);
        void Update(RelatedPartyType RelatedPartyType);
        void Delete(int id);
    }
}