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
    public class RelatedPartyOrderPaymentsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyOrderPayments
        public ActionResult Index()
        {
            var relatedPartyOrderPayments = db.RelatedPartyOrderPayments.Include(r => r.CreditCardType).Include(r => r.PaymentType);
            return View(relatedPartyOrderPayments.ToList());
        }

        // GET: RelatedPartyOrderPayments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrderPayment relatedPartyOrderPayment = db.RelatedPartyOrderPayments.Find(id);
            if (relatedPartyOrderPayment == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrderPayment);
        }

        // GET: RelatedPartyOrderPayments/Create
        public ActionResult Create()
        {
            ViewBag.CreditCardTypeID = new SelectList(db.CreditCardTypes, "ID", "CreditCardTypeName");
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "ID", "PaymentTypeName");
            return View();
        }

        // POST: RelatedPartyOrderPayments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PaymentTypeID,PaymentAmount,OrderID,CreditCardNumber,MCashCode,PaymentDateTime,Balance,CreditCardTypeID,CreditCardExpiryDate,ChequeNumber,ChequeDate,IsAccountsRecommended,RecommendedComment,RecommendedUserID,AdmissionID")] RelatedPartyOrderPayment relatedPartyOrderPayment)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyOrderPayments.Add(relatedPartyOrderPayment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreditCardTypeID = new SelectList(db.CreditCardTypes, "ID", "CreditCardTypeName", relatedPartyOrderPayment.CreditCardTypeID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "ID", "PaymentTypeName", relatedPartyOrderPayment.PaymentTypeID);
            return View(relatedPartyOrderPayment);
        }

        // GET: RelatedPartyOrderPayments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrderPayment relatedPartyOrderPayment = db.RelatedPartyOrderPayments.Find(id);
            if (relatedPartyOrderPayment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreditCardTypeID = new SelectList(db.CreditCardTypes, "ID", "CreditCardTypeName", relatedPartyOrderPayment.CreditCardTypeID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "ID", "PaymentTypeName", relatedPartyOrderPayment.PaymentTypeID);
            return View(relatedPartyOrderPayment);
        }

        // POST: RelatedPartyOrderPayments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PaymentTypeID,PaymentAmount,OrderID,CreditCardNumber,MCashCode,PaymentDateTime,Balance,CreditCardTypeID,CreditCardExpiryDate,ChequeNumber,ChequeDate,IsAccountsRecommended,RecommendedComment,RecommendedUserID,AdmissionID")] RelatedPartyOrderPayment relatedPartyOrderPayment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyOrderPayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreditCardTypeID = new SelectList(db.CreditCardTypes, "ID", "CreditCardTypeName", relatedPartyOrderPayment.CreditCardTypeID);
            ViewBag.PaymentTypeID = new SelectList(db.PaymentTypes, "ID", "PaymentTypeName", relatedPartyOrderPayment.PaymentTypeID);
            return View(relatedPartyOrderPayment);
        }

        // GET: RelatedPartyOrderPayments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrderPayment relatedPartyOrderPayment = db.RelatedPartyOrderPayments.Find(id);
            if (relatedPartyOrderPayment == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrderPayment);
        }

        // POST: RelatedPartyOrderPayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyOrderPayment relatedPartyOrderPayment = db.RelatedPartyOrderPayments.Find(id);
            db.RelatedPartyOrderPayments.Remove(relatedPartyOrderPayment);
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
