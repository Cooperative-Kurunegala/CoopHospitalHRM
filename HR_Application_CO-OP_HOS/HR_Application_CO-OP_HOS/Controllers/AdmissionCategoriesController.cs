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
    public class AdmissionCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: AdmissionCategories
        public ActionResult Index()
        {
            return View(db.AdmissionCategories.ToList());
        }

        // GET: AdmissionCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdmissionCategory admissionCategory = db.AdmissionCategories.Find(id);
            if (admissionCategory == null)
            {
                return HttpNotFound();
            }
            return View(admissionCategory);
        }

        // GET: AdmissionCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmissionCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Category")] AdmissionCategory admissionCategory)
        {
            if (ModelState.IsValid)
            {
                db.AdmissionCategories.Add(admissionCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admissionCategory);
        }

        // GET: AdmissionCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdmissionCategory admissionCategory = db.AdmissionCategories.Find(id);
            if (admissionCategory == null)
            {
                return HttpNotFound();
            }
            return View(admissionCategory);
        }

        // POST: AdmissionCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Category")] AdmissionCategory admissionCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admissionCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admissionCategory);
        }

        // GET: AdmissionCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdmissionCategory admissionCategory = db.AdmissionCategories.Find(id);
            if (admissionCategory == null)
            {
                return HttpNotFound();
            }
            return View(admissionCategory);
        }

        // POST: AdmissionCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdmissionCategory admissionCategory = db.AdmissionCategories.Find(id);
            db.AdmissionCategories.Remove(admissionCategory);
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
