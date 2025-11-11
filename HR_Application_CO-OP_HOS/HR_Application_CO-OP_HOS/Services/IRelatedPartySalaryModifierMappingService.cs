using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartySalaryModifierMappingService
    {
        IEnumerable<RelatedPartySalaryModifierMapping> GetAll();
        RelatedPartySalaryModifierMapping Get(int id);
        void Create(RelatedPartySalaryModifierMapping RelatedPartySalaryModifierMapping);
        void Update(RelatedPartySalaryModifierMapping RelatedPartySalaryModifierMapping);
        void Delete(int id);
    }
}