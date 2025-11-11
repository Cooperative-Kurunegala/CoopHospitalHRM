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
    public class PayMonthMastersController : Controller
    {
        private HREntities db = new HREntities();

        // GET: PayMonthMasters
        public ActionResult Index()
        {
            return View(db.PayMonthMasters.ToList());
        }

        // GET: PayMonthMasters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayMonthMaster payMonthMaster = db.PayMonthMasters.Find(id);
            if (payMonthMaster == null)
            {
                return HttpNotFound();
            }
            return View(payMonthMaster);
        }

        // GET: PayMonthMasters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayMonthMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PayMonth,PayYear,StartDate,EndDate,isCurrentMonth,CreatedBy,CreatedDateTime,isProcessed")] PayMonthMaster payMonthMaster)
        {
            if (ModelState.IsValid)
            {
                db.PayMonthMasters.Add(payMonthMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(payMonthMaster);
        }

        // GET: PayMonthMasters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayMonthMaster payMonthMaster = db.PayMonthMasters.Find(id);
            if (payMonthMaster == null)
            {
                return HttpNotFound();
            }
            return View(payMonthMaster);
        }

        // POST: PayMonthMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PayMonth,PayYear,StartDate,EndDate,isCurrentMonth,CreatedBy,CreatedDateTime,isProcessed")] PayMonthMaster payMonthMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payMonthMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(payMonthMaster);
        }

        // GET: PayMonthMasters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayMonthMaster payMonthMaster = db.PayMonthMasters.Find(id);
            if (payMonthMaster == null)
            {
                return HttpNotFound();
            }
            return View(payMonthMaster);
        }

        // POST: PayMonthMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PayMonthMaster payMonthMaster = db.PayMonthMasters.Find(id);
            db.PayMonthMasters.Remove(payMonthMaster);
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
