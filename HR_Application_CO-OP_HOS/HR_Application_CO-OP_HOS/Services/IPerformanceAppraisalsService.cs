using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IPerformanceAppraisalsService
    {
        IEnumerable<PerformanceAppraisal> GetAll();
        PerformanceAppraisal Get(int id);
        void Create(PerformanceAppraisal PerformanceAppraisal);
        void Update(PerformanceAppraisal PerformanceAppraisal);
        void Delete(int id);
    }
}