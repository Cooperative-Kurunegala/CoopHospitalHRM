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
    public class BatchPopupsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: BatchPopups
        public ActionResult Index()
        {
            return View(db.BatchPopups.ToList());
        }

        // GET: BatchPopups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchPopup batchPopup = db.BatchPopups.Find(id);
            if (batchPopup == null)
            {
                return HttpNotFound();
            }
            return View(batchPopup);
        }

        // GET: BatchPopups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatchPopups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DivisionChargeID,BatchNo,ExpiryDate,Stock,OpeningStockDate,OpeningStock,BatchSellingPrice,CostPrice")] BatchPopup batchPopup)
        {
            if (ModelState.IsValid)
            {
                db.BatchPopups.Add(batchPopup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(batchPopup);
        }

        // GET: BatchPopups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchPopup batchPopup = db.BatchPopups.Find(id);
            if (batchPopup == null)
            {
                return HttpNotFound();
            }
            return View(batchPopup);
        }

        // POST: BatchPopups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DivisionChargeID,BatchNo,ExpiryDate,Stock,OpeningStockDate,OpeningStock,BatchSellingPrice,CostPrice")] BatchPopup batchPopup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(batchPopup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(batchPopup);
        }

        // GET: BatchPopups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchPopup batchPopup = db.BatchPopups.Find(id);
            if (batchPopup == null)
            {
                return HttpNotFound();
            }
            return View(batchPopup);
        }

        // POST: BatchPopups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BatchPopup batchPopup = db.BatchPopups.Find(id);
            db.BatchPopups.Remove(batchPopup);
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
