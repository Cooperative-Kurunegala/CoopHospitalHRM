using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyOrderPaymentService
    {
        IEnumerable<RelatedPartyOrderPayment> GetAll();
        RelatedPartyOrderPayment Get(int id);
        void Create(RelatedPartyOrderPayment RelatedPartyOrderPayment);
        void Update(RelatedPartyOrderPayment RelatedPartyOrderPayment);
        void Delete(int id);
    }
}