using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AttendanceRecordsService : IAttendanceRecordsService
    {
        private readonly IRepository<AttendanceRecord> _repo;
        public AttendanceRecordsService(IRepository<AttendanceRecord> repo) { _repo = repo; }
        public IEnumerable<AttendanceRecord> GetAll() => _repo.GetAll();
        public AttendanceRecord Get(int id) => _repo.Get(id);
        public void Create(AttendanceRecord AttendanceRecord) { _repo.Add(AttendanceRecord); _repo.Save(); }
        public void Update(AttendanceRecord AttendanceRecord) { _repo.Update(AttendanceRecord); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }

    }
}