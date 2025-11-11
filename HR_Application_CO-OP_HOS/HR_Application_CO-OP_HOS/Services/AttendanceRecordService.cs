using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AttendanceRecordService : IAttendanceRecordService
    {
        private readonly IRepository<AttendanceRecord> _repo;
        public AttendanceRecordService(IRepository<AttendanceRecord> repo) { _repo = repo; }
        public IEnumerable<AttendanceRecord> GetAll() => _repo.GetAll();
        public AttendanceRecord Get(int id) => _repo.Get(id);
        public void Create(AttendanceRecord attendanceRecord) { _repo.Add(attendanceRecord); _repo.Save(); }
        public void Update(AttendanceRecord attendanceRecord) { _repo.Update(attendanceRecord); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}