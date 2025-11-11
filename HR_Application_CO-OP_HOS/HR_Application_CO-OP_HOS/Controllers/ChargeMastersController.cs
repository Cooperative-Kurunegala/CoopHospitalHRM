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
    public class ChargeMastersController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChargeMasters
        public ActionResult Index()
        {
            var chargeMasters = db.ChargeMasters.Include(c => c.ChargeType);
            return View(chargeMasters.ToList());
        }

        // GET: ChargeMasters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeMaster chargeMaster = db.ChargeMasters.Find(id);
            if (chargeMaster == null)
            {
                return HttpNotFound();
            }
            return View(chargeMaster);
        }

        // GET: ChargeMasters/Create
        public ActionResult Create()
        {
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName");
            return View();
        }

        // POST: ChargeMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,IsActive,Code,UnitTypeID,MenuTypeID,MenuTypeDetailID,ChargeTypeID,ChargeCategoryID,LocationID,IsIncentiveCalculate")] ChargeMaster chargeMaster)
        {
            if (ModelState.IsValid)
            {
                db.ChargeMasters.Add(chargeMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName", chargeMaster.ChargeTypeID);
            return View(chargeMaster);
        }

        // GET: ChargeMasters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeMaster chargeMaster = db.ChargeMasters.Find(id);
            if (chargeMaster == null)
            {
                return HttpNotFound();
            }
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName", chargeMaster.ChargeTypeID);
            return View(chargeMaster);
        }

        // POST: ChargeMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,IsActive,Code,UnitTypeID,MenuTypeID,MenuTypeDetailID,ChargeTypeID,ChargeCategoryID,LocationID,IsIncentiveCalculate")] ChargeMaster chargeMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chargeMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName", chargeMaster.ChargeTypeID);
            return View(chargeMaster);
        }

        // GET: ChargeMasters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeMaster chargeMaster = db.ChargeMasters.Find(id);
            if (chargeMaster == null)
            {
                return HttpNotFound();
            }
            return View(chargeMaster);
        }

        // POST: ChargeMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChargeMaster chargeMaster = db.ChargeMasters.Find(id);
            db.ChargeMasters.Remove(chargeMaster);
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
