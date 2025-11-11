using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class OrderTypeService : IOrderTypeService
    {
        private readonly IRepository<OrderType> _repo;
        public OrderTypeService(IRepository<OrderType> repo) { _repo = repo; }
        public IEnumerable<OrderType> GetAll() => _repo.GetAll();
        public OrderType Get(int id) => _repo.Get(id);
        public void Create(OrderType OrderType) { _repo.Add(OrderType); _repo.Save(); }
        public void Update(OrderType OrderType) { _repo.Update(OrderType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}