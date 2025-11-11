using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class DoctorWiseTimeSlotService : IDoctorWiseTimeSlotService
    {
        private readonly IRepository<DoctorWiseTimeSlot> _repo;
        public DoctorWiseTimeSlotService(IRepository<DoctorWiseTimeSlot> repo) { _repo = repo; }
        public IEnumerable<DoctorWiseTimeSlot> GetAll() => _repo.GetAll();
        public DoctorWiseTimeSlot Get(int id) => _repo.Get(id);
        public void Create(DoctorWiseTimeSlot doctorWiseTimeSlot) { _repo.Add(doctorWiseTimeSlot); _repo.Save(); }
        public void Update(DoctorWiseTimeSlot doctorWiseTimeSlot) { _repo.Update(doctorWiseTimeSlot); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}