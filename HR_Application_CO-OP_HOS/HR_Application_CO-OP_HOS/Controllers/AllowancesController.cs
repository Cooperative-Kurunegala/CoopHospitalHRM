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
    public class AllowancesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: Allowances
        public ActionResult Index()
        {
            var allowances = db.Allowances.Include(a => a.RelatedParty);
            return View(allowances.ToList());
        }

        // GET: Allowances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allowance allowance = db.Allowances.Find(id);
            if (allowance == null)
            {
                return HttpNotFound();
            }
            return View(allowance);
        }

        // GET: Allowances/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.RelatedParties, "ID", "RegistrationNumber");
            return View();
        }

        // POST: Allowances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeeId,AllowanceType,Amount,EffectiveDate,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy")] Allowance allowance)
        {
            if (ModelState.IsValid)
            {
                db.Allowances.Add(allowance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeId = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", allowance.EmployeeId);
            return View(allowance);
        }

        // GET: Allowances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allowance allowance = db.Allowances.Find(id);
            if (allowance == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeId = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", allowance.EmployeeId);
            return View(allowance);
        }

        // POST: Allowances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeeId,AllowanceType,Amount,EffectiveDate,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy")] Allowance allowance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allowance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeId = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", allowance.EmployeeId);
            return View(allowance);
        }

        // GET: Allowances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allowance allowance = db.Allowances.Find(id);
            if (allowance == null)
            {
                return HttpNotFound();
            }
            return View(allowance);
        }

        // POST: Allowances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Allowance allowance = db.Allowances.Find(id);
            db.Allowances.Remove(allowance);
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
