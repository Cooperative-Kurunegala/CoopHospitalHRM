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
    public class ChargeItemListsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: ChargeItemLists
        public ActionResult Index()
        {
            return View(db.ChargeItemLists.ToList());
        }

        // GET: ChargeItemLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeItemList chargeItemList = db.ChargeItemLists.Find(id);
            if (chargeItemList == null)
            {
                return HttpNotFound();
            }
            return View(chargeItemList);
        }

        // GET: ChargeItemLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChargeItemLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Type")] ChargeItemList chargeItemList)
        {
            if (ModelState.IsValid)
            {
                db.ChargeItemLists.Add(chargeItemList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chargeItemList);
        }

        // GET: ChargeItemLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeItemList chargeItemList = db.ChargeItemLists.Find(id);
            if (chargeItemList == null)
            {
                return HttpNotFound();
            }
            return View(chargeItemList);
        }

        // POST: ChargeItemLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Type")] ChargeItemList chargeItemList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chargeItemList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chargeItemList);
        }

        // GET: ChargeItemLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeItemList chargeItemList = db.ChargeItemLists.Find(id);
            if (chargeItemList == null)
            {
                return HttpNotFound();
            }
            return View(chargeItemList);
        }

        // POST: ChargeItemLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChargeItemList chargeItemList = db.ChargeItemLists.Find(id);
            db.ChargeItemLists.Remove(chargeItemList);
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
