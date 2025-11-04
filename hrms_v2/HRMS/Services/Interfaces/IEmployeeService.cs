using HRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HRMS.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<ServiceResult<IEnumerable<EmployeeModel>>> GetAllEmployees();
        Task<ServiceResult<EmployeeModel>> GetEmployeeById(int id);
        Task<ServiceResult<int>> CreateEmployee(EmployeeModel employee);
        Task<ServiceResult<bool>> UpdateEmployee(EmployeeModel employee);
        Task<ServiceResult<bool>> DeleteEmployee(int id);
        Task<ServiceResult<IEnumerable<EmployeeModel>>> GetEmployeesByDepartment(int departmentId);
    }

    public class ServiceResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}