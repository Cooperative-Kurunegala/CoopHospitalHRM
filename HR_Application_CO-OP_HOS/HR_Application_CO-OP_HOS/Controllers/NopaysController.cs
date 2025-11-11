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
    public class NopaysController : Controller
    {
        private HREntities db = new HREntities();

        // GET: Nopays
        public ActionResult Index()
        {
            return View(db.Nopays.ToList());
        }

        // GET: Nopays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nopay nopay = db.Nopays.Find(id);
            if (nopay == null)
            {
                return HttpNotFound();
            }
            return View(nopay);
        }

        // GET: Nopays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nopays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,PayMonth,PayYear,NoPayDays")] Nopay nopay)
        {
            if (ModelState.IsValid)
            {
                db.Nopays.Add(nopay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nopay);
        }

        // GET: Nopays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nopay nopay = db.Nopays.Find(id);
            if (nopay == null)
            {
                return HttpNotFound();
            }
            return View(nopay);
        }

        // POST: Nopays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,PayMonth,PayYear,NoPayDays")] Nopay nopay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nopay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nopay);
        }

        // GET: Nopays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nopay nopay = db.Nopays.Find(id);
            if (nopay == null)
            {
                return HttpNotFound();
            }
            return View(nopay);
        }

        // POST: Nopays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nopay nopay = db.Nopays.Find(id);
            db.Nopays.Remove(nopay);
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
