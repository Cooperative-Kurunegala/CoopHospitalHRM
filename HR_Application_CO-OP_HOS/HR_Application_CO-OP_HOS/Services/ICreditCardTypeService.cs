using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface ICreditCardTypeService
    {
        IEnumerable<CreditCardType> GetAll();
        CreditCardType Get(int id);
        void Create(CreditCardType creditCardType);
        void Update(CreditCardType creditCardType);
        void Delete(int id);
    }
}