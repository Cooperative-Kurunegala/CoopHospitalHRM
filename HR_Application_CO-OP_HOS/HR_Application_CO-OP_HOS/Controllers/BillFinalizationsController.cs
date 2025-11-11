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
    public class BillFinalizationsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: BillFinalizations
        public ActionResult Index()
        {
            return View(db.BillFinalizations.ToList());
        }

        // GET: BillFinalizations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillFinalization billFinalization = db.BillFinalizations.Find(id);
            if (billFinalization == null)
            {
                return HttpNotFound();
            }
            return View(billFinalization);
        }

        // GET: BillFinalizations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillFinalizations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AppSettingDetailID,RelatedPartySessionID,ChargeName,Amount,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsPerHour,IsMinimumFor24Hours,PerDayValue,NoOfHours,IsPercentage,DivisionMasterTypeID,RelatedPartyOrderID,IsThisBillIncentive,SnapShotDateTime,ConsultantID")] BillFinalization billFinalization)
        {
            if (ModelState.IsValid)
            {
                db.BillFinalizations.Add(billFinalization);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(billFinalization);
        }

        // GET: BillFinalizations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillFinalization billFinalization = db.BillFinalizations.Find(id);
            if (billFinalization == null)
            {
                return HttpNotFound();
            }
            return View(billFinalization);
        }

        // POST: BillFinalizations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AppSettingDetailID,RelatedPartySessionID,ChargeName,Amount,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsPerHour,IsMinimumFor24Hours,PerDayValue,NoOfHours,IsPercentage,DivisionMasterTypeID,RelatedPartyOrderID,IsThisBillIncentive,SnapShotDateTime,ConsultantID")] BillFinalization billFinalization)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billFinalization).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(billFinalization);
        }

        // GET: BillFinalizations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillFinalization billFinalization = db.BillFinalizations.Find(id);
            if (billFinalization == null)
            {
                return HttpNotFound();
            }
            return View(billFinalization);
        }

        // POST: BillFinalizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillFinalization billFinalization = db.BillFinalizations.Find(id);
            db.BillFinalizations.Remove(billFinalization);
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
