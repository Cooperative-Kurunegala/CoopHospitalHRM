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
    public class DayTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: DayTypes
        public ActionResult Index()
        {
            return View(db.DayTypes.ToList());
        }

        // GET: DayTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DayType dayType = db.DayTypes.Find(id);
            if (dayType == null)
            {
                return HttpNotFound();
            }
            return View(dayType);
        }

        // GET: DayTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DayTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DayTypeName,ShiftID")] DayType dayType)
        {
            if (ModelState.IsValid)
            {
                db.DayTypes.Add(dayType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dayType);
        }

        // GET: DayTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DayType dayType = db.DayTypes.Find(id);
            if (dayType == null)
            {
                return HttpNotFound();
            }
            return View(dayType);
        }

        // POST: DayTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DayTypeName,ShiftID")] DayType dayType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dayType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dayType);
        }

        // GET: DayTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DayType dayType = db.DayTypes.Find(id);
            if (dayType == null)
            {
                return HttpNotFound();
            }
            return View(dayType);
        }

        // POST: DayTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DayType dayType = db.DayTypes.Find(id);
            db.DayTypes.Remove(dayType);
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
