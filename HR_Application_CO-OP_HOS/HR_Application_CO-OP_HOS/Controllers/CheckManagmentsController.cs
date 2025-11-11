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
    public class CheckManagmentsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: CheckManagments
        public ActionResult Index()
        {
            return View(db.CheckManagments.ToList());
        }

        // GET: CheckManagments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckManagment checkManagment = db.CheckManagments.Find(id);
            if (checkManagment == null)
            {
                return HttpNotFound();
            }
            return View(checkManagment);
        }

        // GET: CheckManagments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckManagments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CheckDate,PostDate,InvoiceNo,CheckNumber,RelatedpartyID,Amount,Remarks,CreatedBy,CreatedDate,DivisionMasterID,PaymentCategoryID,ChequeType,IsIssued,OrderStatus,IssueDateTime")] CheckManagment checkManagment)
        {
            if (ModelState.IsValid)
            {
                db.CheckManagments.Add(checkManagment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(checkManagment);
        }

        // GET: CheckManagments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckManagment checkManagment = db.CheckManagments.Find(id);
            if (checkManagment == null)
            {
                return HttpNotFound();
            }
            return View(checkManagment);
        }

        // POST: CheckManagments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CheckDate,PostDate,InvoiceNo,CheckNumber,RelatedpartyID,Amount,Remarks,CreatedBy,CreatedDate,DivisionMasterID,PaymentCategoryID,ChequeType,IsIssued,OrderStatus,IssueDateTime")] CheckManagment checkManagment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkManagment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(checkManagment);
        }

        // GET: CheckManagments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckManagment checkManagment = db.CheckManagments.Find(id);
            if (checkManagment == null)
            {
                return HttpNotFound();
            }
            return View(checkManagment);
        }

        // POST: CheckManagments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CheckManagment checkManagment = db.CheckManagments.Find(id);
            db.CheckManagments.Remove(checkManagment);
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
