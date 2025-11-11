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
    public class RelatedPartySessionTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartySessionTypes
        public ActionResult Index()
        {
            return View(db.RelatedPartySessionTypes.ToList());
        }

        // GET: RelatedPartySessionTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySessionType relatedPartySessionType = db.RelatedPartySessionTypes.Find(id);
            if (relatedPartySessionType == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySessionType);
        }

        // GET: RelatedPartySessionTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartySessionTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartySessionTypeName")] RelatedPartySessionType relatedPartySessionType)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartySessionTypes.Add(relatedPartySessionType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartySessionType);
        }

        // GET: RelatedPartySessionTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySessionType relatedPartySessionType = db.RelatedPartySessionTypes.Find(id);
            if (relatedPartySessionType == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySessionType);
        }

        // POST: RelatedPartySessionTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartySessionTypeName")] RelatedPartySessionType relatedPartySessionType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartySessionType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartySessionType);
        }

        // GET: RelatedPartySessionTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySessionType relatedPartySessionType = db.RelatedPartySessionTypes.Find(id);
            if (relatedPartySessionType == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySessionType);
        }

        // POST: RelatedPartySessionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartySessionType relatedPartySessionType = db.RelatedPartySessionTypes.Find(id);
            db.RelatedPartySessionTypes.Remove(relatedPartySessionType);
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
