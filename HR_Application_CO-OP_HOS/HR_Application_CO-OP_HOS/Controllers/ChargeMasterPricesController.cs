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
    public class ChargeMasterPricesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChargeMasterPrices
        public ActionResult Index()
        {
            var chargeMasterPrices = db.ChargeMasterPrices.Include(c => c.ChargeMaster).Include(c => c.OrderType);
            return View(chargeMasterPrices.ToList());
        }

        // GET: ChargeMasterPrices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeMasterPrice chargeMasterPrice = db.ChargeMasterPrices.Find(id);
            if (chargeMasterPrice == null)
            {
                return HttpNotFound();
            }
            return View(chargeMasterPrice);
        }

        // GET: ChargeMasterPrices/Create
        public ActionResult Create()
        {
            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name");
            ViewBag.OrderTypeID = new SelectList(db.OrderTypes, "ID", "OrderTypeName");
            return View();
        }

        // POST: ChargeMasterPrices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ChargeMasterID,Name,Description,IsDefault,OrderTypeID,CostPrice,Margin,SellingPrice,RefDivisionMasterID")] ChargeMasterPrice chargeMasterPrice)
        {
            if (ModelState.IsValid)
            {
                db.ChargeMasterPrices.Add(chargeMasterPrice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name", chargeMasterPrice.ChargeMasterID);
            ViewBag.OrderTypeID = new SelectList(db.OrderTypes, "ID", "OrderTypeName", chargeMasterPrice.OrderTypeID);
            return View(chargeMasterPrice);
        }

        // GET: ChargeMasterPrices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeMasterPrice chargeMasterPrice = db.ChargeMasterPrices.Find(id);
            if (chargeMasterPrice == null)
            {
                return HttpNotFound();
            }
            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name", chargeMasterPrice.ChargeMasterID);
            ViewBag.OrderTypeID = new SelectList(db.OrderTypes, "ID", "OrderTypeName", chargeMasterPrice.OrderTypeID);
            return View(chargeMasterPrice);
        }

        // POST: ChargeMasterPrices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ChargeMasterID,Name,Description,IsDefault,OrderTypeID,CostPrice,Margin,SellingPrice,RefDivisionMasterID")] ChargeMasterPrice chargeMasterPrice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chargeMasterPrice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name", chargeMasterPrice.ChargeMasterID);
            ViewBag.OrderTypeID = new SelectList(db.OrderTypes, "ID", "OrderTypeName", chargeMasterPrice.OrderTypeID);
            return View(chargeMasterPrice);
        }

        // GET: ChargeMasterPrices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeMasterPrice chargeMasterPrice = db.ChargeMasterPrices.Find(id);
            if (chargeMasterPrice == null)
            {
                return HttpNotFound();
            }
            return View(chargeMasterPrice);
        }

        // POST: ChargeMasterPrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChargeMasterPrice chargeMasterPrice = db.ChargeMasterPrices.Find(id);
            db.ChargeMasterPrices.Remove(chargeMasterPrice);
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
