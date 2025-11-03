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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext dapperContext;

        public EmployeeRepository(DapperContext context)
        {
            dapperContext = context;
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllEmployees()
        {
            var query = @"
                SELECT e.*, d.DepartmentName, des.DesignationName, g.GradeName, c.CompanyName
                FROM Employee e
                LEFT JOIN Department d ON e.DepartmentId = d.DepartmentId
                LEFT JOIN Designation des ON e.DesignationId = des.DesignationId
                LEFT JOIN Grade g ON e.GradeId = g.GradeId
                LEFT JOIN Company c ON e.CompanyId = c.CompanyId
                WHERE e.IsActive = 1";

            using (var connection = dapperContext.CreateConnection())
            {
                return await connection.QueryAsync<EmployeeModel>(query);
            }
        }

        public async Task<EmployeeModel> GetEmployeeById(int id)
        {
            var query = @"
                SELECT e.*, d.DepartmentName, des.DesignationName, g.GradeName, c.CompanyName
                FROM Employee e
                LEFT JOIN Department d ON e.DepartmentId = d.DepartmentId
                LEFT JOIN Designation des ON e.DesignationId = des.DesignationId
                LEFT JOIN Grade g ON e.GradeId = g.GradeId
                LEFT JOIN Company c ON e.CompanyId = c.CompanyId
                WHERE e.EmployeeID = @Id";

            using (var connection = dapperContext.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<EmployeeModel>(query, new { Id = id });
            }
        }

        public async Task<int> CreateEmployee(EmployeeModel employee)
        {
            var query = @"
                INSERT INTO Employee (
                    EmployeeNumber, FirstName, LastName, DateOfBirth, Religion, MaritalStatus, 
                    Gender, Province, EmployeeType, NICNumber, MobileNumber, HomeNumber, 
                    EmailAddress, HomeAddress, CurrentAddress, EPFNumber, ETFNumber, 
                    EmergencyContactName, EmergencyContactNumber, EmergencyContactAddress, 
                    JoinedDate, DepartmentId, DesignationId, GradeId, CompanyId
                ) 
                OUTPUT INSERTED.EmployeeID
                VALUES (
                    @EmployeeNumber, @FirstName, @LastName, @DateOfBirth, @Religion, @MaritalStatus,
                    @Gender, @Province, @EmployeeType, @NICNumber, @MobileNumber, @HomeNumber,
                    @EmailAddress, @HomeAddress, @CurrentAddress, @EPFNumber, @ETFNumber,
                    @EmergencyContactName, @EmergencyContactNumber, @EmergencyContactAddress,
                    @JoinedDate, @DepartmentId, @DesignationId, @GradeId, @CompanyId
                )";

            using (var connection = dapperContext.CreateConnection())
            {
                return await connection.ExecuteScalarAsync<int>(query, employee);
            }
        }

        public async Task<bool> UpdateEmployee(EmployeeModel employee)
        {
            var query = @"
                UPDATE Employee SET 
                    EmployeeNumber = @EmployeeNumber,
                    FirstName = @FirstName,
                    LastName = @LastName,
                    DateOfBirth = @DateOfBirth,
                    Religion = @Religion,
                    MaritalStatus = @MaritalStatus,
                    Gender = @Gender,
                    Province = @Province,
                    EmployeeType = @EmployeeType,
                    NICNumber = @NICNumber,
                    MobileNumber = @MobileNumber,
                    HomeNumber = @HomeNumber,
                    EmailAddress = @EmailAddress,
                    HomeAddress = @HomeAddress,
                    CurrentAddress = @CurrentAddress,
                    EPFNumber = @EPFNumber,
                    ETFNumber = @ETFNumber,
                    EmergencyContactName = @EmergencyContactName,
                    EmergencyContactNumber = @EmergencyContactNumber,
                    EmergencyContactAddress = @EmergencyContactAddress,
                    JoinedDate = @JoinedDate,
                    DepartmentId = @DepartmentId,
                    DesignationId = @DesignationId,
                    GradeId = @GradeId,
                    CompanyId = @CompanyId
                WHERE EmployeeID = @EmployeeID";

            using (var connection = dapperContext.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, employee);
                return affectedRows > 0;
            }
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var query = "UPDATE Employee SET IsActive = 0 WHERE EmployeeID = @Id";

            using (var connection = dapperContext.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, new { Id = id });
                return affectedRows > 0;
            }
        }

        public async Task<IEnumerable<EmployeeModel>> GetEmployeesByDepartment(int departmentId)
        {
            var query = @"
                SELECT e.*, d.DepartmentName, des.DesignationName, g.GradeName, c.CompanyName
                FROM Employee e
                LEFT JOIN Department d ON e.DepartmentId = d.DepartmentId
                LEFT JOIN Designation des ON e.DesignationId = des.DesignationId
                LEFT JOIN Grade g ON e.GradeId = g.GradeId
                LEFT JOIN Company c ON e.CompanyId = c.CompanyId
                WHERE e.DepartmentId = @DepartmentId AND e.IsActive = 1";

            using (var connection = dapperContext.CreateConnection())
            {
                return await connection.QueryAsync<EmployeeModel>(query, new { DepartmentId = departmentId });
            }
        }
    }
}
