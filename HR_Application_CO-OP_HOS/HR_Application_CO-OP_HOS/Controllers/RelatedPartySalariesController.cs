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
    public class RelatedPartySalariesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartySalaries
        public ActionResult Index()
        {
            var relatedPartySalaries = db.RelatedPartySalaries.Include(r => r.RelatedParty);
            return View(relatedPartySalaries.ToList());
        }

        // GET: RelatedPartySalaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySalary relatedPartySalary = db.RelatedPartySalaries.Find(id);
            if (relatedPartySalary == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySalary);
        }

        // GET: RelatedPartySalaries/Create
        public ActionResult Create()
        {
            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber");
            return View();
        }

        // POST: RelatedPartySalaries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyEPF,Month,Year,CompanyID,NoPayDays,LateMinutes,OTMinutes,RelatedPartyID,IsPayoutGenerated,IsLocked,SalaryTypeID,CreatedDate,CreatedBy,DoubleOTMinutes,PayeeTaxRate,WorkedDays,ActualNoPayDays,ActualLateHours,ActualOTHours,ActualDBLOTHours,IsVerified,IsAttendanceVerified,TotalShifts,TotalInLate,TotalOutLate,FinalLateCount,TotalAdditionalShifts")] RelatedPartySalary relatedPartySalary)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartySalaries.Add(relatedPartySalary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", relatedPartySalary.RelatedPartyID);
            return View(relatedPartySalary);
        }

        // GET: RelatedPartySalaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySalary relatedPartySalary = db.RelatedPartySalaries.Find(id);
            if (relatedPartySalary == null)
            {
                return HttpNotFound();
            }
            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", relatedPartySalary.RelatedPartyID);
            return View(relatedPartySalary);
        }

        // POST: RelatedPartySalaries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyEPF,Month,Year,CompanyID,NoPayDays,LateMinutes,OTMinutes,RelatedPartyID,IsPayoutGenerated,IsLocked,SalaryTypeID,CreatedDate,CreatedBy,DoubleOTMinutes,PayeeTaxRate,WorkedDays,ActualNoPayDays,ActualLateHours,ActualOTHours,ActualDBLOTHours,IsVerified,IsAttendanceVerified,TotalShifts,TotalInLate,TotalOutLate,FinalLateCount,TotalAdditionalShifts")] RelatedPartySalary relatedPartySalary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartySalary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", relatedPartySalary.RelatedPartyID);
            return View(relatedPartySalary);
        }

        // GET: RelatedPartySalaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySalary relatedPartySalary = db.RelatedPartySalaries.Find(id);
            if (relatedPartySalary == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySalary);
        }

        // POST: RelatedPartySalaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartySalary relatedPartySalary = db.RelatedPartySalaries.Find(id);
            db.RelatedPartySalaries.Remove(relatedPartySalary);
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
