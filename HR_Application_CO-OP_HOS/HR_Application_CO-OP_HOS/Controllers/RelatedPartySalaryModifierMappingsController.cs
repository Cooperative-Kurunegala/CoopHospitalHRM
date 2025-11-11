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
    public class RelatedPartySalaryModifierMappingsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartySalaryModifierMappings
        public ActionResult Index()
        {
            var relatedPartySalaryModifierMappings = db.RelatedPartySalaryModifierMappings.Include(r => r.RelatedPartySalary).Include(r => r.SalaryModifier);
            return View(relatedPartySalaryModifierMappings.ToList());
        }

        // GET: RelatedPartySalaryModifierMappings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySalaryModifierMapping relatedPartySalaryModifierMapping = db.RelatedPartySalaryModifierMappings.Find(id);
            if (relatedPartySalaryModifierMapping == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySalaryModifierMapping);
        }

        // GET: RelatedPartySalaryModifierMappings/Create
        public ActionResult Create()
        {
            ViewBag.RelatedPartySalaryID = new SelectList(db.RelatedPartySalaries, "ID", "ID");
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName");
            return View();
        }

        // POST: RelatedPartySalaryModifierMappings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartySalaryID,SalaryModifierID,OrderIndex,GroupingForSlip,CreatedDate,CreatedBy,ActualAmount,SalaryModifierName,SalaryModifierTypeID,IsNoPay,IsLateHours,TaxTypeID,OTTypeID,IsEditable,IsAllawance,IsRemoved,IsLoan")] RelatedPartySalaryModifierMapping relatedPartySalaryModifierMapping)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartySalaryModifierMappings.Add(relatedPartySalaryModifierMapping);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RelatedPartySalaryID = new SelectList(db.RelatedPartySalaries, "ID", "ID", relatedPartySalaryModifierMapping.RelatedPartySalaryID);
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName", relatedPartySalaryModifierMapping.SalaryModifierID);
            return View(relatedPartySalaryModifierMapping);
        }

        // GET: RelatedPartySalaryModifierMappings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySalaryModifierMapping relatedPartySalaryModifierMapping = db.RelatedPartySalaryModifierMappings.Find(id);
            if (relatedPartySalaryModifierMapping == null)
            {
                return HttpNotFound();
            }
            ViewBag.RelatedPartySalaryID = new SelectList(db.RelatedPartySalaries, "ID", "ID", relatedPartySalaryModifierMapping.RelatedPartySalaryID);
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName", relatedPartySalaryModifierMapping.SalaryModifierID);
            return View(relatedPartySalaryModifierMapping);
        }

        // POST: RelatedPartySalaryModifierMappings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartySalaryID,SalaryModifierID,OrderIndex,GroupingForSlip,CreatedDate,CreatedBy,ActualAmount,SalaryModifierName,SalaryModifierTypeID,IsNoPay,IsLateHours,TaxTypeID,OTTypeID,IsEditable,IsAllawance,IsRemoved,IsLoan")] RelatedPartySalaryModifierMapping relatedPartySalaryModifierMapping)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartySalaryModifierMapping).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RelatedPartySalaryID = new SelectList(db.RelatedPartySalaries, "ID", "ID", relatedPartySalaryModifierMapping.RelatedPartySalaryID);
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName", relatedPartySalaryModifierMapping.SalaryModifierID);
            return View(relatedPartySalaryModifierMapping);
        }

        // GET: RelatedPartySalaryModifierMappings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySalaryModifierMapping relatedPartySalaryModifierMapping = db.RelatedPartySalaryModifierMappings.Find(id);
            if (relatedPartySalaryModifierMapping == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySalaryModifierMapping);
        }

        // POST: RelatedPartySalaryModifierMappings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartySalaryModifierMapping relatedPartySalaryModifierMapping = db.RelatedPartySalaryModifierMappings.Find(id);
            db.RelatedPartySalaryModifierMappings.Remove(relatedPartySalaryModifierMapping);
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
