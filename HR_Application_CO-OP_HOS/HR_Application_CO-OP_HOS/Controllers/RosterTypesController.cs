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
    public class RosterTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RosterTypes
        public ActionResult Index()
        {
            return View(db.RosterTypes.ToList());
        }

        // GET: RosterTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RosterType rosterType = db.RosterTypes.Find(id);
            if (rosterType == null)
            {
                return HttpNotFound();
            }
            return View(rosterType);
        }

        // GET: RosterTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RosterTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RosterTypeName")] RosterType rosterType)
        {
            if (ModelState.IsValid)
            {
                db.RosterTypes.Add(rosterType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rosterType);
        }

        // GET: RosterTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RosterType rosterType = db.RosterTypes.Find(id);
            if (rosterType == null)
            {
                return HttpNotFound();
            }
            return View(rosterType);
        }

        // POST: RosterTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RosterTypeName")] RosterType rosterType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rosterType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rosterType);
        }

        // GET: RosterTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RosterType rosterType = db.RosterTypes.Find(id);
            if (rosterType == null)
            {
                return HttpNotFound();
            }
            return View(rosterType);
        }

        // POST: RosterTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RosterType rosterType = db.RosterTypes.Find(id);
            db.RosterTypes.Remove(rosterType);
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
