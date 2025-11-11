using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IPaymentTypeService
    {
        IEnumerable<PaymentType> GetAll();
        PaymentType Get(int id);
        void Create(PaymentType PaymentType);
        void Update(PaymentType PaymentType);
        void Delete(int id);
    }
}