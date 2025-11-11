using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IChargeDiscountService
    {
        IEnumerable<ChargeDiscount> GetAll();
        ChargeDiscount Get(int id);
        void Create(ChargeDiscount chargeDiscount);
        void Update(ChargeDiscount chargeDiscount);
        void Delete(int id);
    }
}