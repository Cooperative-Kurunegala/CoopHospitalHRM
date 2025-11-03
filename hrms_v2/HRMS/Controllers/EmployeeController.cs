using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using HRMS.Models;
using HRMS.Services.Interfaces;

namespace HRMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var result = await _employeeService.GetAllEmployees();
            if (!result.Success)
                return new HttpStatusCodeResult(400, result.Message);

            return View(result.Data);
        }

        // GET: Employee/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var result = await _employeeService.GetEmployeeById(id);
            if (!result.Success)
                return HttpNotFound(result.Message);

            return View(result.Data);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
                return View(employee);

            var result = await _employeeService.CreateEmployee(employee);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(employee);
            }

            return RedirectToAction("Index");
        }

        // GET: Employee/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var result = await _employeeService.GetEmployeeById(id);
            if (!result.Success)
                return HttpNotFound(result.Message);

            return View(result.Data);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
                return View(employee);

            var result = await _employeeService.UpdateEmployee(employee);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(employee);
            }

            return RedirectToAction("Index");
        }

        // GET: Employee/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _employeeService.GetEmployeeById(id);
            if (!result.Success)
                return HttpNotFound(result.Message);

            return View(result.Data);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return RedirectToAction("Delete", new { id });
            }

            return RedirectToAction("Index");
        }

        // GET: Employee/Department/5
        public async Task<ActionResult> Department(int departmentId)
        {
            var result = await _employeeService.GetEmployeesByDepartment(departmentId);
            if (!result.Success)
                return new HttpStatusCodeResult(400, result.Message);

            return View("Index", result.Data);
        }
    }
}
