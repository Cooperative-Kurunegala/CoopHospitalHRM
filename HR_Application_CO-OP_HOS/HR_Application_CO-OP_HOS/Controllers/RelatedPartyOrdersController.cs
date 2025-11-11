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
    public class RelatedPartyOrdersController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyOrders
        public ActionResult Index()
        {
            return View(db.RelatedPartyOrders.ToList());
        }

        // GET: RelatedPartyOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrder relatedPartyOrder = db.RelatedPartyOrders.Find(id);
            if (relatedPartyOrder == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrder);
        }

        // GET: RelatedPartyOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyID,OrderDate,OrderTypeID,OrderNo,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,OrderStatus,LocationID,ChargeDiscountID,RelatedPartyIdentityCardNo,InvolvedPerson,DivisionMasterID,IsNightTest,AssignedPerson,AdmissionTypeID,IsHomeVisit,HomeVisitHospitalCharge,RefPurchaseOrderID,RelatedPartySessionID,OperationTheatreAssistanceNurse,OperationTheatreRunningNurse,OperationTheatreMinusNurse,OperationTheatreAssistanceNurseIncentiveValue,OperationTheatreRunningNurseIncentiveValue,OperationTheatreMinusNurseIncentiveValue,IsOrderReturned,RefSalesOrderID,RefGRNID,DiscountPercentage,BHTNo,InvoiceDate,PaymentDueDate,Remarks,Deviation,OPDDiscount,PatientVisitID,AppointmentNo,ConsultantID,RequestDivisionMasterID,DistributorID,InvoiceNo,ConsultantName,isSafeDeleted,TimeSlotID,IsConfirmed,RoomID,OutSiderID,Drawer,ConfirmedDate,ConfirmedBy,isVerified,isPaid,PaidBy,PaidDate,AppointmentDateTime,Times,PaymentCategoryID,NoOfprint,IsPosted,IsCancelPosted,AccountingInvoiceID,CancelReturnBy,CancelReturnDateTime,ReportGivenDate,IsUrgent,CashPaid,SelectedDivisionMasterID,PaymentSubCategoryID")] RelatedPartyOrder relatedPartyOrder)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyOrders.Add(relatedPartyOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyOrder);
        }

        // GET: RelatedPartyOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrder relatedPartyOrder = db.RelatedPartyOrders.Find(id);
            if (relatedPartyOrder == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrder);
        }

        // POST: RelatedPartyOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyID,OrderDate,OrderTypeID,OrderNo,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,OrderStatus,LocationID,ChargeDiscountID,RelatedPartyIdentityCardNo,InvolvedPerson,DivisionMasterID,IsNightTest,AssignedPerson,AdmissionTypeID,IsHomeVisit,HomeVisitHospitalCharge,RefPurchaseOrderID,RelatedPartySessionID,OperationTheatreAssistanceNurse,OperationTheatreRunningNurse,OperationTheatreMinusNurse,OperationTheatreAssistanceNurseIncentiveValue,OperationTheatreRunningNurseIncentiveValue,OperationTheatreMinusNurseIncentiveValue,IsOrderReturned,RefSalesOrderID,RefGRNID,DiscountPercentage,BHTNo,InvoiceDate,PaymentDueDate,Remarks,Deviation,OPDDiscount,PatientVisitID,AppointmentNo,ConsultantID,RequestDivisionMasterID,DistributorID,InvoiceNo,ConsultantName,isSafeDeleted,TimeSlotID,IsConfirmed,RoomID,OutSiderID,Drawer,ConfirmedDate,ConfirmedBy,isVerified,isPaid,PaidBy,PaidDate,AppointmentDateTime,Times,PaymentCategoryID,NoOfprint,IsPosted,IsCancelPosted,AccountingInvoiceID,CancelReturnBy,CancelReturnDateTime,ReportGivenDate,IsUrgent,CashPaid,SelectedDivisionMasterID,PaymentSubCategoryID")] RelatedPartyOrder relatedPartyOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyOrder);
        }

        // GET: RelatedPartyOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyOrder relatedPartyOrder = db.RelatedPartyOrders.Find(id);
            if (relatedPartyOrder == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyOrder);
        }

        // POST: RelatedPartyOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyOrder relatedPartyOrder = db.RelatedPartyOrders.Find(id);
            db.RelatedPartyOrders.Remove(relatedPartyOrder);
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
