using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IOrderTypeService
    {
        IEnumerable<OrderType> GetAll();
        OrderType Get(int id);
        void Create(OrderType OrderType);
        void Update(OrderType OrderType);
        void Delete(int id);
    }
}