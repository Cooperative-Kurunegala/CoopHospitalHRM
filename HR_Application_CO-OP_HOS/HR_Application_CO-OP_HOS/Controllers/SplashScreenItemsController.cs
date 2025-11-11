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
    public class SplashScreenItemsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: SplashScreenItems
        public ActionResult Index()
        {
            var splashScreenItems = db.SplashScreenItems.Include(s => s.Location);
            return View(splashScreenItems.ToList());
        }

        // GET: SplashScreenItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SplashScreenItem splashScreenItem = db.SplashScreenItems.Find(id);
            if (splashScreenItem == null)
            {
                return HttpNotFound();
            }
            return View(splashScreenItem);
        }

        // GET: SplashScreenItems/Create
        public ActionResult Create()
        {
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "LocationName");
            return View();
        }

        // POST: SplashScreenItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SplashScreenItemName,SplashScreenItemDescription,OrderIndex,AttachmentID,LocationID")] SplashScreenItem splashScreenItem)
        {
            if (ModelState.IsValid)
            {
                db.SplashScreenItems.Add(splashScreenItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LocationID = new SelectList(db.Locations, "ID", "LocationName", splashScreenItem.LocationID);
            return View(splashScreenItem);
        }

        // GET: SplashScreenItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SplashScreenItem splashScreenItem = db.SplashScreenItems.Find(id);
            if (splashScreenItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "LocationName", splashScreenItem.LocationID);
            return View(splashScreenItem);
        }

        // POST: SplashScreenItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SplashScreenItemName,SplashScreenItemDescription,OrderIndex,AttachmentID,LocationID")] SplashScreenItem splashScreenItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(splashScreenItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "LocationName", splashScreenItem.LocationID);
            return View(splashScreenItem);
        }

        // GET: SplashScreenItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SplashScreenItem splashScreenItem = db.SplashScreenItems.Find(id);
            if (splashScreenItem == null)
            {
                return HttpNotFound();
            }
            return View(splashScreenItem);
        }

        // POST: SplashScreenItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SplashScreenItem splashScreenItem = db.SplashScreenItems.Find(id);
            db.SplashScreenItems.Remove(splashScreenItem);
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
