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
    public class RelatedPartyBankAccountsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyBankAccounts
        public ActionResult Index()
        {
            return View(db.RelatedPartyBankAccounts.ToList());
        }

        // GET: RelatedPartyBankAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyBankAccount relatedPartyBankAccount = db.RelatedPartyBankAccounts.Find(id);
            if (relatedPartyBankAccount == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyBankAccount);
        }

        // GET: RelatedPartyBankAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyBankAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,BankID,BranchID,StandingOrderAmount,BankAccountNo,IsEnable,CreatedDate,CreatedBy")] RelatedPartyBankAccount relatedPartyBankAccount)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyBankAccounts.Add(relatedPartyBankAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyBankAccount);
        }

        // GET: RelatedPartyBankAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyBankAccount relatedPartyBankAccount = db.RelatedPartyBankAccounts.Find(id);
            if (relatedPartyBankAccount == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyBankAccount);
        }

        // POST: RelatedPartyBankAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,BankID,BranchID,StandingOrderAmount,BankAccountNo,IsEnable,CreatedDate,CreatedBy")] RelatedPartyBankAccount relatedPartyBankAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyBankAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyBankAccount);
        }

        // GET: RelatedPartyBankAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyBankAccount relatedPartyBankAccount = db.RelatedPartyBankAccounts.Find(id);
            if (relatedPartyBankAccount == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyBankAccount);
        }

        // POST: RelatedPartyBankAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyBankAccount relatedPartyBankAccount = db.RelatedPartyBankAccounts.Find(id);
            db.RelatedPartyBankAccounts.Remove(relatedPartyBankAccount);
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
