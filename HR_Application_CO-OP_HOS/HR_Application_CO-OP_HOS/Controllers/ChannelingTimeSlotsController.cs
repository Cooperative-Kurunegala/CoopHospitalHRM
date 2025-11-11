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
    public class ChannelingTimeSlotsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChannelingTimeSlots
        public ActionResult Index()
        {
            return View(db.ChannelingTimeSlots.ToList());
        }

        // GET: ChannelingTimeSlots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChannelingTimeSlot channelingTimeSlot = db.ChannelingTimeSlots.Find(id);
            if (channelingTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(channelingTimeSlot);
        }

        // GET: ChannelingTimeSlots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChannelingTimeSlots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TimeSlot")] ChannelingTimeSlot channelingTimeSlot)
        {
            if (ModelState.IsValid)
            {
                db.ChannelingTimeSlots.Add(channelingTimeSlot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(channelingTimeSlot);
        }

        // GET: ChannelingTimeSlots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChannelingTimeSlot channelingTimeSlot = db.ChannelingTimeSlots.Find(id);
            if (channelingTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(channelingTimeSlot);
        }

        // POST: ChannelingTimeSlots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TimeSlot")] ChannelingTimeSlot channelingTimeSlot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(channelingTimeSlot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(channelingTimeSlot);
        }

        // GET: ChannelingTimeSlots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChannelingTimeSlot channelingTimeSlot = db.ChannelingTimeSlots.Find(id);
            if (channelingTimeSlot == null)
            {
                return HttpNotFound();
            }
            return View(channelingTimeSlot);
        }

        // POST: ChannelingTimeSlots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChannelingTimeSlot channelingTimeSlot = db.ChannelingTimeSlots.Find(id);
            db.ChannelingTimeSlots.Remove(channelingTimeSlot);
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
