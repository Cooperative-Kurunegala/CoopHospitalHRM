using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRMS.Models;
using HRMS.Services.Interfaces;
using HRMS.Repositories;
using System.Threading.Tasks;

namespace HRMS.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<ServiceResult<IEnumerable<EmployeeModel>>> GetAllEmployees()
        {
            try
            {
                var employees = await _employeeRepository.GetAllEmployees();
                return new ServiceResult<IEnumerable<EmployeeModel>>
                {
                    Success = true,
                    Data = employees,
                    Message = "Employees retrieved successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<IEnumerable<EmployeeModel>>
                {
                    Success = false,
                    Message = $"Error retrieving employees: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<EmployeeModel>> GetEmployeeById(int id)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeById(id);
                if (employee == null)
                {
                    return new ServiceResult<EmployeeModel>
                    {
                        Success = false,
                        Message = "Employee not found"
                    };
                }

                return new ServiceResult<EmployeeModel>
                {
                    Success = true,
                    Data = employee,
                    Message = "Employee retrieved successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<EmployeeModel>
                {
                    Success = false,
                    Message = $"Error retrieving employee: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<int>> CreateEmployee(EmployeeModel employee)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrEmpty(employee.FirstName) || string.IsNullOrEmpty(employee.LastName))
                {
                    return new ServiceResult<int>
                    {
                        Success = false,
                        Message = "First name and last name are required"
                    };
                }

                var employeeId = await _employeeRepository.CreateEmployee(employee);
                return new ServiceResult<int>
                {
                    Success = true,
                    Data = employeeId,
                    Message = "Employee created successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<int>
                {
                    Success = false,
                    Message = $"Error creating employee: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<bool>> UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                var existingEmployee = await _employeeRepository.GetEmployeeById(employee.EmployeeID);
                if (existingEmployee == null)
                {
                    return new ServiceResult<bool>
                    {
                        Success = false,
                        Message = "Employee not found"
                    };
                }

                var result = await _employeeRepository.UpdateEmployee(employee);
                return new ServiceResult<bool>
                {
                    Success = result,
                    Data = result,
                    Message = result ? "Employee updated successfully" : "Failed to update employee"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                {
                    Success = false,
                    Message = $"Error updating employee: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<bool>> DeleteEmployee(int id)
        {
            try
            {
                var result = await _employeeRepository.DeleteEmployee(id);
                return new ServiceResult<bool>
                {
                    Success = result,
                    Data = result,
                    Message = result ? "Employee deleted successfully" : "Failed to delete employee"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                {
                    Success = false,
                    Message = $"Error deleting employee: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<IEnumerable<EmployeeModel>>> GetEmployeesByDepartment(int departmentId)
        {
            try
            {
                var employees = await _employeeRepository.GetEmployeesByDepartment(departmentId);
                return new ServiceResult<IEnumerable<EmployeeModel>>
                {
                    Success = true,
                    Data = employees,
                    Message = "Department employees retrieved successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<IEnumerable<EmployeeModel>>
                {
                    Success = false,
                    Message = $"Error retrieving department employees: {ex.Message}"
                };
            }
        }
    }
}