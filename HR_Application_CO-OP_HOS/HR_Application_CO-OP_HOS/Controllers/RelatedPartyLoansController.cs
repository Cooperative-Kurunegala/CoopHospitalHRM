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
    public class RelatedPartyLoansController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyLoans
        public ActionResult Index()
        {
            return View(db.RelatedPartyLoans.ToList());
        }

        // GET: RelatedPartyLoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLoan relatedPartyLoan = db.RelatedPartyLoans.Find(id);
            if (relatedPartyLoan == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLoan);
        }

        // GET: RelatedPartyLoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyLoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,LoanTotalAmount,MonthlyAmount,NoOfInstallments,LoanStartDate,LoanCategoryID,IsActive,LoanEndDate")] RelatedPartyLoan relatedPartyLoan)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyLoans.Add(relatedPartyLoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyLoan);
        }

        // GET: RelatedPartyLoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLoan relatedPartyLoan = db.RelatedPartyLoans.Find(id);
            if (relatedPartyLoan == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLoan);
        }

        // POST: RelatedPartyLoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,LoanTotalAmount,MonthlyAmount,NoOfInstallments,LoanStartDate,LoanCategoryID,IsActive,LoanEndDate")] RelatedPartyLoan relatedPartyLoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyLoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyLoan);
        }

        // GET: RelatedPartyLoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLoan relatedPartyLoan = db.RelatedPartyLoans.Find(id);
            if (relatedPartyLoan == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLoan);
        }

        // POST: RelatedPartyLoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyLoan relatedPartyLoan = db.RelatedPartyLoans.Find(id);
            db.RelatedPartyLoans.Remove(relatedPartyLoan);
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
