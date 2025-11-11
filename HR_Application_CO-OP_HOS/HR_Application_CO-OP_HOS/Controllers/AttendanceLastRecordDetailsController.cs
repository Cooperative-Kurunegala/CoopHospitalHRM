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
    public class AttendanceLastRecordDetailsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: AttendanceLastRecordDetails
        public ActionResult Index()
        {
            return View(db.AttendanceLastRecordDetails.ToList());
        }

        // GET: AttendanceLastRecordDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceLastRecordDetail attendanceLastRecordDetail = db.AttendanceLastRecordDetails.Find(id);
            if (attendanceLastRecordDetail == null)
            {
                return HttpNotFound();
            }
            return View(attendanceLastRecordDetail);
        }

        // GET: AttendanceLastRecordDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttendanceLastRecordDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AttendanceLastRecord,ID")] AttendanceLastRecordDetail attendanceLastRecordDetail)
        {
            if (ModelState.IsValid)
            {
                db.AttendanceLastRecordDetails.Add(attendanceLastRecordDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendanceLastRecordDetail);
        }

        // GET: AttendanceLastRecordDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceLastRecordDetail attendanceLastRecordDetail = db.AttendanceLastRecordDetails.Find(id);
            if (attendanceLastRecordDetail == null)
            {
                return HttpNotFound();
            }
            return View(attendanceLastRecordDetail);
        }

        // POST: AttendanceLastRecordDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AttendanceLastRecord,ID")] AttendanceLastRecordDetail attendanceLastRecordDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendanceLastRecordDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendanceLastRecordDetail);
        }

        // GET: AttendanceLastRecordDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceLastRecordDetail attendanceLastRecordDetail = db.AttendanceLastRecordDetails.Find(id);
            if (attendanceLastRecordDetail == null)
            {
                return HttpNotFound();
            }
            return View(attendanceLastRecordDetail);
        }

        // POST: AttendanceLastRecordDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendanceLastRecordDetail attendanceLastRecordDetail = db.AttendanceLastRecordDetails.Find(id);
            db.AttendanceLastRecordDetails.Remove(attendanceLastRecordDetail);
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
