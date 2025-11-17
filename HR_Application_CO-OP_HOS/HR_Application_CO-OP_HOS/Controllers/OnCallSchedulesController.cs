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
    public class OnCallSchedulesController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: OnCallSchedules
        public ActionResult Index()
        {
            return View(db.OnCallSchedules.ToList());
        }

        // GET: OnCallSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OnCallSchedule onCallSchedule = db.OnCallSchedules.Find(id);
            if (onCallSchedule == null)
            {
                return HttpNotFound();
            }
            return View(onCallSchedule);
        }

        // GET: OnCallSchedules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OnCallSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OnCallID,EmployeeID,OnCallDate,StartTime,EndTime,IsActive,Remarks,CreatedDate")] OnCallSchedule onCallSchedule)
        {
            if (ModelState.IsValid)
            {
                db.OnCallSchedules.Add(onCallSchedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(onCallSchedule);
        }

        // GET: OnCallSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OnCallSchedule onCallSchedule = db.OnCallSchedules.Find(id);
            if (onCallSchedule == null)
            {
                return HttpNotFound();
            }
            return View(onCallSchedule);
        }

        // POST: OnCallSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OnCallID,EmployeeID,OnCallDate,StartTime,EndTime,IsActive,Remarks,CreatedDate")] OnCallSchedule onCallSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(onCallSchedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(onCallSchedule);
        }

        // GET: OnCallSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OnCallSchedule onCallSchedule = db.OnCallSchedules.Find(id);
            if (onCallSchedule == null)
            {
                return HttpNotFound();
            }
            return View(onCallSchedule);
        }

        // POST: OnCallSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OnCallSchedule onCallSchedule = db.OnCallSchedules.Find(id);
            db.OnCallSchedules.Remove(onCallSchedule);
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
