using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using HRMS.Models;

namespace HRMS.Services.Interfaces
{
    public interface ISalaryService
    {
        // Salary Operations
        Task<ServiceResult<IEnumerable<SalaryModel>>> GetEmployeeSalaries(int employeeId);
        Task<ServiceResult<SalaryModel>> GetSalaryById(int salaryId);
        Task<ServiceResult<int>> CreateSalary(SalaryModel salary);
        Task<ServiceResult<bool>> UpdateSalary(SalaryModel salary);
        Task<ServiceResult<bool>> DeleteSalary(int salaryId);

        // Payroll Operations
        Task<ServiceResult<bool>> ProcessPayroll(int month, int year, int companyId);
        Task<ServiceResult<IEnumerable<RelatedPartySalaryModel>>> GetPayrollData(int month, int year, int companyId);
        Task<ServiceResult<bool>> LockPayroll(int month, int year, int companyId);

        // Reports
        Task<ServiceResult<IEnumerable<dynamic>>> GetSalaryReport(int month, int year);
        Task<ServiceResult<decimal>> GetTotalSalaryExpense(int month, int year, int companyId);
    }
}