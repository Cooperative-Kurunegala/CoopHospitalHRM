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
    public class EmployeeShiftsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();


        // GET: EmployeeShifts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeShift employeeShift = db.EmployeeShifts.Find(id);
            if (employeeShift == null)
            {
                return HttpNotFound();
            }
            return View(employeeShift);
        }

        // POST: EmployeeShifts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,ShiftDate,ShiftID,StartTime,EndTime,IsActive")] EmployeeShift employeeShift)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeShifts.Add(employeeShift);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeShift);
        }


        // GET: EmployeeShifts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeShift employeeShift = db.EmployeeShifts.Find(id);
            if (employeeShift == null)
            {
                return HttpNotFound();
            }
            return View(employeeShift);
        }

        // POST: EmployeeShifts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeShift employeeShift = db.EmployeeShifts.Find(id);
            db.EmployeeShifts.Remove(employeeShift);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // In your EmployeeShiftController
        public ActionResult Create()
        {
            // Populate dropdown data
            ViewBag.Employees = db.Employees.Where(e => e.IsActive).ToList();
            ViewBag.Shifts = db.Shifts.Where(s => s.IsActive).ToList();
            ViewBag.RelatedParties = db.Employees.Where(e => e.IsActive).ToList();

            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            EmployeeShift employeeShift = db.EmployeeShifts.Find(id);
            if (employeeShift == null)
            {
                return HttpNotFound();
            }

            // Populate dropdown data
            ViewBag.Employees = db.Employees.Where(e => e.IsActive).ToList();
            ViewBag.Shifts = db.Shifts.Where(s => s.IsActive).ToList();
            ViewBag.RelatedParties = db.Employees.Where(e => e.IsActive).ToList();

            return View(employeeShift);
        }

        public ActionResult Index()
        {
            // Quick fix: no navigation properties exist, so do not call Include.
            var employeeShifts = db.EmployeeShifts.ToList();

            // Create lookup dictionaries for display
            ViewBag.EmployeeLookup = db.Employees.ToDictionary(e => e.EmployeeID, e => e.FullName);
            ViewBag.ShiftLookup = db.Shifts.ToDictionary(s => s.ShiftID, s => s.ShiftName);

            return View(employeeShifts);
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