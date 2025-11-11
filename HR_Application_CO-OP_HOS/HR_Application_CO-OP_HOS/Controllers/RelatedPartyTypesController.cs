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
    public class RelatedPartyTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyTypes
        public ActionResult Index()
        {
            return View(db.RelatedPartyTypes.ToList());
        }

        // GET: RelatedPartyTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyType relatedPartyType = db.RelatedPartyTypes.Find(id);
            if (relatedPartyType == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyType);
        }

        // GET: RelatedPartyTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyTypeName")] RelatedPartyType relatedPartyType)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyTypes.Add(relatedPartyType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyType);
        }

        // GET: RelatedPartyTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyType relatedPartyType = db.RelatedPartyTypes.Find(id);
            if (relatedPartyType == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyType);
        }

        // POST: RelatedPartyTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyTypeName")] RelatedPartyType relatedPartyType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyType);
        }

        // GET: RelatedPartyTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyType relatedPartyType = db.RelatedPartyTypes.Find(id);
            if (relatedPartyType == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyType);
        }

        // POST: RelatedPartyTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyType relatedPartyType = db.RelatedPartyTypes.Find(id);
            db.RelatedPartyTypes.Remove(relatedPartyType);
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
