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
    public class DivisionChargesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: DivisionCharges
        public ActionResult Index()
        {
            var divisionCharges = db.DivisionCharges.Include(d => d.ChargeMaster).Include(d => d.ChargeType).Include(d => d.DivisionMaster);
            return View(divisionCharges.ToList());
        }

        // GET: DivisionCharges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionCharge divisionCharge = db.DivisionCharges.Find(id);
            if (divisionCharge == null)
            {
                return HttpNotFound();
            }
            return View(divisionCharge);
        }

        // GET: DivisionCharges/Create
        public ActionResult Create()
        {
            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name");
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName");
            ViewBag.DivisionMasterID = new SelectList(db.DivisionMasters, "ID", "DivisionMasterName");
            return View();
        }

        // POST: DivisionCharges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ChargeMasterID,DivisionMasterID,Qty,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,OpeningBalanceDate,ChargeTypeID,BatchNumber,ExpiryDate,ReorderLevel,ChargeMasterPriceID,LocationID,IsBoxItem,PerBoxQty,CostPrice,Margin,SellingPrice,WardPharmacyPrice,ParentDivisionChargeID,ConsultantID,PhysicalStock,OpeningStock,IsIncentiveCalculate,AttachmentID")] DivisionCharge divisionCharge)
        {
            if (ModelState.IsValid)
            {
                db.DivisionCharges.Add(divisionCharge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name", divisionCharge.ChargeMasterID);
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName", divisionCharge.ChargeTypeID);
            ViewBag.DivisionMasterID = new SelectList(db.DivisionMasters, "ID", "DivisionMasterName", divisionCharge.DivisionMasterID);
            return View(divisionCharge);
        }

        // GET: DivisionCharges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionCharge divisionCharge = db.DivisionCharges.Find(id);
            if (divisionCharge == null)
            {
                return HttpNotFound();
            }
            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name", divisionCharge.ChargeMasterID);
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName", divisionCharge.ChargeTypeID);
            ViewBag.DivisionMasterID = new SelectList(db.DivisionMasters, "ID", "DivisionMasterName", divisionCharge.DivisionMasterID);
            return View(divisionCharge);
        }

        // POST: DivisionCharges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ChargeMasterID,DivisionMasterID,Qty,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,OpeningBalanceDate,ChargeTypeID,BatchNumber,ExpiryDate,ReorderLevel,ChargeMasterPriceID,LocationID,IsBoxItem,PerBoxQty,CostPrice,Margin,SellingPrice,WardPharmacyPrice,ParentDivisionChargeID,ConsultantID,PhysicalStock,OpeningStock,IsIncentiveCalculate,AttachmentID")] DivisionCharge divisionCharge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(divisionCharge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ChargeMasterID = new SelectList(db.ChargeMasters, "ID", "Name", divisionCharge.ChargeMasterID);
            ViewBag.ChargeTypeID = new SelectList(db.ChargeTypes, "ID", "ChargeTypeName", divisionCharge.ChargeTypeID);
            ViewBag.DivisionMasterID = new SelectList(db.DivisionMasters, "ID", "DivisionMasterName", divisionCharge.DivisionMasterID);
            return View(divisionCharge);
        }

        // GET: DivisionCharges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionCharge divisionCharge = db.DivisionCharges.Find(id);
            if (divisionCharge == null)
            {
                return HttpNotFound();
            }
            return View(divisionCharge);
        }

        // POST: DivisionCharges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DivisionCharge divisionCharge = db.DivisionCharges.Find(id);
            db.DivisionCharges.Remove(divisionCharge);
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
