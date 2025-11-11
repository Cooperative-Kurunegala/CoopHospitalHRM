using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DayTypeService : IDayTypeService
    {
        private readonly IRepository<DayType> _repo;
        public DayTypeService(IRepository<DayType> repo) { _repo = repo; }
        public IEnumerable<DayType> GetAll() => _repo.GetAll();
        public DayType Get(int id) => _repo.Get(id);
        public void Create(DayType dayType) { _repo.Add(dayType); _repo.Save(); }
        public void Update(DayType dayType) { _repo.Update(dayType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}