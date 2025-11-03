using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using HRMS.Models;
using HRMS.Repositories;
using HRMS.Services.Interfaces;

namespace HRMS.Services.Implementations
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryRepository _salaryRepository;

        public SalaryService(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public async Task<ServiceResult<IEnumerable<SalaryModel>>> GetEmployeeSalaries(int employeeId)
        {
            try
            {
                var salaries = await _salaryRepository.GetEmployeeSalaries(employeeId);
                return new ServiceResult<IEnumerable<SalaryModel>>
                {
                    Success = true,
                    Data = salaries,
                    Message = "Employee salaries retrieved successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<IEnumerable<SalaryModel>>
                {
                    Success = false,
                    Message = $"Error retrieving employee salaries: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<SalaryModel>> GetSalaryById(int salaryId)
        {
            try
            {
                var salary = await _salaryRepository.GetSalaryById(salaryId);
                if (salary == null)
                {
                    return new ServiceResult<SalaryModel>
                    {
                        Success = false,
                        Message = "Salary record not found"
                    };
                }

                return new ServiceResult<SalaryModel>
                {
                    Success = true,
                    Data = salary,
                    Message = "Salary record retrieved successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<SalaryModel>
                {
                    Success = false,
                    Message = $"Error retrieving salary: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<int>> CreateSalary(SalaryModel salary)
        {
            try
            {
                // Validate salary data
                if (salary.GrossSalary <= 0)
                {
                    return new ServiceResult<int>
                    {
                        Success = false,
                        Message = "Gross salary must be greater than 0"
                    };
                }

                // Calculate net salary if not provided
                if (salary.NetSalary == 0)
                {
                    salary.NetSalary = salary.GrossSalary + salary.Increments - salary.Deductions;
                }

                var salaryId = await _salaryRepository.CreateSalary(salary);
                return new ServiceResult<int>
                {
                    Success = true,
                    Data = salaryId,
                    Message = "Salary record created successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<int>
                {
                    Success = false,
                    Message = $"Error creating salary record: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<bool>> UpdateSalary(SalaryModel salary)
        {
            try
            {
                var existingSalary = await _salaryRepository.GetSalaryById(salary.SalaryId);
                if (existingSalary == null)
                {
                    return new ServiceResult<bool>
                    {
                        Success = false,
                        Message = "Salary record not found"
                    };
                }

                var result = await _salaryRepository.UpdateSalary(salary);
                return new ServiceResult<bool>
                {
                    Success = result,
                    Data = result,
                    Message = result ? "Salary record updated successfully" : "Failed to update salary record"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                {
                    Success = false,
                    Message = $"Error updating salary record: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<bool>> DeleteSalary(int salaryId)
        {
            try
            {
                var result = await _salaryRepository.DeleteSalary(salaryId);
                return new ServiceResult<bool>
                {
                    Success = result,
                    Data = result,
                    Message = result ? "Salary record deleted successfully" : "Failed to delete salary record"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                {
                    Success = false,
                    Message = $"Error deleting salary record: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<bool>> ProcessPayroll(int month, int year, int companyId)
        {
            try
            {
                // Validate input
                if (month < 1 || month > 12)
                {
                    return new ServiceResult<bool>
                    {
                        Success = false,
                        Message = "Invalid month. Must be between 1 and 12"
                    };
                }

                if (year < 2000 || year > 2100)
                {
                    return new ServiceResult<bool>
                    {
                        Success = false,
                        Message = "Invalid year"
                    };
                }

                // Check if payroll is already locked
                var isLocked = await _salaryRepository.IsPayrollLocked(month, year, companyId);
                if (isLocked)
                {
                    return new ServiceResult<bool>
                    {
                        Success = false,
                        Message = $"Payroll for {month}/{year} is already locked and cannot be processed"
                    };
                }

                var result = await _salaryRepository.ProcessPayroll(month, year, companyId);
                return new ServiceResult<bool>
                {
                    Success = result,
                    Data = result,
                    Message = result ? "Payroll processed successfully" : "Failed to process payroll"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                {
                    Success = false,
                    Message = $"Error processing payroll: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<IEnumerable<RelatedPartySalaryModel>>> GetPayrollData(int month, int year, int companyId)
        {
            try
            {
                var payrollData = await _salaryRepository.GetPayrollData(month, year, companyId);
                return new ServiceResult<IEnumerable<RelatedPartySalaryModel>>
                {
                    Success = true,
                    Data = payrollData,
                    Message = "Payroll data retrieved successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<IEnumerable<RelatedPartySalaryModel>>
                {
                    Success = false,
                    Message = $"Error retrieving payroll data: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<bool>> LockPayroll(int month, int year, int companyId)
        {
            try
            {
                var result = await _salaryRepository.LockPayroll(month, year, companyId);
                return new ServiceResult<bool>
                {
                    Success = result,
                    Data = result,
                    Message = result ? "Payroll locked successfully" : "Failed to lock payroll"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                {
                    Success = false,
                    Message = $"Error locking payroll: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<IEnumerable<dynamic>>> GetSalaryReport(int month, int year)
        {
            try
            {
                var report = await _salaryRepository.GetSalaryReport(month, year);
                return new ServiceResult<IEnumerable<dynamic>>
                {
                    Success = true,
                    Data = report,
                    Message = "Salary report generated successfully"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<IEnumerable<dynamic>>
                {
                    Success = false,
                    Message = $"Error generating salary report: {ex.Message}"
                };
            }
        }

        public async Task<ServiceResult<decimal>> GetTotalSalaryExpense(int month, int year, int companyId)
        {
            try
            {
                var totalExpense = await _salaryRepository.GetTotalSalaryExpense(month, year, companyId);
                return new ServiceResult<decimal>
                {
                    Success = true,
                    Data = totalExpense,
                    Message = $"Total salary expense for {month}/{year}: {totalExpense:C}"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult<decimal>
                {
                    Success = false,
                    Message = $"Error calculating total salary expense: {ex.Message}"
                };
            }
        }
    }
}