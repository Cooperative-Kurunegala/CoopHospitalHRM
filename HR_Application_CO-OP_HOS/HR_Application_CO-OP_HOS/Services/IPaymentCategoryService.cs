using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IPaymentCategoryService
    {
        IEnumerable<PaymentCategory> GetAll();
        PaymentCategory Get(int id);
        void Create(PaymentCategory PaymentCategory);
        void Update(PaymentCategory PaymentCategory);
        void Delete(int id);
    }
}