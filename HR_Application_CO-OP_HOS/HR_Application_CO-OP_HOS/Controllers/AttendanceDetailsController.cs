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
    public class AttendanceDetailsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: AttendanceDetails
        public ActionResult Index()
        {
            return View(db.AttendanceDetails.ToList());
        }

        // GET: AttendanceDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceDetail attendanceDetail = db.AttendanceDetails.Find(id);
            if (attendanceDetail == null)
            {
                return HttpNotFound();
            }
            return View(attendanceDetail);
        }

        // GET: AttendanceDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttendanceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,WorkedMonth,WorkedYear,IsOTRecommended")] AttendanceDetail attendanceDetail)
        {
            if (ModelState.IsValid)
            {
                db.AttendanceDetails.Add(attendanceDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendanceDetail);
        }

        // GET: AttendanceDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceDetail attendanceDetail = db.AttendanceDetails.Find(id);
            if (attendanceDetail == null)
            {
                return HttpNotFound();
            }
            return View(attendanceDetail);
        }

        // POST: AttendanceDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,WorkedMonth,WorkedYear,IsOTRecommended")] AttendanceDetail attendanceDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendanceDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendanceDetail);
        }

        // GET: AttendanceDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceDetail attendanceDetail = db.AttendanceDetails.Find(id);
            if (attendanceDetail == null)
            {
                return HttpNotFound();
            }
            return View(attendanceDetail);
        }

        // POST: AttendanceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendanceDetail attendanceDetail = db.AttendanceDetails.Find(id);
            db.AttendanceDetails.Remove(attendanceDetail);
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
