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
    public class OPDTimeSlotsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: OPDTimeSlots
        public ActionResult Index()
        {
            return View(db.OPDTimeSlots.ToList());
        }

        // GET: OPDTimeSlots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OPDTimeSlot oPDTimeSlot = db.OPDTimeSlots.Find(id);
            if (oPDTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(oPDTimeSlot);
        }

        // GET: OPDTimeSlots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OPDTimeSlots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TimeSlot")] OPDTimeSlot oPDTimeSlot)
        {
            if (ModelState.IsValid)
            {
                db.OPDTimeSlots.Add(oPDTimeSlot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oPDTimeSlot);
        }

        // GET: OPDTimeSlots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OPDTimeSlot oPDTimeSlot = db.OPDTimeSlots.Find(id);
            if (oPDTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(oPDTimeSlot);
        }

        // POST: OPDTimeSlots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TimeSlot")] OPDTimeSlot oPDTimeSlot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oPDTimeSlot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oPDTimeSlot);
        }

        // GET: OPDTimeSlots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OPDTimeSlot oPDTimeSlot = db.OPDTimeSlots.Find(id);
            if (oPDTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(oPDTimeSlot);
        }

        // POST: OPDTimeSlots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OPDTimeSlot oPDTimeSlot = db.OPDTimeSlots.Find(id);
            db.OPDTimeSlots.Remove(oPDTimeSlot);
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
