using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAttendanceRecordsService
    {
        IEnumerable<AttendanceRecord> GetAll();
        AttendanceRecord Get(int id);
        void Create(AttendanceRecord AttendanceRecord);
        void Update(AttendanceRecord AttendanceRecord);
        void Delete(int id);
    }
}