using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class OPDTimeSlotService : IOPDTimeSlotService
    {
        private readonly IRepository<OPDTimeSlot> _repo;
        public OPDTimeSlotService(IRepository<OPDTimeSlot> repo) { _repo = repo; }
        public IEnumerable<OPDTimeSlot> GetAll() => _repo.GetAll();
        public OPDTimeSlot Get(int id) => _repo.Get(id);
        public void Create(OPDTimeSlot OPDTimeSlot) { _repo.Add(OPDTimeSlot); _repo.Save(); }
        public void Update(OPDTimeSlot OPDTimeSlot) { _repo.Update(OPDTimeSlot); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}