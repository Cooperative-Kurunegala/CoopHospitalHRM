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
    public class CurrentPayrollMonthsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: CurrentPayrollMonths
        public ActionResult Index()
        {
            return View(db.CurrentPayrollMonths.ToList());
        }

        // GET: CurrentPayrollMonths/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentPayrollMonth currentPayrollMonth = db.CurrentPayrollMonths.Find(id);
            if (currentPayrollMonth == null)
            {
                return HttpNotFound();
            }
            return View(currentPayrollMonth);
        }

        // GET: CurrentPayrollMonths/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CurrentPayrollMonths/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CurrentPayrollMonthValue,CurrentPayrollYearValue,SalaryTypeID,CompanyID,IsCurrentPayrollMonth,MonthName,IsClosed,DurationFrom,DurationTo")] CurrentPayrollMonth currentPayrollMonth)
        {
            if (ModelState.IsValid)
            {
                db.CurrentPayrollMonths.Add(currentPayrollMonth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(currentPayrollMonth);
        }

        // GET: CurrentPayrollMonths/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentPayrollMonth currentPayrollMonth = db.CurrentPayrollMonths.Find(id);
            if (currentPayrollMonth == null)
            {
                return HttpNotFound();
            }
            return View(currentPayrollMonth);
        }

        // POST: CurrentPayrollMonths/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CurrentPayrollMonthValue,CurrentPayrollYearValue,SalaryTypeID,CompanyID,IsCurrentPayrollMonth,MonthName,IsClosed,DurationFrom,DurationTo")] CurrentPayrollMonth currentPayrollMonth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(currentPayrollMonth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(currentPayrollMonth);
        }

        // GET: CurrentPayrollMonths/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentPayrollMonth currentPayrollMonth = db.CurrentPayrollMonths.Find(id);
            if (currentPayrollMonth == null)
            {
                return HttpNotFound();
            }
            return View(currentPayrollMonth);
        }

        // POST: CurrentPayrollMonths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CurrentPayrollMonth currentPayrollMonth = db.CurrentPayrollMonths.Find(id);
            db.CurrentPayrollMonths.Remove(currentPayrollMonth);
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
