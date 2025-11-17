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
    public class EmployeeAllowancesController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: EmployeeAllowances
        public ActionResult Index()
        {
            return View(db.EmployeeAllowances.ToList());
        }

        // GET: EmployeeAllowances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeAllowance employeeAllowance = db.EmployeeAllowances.Find(id);
            if (employeeAllowance == null)
            {
                return HttpNotFound();
            }
            return View(employeeAllowance);
        }

        // GET: EmployeeAllowances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeAllowances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeAllowanceID,EmployeeID,AllowanceID,Amount,EffectiveDate,EndDate,IsActive")] EmployeeAllowance employeeAllowance)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeAllowances.Add(employeeAllowance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeAllowance);
        }

        // GET: EmployeeAllowances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeAllowance employeeAllowance = db.EmployeeAllowances.Find(id);
            if (employeeAllowance == null)
            {
                return HttpNotFound();
            }
            return View(employeeAllowance);
        }

        // POST: EmployeeAllowances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeAllowanceID,EmployeeID,AllowanceID,Amount,EffectiveDate,EndDate,IsActive")] EmployeeAllowance employeeAllowance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeAllowance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeAllowance);
        }

        // GET: EmployeeAllowances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeAllowance employeeAllowance = db.EmployeeAllowances.Find(id);
            if (employeeAllowance == null)
            {
                return HttpNotFound();
            }
            return View(employeeAllowance);
        }

        // POST: EmployeeAllowances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeAllowance employeeAllowance = db.EmployeeAllowances.Find(id);
            db.EmployeeAllowances.Remove(employeeAllowance);
            db.SaveChanges();
            return RedirectToAction("Index");
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
