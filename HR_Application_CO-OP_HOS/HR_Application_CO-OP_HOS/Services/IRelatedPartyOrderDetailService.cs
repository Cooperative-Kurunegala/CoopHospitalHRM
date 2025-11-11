using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyOrderDetailService
    {
        IEnumerable<RelatedPartyOrderDetail> GetAll();
        RelatedPartyOrderDetail Get(int id);
        void Create(RelatedPartyOrderDetail RelatedPartyOrderDetail);
        void Update(RelatedPartyOrderDetail RelatedPartyOrderDetail);
        void Delete(int id);
    }
}