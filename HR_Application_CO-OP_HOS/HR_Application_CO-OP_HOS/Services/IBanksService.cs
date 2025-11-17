using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IBanksService
    {
        IEnumerable<Bank> GetAll();
        Bank Get(int id);
        void Create(Bank Bank);
        void Update(Bank Bank);
        void Delete(int id);
    }
}