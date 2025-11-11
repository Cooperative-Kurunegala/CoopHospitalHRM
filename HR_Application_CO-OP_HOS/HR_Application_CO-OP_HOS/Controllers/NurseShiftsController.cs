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
    public class NurseShiftsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: NurseShifts
        public ActionResult Index()
        {
            return View(db.NurseShifts.ToList());
        }

        // GET: NurseShifts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NurseShift nurseShift = db.NurseShifts.Find(id);
            if (nurseShift == null)
            {
                return HttpNotFound();
            }
            return View(nurseShift);
        }

        // GET: NurseShifts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NurseShifts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AdmissionType,ReceivedNurse,NurseInChargeAdditional,AssitantNurse,NurseInCharge,Shift,CreatedDate,RelatedPartySessionID")] NurseShift nurseShift)
        {
            if (ModelState.IsValid)
            {
                db.NurseShifts.Add(nurseShift);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nurseShift);
        }

        // GET: NurseShifts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NurseShift nurseShift = db.NurseShifts.Find(id);
            if (nurseShift == null)
            {
                return HttpNotFound();
            }
            return View(nurseShift);
        }

        // POST: NurseShifts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AdmissionType,ReceivedNurse,NurseInChargeAdditional,AssitantNurse,NurseInCharge,Shift,CreatedDate,RelatedPartySessionID")] NurseShift nurseShift)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nurseShift).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nurseShift);
        }

        // GET: NurseShifts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NurseShift nurseShift = db.NurseShifts.Find(id);
            if (nurseShift == null)
            {
                return HttpNotFound();
            }
            return View(nurseShift);
        }

        // POST: NurseShifts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NurseShift nurseShift = db.NurseShifts.Find(id);
            db.NurseShifts.Remove(nurseShift);
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
