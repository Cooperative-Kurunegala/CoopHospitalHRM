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
    public class PayrollRecordsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: PayrollRecords
        public ActionResult Index()
        {
            return View(db.PayrollRecords.ToList());
        }

        // GET: PayrollRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayrollRecord payrollRecord = db.PayrollRecords.Find(id);
            if (payrollRecord == null)
            {
                return HttpNotFound();
            }
            return View(payrollRecord);
        }

        // GET: PayrollRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayrollRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PayrollID,EmployeeID,PayPeriod,PayDate,BasicSalary,FixedAllowances,VariableAllowances,OvertimePay,ShiftAllowances,AttendanceIncentive,GrossSalary,EPFEmployee,EPFEmployer,ETFEmployer,PayeeTax,LoanDeductions,OtherDeductions,TotalDeductions,NetSalary,Status,PaymentMethod,BankAccountID,GeneratedDate,GeneratedBy")] PayrollRecord payrollRecord)
        {
            if (ModelState.IsValid)
            {
                db.PayrollRecords.Add(payrollRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(payrollRecord);
        }

        // GET: PayrollRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayrollRecord payrollRecord = db.PayrollRecords.Find(id);
            if (payrollRecord == null)
            {
                return HttpNotFound();
            }
            return View(payrollRecord);
        }

        // POST: PayrollRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PayrollID,EmployeeID,PayPeriod,PayDate,BasicSalary,FixedAllowances,VariableAllowances,OvertimePay,ShiftAllowances,AttendanceIncentive,GrossSalary,EPFEmployee,EPFEmployer,ETFEmployer,PayeeTax,LoanDeductions,OtherDeductions,TotalDeductions,NetSalary,Status,PaymentMethod,BankAccountID,GeneratedDate,GeneratedBy")] PayrollRecord payrollRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payrollRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payrollRecord);
        }

        // GET: PayrollRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayrollRecord payrollRecord = db.PayrollRecords.Find(id);
            if (payrollRecord == null)
            {
                return HttpNotFound();
            }
            return View(payrollRecord);
        }

        // POST: PayrollRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayrollRecord payrollRecord = db.PayrollRecords.Find(id);
            db.PayrollRecords.Remove(payrollRecord);
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
