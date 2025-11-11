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
    public class PayeeTaxesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: PayeeTaxes
        public ActionResult Index()
        {
            return View(db.PayeeTaxes.ToList());
        }

        // GET: PayeeTaxes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayeeTax payeeTax = db.PayeeTaxes.Find(id);
            if (payeeTax == null)
            {
                return HttpNotFound();
            }
            return View(payeeTax);
        }

        // GET: PayeeTaxes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayeeTaxes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PayeeRate,Conditions,TaxTypeID")] PayeeTax payeeTax)
        {
            if (ModelState.IsValid)
            {
                db.PayeeTaxes.Add(payeeTax);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(payeeTax);
        }

        // GET: PayeeTaxes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayeeTax payeeTax = db.PayeeTaxes.Find(id);
            if (payeeTax == null)
            {
                return HttpNotFound();
            }
            return View(payeeTax);
        }

        // POST: PayeeTaxes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PayeeRate,Conditions,TaxTypeID")] PayeeTax payeeTax)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payeeTax).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payeeTax);
        }

        // GET: PayeeTaxes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayeeTax payeeTax = db.PayeeTaxes.Find(id);
            if (payeeTax == null)
            {
                return HttpNotFound();
            }
            return View(payeeTax);
        }

        // POST: PayeeTaxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayeeTax payeeTax = db.PayeeTaxes.Find(id);
            db.PayeeTaxes.Remove(payeeTax);
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
