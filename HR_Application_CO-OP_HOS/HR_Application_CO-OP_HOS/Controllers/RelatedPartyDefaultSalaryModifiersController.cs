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
    public class RelatedPartyDefaultSalaryModifiersController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyDefaultSalaryModifiers
        public ActionResult Index()
        {
            var relatedPartyDefaultSalaryModifiers = db.RelatedPartyDefaultSalaryModifiers.Include(r => r.RelatedParty).Include(r => r.SalaryModifier);
            return View(relatedPartyDefaultSalaryModifiers.ToList());
        }

        // GET: RelatedPartyDefaultSalaryModifiers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyDefaultSalaryModifier relatedPartyDefaultSalaryModifier = db.RelatedPartyDefaultSalaryModifiers.Find(id);
            if (relatedPartyDefaultSalaryModifier == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyDefaultSalaryModifier);
        }

        // GET: RelatedPartyDefaultSalaryModifiers/Create
        public ActionResult Create()
        {
            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber");
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName");
            return View();
        }

        // POST: RelatedPartyDefaultSalaryModifiers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,SalaryModifierID,OrderIndex,IsEnabled,CreatedDate,CreatedBy,DefaultValue,IsPayee,IsRemoved")] RelatedPartyDefaultSalaryModifier relatedPartyDefaultSalaryModifier)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyDefaultSalaryModifiers.Add(relatedPartyDefaultSalaryModifier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", relatedPartyDefaultSalaryModifier.RelatedPartyID);
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName", relatedPartyDefaultSalaryModifier.SalaryModifierID);
            return View(relatedPartyDefaultSalaryModifier);
        }

        // GET: RelatedPartyDefaultSalaryModifiers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyDefaultSalaryModifier relatedPartyDefaultSalaryModifier = db.RelatedPartyDefaultSalaryModifiers.Find(id);
            if (relatedPartyDefaultSalaryModifier == null)
            {
                return HttpNotFound();
            }
            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", relatedPartyDefaultSalaryModifier.RelatedPartyID);
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName", relatedPartyDefaultSalaryModifier.SalaryModifierID);
            return View(relatedPartyDefaultSalaryModifier);
        }

        // POST: RelatedPartyDefaultSalaryModifiers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,SalaryModifierID,OrderIndex,IsEnabled,CreatedDate,CreatedBy,DefaultValue,IsPayee,IsRemoved")] RelatedPartyDefaultSalaryModifier relatedPartyDefaultSalaryModifier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyDefaultSalaryModifier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RelatedPartyID = new SelectList(db.RelatedParties, "ID", "RegistrationNumber", relatedPartyDefaultSalaryModifier.RelatedPartyID);
            ViewBag.SalaryModifierID = new SelectList(db.SalaryModifiers, "ID", "SalaryModifierName", relatedPartyDefaultSalaryModifier.SalaryModifierID);
            return View(relatedPartyDefaultSalaryModifier);
        }

        // GET: RelatedPartyDefaultSalaryModifiers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyDefaultSalaryModifier relatedPartyDefaultSalaryModifier = db.RelatedPartyDefaultSalaryModifiers.Find(id);
            if (relatedPartyDefaultSalaryModifier == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyDefaultSalaryModifier);
        }

        // POST: RelatedPartyDefaultSalaryModifiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyDefaultSalaryModifier relatedPartyDefaultSalaryModifier = db.RelatedPartyDefaultSalaryModifiers.Find(id);
            db.RelatedPartyDefaultSalaryModifiers.Remove(relatedPartyDefaultSalaryModifier);
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
