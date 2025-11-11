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
    public class DoctorWiseTimeSlotsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: DoctorWiseTimeSlots
        public ActionResult Index()
        {
            return View(db.DoctorWiseTimeSlots.ToList());
        }

        // GET: DoctorWiseTimeSlots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorWiseTimeSlot doctorWiseTimeSlot = db.DoctorWiseTimeSlots.Find(id);
            if (doctorWiseTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(doctorWiseTimeSlot);
        }

        // GET: DoctorWiseTimeSlots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorWiseTimeSlots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,TimeSlotID,Times")] DoctorWiseTimeSlot doctorWiseTimeSlot)
        {
            if (ModelState.IsValid)
            {
                db.DoctorWiseTimeSlots.Add(doctorWiseTimeSlot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctorWiseTimeSlot);
        }

        // GET: DoctorWiseTimeSlots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorWiseTimeSlot doctorWiseTimeSlot = db.DoctorWiseTimeSlots.Find(id);
            if (doctorWiseTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(doctorWiseTimeSlot);
        }

        // POST: DoctorWiseTimeSlots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,TimeSlotID,Times")] DoctorWiseTimeSlot doctorWiseTimeSlot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorWiseTimeSlot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorWiseTimeSlot);
        }

        // GET: DoctorWiseTimeSlots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorWiseTimeSlot doctorWiseTimeSlot = db.DoctorWiseTimeSlots.Find(id);
            if (doctorWiseTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(doctorWiseTimeSlot);
        }

        // POST: DoctorWiseTimeSlots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorWiseTimeSlot doctorWiseTimeSlot = db.DoctorWiseTimeSlots.Find(id);
            db.DoctorWiseTimeSlots.Remove(doctorWiseTimeSlot);
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
