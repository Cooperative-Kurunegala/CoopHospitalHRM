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
    public class RelatedPartySubCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartySubCategories
        public ActionResult Index()
        {
            return View(db.RelatedPartySubCategories.ToList());
        }

        // GET: RelatedPartySubCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySubCategory relatedPartySubCategory = db.RelatedPartySubCategories.Find(id);
            if (relatedPartySubCategory == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySubCategory);
        }

        // GET: RelatedPartySubCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartySubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SubCategoryName,RelatedPartyCategoryID,HospitalCharge")] RelatedPartySubCategory relatedPartySubCategory)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartySubCategories.Add(relatedPartySubCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartySubCategory);
        }

        // GET: RelatedPartySubCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySubCategory relatedPartySubCategory = db.RelatedPartySubCategories.Find(id);
            if (relatedPartySubCategory == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySubCategory);
        }

        // POST: RelatedPartySubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SubCategoryName,RelatedPartyCategoryID,HospitalCharge")] RelatedPartySubCategory relatedPartySubCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartySubCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartySubCategory);
        }

        // GET: RelatedPartySubCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySubCategory relatedPartySubCategory = db.RelatedPartySubCategories.Find(id);
            if (relatedPartySubCategory == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySubCategory);
        }

        // POST: RelatedPartySubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartySubCategory relatedPartySubCategory = db.RelatedPartySubCategories.Find(id);
            db.RelatedPartySubCategories.Remove(relatedPartySubCategory);
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
