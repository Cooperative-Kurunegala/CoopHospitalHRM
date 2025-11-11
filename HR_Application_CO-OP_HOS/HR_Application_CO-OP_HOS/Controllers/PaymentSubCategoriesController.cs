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
    public class PaymentSubCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: PaymentSubCategories
        public ActionResult Index()
        {
            return View(db.PaymentSubCategories.ToList());
        }

        // GET: PaymentSubCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentSubCategory paymentSubCategory = db.PaymentSubCategories.Find(id);
            if (paymentSubCategory == null)
            {
                return HttpNotFound();
            }
            return View(paymentSubCategory);
        }

        // GET: PaymentSubCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentSubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CategoryName,OrderTypeID")] PaymentSubCategory paymentSubCategory)
        {
            if (ModelState.IsValid)
            {
                db.PaymentSubCategories.Add(paymentSubCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentSubCategory);
        }

        // GET: PaymentSubCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentSubCategory paymentSubCategory = db.PaymentSubCategories.Find(id);
            if (paymentSubCategory == null)
            {
                return HttpNotFound();
            }
            return View(paymentSubCategory);
        }

        // POST: PaymentSubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CategoryName,OrderTypeID")] PaymentSubCategory paymentSubCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentSubCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentSubCategory);
        }

        // GET: PaymentSubCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentSubCategory paymentSubCategory = db.PaymentSubCategories.Find(id);
            if (paymentSubCategory == null)
            {
                return HttpNotFound();
            }
            return View(paymentSubCategory);
        }

        // POST: PaymentSubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentSubCategory paymentSubCategory = db.PaymentSubCategories.Find(id);
            db.PaymentSubCategories.Remove(paymentSubCategory);
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
