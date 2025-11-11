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
    public class ChannelingSquencesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChannelingSquences
        public ActionResult Index()
        {
            return View(db.ChannelingSquences.ToList());
        }

        // GET: ChannelingSquences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChannelingSquence channelingSquence = db.ChannelingSquences.Find(id);
            if (channelingSquence == null)
            {
                return HttpNotFound();
            }
            return View(channelingSquence);
        }

        // GET: ChannelingSquences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChannelingSquences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LocationID,DoctorID,ChannelDate,TimeSlotID,Sequence,SquenceStatus,Times,PatientLimits,DivisionMasterID,TimeInterval")] ChannelingSquence channelingSquence)
        {
            if (ModelState.IsValid)
            {
                db.ChannelingSquences.Add(channelingSquence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(channelingSquence);
        }

        // GET: ChannelingSquences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChannelingSquence channelingSquence = db.ChannelingSquences.Find(id);
            if (channelingSquence == null)
            {
                return HttpNotFound();
            }
            return View(channelingSquence);
        }

        // POST: ChannelingSquences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LocationID,DoctorID,ChannelDate,TimeSlotID,Sequence,SquenceStatus,Times,PatientLimits,DivisionMasterID,TimeInterval")] ChannelingSquence channelingSquence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(channelingSquence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(channelingSquence);
        }

        // GET: ChannelingSquences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChannelingSquence channelingSquence = db.ChannelingSquences.Find(id);
            if (channelingSquence == null)
            {
                return HttpNotFound();
            }
            return View(channelingSquence);
        }

        // POST: ChannelingSquences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChannelingSquence channelingSquence = db.ChannelingSquences.Find(id);
            db.ChannelingSquences.Remove(channelingSquence);
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
