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
    public class RelatedPartyCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyCategories
        public ActionResult Index()
        {
            return View(db.RelatedPartyCategories.ToList());
        }

        // GET: RelatedPartyCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyCategory relatedPartyCategory = db.RelatedPartyCategories.Find(id);
            if (relatedPartyCategory == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyCategory);
        }

        // GET: RelatedPartyCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyCategoryName,RelatedPartyTypeID,RelatedPartyCategoryCode,RelatedPartyGrade,RelatedPartyCategoryDescription,AttendanceInCaptureStart,AttendanceInCaptureEnd,AttendanceOutCaptureStart,AttendanceOutCaptureEnd,ExpectedIn,ExpectedOut")] RelatedPartyCategory relatedPartyCategory)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyCategories.Add(relatedPartyCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyCategory);
        }

        // GET: RelatedPartyCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyCategory relatedPartyCategory = db.RelatedPartyCategories.Find(id);
            if (relatedPartyCategory == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyCategory);
        }

        // POST: RelatedPartyCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyCategoryName,RelatedPartyTypeID,RelatedPartyCategoryCode,RelatedPartyGrade,RelatedPartyCategoryDescription,AttendanceInCaptureStart,AttendanceInCaptureEnd,AttendanceOutCaptureStart,AttendanceOutCaptureEnd,ExpectedIn,ExpectedOut")] RelatedPartyCategory relatedPartyCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyCategory);
        }

        // GET: RelatedPartyCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyCategory relatedPartyCategory = db.RelatedPartyCategories.Find(id);
            if (relatedPartyCategory == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyCategory);
        }

        // POST: RelatedPartyCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyCategory relatedPartyCategory = db.RelatedPartyCategories.Find(id);
            db.RelatedPartyCategories.Remove(relatedPartyCategory);
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
