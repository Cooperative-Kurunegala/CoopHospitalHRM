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
    public class AttendanceRecordsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: AttendanceRecords
        public ActionResult Index()
        {
            return View(db.AttendanceRecords.ToList());
        }

        // GET: AttendanceRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceRecord attendanceRecord = db.AttendanceRecords.Find(id);
            if (attendanceRecord == null)
            {
                return HttpNotFound();
            }
            return View(attendanceRecord);
        }

        // GET: AttendanceRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttendanceRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AttendanceID,EmployeeID,AttendanceDate,ShiftID,ScheduledIn,ScheduledOut,ActualIn,ActualOut,TotalHours,OvertimeHours,NightHours,LateMinutes,EarlyOutMinutes,Status,Remarks,IsRegularized,RegularizedBy,RegularizedDate,CreatedDate,CreatedBy")] AttendanceRecord attendanceRecord)
        {
            if (ModelState.IsValid)
            {
                db.AttendanceRecords.Add(attendanceRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendanceRecord);
        }

        // GET: AttendanceRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceRecord attendanceRecord = db.AttendanceRecords.Find(id);
            if (attendanceRecord == null)
            {
                return HttpNotFound();
            }
            return View(attendanceRecord);
        }

        // POST: AttendanceRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AttendanceID,EmployeeID,AttendanceDate,ShiftID,ScheduledIn,ScheduledOut,ActualIn,ActualOut,TotalHours,OvertimeHours,NightHours,LateMinutes,EarlyOutMinutes,Status,Remarks,IsRegularized,RegularizedBy,RegularizedDate,CreatedDate,CreatedBy")] AttendanceRecord attendanceRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendanceRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendanceRecord);
        }

        // GET: AttendanceRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceRecord attendanceRecord = db.AttendanceRecords.Find(id);
            if (attendanceRecord == null)
            {
                return HttpNotFound();
            }
            return View(attendanceRecord);
        }

        // POST: AttendanceRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendanceRecord attendanceRecord = db.AttendanceRecords.Find(id);
            db.AttendanceRecords.Remove(attendanceRecord);
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
