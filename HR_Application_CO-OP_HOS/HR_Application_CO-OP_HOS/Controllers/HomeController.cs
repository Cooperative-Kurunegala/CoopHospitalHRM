using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace HR_Application_CO_OP_HOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Default zeros
            ViewBag.TotalEmployees = 0;
            ViewBag.ActiveToday = 0;
            ViewBag.OnLeave = 0;
            ViewBag.PendingPayroll = 0;
            ViewBag.TotalDepartments = 0;

            try
            {
                var connString = ConfigurationManager.ConnectionStrings["HospitalHRDataEntities"]?.ConnectionString;
                if (string.IsNullOrWhiteSpace(connString))
                {
                    connString = ConfigurationManager.ConnectionStrings["HRMSContext"]?.ConnectionString;
                }

                if (string.IsNullOrWhiteSpace(connString))
                {
                    System.Diagnostics.Debug.WriteLine("No connection string found");
                    return View();
                }

                System.Diagnostics.Debug.WriteLine($"Using connection string: {connString}");

                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    System.Diagnostics.Debug.WriteLine("Database connection opened successfully");

                    // Test each query individually to find which one fails
                    try
                    {
                        // 1. Total Employees
                        using (var cmd = new SqlCommand("SELECT ISNULL(COUNT(1),0) FROM Employees WHERE IsActive = 1", conn))
                        {
                            ViewBag.TotalEmployees = (int)cmd.ExecuteScalar();
                            System.Diagnostics.Debug.WriteLine($"TotalEmployees: {ViewBag.TotalEmployees}");
                        }

                        // 2. Active Today
                        using (var cmd = new SqlCommand(
                            "SELECT ISNULL(COUNT(DISTINCT EmployeeID),0) FROM AttendanceRecords WHERE CONVERT(date, AttendanceDate) = CONVERT(date, GETDATE()) AND Status = 'Present'",
                            conn))
                        {
                            ViewBag.ActiveToday = (int)cmd.ExecuteScalar();
                            System.Diagnostics.Debug.WriteLine($"ActiveToday: {ViewBag.ActiveToday}");
                        }

                        // 3. On Leave
                        using (var cmd = new SqlCommand(
                            "SELECT ISNULL(COUNT(DISTINCT EmployeeID),0) FROM Leaves WHERE Status = 'Approved' AND CONVERT(date, GETDATE()) BETWEEN StartDate AND EndDate",
                            conn))
                        {
                            ViewBag.OnLeave = (int)cmd.ExecuteScalar();
                            System.Diagnostics.Debug.WriteLine($"OnLeave: {ViewBag.OnLeave}");
                        }

                        // 4. Pending Payroll
                        var currentPeriod = DateTime.Now.ToString("yyyy-MM");
                        using (var cmd = new SqlCommand(
                            @"SELECT ISNULL(COUNT(1),0) FROM Employees e WHERE e.IsActive = 1 AND NOT EXISTS (
                        SELECT 1 FROM PayrollRecords p WHERE p.EmployeeID = e.EmployeeID AND p.PayPeriod = @period)",
                            conn))
                        {
                            cmd.Parameters.AddWithValue("@period", currentPeriod);
                            ViewBag.PendingPayroll = (int)cmd.ExecuteScalar();
                            System.Diagnostics.Debug.WriteLine($"PendingPayroll: {ViewBag.PendingPayroll}");
                        }

                        // 5. Total Departments
                        using (var cmd = new SqlCommand("SELECT ISNULL(COUNT(1),0) FROM Departments WHERE IsActive = 1", conn))
                        {
                            ViewBag.TotalDepartments = (int)cmd.ExecuteScalar();
                            System.Diagnostics.Debug.WriteLine($"TotalDepartments: {ViewBag.TotalDepartments}");
                        }
                    }
                    catch (Exception innerEx)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error in individual query: {innerEx.Message}");
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading dashboard stats: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");

                // Reset to defaults on error
                ViewBag.TotalEmployees = 0;
                ViewBag.ActiveToday = 0;
                ViewBag.OnLeave = 0;
                ViewBag.PendingPayroll = 0;
                ViewBag.TotalDepartments = 0;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hospital HR Management System - About";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hospital HR Management System - Contact";
            return View();
        }
    }
}