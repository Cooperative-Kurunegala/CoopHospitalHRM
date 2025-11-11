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
    public class RelatedPartyLoan1Controller : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyLoan1
        public ActionResult Index()
        {
            return View(db.RelatedPartyLoans1.ToList());
        }

        // GET: RelatedPartyLoan1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLoan1 relatedPartyLoan1 = db.RelatedPartyLoans1.Find(id);
            if (relatedPartyLoan1 == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLoan1);
        }

        // GET: RelatedPartyLoan1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyLoan1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LoanAmount,Premium,LoanStartDate,LoanEndDate,InterestPercentage")] RelatedPartyLoan1 relatedPartyLoan1)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyLoans1.Add(relatedPartyLoan1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyLoan1);
        }

        // GET: RelatedPartyLoan1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLoan1 relatedPartyLoan1 = db.RelatedPartyLoans1.Find(id);
            if (relatedPartyLoan1 == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLoan1);
        }

        // POST: RelatedPartyLoan1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LoanAmount,Premium,LoanStartDate,LoanEndDate,InterestPercentage")] RelatedPartyLoan1 relatedPartyLoan1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyLoan1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyLoan1);
        }

        // GET: RelatedPartyLoan1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyLoan1 relatedPartyLoan1 = db.RelatedPartyLoans1.Find(id);
            if (relatedPartyLoan1 == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyLoan1);
        }

        // POST: RelatedPartyLoan1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyLoan1 relatedPartyLoan1 = db.RelatedPartyLoans1.Find(id);
            db.RelatedPartyLoans1.Remove(relatedPartyLoan1);
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
