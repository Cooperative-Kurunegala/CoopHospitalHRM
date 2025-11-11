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
    public class BillFinalization_LastController : Controller
    {
        private HREntities db = new HREntities();

        // GET: BillFinalization_Last
        public ActionResult Index()
        {
            return View(db.BillFinalization_Last.ToList());
        }

        // GET: BillFinalization_Last/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillFinalization_Last billFinalization_Last = db.BillFinalization_Last.Find(id);
            if (billFinalization_Last == null)
            {
                return HttpNotFound();
            }
            return View(billFinalization_Last);
        }

        // GET: BillFinalization_Last/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillFinalization_Last/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AppSettingDetailID,RelatedPartySessionID,ChargeName,Amount,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsPerHour,IsMinimumFor24Hours,PerDayValue,NoOfHours,IsPercentage,DivisionMasterTypeID,RelatedPartyOrderID,IsThisBillIncentive,SnapShotDateTime,ConsultantID")] BillFinalization_Last billFinalization_Last)
        {
            if (ModelState.IsValid)
            {
                db.BillFinalization_Last.Add(billFinalization_Last);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(billFinalization_Last);
        }

        // GET: BillFinalization_Last/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillFinalization_Last billFinalization_Last = db.BillFinalization_Last.Find(id);
            if (billFinalization_Last == null)
            {
                return HttpNotFound();
            }
            return View(billFinalization_Last);
        }

        // POST: BillFinalization_Last/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AppSettingDetailID,RelatedPartySessionID,ChargeName,Amount,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsPerHour,IsMinimumFor24Hours,PerDayValue,NoOfHours,IsPercentage,DivisionMasterTypeID,RelatedPartyOrderID,IsThisBillIncentive,SnapShotDateTime,ConsultantID")] BillFinalization_Last billFinalization_Last)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billFinalization_Last).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(billFinalization_Last);
        }

        // GET: BillFinalization_Last/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillFinalization_Last billFinalization_Last = db.BillFinalization_Last.Find(id);
            if (billFinalization_Last == null)
            {
                return HttpNotFound();
            }
            return View(billFinalization_Last);
        }

        // POST: BillFinalization_Last/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillFinalization_Last billFinalization_Last = db.BillFinalization_Last.Find(id);
            db.BillFinalization_Last.Remove(billFinalization_Last);
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
