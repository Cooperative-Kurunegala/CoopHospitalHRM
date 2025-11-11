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
    public class PaymentDetailsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: PaymentDetails
        public ActionResult Index()
        {
            return View(db.PaymentDetails.ToList());
        }

        // GET: PaymentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentDetail paymentDetail = db.PaymentDetails.Find(id);
            if (paymentDetail == null)
            {
                return HttpNotFound();
            }
            return View(paymentDetail);
        }

        // GET: PaymentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ChargeItemListID,AdmissionType,OrderNo,Amount,Drawer,DoctorID,PatientName,BHT,DoctorCharge,HospitalCharge,Reason,CreatedBy,CreatedDate,OrderStatus,ReceivedBy,Description,IsPosted,IsCancelPosted")] PaymentDetail paymentDetail)
        {
            if (ModelState.IsValid)
            {
                db.PaymentDetails.Add(paymentDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentDetail);
        }

        // GET: PaymentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentDetail paymentDetail = db.PaymentDetails.Find(id);
            if (paymentDetail == null)
            {
                return HttpNotFound();
            }
            return View(paymentDetail);
        }

        // POST: PaymentDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ChargeItemListID,AdmissionType,OrderNo,Amount,Drawer,DoctorID,PatientName,BHT,DoctorCharge,HospitalCharge,Reason,CreatedBy,CreatedDate,OrderStatus,ReceivedBy,Description,IsPosted,IsCancelPosted")] PaymentDetail paymentDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentDetail);
        }

        // GET: PaymentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentDetail paymentDetail = db.PaymentDetails.Find(id);
            if (paymentDetail == null)
            {
                return HttpNotFound();
            }
            return View(paymentDetail);
        }

        // POST: PaymentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentDetail paymentDetail = db.PaymentDetails.Find(id);
            db.PaymentDetails.Remove(paymentDetail);
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
