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
    public class LogDetailsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: LogDetails
        public ActionResult Index()
        {
            return View(db.LogDetails.ToList());
        }

        // GET: LogDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LogDetail logDetail = db.LogDetails.Find(id);
            if (logDetail == null)
            {
                return HttpNotFound();
            }
            return View(logDetail);
        }

        // GET: LogDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,log_date,usr_sys_code,RelatedID,RelatedTable,log_desc,log_event")] LogDetail logDetail)
        {
            if (ModelState.IsValid)
            {
                db.LogDetails.Add(logDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(logDetail);
        }

        // GET: LogDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LogDetail logDetail = db.LogDetails.Find(id);
            if (logDetail == null)
            {
                return HttpNotFound();
            }
            return View(logDetail);
        }

        // POST: LogDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,log_date,usr_sys_code,RelatedID,RelatedTable,log_desc,log_event")] LogDetail logDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(logDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logDetail);
        }

        // GET: LogDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LogDetail logDetail = db.LogDetails.Find(id);
            if (logDetail == null)
            {
                return HttpNotFound();
            }
            return View(logDetail);
        }

        // POST: LogDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LogDetail logDetail = db.LogDetails.Find(id);
            db.LogDetails.Remove(logDetail);
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
