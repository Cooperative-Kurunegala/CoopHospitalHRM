using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAttendanceDetailService
    {
        IEnumerable<AttendanceDetail> GetAll();
        AttendanceDetail Get(int id);
        void Create(AttendanceDetail attendanceDetail);
        void Update(AttendanceDetail attendanceDetail);
        void Delete(int id);
    }
}