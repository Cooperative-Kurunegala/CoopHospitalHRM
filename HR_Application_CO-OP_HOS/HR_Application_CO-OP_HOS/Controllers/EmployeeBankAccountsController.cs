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
    public class EmployeeBankAccountsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: EmployeeBankAccounts
        public ActionResult Index()
        {
            return View(db.EmployeeBankAccounts.ToList());
        }

        // GET: EmployeeBankAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeBankAccount employeeBankAccount = db.EmployeeBankAccounts.Find(id);
            if (employeeBankAccount == null)
            {
                return HttpNotFound();
            }
            return View(employeeBankAccount);
        }

        // GET: EmployeeBankAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeBankAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountID,EmployeeID,BankID,BranchID,AccountNumber,AccountHolderName,IsPrimary,IsActive")] EmployeeBankAccount employeeBankAccount)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeBankAccounts.Add(employeeBankAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeBankAccount);
        }

        // GET: EmployeeBankAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeBankAccount employeeBankAccount = db.EmployeeBankAccounts.Find(id);
            if (employeeBankAccount == null)
            {
                return HttpNotFound();
            }
            return View(employeeBankAccount);
        }

        // POST: EmployeeBankAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccountID,EmployeeID,BankID,BranchID,AccountNumber,AccountHolderName,IsPrimary,IsActive")] EmployeeBankAccount employeeBankAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeBankAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeBankAccount);
        }

        // GET: EmployeeBankAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeBankAccount employeeBankAccount = db.EmployeeBankAccounts.Find(id);
            if (employeeBankAccount == null)
            {
                return HttpNotFound();
            }
            return View(employeeBankAccount);
        }

        // POST: EmployeeBankAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeBankAccount employeeBankAccount = db.EmployeeBankAccounts.Find(id);
            db.EmployeeBankAccounts.Remove(employeeBankAccount);
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
