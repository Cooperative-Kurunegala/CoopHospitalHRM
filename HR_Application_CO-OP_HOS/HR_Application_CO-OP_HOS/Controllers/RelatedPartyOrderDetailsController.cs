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
    public class RelatedPartyOrderDetailsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyOrderDetails
        public ActionResult Index()
        {
            var relatedPartyOrderDetails = db.RelatedPartyOrderDetails.Include(r => r.RelatedPartyOrder);
            return View(relatedPartyOrderDetails.ToList());
        }

        // GET: RelatedPartyOrderDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrderDetail relatedPartyOrderDetail = db.RelatedPartyOrderDetails.Find(id);
            if (relatedPartyOrderDetail == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrderDetail);
        }

        // GET: RelatedPartyOrderDetails/Create
        public ActionResult Create()
        {
            ViewBag.OrderID = new SelectList(db.RelatedPartyOrders, "ID", "OrderNo");
            return View();
        }

        // POST: RelatedPartyOrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OrderID,Qty,Price,LineTotal,DivisionChargeID,DivisionChargeName,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,ChargeTypeID,BatchNumber,ExpiryDate,ReorderLevel,ChargeMasterPriceID,IsNurseCharge,BonusQty,DocFee,HosFee,WardDocFee,BatchPopupID,IsNightTest,involvedperson,QtyPerPack,SalesPrice,TechnicianCharge,AttachmentID,NurseFee")] RelatedPartyOrderDetail relatedPartyOrderDetail)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyOrderDetails.Add(relatedPartyOrderDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrderID = new SelectList(db.RelatedPartyOrders, "ID", "OrderNo", relatedPartyOrderDetail.OrderID);
            return View(relatedPartyOrderDetail);
        }

        // GET: RelatedPartyOrderDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrderDetail relatedPartyOrderDetail = db.RelatedPartyOrderDetails.Find(id);
            if (relatedPartyOrderDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrderID = new SelectList(db.RelatedPartyOrders, "ID", "OrderNo", relatedPartyOrderDetail.OrderID);
            return View(relatedPartyOrderDetail);
        }

        // POST: RelatedPartyOrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OrderID,Qty,Price,LineTotal,DivisionChargeID,DivisionChargeName,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,ChargeTypeID,BatchNumber,ExpiryDate,ReorderLevel,ChargeMasterPriceID,IsNurseCharge,BonusQty,DocFee,HosFee,WardDocFee,BatchPopupID,IsNightTest,involvedperson,QtyPerPack,SalesPrice,TechnicianCharge,AttachmentID,NurseFee")] RelatedPartyOrderDetail relatedPartyOrderDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyOrderDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrderID = new SelectList(db.RelatedPartyOrders, "ID", "OrderNo", relatedPartyOrderDetail.OrderID);
            return View(relatedPartyOrderDetail);
        }

        // GET: RelatedPartyOrderDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrderDetail relatedPartyOrderDetail = db.RelatedPartyOrderDetails.Find(id);
            if (relatedPartyOrderDetail == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrderDetail);
        }

        // POST: RelatedPartyOrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyOrderDetail relatedPartyOrderDetail = db.RelatedPartyOrderDetails.Find(id);
            db.RelatedPartyOrderDetails.Remove(relatedPartyOrderDetail);
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
