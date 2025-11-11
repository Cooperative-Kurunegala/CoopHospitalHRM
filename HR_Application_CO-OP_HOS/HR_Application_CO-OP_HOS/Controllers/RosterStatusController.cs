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
    public class RosterStatusController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RosterStatus
        public ActionResult Index()
        {
            return View(db.RosterStatus.ToList());
        }

        // GET: RosterStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RosterStatu rosterStatu = db.RosterStatus.Find(id);
            if (rosterStatu == null)
            {
                return HttpNotFound();
            }
            return View(rosterStatu);
        }

        // GET: RosterStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RosterStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DayStatusDescription,OrderIndex,StartDate,EndDate,RosterRelated,RosterTypeID,NoOfMinutes,WithNextDay")] RosterStatu rosterStatu)
        {
            if (ModelState.IsValid)
            {
                db.RosterStatus.Add(rosterStatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rosterStatu);
        }

        // GET: RosterStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RosterStatu rosterStatu = db.RosterStatus.Find(id);
            if (rosterStatu == null)
            {
                return HttpNotFound();
            }
            return View(rosterStatu);
        }

        // POST: RosterStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DayStatusDescription,OrderIndex,StartDate,EndDate,RosterRelated,RosterTypeID,NoOfMinutes,WithNextDay")] RosterStatu rosterStatu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rosterStatu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rosterStatu);
        }

        // GET: RosterStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RosterStatu rosterStatu = db.RosterStatus.Find(id);
            if (rosterStatu == null)
            {
                return HttpNotFound();
            }
            return View(rosterStatu);
        }

        // POST: RosterStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RosterStatu rosterStatu = db.RosterStatus.Find(id);
            db.RosterStatus.Remove(rosterStatu);
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
