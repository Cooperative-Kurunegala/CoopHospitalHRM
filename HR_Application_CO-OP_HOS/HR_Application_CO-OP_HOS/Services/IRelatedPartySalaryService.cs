using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartySalaryService
    {
        IEnumerable<RelatedPartySalary> GetAll();
        RelatedPartySalary Get(int id);
        void Create(RelatedPartySalary RelatedPartySalary);
        void Update(RelatedPartySalary RelatedPartySalary);
        void Delete(int id);
    }
}