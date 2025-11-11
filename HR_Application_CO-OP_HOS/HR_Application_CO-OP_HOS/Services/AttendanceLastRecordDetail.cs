using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AttendanceLastRecordDetailService : IAttendanceLastRecordDetailService
    {
        private readonly IRepository<AttendanceLastRecordDetail> _repo;
        public AttendanceLastRecordDetailService(IRepository<AttendanceLastRecordDetail> repo) { _repo = repo; }
        public IEnumerable<AttendanceLastRecordDetail> GetAll() => _repo.GetAll();
        public AttendanceLastRecordDetail Get(int id) => _repo.Get(id);
        public void Create(AttendanceLastRecordDetail attendanceLastRecordDetail) { _repo.Add(attendanceLastRecordDetail); _repo.Save(); }
        public void Update(AttendanceLastRecordDetail attendanceLastRecordDetail) { _repo.Update(attendanceLastRecordDetail); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}