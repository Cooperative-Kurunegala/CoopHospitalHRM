using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class ShiftService : IShiftService
    {
        private readonly IRepository<Shift> _repo;
        public ShiftService(IRepository<Shift> repo) { _repo = repo; }
        public IEnumerable<Shift> GetAll() => _repo.GetAll();
        public Shift Get(int id) => _repo.Get(id);
        public void Create(Shift Shift) { _repo.Add(Shift); _repo.Save(); }
        public void Update(Shift Shift) { _repo.Update(Shift); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}