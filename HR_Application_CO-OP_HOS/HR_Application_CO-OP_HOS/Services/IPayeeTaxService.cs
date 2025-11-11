using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IPayeeTaxService
    {
        IEnumerable<PayeeTax> GetAll();
        PayeeTax Get(int id);
        void Create(PayeeTax PayeeTax);
        void Update(PayeeTax PayeeTax);
        void Delete(int id);
    }
}