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
    public class LeaveCategoriesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: LeaveCategories
        public ActionResult Index()
        {
            return View(db.LeaveCategories.ToList());
        }

        // GET: LeaveCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveCategory leaveCategory = db.LeaveCategories.Find(id);
            if (leaveCategory == null)
            {
                return HttpNotFound();
            }
            return View(leaveCategory);
        }

        // GET: LeaveCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CategoryName,LeaveCode")] LeaveCategory leaveCategory)
        {
            if (ModelState.IsValid)
            {
                db.LeaveCategories.Add(leaveCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leaveCategory);
        }

        // GET: LeaveCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveCategory leaveCategory = db.LeaveCategories.Find(id);
            if (leaveCategory == null)
            {
                return HttpNotFound();
            }
            return View(leaveCategory);
        }

        // POST: LeaveCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CategoryName,LeaveCode")] LeaveCategory leaveCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leaveCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leaveCategory);
        }

        // GET: LeaveCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveCategory leaveCategory = db.LeaveCategories.Find(id);
            if (leaveCategory == null)
            {
                return HttpNotFound();
            }
            return View(leaveCategory);
        }

        // POST: LeaveCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeaveCategory leaveCategory = db.LeaveCategories.Find(id);
            db.LeaveCategories.Remove(leaveCategory);
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
