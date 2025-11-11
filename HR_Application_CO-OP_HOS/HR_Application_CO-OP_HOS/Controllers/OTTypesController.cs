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
    public class OTTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: OTTypes
        public ActionResult Index()
        {
            return View(db.OTTypes.ToList());
        }

        // GET: OTTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OTType oTType = db.OTTypes.Find(id);
            if (oTType == null)
            {
                return HttpNotFound();
            }
            return View(oTType);
        }

        // GET: OTTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OTTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OTTypeName,Rate,IsEnabled")] OTType oTType)
        {
            if (ModelState.IsValid)
            {
                db.OTTypes.Add(oTType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oTType);
        }

        // GET: OTTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OTType oTType = db.OTTypes.Find(id);
            if (oTType == null)
            {
                return HttpNotFound();
            }
            return View(oTType);
        }

        // POST: OTTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OTTypeName,Rate,IsEnabled")] OTType oTType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oTType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oTType);
        }

        // GET: OTTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OTType oTType = db.OTTypes.Find(id);
            if (oTType == null)
            {
                return HttpNotFound();
            }
            return View(oTType);
        }

        // POST: OTTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OTType oTType = db.OTTypes.Find(id);
            db.OTTypes.Remove(oTType);
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
