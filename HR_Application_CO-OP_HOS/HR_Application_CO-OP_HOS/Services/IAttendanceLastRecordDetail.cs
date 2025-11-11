using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IAttendanceLastRecordDetailService
    {
        IEnumerable<AttendanceLastRecordDetail> GetAll();
        AttendanceLastRecordDetail Get(int id);
        void Create(AttendanceLastRecordDetail attendanceLastRecordDetail);
        void Update(AttendanceLastRecordDetail attendanceLastRecordDetail);
        void Delete(int id);
    }
}