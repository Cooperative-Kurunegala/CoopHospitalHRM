using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class NurseShiftService : INurseShiftService
    {
        private readonly IRepository<NurseShift> _repo;
        public NurseShiftService(IRepository<NurseShift> repo) { _repo = repo; }
        public IEnumerable<NurseShift> GetAll() => _repo.GetAll();
        public NurseShift Get(int id) => _repo.Get(id);
        public void Create(NurseShift NurseShift) { _repo.Add(NurseShift); _repo.Save(); }
        public void Update(NurseShift NurseShift) { _repo.Update(NurseShift); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}
