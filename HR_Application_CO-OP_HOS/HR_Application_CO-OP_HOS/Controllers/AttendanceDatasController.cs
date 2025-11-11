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
    public class AttendanceDatasController : Controller
    {
        private HREntities db = new HREntities();

        // GET: AttendanceDatas
        public ActionResult Index()
        {
            return View(db.AttendanceDatas.ToList());
        }

        // GET: AttendanceDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceData attendanceData = db.AttendanceDatas.Find(id);
            if (attendanceData == null)
            {
                return HttpNotFound();
            }
            return View(attendanceData);
        }

        // GET: AttendanceDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttendanceDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EPF,Date,InTime,OutTime")] AttendanceData attendanceData)
        {
            if (ModelState.IsValid)
            {
                db.AttendanceDatas.Add(attendanceData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendanceData);
        }

        // GET: AttendanceDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceData attendanceData = db.AttendanceDatas.Find(id);
            if (attendanceData == null)
            {
                return HttpNotFound();
            }
            return View(attendanceData);
        }

        // POST: AttendanceDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EPF,Date,InTime,OutTime")] AttendanceData attendanceData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendanceData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendanceData);
        }

        // GET: AttendanceDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceData attendanceData = db.AttendanceDatas.Find(id);
            if (attendanceData == null)
            {
                return HttpNotFound();
            }
            return View(attendanceData);
        }

        // POST: AttendanceDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendanceData attendanceData = db.AttendanceDatas.Find(id);
            db.AttendanceDatas.Remove(attendanceData);
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
