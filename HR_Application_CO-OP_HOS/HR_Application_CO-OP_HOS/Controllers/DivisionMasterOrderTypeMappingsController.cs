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
    public class DivisionMasterOrderTypeMappingsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: DivisionMasterOrderTypeMappings
        public ActionResult Index()
        {
            return View(db.DivisionMasterOrderTypeMappings.ToList());
        }

        // GET: DivisionMasterOrderTypeMappings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping = db.DivisionMasterOrderTypeMappings.Find(id);
            if (divisionMasterOrderTypeMapping == null)
            {
                return HttpNotFound();
            }
            return View(divisionMasterOrderTypeMapping);
        }

        // GET: DivisionMasterOrderTypeMappings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DivisionMasterOrderTypeMappings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DivisionMasterID,OrderTypeID,LocationID,OrderSequence")] DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping)
        {
            if (ModelState.IsValid)
            {
                db.DivisionMasterOrderTypeMappings.Add(divisionMasterOrderTypeMapping);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(divisionMasterOrderTypeMapping);
        }

        // GET: DivisionMasterOrderTypeMappings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping = db.DivisionMasterOrderTypeMappings.Find(id);
            if (divisionMasterOrderTypeMapping == null)
            {
                return HttpNotFound();
            }
            return View(divisionMasterOrderTypeMapping);
        }

        // POST: DivisionMasterOrderTypeMappings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DivisionMasterID,OrderTypeID,LocationID,OrderSequence")] DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping)
        {
            if (ModelState.IsValid)
            {
                db.Entry(divisionMasterOrderTypeMapping).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(divisionMasterOrderTypeMapping);
        }

        // GET: DivisionMasterOrderTypeMappings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping = db.DivisionMasterOrderTypeMappings.Find(id);
            if (divisionMasterOrderTypeMapping == null)
            {
                return HttpNotFound();
            }
            return View(divisionMasterOrderTypeMapping);
        }

        // POST: DivisionMasterOrderTypeMappings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DivisionMasterOrderTypeMapping divisionMasterOrderTypeMapping = db.DivisionMasterOrderTypeMappings.Find(id);
            db.DivisionMasterOrderTypeMappings.Remove(divisionMasterOrderTypeMapping);
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
