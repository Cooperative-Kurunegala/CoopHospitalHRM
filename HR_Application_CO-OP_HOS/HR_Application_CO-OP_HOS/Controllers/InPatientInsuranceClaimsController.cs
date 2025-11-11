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
    public class InPatientInsuranceClaimsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: InPatientInsuranceClaims
        public ActionResult Index()
        {
            return View(db.InPatientInsuranceClaims.ToList());
        }

        // GET: InPatientInsuranceClaims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InPatientInsuranceClaim inPatientInsuranceClaim = db.InPatientInsuranceClaims.Find(id);
            if (inPatientInsuranceClaim == null)
            {
                return HttpNotFound();
            }
            return View(inPatientInsuranceClaim);
        }

        // GET: InPatientInsuranceClaims/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InPatientInsuranceClaims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartySessionID,CustomerName,PatientName,CompanyName,BillAmount,ClaimAmount,ReceivedAmount,BillNo,ChequeNo,ChequeDate,Remarks,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsChequeReceived")] InPatientInsuranceClaim inPatientInsuranceClaim)
        {
            if (ModelState.IsValid)
            {
                db.InPatientInsuranceClaims.Add(inPatientInsuranceClaim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inPatientInsuranceClaim);
        }

        // GET: InPatientInsuranceClaims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InPatientInsuranceClaim inPatientInsuranceClaim = db.InPatientInsuranceClaims.Find(id);
            if (inPatientInsuranceClaim == null)
            {
                return HttpNotFound();
            }
            return View(inPatientInsuranceClaim);
        }

        // POST: InPatientInsuranceClaims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartySessionID,CustomerName,PatientName,CompanyName,BillAmount,ClaimAmount,ReceivedAmount,BillNo,ChequeNo,ChequeDate,Remarks,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsChequeReceived")] InPatientInsuranceClaim inPatientInsuranceClaim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inPatientInsuranceClaim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inPatientInsuranceClaim);
        }

        // GET: InPatientInsuranceClaims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InPatientInsuranceClaim inPatientInsuranceClaim = db.InPatientInsuranceClaims.Find(id);
            if (inPatientInsuranceClaim == null)
            {
                return HttpNotFound();
            }
            return View(inPatientInsuranceClaim);
        }

        // POST: InPatientInsuranceClaims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InPatientInsuranceClaim inPatientInsuranceClaim = db.InPatientInsuranceClaims.Find(id);
            db.InPatientInsuranceClaims.Remove(inPatientInsuranceClaim);
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
