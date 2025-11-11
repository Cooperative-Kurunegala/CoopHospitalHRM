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
    public class MenuConfigurationsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: MenuConfigurations
        public ActionResult Index()
        {
            return View(db.MenuConfigurations.ToList());
        }

        // GET: MenuConfigurations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuConfiguration menuConfiguration = db.MenuConfigurations.Find(id);
            if (menuConfiguration == null)
            {
                return HttpNotFound();
            }
            return View(menuConfiguration);
        }

        // GET: MenuConfigurations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuConfigurations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MenuItemName,MenuItemDescription,ParentMenuItemID,MenuLevel,MenuItemControlName,UIType,MenuTypeID,MenuTypeDetailID,SplashScreenItemID,OrderIndex,DivisionMasterID,ChargeTypeID,RelatedPartyTypeID,OrderTypeID,IsSellWardPharmacyPrice,AdmissionTypeID")] MenuConfiguration menuConfiguration)
        {
            if (ModelState.IsValid)
            {
                db.MenuConfigurations.Add(menuConfiguration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuConfiguration);
        }

        // GET: MenuConfigurations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuConfiguration menuConfiguration = db.MenuConfigurations.Find(id);
            if (menuConfiguration == null)
            {
                return HttpNotFound();
            }
            return View(menuConfiguration);
        }

        // POST: MenuConfigurations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MenuItemName,MenuItemDescription,ParentMenuItemID,MenuLevel,MenuItemControlName,UIType,MenuTypeID,MenuTypeDetailID,SplashScreenItemID,OrderIndex,DivisionMasterID,ChargeTypeID,RelatedPartyTypeID,OrderTypeID,IsSellWardPharmacyPrice,AdmissionTypeID")] MenuConfiguration menuConfiguration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuConfiguration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuConfiguration);
        }

        // GET: MenuConfigurations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuConfiguration menuConfiguration = db.MenuConfigurations.Find(id);
            if (menuConfiguration == null)
            {
                return HttpNotFound();
            }
            return View(menuConfiguration);
        }

        // POST: MenuConfigurations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuConfiguration menuConfiguration = db.MenuConfigurations.Find(id);
            db.MenuConfigurations.Remove(menuConfiguration);
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
