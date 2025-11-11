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
    public class RelatedPartyFixedRostersController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyFixedRosters
        public ActionResult Index()
        {
            return View(db.RelatedPartyFixedRosters.ToList());
        }

        // GET: RelatedPartyFixedRosters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyFixedRoster relatedPartyFixedRoster = db.RelatedPartyFixedRosters.Find(id);
            if (relatedPartyFixedRoster == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyFixedRoster);
        }

        // GET: RelatedPartyFixedRosters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyFixedRosters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RosterID,RelatedPartyID,WeekDay")] RelatedPartyFixedRoster relatedPartyFixedRoster)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyFixedRosters.Add(relatedPartyFixedRoster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyFixedRoster);
        }

        // GET: RelatedPartyFixedRosters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyFixedRoster relatedPartyFixedRoster = db.RelatedPartyFixedRosters.Find(id);
            if (relatedPartyFixedRoster == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyFixedRoster);
        }

        // POST: RelatedPartyFixedRosters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RosterID,RelatedPartyID,WeekDay")] RelatedPartyFixedRoster relatedPartyFixedRoster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyFixedRoster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyFixedRoster);
        }

        // GET: RelatedPartyFixedRosters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyFixedRoster relatedPartyFixedRoster = db.RelatedPartyFixedRosters.Find(id);
            if (relatedPartyFixedRoster == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyFixedRoster);
        }

        // POST: RelatedPartyFixedRosters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyFixedRoster relatedPartyFixedRoster = db.RelatedPartyFixedRosters.Find(id);
            db.RelatedPartyFixedRosters.Remove(relatedPartyFixedRoster);
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
