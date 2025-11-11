using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAttendanceDataService
    {
        IEnumerable<AttendanceData> GetAll();
        AttendanceData Get(int id);
        void Create(AttendanceData attendanceData);
        void Update(AttendanceData attendanceData);
        void Delete(int id);
    }
}