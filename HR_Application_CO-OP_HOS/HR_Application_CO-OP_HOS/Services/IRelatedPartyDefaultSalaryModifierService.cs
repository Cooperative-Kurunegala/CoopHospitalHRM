using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyDefaultSalaryModifierService
    {
        IEnumerable<RelatedPartyDefaultSalaryModifier> GetAll();
        RelatedPartyDefaultSalaryModifier Get(int id);
        void Create(RelatedPartyDefaultSalaryModifier RelatedPartyDefaultSalaryModifier);
        void Update(RelatedPartyDefaultSalaryModifier RelatedPartyDefaultSalaryModifier);
        void Delete(int id);
    }
}