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
    public class ChargeCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChargeCategories
        public ActionResult Index()
        {
            return View(db.ChargeCategories.ToList());
        }

        // GET: ChargeCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeCategory chargeCategory = db.ChargeCategories.Find(id);
            if (chargeCategory == null)
            {
                return HttpNotFound();
            }
            return View(chargeCategory);
        }

        // GET: ChargeCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChargeCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CategoryName,CategoryDescription,ChargeTypeID")] ChargeCategory chargeCategory)
        {
            if (ModelState.IsValid)
            {
                db.ChargeCategories.Add(chargeCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chargeCategory);
        }

        // GET: ChargeCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeCategory chargeCategory = db.ChargeCategories.Find(id);
            if (chargeCategory == null)
            {
                return HttpNotFound();
            }
            return View(chargeCategory);
        }

        // POST: ChargeCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CategoryName,CategoryDescription,ChargeTypeID")] ChargeCategory chargeCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chargeCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chargeCategory);
        }

        // GET: ChargeCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeCategory chargeCategory = db.ChargeCategories.Find(id);
            if (chargeCategory == null)
            {
                return HttpNotFound();
            }
            return View(chargeCategory);
        }

        // POST: ChargeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChargeCategory chargeCategory = db.ChargeCategories.Find(id);
            db.ChargeCategories.Remove(chargeCategory);
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
