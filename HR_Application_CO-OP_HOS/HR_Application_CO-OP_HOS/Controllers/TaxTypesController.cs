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
    public class TaxTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: TaxTypes
        public ActionResult Index()
        {
            return View(db.TaxTypes.ToList());
        }

        // GET: TaxTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaxType taxType = db.TaxTypes.Find(id);
            if (taxType == null)
            {
                return HttpNotFound();
            }
            return View(taxType);
        }

        // GET: TaxTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaxTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaxTypeName,TaxRate,ID,IsEnabled,CreatedDate,CreatedBy")] TaxType taxType)
        {
            if (ModelState.IsValid)
            {
                db.TaxTypes.Add(taxType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taxType);
        }

        // GET: TaxTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaxType taxType = db.TaxTypes.Find(id);
            if (taxType == null)
            {
                return HttpNotFound();
            }
            return View(taxType);
        }

        // POST: TaxTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaxTypeName,TaxRate,ID,IsEnabled,CreatedDate,CreatedBy")] TaxType taxType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taxType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taxType);
        }

        // GET: TaxTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaxType taxType = db.TaxTypes.Find(id);
            if (taxType == null)
            {
                return HttpNotFound();
            }
            return View(taxType);
        }

        // POST: TaxTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaxType taxType = db.TaxTypes.Find(id);
            db.TaxTypes.Remove(taxType);
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
