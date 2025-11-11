using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAttendanceRecordService
    {
        IEnumerable<AttendanceRecord> GetAll();
        AttendanceRecord Get(int id);
        void Create(AttendanceRecord attendanceRecord);
        void Update(AttendanceRecord attendanceRecord);
        void Delete(int id);
    }
}