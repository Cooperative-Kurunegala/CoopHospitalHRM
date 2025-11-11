using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyOrderService
    {
        IEnumerable<RelatedPartyOrder> GetAll();
        RelatedPartyOrder Get(int id);
        void Create(RelatedPartyOrder RelatedPartyOrder);
        void Update(RelatedPartyOrder RelatedPartyOrder);
        void Delete(int id);
    }
}