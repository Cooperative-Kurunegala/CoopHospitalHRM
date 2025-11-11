using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAttendanceTimeService
    {
        IEnumerable<AttendanceTime> GetAll();
        AttendanceTime Get(int id);
        void Create(AttendanceTime attendanceTime);
        void Update(AttendanceTime attendanceTime);
        void Delete(int id);
    }
}