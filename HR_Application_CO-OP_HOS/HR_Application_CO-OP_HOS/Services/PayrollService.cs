using HR_Application_CO_OP_HOS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using HR_Application_CO_OP_HOS.Models;

namespace HR_Application_CO_OP_HOS.Services
{
    public class PayrollService
    {
        private readonly GenericRepository<EmployeeModel> _empRepo;
        private readonly DapperRepository _dapper;

        public PayrollService(GenericRepository<EmployeeModel> empRepo, DapperRepository dapper)
        {
            _empRepo = empRepo;
            _dapper = dapper;
        }

        public void RunMonthlyPayroll(int month, int year)
        {
            var employees = _empRepo.GetAll().Where(e => e.IsActive == true).ToList();
            var payrollPeriod = new DateTime(year, month, 1);

            foreach (var emp in employees)
            {
                // Get allowances for the specific payroll period
                var allowances = _dapper.Query<Allowance>(
                    @"SELECT * FROM Allowance 
                      WHERE EmployeeId = @EmployeeId 
                      AND EffectiveDate <= @PayrollPeriod
                      AND (EffectiveDate = (
                          SELECT MAX(EffectiveDate) 
                          FROM Allowance 
                          WHERE EmployeeId = @EmployeeId 
                          AND AllowanceType = a.AllowanceType 
                          AND EffectiveDate <= @PayrollPeriod
                      ))",
                    new { EmployeeId = emp.ID, PayrollPeriod = payrollPeriod }
                ).ToList();

                // Calculate total allowances
                decimal totalAllowances = allowances.Sum(a => a.Amount);

                // Calculate basic salary (you might need to get this from EmployeeModel)
                decimal basicSalary = emp.BasicSalary ?? 0; // Adjust based on your EmployeeModel

                // Calculate net salary
                decimal netSalary = basicSalary + totalAllowances;

                // Here you would typically:
                // 1. Create a PayrollRecord or SalaryModel
                // 2. Apply deductions, taxes, etc.
                // 3. Save the payroll record

                Console.WriteLine($"Employee: {emp.RelatedPartyName}, Basic: {basicSalary}, Allowances: {totalAllowances}, Net: {netSalary}");

                // If you need to save payroll records, you would do it here
                // SavePayrollRecord(emp.Id, month, year, basicSalary, totalAllowances, netSalary);
            }

            // Remove or replace with appropriate save method
            // _empRepo.SaveChanges(); // If this method exists
        }

        // Optional: Method to get allowances by type for a specific period
        public Dictionary<string, decimal> GetEmployeeAllowancesByType(int employeeId, DateTime payrollPeriod)
        {
            var allowances = _dapper.Query<Allowance>(
                @"SELECT * FROM Allowance 
                  WHERE EmployeeId = @EmployeeId 
                  AND EffectiveDate <= @PayrollPeriod
                  AND (EffectiveDate = (
                      SELECT MAX(EffectiveDate) 
                      FROM Allowance 
                      WHERE EmployeeId = @EmployeeId 
                      AND AllowanceType = a.AllowanceType 
                      AND EffectiveDate <= @PayrollPeriod
                  ))",
                new { EmployeeId = employeeId, PayrollPeriod = payrollPeriod }
            );

            return allowances.GroupBy(a => a.AllowanceType)
                            .ToDictionary(g => g.Key, g => g.Sum(a => a.Amount));
        }

        // Optional: Method to get current active allowances
        public List<Allowance> GetCurrentAllowances(int employeeId)
        {
            return _dapper.Query<Allowance>(
                @"SELECT a.* FROM Allowance a
                  INNER JOIN (
                      SELECT AllowanceType, MAX(EffectiveDate) as MaxDate
                      FROM Allowance
                      WHERE EmployeeId = @EmployeeId 
                      AND EffectiveDate <= GETDATE()
                      GROUP BY AllowanceType
                  ) latest ON a.AllowanceType = latest.AllowanceType AND a.EffectiveDate = latest.MaxDate
                  WHERE a.EmployeeId = @EmployeeId",
                new { EmployeeId = employeeId }
            ).ToList();
        }
    }
}