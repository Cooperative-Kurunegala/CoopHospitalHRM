using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyLoan1Service
    {
        IEnumerable<RelatedPartyLoan1> GetAll();
        RelatedPartyLoan1 Get(int id);
        void Create(RelatedPartyLoan1 RelatedPartyLoan1);
        void Update(RelatedPartyLoan1 RelatedPartyLoan1);
        void Delete(int id);
    }
}