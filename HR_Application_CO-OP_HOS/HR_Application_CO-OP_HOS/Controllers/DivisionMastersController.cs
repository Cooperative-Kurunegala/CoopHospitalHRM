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
    public class DivisionMastersController : Controller
    {
        private HREntities db = new HREntities();

        // GET: DivisionMasters
        public ActionResult Index()
        {
            return View(db.DivisionMasters.ToList());
        }

        // GET: DivisionMasters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionMaster divisionMaster = db.DivisionMasters.Find(id);
            if (divisionMaster == null)
            {
                return HttpNotFound();
            }
            return View(divisionMaster);
        }

        // GET: DivisionMasters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DivisionMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DivisionMasterName,DivisionMasterCode,IsActive,MenuTypeID,MenuTypeDetailID,DivisionMasterDescription,IsStockManaged,ParentDivisionMasterID,DivisionMasterTypeID,LocationID,OrderTypeID,OrderSequence,IsReserved,AccoutClassID,AccoutClassCode")] DivisionMaster divisionMaster)
        {
            if (ModelState.IsValid)
            {
                db.DivisionMasters.Add(divisionMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(divisionMaster);
        }

        // GET: DivisionMasters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionMaster divisionMaster = db.DivisionMasters.Find(id);
            if (divisionMaster == null)
            {
                return HttpNotFound();
            }
            return View(divisionMaster);
        }

        // POST: DivisionMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DivisionMasterName,DivisionMasterCode,IsActive,MenuTypeID,MenuTypeDetailID,DivisionMasterDescription,IsStockManaged,ParentDivisionMasterID,DivisionMasterTypeID,LocationID,OrderTypeID,OrderSequence,IsReserved,AccoutClassID,AccoutClassCode")] DivisionMaster divisionMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(divisionMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(divisionMaster);
        }

        // GET: DivisionMasters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionMaster divisionMaster = db.DivisionMasters.Find(id);
            if (divisionMaster == null)
            {
                return HttpNotFound();
            }
            return View(divisionMaster);
        }

        // POST: DivisionMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DivisionMaster divisionMaster = db.DivisionMasters.Find(id);
            db.DivisionMasters.Remove(divisionMaster);
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
