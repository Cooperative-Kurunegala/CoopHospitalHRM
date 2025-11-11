using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ITaxTypeService
    {
        IEnumerable<TaxType> GetAll();
        TaxType Get(int id);
        void Create(TaxType TaxType);
        void Update(TaxType TaxType);
        void Delete(int id);
    }
}