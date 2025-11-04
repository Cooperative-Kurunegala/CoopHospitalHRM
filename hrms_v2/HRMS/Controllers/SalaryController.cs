using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using HRMS.Models;
using HRMS.Services.Interfaces;

namespace HRMS.Controllers
{
    public class SalaryController : Controller
    {
        private readonly ISalaryService _salaryService;

        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }

        // GET: Salary
        public async Task<ActionResult> Index()
        {
            // You can modify this to load all salaries if needed
            return View();
        }

        // GET: Salary/Employee/5
        public async Task<ActionResult> Employee(int employeeId)
        {
            var result = await _salaryService.GetEmployeeSalaries(employeeId);
            if (!result.Success)
                return new HttpStatusCodeResult(400, result.Message);

            return View(result.Data);
        }

        // GET: Salary/Details/5
        public async Task<ActionResult> Details(int salaryId)
        {
            var result = await _salaryService.GetSalaryById(salaryId);
            if (!result.Success)
                return HttpNotFound(result.Message);

            return View(result.Data);
        }

        // GET: Salary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SalaryModel salary)
        {
            if (!ModelState.IsValid)
                return View(salary);

            var result = await _salaryService.CreateSalary(salary);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(salary);
            }

            return RedirectToAction("Index");
        }

        // GET: Salary/Edit/5
        public async Task<ActionResult> Edit(int salaryId)
        {
            var result = await _salaryService.GetSalaryById(salaryId);
            if (!result.Success)
                return HttpNotFound(result.Message);

            return View(result.Data);
        }

        // POST: Salary/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SalaryModel salary)
        {
            if (!ModelState.IsValid)
                return View(salary);

            var result = await _salaryService.UpdateSalary(salary);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(salary);
            }

            return RedirectToAction("Index");
        }

        // GET: Salary/Delete/5
        public async Task<ActionResult> Delete(int salaryId)
        {
            var result = await _salaryService.GetSalaryById(salaryId);
            if (!result.Success)
                return HttpNotFound(result.Message);

            return View(result.Data);
        }

        // POST: Salary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int salaryId)
        {
            var result = await _salaryService.DeleteSalary(salaryId);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return RedirectToAction("Delete", new { salaryId });
            }

            return RedirectToAction("Index");
        }

        // POST: Salary/ProcessPayroll
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ProcessPayroll(PayrollRequest request)
        {
            var result = await _salaryService.ProcessPayroll(request.Month, request.Year, request.CompanyId);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return RedirectToAction("Index");
            }

            TempData["SuccessMessage"] = "Payroll processed successfully.";
            return RedirectToAction("Index");
        }

        // GET: Salary/Payroll/Month/Year/CompanyId
        public async Task<ActionResult> Payroll(int month, int year, int companyId)
        {
            var result = await _salaryService.GetPayrollData(month, year, companyId);
            if (!result.Success)
                return new HttpStatusCodeResult(400, result.Message);

            return View(result.Data);
        }

        // POST: Salary/LockPayroll
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LockPayroll(PayrollRequest request)
        {
            var result = await _salaryService.LockPayroll(request.Month, request.Year, request.CompanyId);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return RedirectToAction("Index");
            }

            TempData["SuccessMessage"] = "Payroll locked successfully.";
            return RedirectToAction("Index");
        }

        // GET: Salary/Report/Month/Year
        public async Task<ActionResult> Report(int month, int year)
        {
            var result = await _salaryService.GetSalaryReport(month, year);
            if (!result.Success)
                return new HttpStatusCodeResult(400, result.Message);

            return View(result.Data);
        }

        // GET: Salary/Expense/Month/Year/CompanyId
        public async Task<ActionResult> Expense(int month, int year, int companyId)
        {
            var result = await _salaryService.GetTotalSalaryExpense(month, year, companyId);
            if (!result.Success)
                return new HttpStatusCodeResult(400, result.Message);

            ViewBag.TotalExpense = result.Data;
            return View();
        }
    }

    public class PayrollRequest
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int CompanyId { get; set; }
    }
}
