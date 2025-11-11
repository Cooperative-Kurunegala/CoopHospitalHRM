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
    public class RelatedPartyLeaveAllocationsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyLeaveAllocations
        public ActionResult Index()
        {
            return View(db.RelatedPartyLeaveAllocations.ToList());
        }

        // GET: RelatedPartyLeaveAllocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLeaveAllocation relatedPartyLeaveAllocation = db.RelatedPartyLeaveAllocations.Find(id);
            if (relatedPartyLeaveAllocation == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLeaveAllocation);
        }

        // GET: RelatedPartyLeaveAllocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyLeaveAllocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,HRYear,LeaveCategoryID,StartingValue,StartingValueDate")] RelatedPartyLeaveAllocation relatedPartyLeaveAllocation)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyLeaveAllocations.Add(relatedPartyLeaveAllocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyLeaveAllocation);
        }

        // GET: RelatedPartyLeaveAllocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLeaveAllocation relatedPartyLeaveAllocation = db.RelatedPartyLeaveAllocations.Find(id);
            if (relatedPartyLeaveAllocation == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLeaveAllocation);
        }

        // POST: RelatedPartyLeaveAllocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,HRYear,LeaveCategoryID,StartingValue,StartingValueDate")] RelatedPartyLeaveAllocation relatedPartyLeaveAllocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyLeaveAllocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyLeaveAllocation);
        }

        // GET: RelatedPartyLeaveAllocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLeaveAllocation relatedPartyLeaveAllocation = db.RelatedPartyLeaveAllocations.Find(id);
            if (relatedPartyLeaveAllocation == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLeaveAllocation);
        }

        // POST: RelatedPartyLeaveAllocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyLeaveAllocation relatedPartyLeaveAllocation = db.RelatedPartyLeaveAllocations.Find(id);
            db.RelatedPartyLeaveAllocations.Remove(relatedPartyLeaveAllocation);
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
