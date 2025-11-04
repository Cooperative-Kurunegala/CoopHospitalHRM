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
    public class SalaryRepository : ISalaryRepository
    {
        private readonly DapperContext _context;

        public SalaryRepository(DapperContext context)
        {
            _context = context;
        }

        // Salary Operations
        public async Task<IEnumerable<SalaryModel>> GetEmployeeSalaries(int employeeId)
        {
            var query = @"
                SELECT s.*, e.FirstName, e.LastName, e.EmployeeNumber,
                       d.DepartmentName, des.DesignationName, g.GradeName, c.CompanyName
                FROM Salary s
                INNER JOIN Employee e ON s.EmployeeId = e.EmployeeID
                LEFT JOIN Department d ON s.DepartmentId = d.DepartmentId
                LEFT JOIN Designation des ON s.DesignationId = des.DesignationId
                LEFT JOIN Grade g ON s.GradeId = g.GradeId
                LEFT JOIN Company c ON s.CompanyId = c.CompanyId
                WHERE s.EmployeeId = @EmployeeId
                ORDER BY s.IssuedDate DESC";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<SalaryModel>(query, new { EmployeeId = employeeId });
            }
        }

        public async Task<SalaryModel> GetSalaryById(int salaryId)
        {
            var query = @"
                SELECT s.*, e.FirstName, e.LastName, e.EmployeeNumber,
                       d.DepartmentName, des.DesignationName, g.GradeName, c.CompanyName
                FROM Salary s
                INNER JOIN Employee e ON s.EmployeeId = e.EmployeeID
                LEFT JOIN Department d ON s.DepartmentId = d.DepartmentId
                LEFT JOIN Designation des ON s.DesignationId = des.DesignationId
                LEFT JOIN Grade g ON s.GradeId = g.GradeId
                LEFT JOIN Company c ON s.CompanyId = c.CompanyId
                WHERE s.SalaryId = @SalaryId";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<SalaryModel>(query, new { SalaryId = salaryId });
            }
        }

        public async Task<int> CreateSalary(SalaryModel salary)
        {
            var query = @"
                INSERT INTO Salary (
                    SalaryHeadName, IssuedDate, EmployeeId, CategoryId, DepartmentId,
                    DesignationId, GradeId, GrossSalary, Increments, Deductions, NetSalary
                )
                OUTPUT INSERTED.SalaryId
                VALUES (
                    @SalaryHeadName, @IssuedDate, @EmployeeId, @CategoryId, @DepartmentId,
                    @DesignationId, @GradeId, @GrossSalary, @Increments, @Deductions, @NetSalary
                )";

            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteScalarAsync<int>(query, salary);
            }
        }

        public async Task<bool> UpdateSalary(SalaryModel salary)
        {
            var query = @"
                UPDATE Salary SET 
                    SalaryHeadName = @SalaryHeadName,
                    IssuedDate = @IssuedDate,
                    EmployeeId = @EmployeeId,
                    CategoryId = @CategoryId,
                    DepartmentId = @DepartmentId,
                    DesignationId = @DesignationId,
                    GradeId = @GradeId,
                    GrossSalary = @GrossSalary,
                    Increments = @Increments,
                    Deductions = @Deductions,
                    NetSalary = @NetSalary
                WHERE SalaryId = @SalaryId";

            using (var connection = _context.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, salary);
                return affectedRows > 0;
            }
        }

        public async Task<bool> DeleteSalary(int salaryId)
        {
            var query = "DELETE FROM Salary WHERE SalaryId = @SalaryId";
            using (var connection = _context.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, new { SalaryId = salaryId });
                return affectedRows > 0;
            }
        }

        public async Task<IEnumerable<SalaryModel>> GetSalariesByDateRange(string startDate, string endDate)
        {
            var query = @"
                SELECT s.*, e.FirstName, e.LastName, e.EmployeeNumber,
                       d.DepartmentName, des.DesignationName, g.GradeName, c.CompanyName
                FROM Salary s
                INNER JOIN Employee e ON s.EmployeeId = e.EmployeeID
                LEFT JOIN Department d ON s.DepartmentId = d.DepartmentId
                LEFT JOIN Designation des ON s.DesignationId = des.DesignationId
                LEFT JOIN Grade g ON s.GradeId = g.GradeId
                LEFT JOIN Company c ON s.CompanyId = c.CompanyId
                WHERE s.IssuedDate BETWEEN @StartDate AND @EndDate
                ORDER BY s.IssuedDate DESC, e.FirstName, e.LastName";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<SalaryModel>(query, new
                {
                    StartDate = startDate,
                    EndDate = endDate
                });
            }
        }

        // Related Party Salary Operations
        public async Task<IEnumerable<RelatedPartySalaryModel>> GetRelatedPartySalaries(int relatedPartyId)
        {
            var query = @"
                SELECT rs.*, rp.RelatedPartyName, rp.RegistrationNumber, c.CompanyName, st.SalaryTypeName
                FROM RelatedPartySalary rs
                INNER JOIN RelatedParty rp ON rs.RelatedPartyID = rp.ID
                LEFT JOIN Company c ON rs.CompanyID = c.CompanyId
                LEFT JOIN SalaryType st ON rs.SalaryTypeID = st.ID
                WHERE rs.RelatedPartyID = @RelatedPartyId
                ORDER BY rs.Year DESC, rs.Month DESC";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<RelatedPartySalaryModel>(query, new { RelatedPartyId = relatedPartyId });
            }
        }

        public async Task<RelatedPartySalaryModel> GetRelatedPartySalaryById(int salaryId)
        {
            var query = @"
                SELECT rs.*, rp.RelatedPartyName, rp.RegistrationNumber, c.CompanyName, st.SalaryTypeName
                FROM RelatedPartySalary rs
                INNER JOIN RelatedParty rp ON rs.RelatedPartyID = rp.ID
                LEFT JOIN Company c ON rs.CompanyID = c.CompanyId
                LEFT JOIN SalaryType st ON rs.SalaryTypeID = st.ID
                WHERE rs.ID = @SalaryId";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<RelatedPartySalaryModel>(query, new { SalaryId = salaryId });
            }
        }

        public async Task<int> CreateRelatedPartySalary(RelatedPartySalaryModel salary)
        {
            var query = @"
                INSERT INTO RelatedPartySalary (
                    RelatedPartyEPF, Month, Year, CompanyID, NoPayDays, LateMinutes, OTMinutes,
                    RelatedPartyID, IsPayoutGenerated, IsLocked, SalaryTypeID, PayeeTaxRate, WorkedDays
                )
                OUTPUT INSERTED.ID
                VALUES (
                    @RelatedPartyEPF, @Month, @Year, @CompanyID, @NoPayDays, @LateMinutes, @OTMinutes,
                    @RelatedPartyID, @IsPayoutGenerated, @IsLocked, @SalaryTypeID, @PayeeTaxRate, @WorkedDays
                )";

            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteScalarAsync<int>(query, salary);
            }
        }

        public async Task<bool> UpdateRelatedPartySalary(RelatedPartySalaryModel salary)
        {
            var query = @"
                UPDATE RelatedPartySalary SET 
                    RelatedPartyEPF = @RelatedPartyEPF,
                    Month = @Month,
                    Year = @Year,
                    CompanyID = @CompanyID,
                    NoPayDays = @NoPayDays,
                    LateMinutes = @LateMinutes,
                    OTMinutes = @OTMinutes,
                    RelatedPartyID = @RelatedPartyID,
                    IsPayoutGenerated = @IsPayoutGenerated,
                    IsLocked = @IsLocked,
                    SalaryTypeID = @SalaryTypeID,
                    PayeeTaxRate = @PayeeTaxRate,
                    WorkedDays = @WorkedDays
                WHERE ID = @ID";

            using (var connection = _context.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, salary);
                return affectedRows > 0;
            }
        }

        // Payroll Processing
        public async Task<bool> ProcessPayroll(int month, int year, int companyId)
        {
            using (var connection = _context.CreateConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var checkQuery = @"
                            SELECT COUNT(*) FROM RelatedPartySalary 
                            WHERE Month = @Month AND Year = @Year AND CompanyID = @CompanyId";

                        var existingCount = await connection.ExecuteScalarAsync<int>(checkQuery, new
                        {
                            Month = month,
                            Year = year,
                            CompanyId = companyId
                        }, transaction);

                        if (existingCount > 0)
                        {
                            throw new Exception($"Payroll for {month}/{year} is already processed");
                        }

                        var employeesQuery = @"
                            SELECT ID, RegistrationNumber, RelatedPartyName, BasicSalary 
                            FROM RelatedParty 
                            WHERE CompanyID = @CompanyId AND IsActive = 1 AND IsSetforPayroll = 1";

                        var employees = await connection.QueryAsync<dynamic>(employeesQuery, new { CompanyId = companyId }, transaction);

                        foreach (var employee in employees)
                        {
                            var attendanceQuery = @"
                                SELECT 
                                    COUNT(*) as TotalDays,
                                    SUM(CASE WHEN LateInMinutes > 0 THEN 1 ELSE 0 END) as LateDays,
                                    SUM(OTMinutes) as TotalOTMinutes,
                                    SUM(WorkedMinutes) as TotalWorkedMinutes
                                FROM RelatedPartySession 
                                WHERE RelatedPartyID = @EmployeeId 
                                AND PayMonth = @Month 
                                AND PayYear = @Year";

                            var attendanceData = await connection.QueryFirstOrDefaultAsync<dynamic>(attendanceQuery, new
                            {
                                EmployeeId = employee.ID,
                                Month = month,
                                Year = year
                            }, transaction);

                            double basicSalary = employee.BasicSalary;
                            double workedDays = attendanceData?.TotalDays ?? 0;
                            double noPayDays = 0;
                            double lateMinutes = (attendanceData?.LateDays ?? 0) * 30;
                            double otMinutes = attendanceData?.TotalOTMinutes ?? 0;

                            var salaryQuery = @"
                                INSERT INTO RelatedPartySalary (
                                    RelatedPartyEPF, Month, Year, CompanyID, NoPayDays, LateMinutes, 
                                    OTMinutes, RelatedPartyID, IsPayoutGenerated, IsLocked, SalaryTypeID,
                                    PayeeTaxRate, WorkedDays
                                )
                                VALUES (
                                    @RelatedPartyEPF, @Month, @Year, @CompanyID, @NoPayDays, @LateMinutes,
                                    @OTMinutes, @RelatedPartyID, 0, 0, 1, @PayeeTaxRate, @WorkedDays
                                )";

                            await connection.ExecuteAsync(salaryQuery, new
                            {
                                RelatedPartyEPF = employee.RegistrationNumber,
                                Month = month,
                                Year = year,
                                CompanyID = companyId,
                                NoPayDays = noPayDays,
                                LateMinutes = lateMinutes,
                                OTMinutes = otMinutes,
                                RelatedPartyID = employee.ID,
                                PayeeTaxRate = 0.0,
                                WorkedDays = workedDays
                            }, transaction);
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public async Task<IEnumerable<RelatedPartySalaryModel>> GetPayrollData(int month, int year, int companyId)
        {
            var query = @"
                SELECT rs.*, rp.RelatedPartyName, rp.RegistrationNumber, c.CompanyName, st.SalaryTypeName
                FROM RelatedPartySalary rs
                INNER JOIN RelatedParty rp ON rs.RelatedPartyID = rp.ID
                LEFT JOIN Company c ON rs.CompanyID = c.CompanyId
                LEFT JOIN SalaryType st ON rs.SalaryTypeID = st.ID
                WHERE rs.Month = @Month AND rs.Year = @Year AND rs.CompanyID = @CompanyId
                ORDER BY rp.RelatedPartyName";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<RelatedPartySalaryModel>(query, new
                {
                    Month = month,
                    Year = year,
                    CompanyId = companyId
                });
            }
        }

        public async Task<bool> LockPayroll(int month, int year, int companyId)
        {
            var query = @"
                UPDATE RelatedPartySalary 
                SET IsLocked = 1 
                WHERE Month = @Month AND Year = @Year AND CompanyID = @CompanyId";

            using (var connection = _context.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, new
                {
                    Month = month,
                    Year = year,
                    CompanyId = companyId
                });
                return affectedRows > 0;
            }
        }

        public async Task<bool> IsPayrollLocked(int month, int year, int companyId)
        {
            var query = @"
                SELECT TOP 1 IsLocked 
                FROM RelatedPartySalary 
                WHERE Month = @Month AND Year = @Year AND CompanyID = @CompanyId";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.ExecuteScalarAsync<bool?>(query, new
                {
                    Month = month,
                    Year = year,
                    CompanyId = companyId
                });
                return result ?? false;
            }
        }

        // Salary Modifiers
        public async Task<IEnumerable<SalaryModifiersModel>> GetSalaryModifiers()
        {
            var query = @"
                SELECT * FROM SalaryModifiers 
                WHERE IsEnabled = 1 
                ORDER BY OrderIndex";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<SalaryModifiersModel>(query);
            }
        }

        public async Task<IEnumerable<RelatedPartySalaryModifierMappingModel>> GetSalaryModifierMappings(int salaryId)
        {
            var query = @"
                SELECT smm.*, sm.SalaryModifierName, sm.SalaryModifierTypeID
                FROM RelatedPartySalaryModifierMapping smm
                LEFT JOIN SalaryModifiers sm ON smm.SalaryModifierID = sm.ID
                WHERE smm.RelatedPartySalaryID = @SalaryId
                ORDER BY smm.OrderIndex";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<RelatedPartySalaryModifierMappingModel>(query, new { SalaryId = salaryId });
            }
        }

        public async Task<int> AddSalaryModifierMapping(RelatedPartySalaryModifierMappingModel mapping)
        {
            var query = @"
                INSERT INTO RelatedPartySalaryModifierMapping (
                    RelatedPartySalaryID, SalaryModifierID, OrderIndex, GroupingForSlip,
                    ActualAmount, SalaryModifierName, SalaryModifierTypeID, IsNoPay, IsLateHours
                )
                OUTPUT INSERTED.ID
                VALUES (
                    @RelatedPartySalaryID, @SalaryModifierID, @OrderIndex, @GroupingForSlip,
                    @ActualAmount, @SalaryModifierName, @SalaryModifierTypeID, @IsNoPay, @IsLateHours
                )";

            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteScalarAsync<int>(query, mapping);
            }
        }

        public async Task<bool> UpdateSalaryModifierMapping(RelatedPartySalaryModifierMappingModel mapping)
        {
            var query = @"
                UPDATE RelatedPartySalaryModifierMapping SET 
                    OrderIndex = @OrderIndex,
                    GroupingForSlip = @GroupingForSlip,
                    ActualAmount = @ActualAmount,
                    SalaryModifierName = @SalaryModifierName,
                    SalaryModifierTypeID = @SalaryModifierTypeID,
                    IsNoPay = @IsNoPay,
                    IsLateHours = @IsLateHours
                WHERE ID = @ID";

            using (var connection = _context.CreateConnection())
            {
                var affectedRows = await connection.ExecuteAsync(query, mapping);
                return affectedRows > 0;
            }
        }

        // Reports
        public async Task<IEnumerable<dynamic>> GetSalaryReport(int month, int year)
        {
            var query = @"
                SELECT 
                    rp.RelatedPartyName,
                    rp.RegistrationNumber,
                    d.DepartmentName,
                    des.DesignationName,
                    rs.Month,
                    rs.Year,
                    rs.WorkedDays,
                    rs.NoPayDays,
                    rs.LateMinutes,
                    rs.OTMinutes,
                    c.CompanyName
                FROM RelatedPartySalary rs
                INNER JOIN RelatedParty rp ON rs.RelatedPartyID = rp.ID
                LEFT JOIN Department d ON rp.DivisionMasterID = d.DepartmentId
                LEFT JOIN Designation des ON rp.DesignationID = des.DesignationId
                LEFT JOIN Company c ON rs.CompanyID = c.CompanyId
                WHERE rs.Month = @Month AND rs.Year = @Year
                ORDER BY c.CompanyName, d.DepartmentName, rp.RelatedPartyName";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<dynamic>(query, new { Month = month, Year = year });
            }
        }

        public async Task<decimal> GetTotalSalaryExpense(int month, int year, int companyId)
        {
            var query = @"
                SELECT SUM(rs.BasicSalary + rs.Allowances - rs.Deductions) as TotalExpense
                FROM RelatedPartySalary rs
                WHERE rs.Month = @Month AND rs.Year = @Year AND rs.CompanyID = @CompanyId";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.ExecuteScalarAsync<decimal?>(query, new
                {
                    Month = month,
                    Year = year,
                    CompanyId = companyId
                });
                return result ?? 0;
            }
        }
    }
}
