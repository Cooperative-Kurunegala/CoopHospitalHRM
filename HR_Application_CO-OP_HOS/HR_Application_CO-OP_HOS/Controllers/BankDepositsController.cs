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
    public class BankDepositsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: BankDeposits
        public ActionResult Index()
        {
            return View(db.BankDeposits.ToList());
        }

        // GET: BankDeposits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankDeposit bankDeposit = db.BankDeposits.Find(id);
            if (bankDeposit == null)
            {
                return HttpNotFound();
            }
            return View(bankDeposit);
        }

        // GET: BankDeposits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankDeposits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Pharmacy_Deposit,Reception_Deposit,DepositDatetime,CreatedBy,Cheque_Deposit,CashInHand")] BankDeposit bankDeposit)
        {
            if (ModelState.IsValid)
            {
                db.BankDeposits.Add(bankDeposit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankDeposit);
        }

        // GET: BankDeposits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankDeposit bankDeposit = db.BankDeposits.Find(id);
            if (bankDeposit == null)
            {
                return HttpNotFound();
            }
            return View(bankDeposit);
        }

        // POST: BankDeposits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Pharmacy_Deposit,Reception_Deposit,DepositDatetime,CreatedBy,Cheque_Deposit,CashInHand")] BankDeposit bankDeposit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankDeposit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankDeposit);
        }

        // GET: BankDeposits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankDeposit bankDeposit = db.BankDeposits.Find(id);
            if (bankDeposit == null)
            {
                return HttpNotFound();
            }
            return View(bankDeposit);
        }

        // POST: BankDeposits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BankDeposit bankDeposit = db.BankDeposits.Find(id);
            db.BankDeposits.Remove(bankDeposit);
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
