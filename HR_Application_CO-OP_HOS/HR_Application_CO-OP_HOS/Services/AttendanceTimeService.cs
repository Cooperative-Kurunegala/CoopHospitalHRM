using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AttendanceTimeService : IAttendanceTimeService
    {
        private readonly IRepository<AttendanceTime> _repo;
        public AttendanceTimeService(IRepository<AttendanceTime> repo) { _repo = repo; }
        public IEnumerable<AttendanceTime> GetAll() => _repo.GetAll();
        public AttendanceTime Get(int id) => _repo.Get(id);
        public void Create(AttendanceTime attendanceTime) { _repo.Add(attendanceTime); _repo.Save(); }
        public void Update(AttendanceTime attendanceTime) { _repo.Update(attendanceTime); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}