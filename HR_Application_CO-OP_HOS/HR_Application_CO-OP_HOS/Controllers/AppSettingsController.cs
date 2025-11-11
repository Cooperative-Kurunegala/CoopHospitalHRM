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
    public class AppSettingsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: AppSettings
        public ActionResult Index()
        {
            return View(db.AppSettings.ToList());
        }

        // GET: AppSettings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppSetting appSetting = db.AppSettings.Find(id);
            if (appSetting == null)
            {
                return HttpNotFound();
            }
            return View(appSetting);
        }

        // GET: AppSettings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AppSettingKey,AppSettingValue")] AppSetting appSetting)
        {
            if (ModelState.IsValid)
            {
                db.AppSettings.Add(appSetting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appSetting);
        }

        // GET: AppSettings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppSetting appSetting = db.AppSettings.Find(id);
            if (appSetting == null)
            {
                return HttpNotFound();
            }
            return View(appSetting);
        }

        // POST: AppSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AppSettingKey,AppSettingValue")] AppSetting appSetting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appSetting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appSetting);
        }

        // GET: AppSettings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppSetting appSetting = db.AppSettings.Find(id);
            if (appSetting == null)
            {
                return HttpNotFound();
            }
            return View(appSetting);
        }

        // POST: AppSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppSetting appSetting = db.AppSettings.Find(id);
            db.AppSettings.Remove(appSetting);
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
