using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using HRMS.Models;
using HRMS.Data;
using System.Threading.Tasks;

namespace HRMS.Repositories.Implementations
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly DapperContext _context;

        public AttendanceRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AttendanceModel>> GetEmployeeAttendance(int employeeId, string startDate, string endDate)
        {
            var query = @"
                SELECT * FROM Attendance 
                WHERE EmployeeId = @EmployeeId 
                AND AttendanceDate BETWEEN @StartDate AND @EndDate
                ORDER BY AttendanceDate DESC";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<AttendanceModel>(query, new
                {
                    EmployeeId = employeeId,
                    StartDate = startDate,
                    EndDate = endDate
                });
            }
        }

        public async Task<int> MarkAttendance(AttendanceModel attendance)
        {
            var query = @"
                INSERT INTO Attendance (InTime, OutTime, AttendanceDate, EmployeeId)
                OUTPUT INSERTED.AttendanceId
                VALUES (@InTime, @OutTime, @AttendanceDate, @EmployeeId)";

            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteScalarAsync<int>(query, attendance);
            }
        }

        public async Task<bool> UpdateAttendance(AttendanceModel attendance)
        {
            var query = @"
                UPDATE Attendance SET 
                    InTime = @InTime,
                    OutTime = @OutTime,
                    AttendanceDate = @AttendanceDate
                WHERE AttendanceId = @AttendanceId";

            using (var connection = _context.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, attendance);
                return affectedRows > 0;
            }
        }

        public async Task<IEnumerable<RelatedPartySessionModel>> GetEmployeeSessions(int employeeId, int month, int year)
        {
            var query = @"
                SELECT * FROM RelatedPartySession 
                WHERE RelatedPartyID = @EmployeeId 
                AND PayMonth = @Month 
                AND PayYear = @Year
                ORDER BY CalendarDay";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<RelatedPartySessionModel>(query, new
                {
                    EmployeeId = employeeId,
                    Month = month,
                    Year = year
                });
            }
        }
    }
}
