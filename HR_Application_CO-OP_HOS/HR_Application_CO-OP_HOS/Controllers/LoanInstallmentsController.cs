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
    public class LoanInstallmentsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: LoanInstallments
        public ActionResult Index()
        {
            return View(db.LoanInstallments.ToList());
        }

        // GET: LoanInstallments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanInstallment loanInstallment = db.LoanInstallments.Find(id);
            if (loanInstallment == null)
            {
                return HttpNotFound();
            }
            return View(loanInstallment);
        }

        // GET: LoanInstallments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanInstallments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InstallmentID,LoanID,InstallmentNumber,DueDate,Amount,PaidDate,Status,PaidAmount,Remarks")] LoanInstallment loanInstallment)
        {
            if (ModelState.IsValid)
            {
                db.LoanInstallments.Add(loanInstallment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanInstallment);
        }

        // GET: LoanInstallments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanInstallment loanInstallment = db.LoanInstallments.Find(id);
            if (loanInstallment == null)
            {
                return HttpNotFound();
            }
            return View(loanInstallment);
        }

        // POST: LoanInstallments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InstallmentID,LoanID,InstallmentNumber,DueDate,Amount,PaidDate,Status,PaidAmount,Remarks")] LoanInstallment loanInstallment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanInstallment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanInstallment);
        }

        // GET: LoanInstallments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanInstallment loanInstallment = db.LoanInstallments.Find(id);
            if (loanInstallment == null)
            {
                return HttpNotFound();
            }
            return View(loanInstallment);
        }

        // POST: LoanInstallments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanInstallment loanInstallment = db.LoanInstallments.Find(id);
            db.LoanInstallments.Remove(loanInstallment);
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
