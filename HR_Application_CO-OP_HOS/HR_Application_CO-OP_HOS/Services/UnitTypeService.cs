using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class UnitTypeService : IUnitTypeService
    {
        private readonly IRepository<UnitType> _repo;
        public UnitTypeService(IRepository<UnitType> repo) { _repo = repo; }
        public IEnumerable<UnitType> GetAll() => _repo.GetAll();
        public UnitType Get(int id) => _repo.Get(id);
        public void Create(UnitType UnitType) { _repo.Add(UnitType); _repo.Save(); }
        public void Update(UnitType UnitType) { _repo.Update(UnitType); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}