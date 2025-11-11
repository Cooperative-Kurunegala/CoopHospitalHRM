using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public class AttendanceDetailService : IAttendanceDetailService
    {
        private readonly IRepository<AttendanceDetail> _repo;
        public AttendanceDetailService(IRepository<AttendanceDetail> repo) { _repo = repo; }
        public IEnumerable<AttendanceDetail> GetAll() => _repo.GetAll();
        public AttendanceDetail Get(int id) => _repo.Get(id);
        public void Create(AttendanceDetail attendanceDetail) { _repo.Add(attendanceDetail); _repo.Save(); }
        public void Update(AttendanceDetail attendanceDetail) { _repo.Update(attendanceDetail); _repo.Save(); }
        public void Delete(int id) { _repo.Delete(id); _repo.Save(); }
    }
}