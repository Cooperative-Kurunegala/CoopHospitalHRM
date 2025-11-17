using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HR_Application_CO_OP_HOS.Models;

namespace HR_Application_CO_OP_HOS.Controllers
{
    public class EmployeesController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: Employees
        public ActionResult Index()
        {
            try
            {
                var employees = db.Employees.ToList();
                return View(employees);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading employees: {ex.Message}";
                return View(new List<Employee>());
            }
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                TempData["ErrorMessage"] = "Employee ID is required";
                return RedirectToAction("Index");
            }

            try
            {
                Employee employee = db.Employees.Find(id);
                if (employee == null)
                {
                    TempData["ErrorMessage"] = "Employee not found";
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading employee details: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            try
            {
                // Initialize default values for new employee
                var employee = new Employee
                {
                    DateOfJoin = DateTime.Today,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };
                return View(employee);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading create form: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Set additional properties
                    employee.CreatedDate = DateTime.Now;
                    employee.ModifiedDate = DateTime.Now;

                    // Validate required fields
                    if (string.IsNullOrEmpty(employee.EmployeeNumber))
                    {
                        ModelState.AddModelError("EmployeeNumber", "Employee Number is required");
                        return View(employee);
                    }

                    // Check for duplicate employee number
                    if (db.Employees.Any(e => e.EmployeeNumber == employee.EmployeeNumber))
                    {
                        ModelState.AddModelError("EmployeeNumber", "Employee Number already exists");
                        return View(employee);
                    }

                    db.Employees.Add(employee);
                    db.SaveChanges();

                    TempData["SuccessMessage"] = "Employee created successfully!";
                    return RedirectToAction("Index");
                }

                // If we got this far, something failed; redisplay form
                TempData["ErrorMessage"] = "Please correct the errors below";
                return View(employee);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error creating employee: {ex.Message}";
                return View(employee);
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                TempData["ErrorMessage"] = "Employee ID is required";
                return RedirectToAction("Index");
            }

            try
            {
                Employee employee = db.Employees.Find(id);
                if (employee == null)
                {
                    TempData["ErrorMessage"] = "Employee not found";
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading employee for editing: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Set modification details
                    employee.ModifiedDate = DateTime.Now;

                    // Validate required fields
                    if (string.IsNullOrEmpty(employee.EmployeeNumber))
                    {
                        ModelState.AddModelError("EmployeeNumber", "Employee Number is required");
                        return View(employee);
                    }

                    // Check for duplicate employee number (excluding current employee)
                    if (db.Employees.Any(e => e.EmployeeNumber == employee.EmployeeNumber && e.EmployeeID != employee.EmployeeID))
                    {
                        ModelState.AddModelError("EmployeeNumber", "Employee Number already exists");
                        return View(employee);
                    }

                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["SuccessMessage"] = "Employee updated successfully!";
                    return RedirectToAction("Index");
                }

                TempData["ErrorMessage"] = "Please correct the errors below";
                return View(employee);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error updating employee: {ex.Message}";
                return View(employee);
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                TempData["ErrorMessage"] = "Employee ID is required";
                return RedirectToAction("Index");
            }

            try
            {
                Employee employee = db.Employees.Find(id);
                if (employee == null)
                {
                    TempData["ErrorMessage"] = "Employee not found";
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading employee for deletion: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Employee employee = db.Employees.Find(id);
                if (employee == null)
                {
                    TempData["ErrorMessage"] = "Employee not found";
                    return RedirectToAction("Index");
                }

                db.Employees.Remove(employee);
                db.SaveChanges();

                TempData["SuccessMessage"] = "Employee deleted successfully!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error deleting employee: {ex.Message}";
                return RedirectToAction("Delete", new { id = id });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}