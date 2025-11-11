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
    public class LeaveStatusController : Controller
    {
        private HREntities db = new HREntities();

        // GET: LeaveStatus
        public ActionResult Index()
        {
            return View(db.LeaveStatus.ToList());
        }

        // GET: LeaveStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveStatu leaveStatu = db.LeaveStatus.Find(id);
            if (leaveStatu == null)
            {
                return HttpNotFound();
            }
            return View(leaveStatu);
        }

        // GET: LeaveStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DayStatusDescription,OrderIndex,StartDate,EndDate,LeaveCount")] LeaveStatu leaveStatu)
        {
            if (ModelState.IsValid)
            {
                db.LeaveStatus.Add(leaveStatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leaveStatu);
        }

        // GET: LeaveStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveStatu leaveStatu = db.LeaveStatus.Find(id);
            if (leaveStatu == null)
            {
                return HttpNotFound();
            }
            return View(leaveStatu);
        }

        // POST: LeaveStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DayStatusDescription,OrderIndex,StartDate,EndDate,LeaveCount")] LeaveStatu leaveStatu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leaveStatu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leaveStatu);
        }

        // GET: LeaveStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveStatu leaveStatu = db.LeaveStatus.Find(id);
            if (leaveStatu == null)
            {
                return HttpNotFound();
            }
            return View(leaveStatu);
        }

        // POST: LeaveStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeaveStatu leaveStatu = db.LeaveStatus.Find(id);
            db.LeaveStatus.Remove(leaveStatu);
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
