using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ILogDetailService
    {
        IEnumerable<LogDetail> GetAll();
        LogDetail Get(int id);
        void Create(LogDetail LogDetail);
        void Update(LogDetail LogDetail);
        void Delete(int id);
    }
}