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
    public class OrderTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: OrderTypes
        public ActionResult Index()
        {
            return View(db.OrderTypes.ToList());
        }

        // GET: OrderTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderType orderType = db.OrderTypes.Find(id);
            if (orderType == null)
            {
                return HttpNotFound();
            }
            return View(orderType);
        }

        // GET: OrderTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OrderTypeName,OrderSequence,OrderTypeCode")] OrderType orderType)
        {
            if (ModelState.IsValid)
            {
                db.OrderTypes.Add(orderType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderType);
        }

        // GET: OrderTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderType orderType = db.OrderTypes.Find(id);
            if (orderType == null)
            {
                return HttpNotFound();
            }
            return View(orderType);
        }

        // POST: OrderTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OrderTypeName,OrderSequence,OrderTypeCode")] OrderType orderType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderType);
        }

        // GET: OrderTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderType orderType = db.OrderTypes.Find(id);
            if (orderType == null)
            {
                return HttpNotFound();
            }
            return View(orderType);
        }

        // POST: OrderTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderType orderType = db.OrderTypes.Find(id);
            db.OrderTypes.Remove(orderType);
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
