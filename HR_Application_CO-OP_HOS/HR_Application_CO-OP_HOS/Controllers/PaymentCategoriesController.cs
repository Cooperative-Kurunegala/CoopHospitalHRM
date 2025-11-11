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
    public class PaymentCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: PaymentCategories
        public ActionResult Index()
        {
            return View(db.PaymentCategories.ToList());
        }

        // GET: PaymentCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentCategory paymentCategory = db.PaymentCategories.Find(id);
            if (paymentCategory == null)
            {
                return HttpNotFound();
            }
            return View(paymentCategory);
        }

        // GET: PaymentCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CategoryName,OrderTypeID")] PaymentCategory paymentCategory)
        {
            if (ModelState.IsValid)
            {
                db.PaymentCategories.Add(paymentCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentCategory);
        }

        // GET: PaymentCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentCategory paymentCategory = db.PaymentCategories.Find(id);
            if (paymentCategory == null)
            {
                return HttpNotFound();
            }
            return View(paymentCategory);
        }

        // POST: PaymentCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CategoryName,OrderTypeID")] PaymentCategory paymentCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentCategory);
        }

        // GET: PaymentCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentCategory paymentCategory = db.PaymentCategories.Find(id);
            if (paymentCategory == null)
            {
                return HttpNotFound();
            }
            return View(paymentCategory);
        }

        // POST: PaymentCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentCategory paymentCategory = db.PaymentCategories.Find(id);
            db.PaymentCategories.Remove(paymentCategory);
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
