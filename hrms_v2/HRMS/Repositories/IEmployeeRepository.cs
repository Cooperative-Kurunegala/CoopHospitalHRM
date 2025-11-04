using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

using HRMS.Models;

namespace HRMS.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
        Task<EmployeeModel> GetEmployeeById(int id);
        Task<int> CreateEmployee(EmployeeModel employee);
        Task<bool> UpdateEmployee(EmployeeModel employee);
        Task<bool> DeleteEmployee(int id);
        Task<IEnumerable<EmployeeModel>> GetEmployeesByDepartment(int departmentId);
    }

    public interface IAttendanceRepository
    {
        Task<IEnumerable<AttendanceModel>> GetEmployeeAttendance(int employeeId, string startDate, string endDate);
        Task<int> MarkAttendance(AttendanceModel attendance);
        Task<bool> UpdateAttendance(AttendanceModel attendance);
        Task<IEnumerable<RelatedPartySessionModel>> GetEmployeeSessions(int employeeId, int month, int year);
    }

    public interface ISalaryRepository
    {
        // Salary Operations
        Task<IEnumerable<SalaryModel>> GetEmployeeSalaries(int employeeId);
        Task<SalaryModel> GetSalaryById(int salaryId);
        Task<int> CreateSalary(SalaryModel salary);
        Task<bool> UpdateSalary(SalaryModel salary);
        Task<bool> DeleteSalary(int salaryId);
        Task<IEnumerable<SalaryModel>> GetSalariesByDateRange(string startDate, string endDate);

        // Related Party Salary Operations
        Task<IEnumerable<RelatedPartySalaryModel>> GetRelatedPartySalaries(int relatedPartyId);
        Task<RelatedPartySalaryModel> GetRelatedPartySalaryById(int salaryId);
        Task<int> CreateRelatedPartySalary(RelatedPartySalaryModel salary);
        Task<bool> UpdateRelatedPartySalary(RelatedPartySalaryModel salary);

        // Payroll Processing
        Task<bool> ProcessPayroll(int month, int year, int companyId);
        Task<IEnumerable<RelatedPartySalaryModel>> GetPayrollData(int month, int year, int companyId);
        Task<bool> LockPayroll(int month, int year, int companyId);
        Task<bool> IsPayrollLocked(int month, int year, int companyId);

        // Salary Modifiers
        Task<IEnumerable<SalaryModifiersModel>> GetSalaryModifiers();
        Task<IEnumerable<RelatedPartySalaryModifierMappingModel>> GetSalaryModifierMappings(int salaryId);
        Task<int> AddSalaryModifierMapping(RelatedPartySalaryModifierMappingModel mapping);
        Task<bool> UpdateSalaryModifierMapping(RelatedPartySalaryModifierMappingModel mapping);

        // Reports
        Task<IEnumerable<dynamic>> GetSalaryReport(int month, int year);
        Task<decimal> GetTotalSalaryExpense(int month, int year, int companyId);
    }
}