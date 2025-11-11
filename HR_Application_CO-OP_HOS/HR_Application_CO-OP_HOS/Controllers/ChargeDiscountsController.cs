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
    public class ChargeDiscountsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChargeDiscounts
        public ActionResult Index()
        {
            return View(db.ChargeDiscounts.ToList());
        }

        // GET: ChargeDiscounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeDiscount chargeDiscount = db.ChargeDiscounts.Find(id);
            if (chargeDiscount == null)
            {
                return HttpNotFound();
            }
            return View(chargeDiscount);
        }

        // GET: ChargeDiscounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChargeDiscounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DiscountTypeName,DiscountTypeCode,DiscountPercentage,ChargeTypeID,IsActive,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,RelatedPartyTypeID,OrderTypeID")] ChargeDiscount chargeDiscount)
        {
            if (ModelState.IsValid)
            {
                db.ChargeDiscounts.Add(chargeDiscount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chargeDiscount);
        }

        // GET: ChargeDiscounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeDiscount chargeDiscount = db.ChargeDiscounts.Find(id);
            if (chargeDiscount == null)
            {
                return HttpNotFound();
            }
            return View(chargeDiscount);
        }

        // POST: ChargeDiscounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DiscountTypeName,DiscountTypeCode,DiscountPercentage,ChargeTypeID,IsActive,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,RelatedPartyTypeID,OrderTypeID")] ChargeDiscount chargeDiscount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chargeDiscount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chargeDiscount);
        }

        // GET: ChargeDiscounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeDiscount chargeDiscount = db.ChargeDiscounts.Find(id);
            if (chargeDiscount == null)
            {
                return HttpNotFound();
            }
            return View(chargeDiscount);
        }

        // POST: ChargeDiscounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChargeDiscount chargeDiscount = db.ChargeDiscounts.Find(id);
            db.ChargeDiscounts.Remove(chargeDiscount);
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
