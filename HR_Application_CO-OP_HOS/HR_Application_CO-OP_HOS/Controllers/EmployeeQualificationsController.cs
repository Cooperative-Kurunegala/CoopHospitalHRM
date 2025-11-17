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
    public class EmployeeQualificationsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: EmployeeQualifications
        public ActionResult Index()
        {
            return View(db.EmployeeQualifications.ToList());
        }

        // GET: EmployeeQualifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeQualification employeeQualification = db.EmployeeQualifications.Find(id);
            if (employeeQualification == null)
            {
                return HttpNotFound();
            }
            return View(employeeQualification);
        }

        // GET: EmployeeQualifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeQualifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QualificationID,EmployeeID,Qualification,Institution,Year,Grade,DocumentPath,IsVerified,VerifiedBy,VerifiedDate")] EmployeeQualification employeeQualification)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeQualifications.Add(employeeQualification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeQualification);
        }

        // GET: EmployeeQualifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeQualification employeeQualification = db.EmployeeQualifications.Find(id);
            if (employeeQualification == null)
            {
                return HttpNotFound();
            }
            return View(employeeQualification);
        }

        // POST: EmployeeQualifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QualificationID,EmployeeID,Qualification,Institution,Year,Grade,DocumentPath,IsVerified,VerifiedBy,VerifiedDate")] EmployeeQualification employeeQualification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeQualification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeQualification);
        }

        // GET: EmployeeQualifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeQualification employeeQualification = db.EmployeeQualifications.Find(id);
            if (employeeQualification == null)
            {
                return HttpNotFound();
            }
            return View(employeeQualification);
        }

        // POST: EmployeeQualifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeQualification employeeQualification = db.EmployeeQualifications.Find(id);
            db.EmployeeQualifications.Remove(employeeQualification);
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
