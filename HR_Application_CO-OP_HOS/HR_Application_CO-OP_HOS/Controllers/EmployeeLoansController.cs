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
    public class EmployeeLoansController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: EmployeeLoans
        public ActionResult Index()
        {
            return View(db.EmployeeLoans.ToList());
        }

        // GET: EmployeeLoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeLoan employeeLoan = db.EmployeeLoans.Find(id);
            if (employeeLoan == null)
            {
                return HttpNotFound();
            }
            return View(employeeLoan);
        }

        // GET: EmployeeLoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeLoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoanID,EmployeeID,LoanCategoryID,LoanNumber,LoanAmount,InterestRate,TotalAmount,MonthlyInstallment,TotalInstallments,PaidInstallments,RemainingInstallments,PaidAmount,RemainingAmount,StartDate,EndDate,Status,Remarks,ApprovedBy,ApprovedDate")] EmployeeLoan employeeLoan)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeLoans.Add(employeeLoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeLoan);
        }

        // GET: EmployeeLoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeLoan employeeLoan = db.EmployeeLoans.Find(id);
            if (employeeLoan == null)
            {
                return HttpNotFound();
            }
            return View(employeeLoan);
        }

        // POST: EmployeeLoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoanID,EmployeeID,LoanCategoryID,LoanNumber,LoanAmount,InterestRate,TotalAmount,MonthlyInstallment,TotalInstallments,PaidInstallments,RemainingInstallments,PaidAmount,RemainingAmount,StartDate,EndDate,Status,Remarks,ApprovedBy,ApprovedDate")] EmployeeLoan employeeLoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeLoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeLoan);
        }

        // GET: EmployeeLoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeLoan employeeLoan = db.EmployeeLoans.Find(id);
            if (employeeLoan == null)
            {
                return HttpNotFound();
            }
            return View(employeeLoan);
        }

        // POST: EmployeeLoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeLoan employeeLoan = db.EmployeeLoans.Find(id);
            db.EmployeeLoans.Remove(employeeLoan);
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
