using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AttendanceDataService : IAttendanceDataService
    {
        private readonly IRepository<AttendanceData> _repo;
        public AttendanceDataService(IRepository<AttendanceData> repo) { _repo = repo; }
        public IEnumerable<AttendanceData> GetAll() => _repo.GetAll();
        public AttendanceData Get(int id) => _repo.Get(id);
        public void Create(AttendanceData attendanceData) { _repo.Add(attendanceData); _repo.Save(); }
        public void Update(AttendanceData attendanceData) { _repo.Update(attendanceData); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}