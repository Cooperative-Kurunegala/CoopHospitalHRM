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
    public class EmployeeTrainingsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: EmployeeTrainings
        public ActionResult Index()
        {
            return View(db.EmployeeTrainings.ToList());
        }

        // GET: EmployeeTrainings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTraining employeeTraining = db.EmployeeTrainings.Find(id);
            if (employeeTraining == null)
            {
                return HttpNotFound();
            }
            return View(employeeTraining);
        }

        // GET: EmployeeTrainings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTrainings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainingID,EmployeeID,TrainingName,TrainingProvider,StartDate,EndDate,Duration,Status,CertificatePath,Remarks")] EmployeeTraining employeeTraining)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeTrainings.Add(employeeTraining);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeTraining);
        }

        // GET: EmployeeTrainings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTraining employeeTraining = db.EmployeeTrainings.Find(id);
            if (employeeTraining == null)
            {
                return HttpNotFound();
            }
            return View(employeeTraining);
        }

        // POST: EmployeeTrainings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainingID,EmployeeID,TrainingName,TrainingProvider,StartDate,EndDate,Duration,Status,CertificatePath,Remarks")] EmployeeTraining employeeTraining)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeTraining).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeTraining);
        }

        // GET: EmployeeTrainings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTraining employeeTraining = db.EmployeeTrainings.Find(id);
            if (employeeTraining == null)
            {
                return HttpNotFound();
            }
            return View(employeeTraining);
        }

        // POST: EmployeeTrainings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeTraining employeeTraining = db.EmployeeTrainings.Find(id);
            db.EmployeeTrainings.Remove(employeeTraining);
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
