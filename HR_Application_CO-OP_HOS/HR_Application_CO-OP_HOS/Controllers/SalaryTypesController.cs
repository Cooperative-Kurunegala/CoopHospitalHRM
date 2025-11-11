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
    public class SalaryTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: SalaryTypes
        public ActionResult Index()
        {
            return View(db.SalaryTypes.ToList());
        }

        // GET: SalaryTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryType salaryType = db.SalaryTypes.Find(id);
            if (salaryType == null)
            {
                return HttpNotFound();
            }
            return View(salaryType);
        }

        // GET: SalaryTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalaryTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SalaryTypeName,CreatedDate,CreatedBy")] SalaryType salaryType)
        {
            if (ModelState.IsValid)
            {
                db.SalaryTypes.Add(salaryType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salaryType);
        }

        // GET: SalaryTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryType salaryType = db.SalaryTypes.Find(id);
            if (salaryType == null)
            {
                return HttpNotFound();
            }
            return View(salaryType);
        }

        // POST: SalaryTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SalaryTypeName,CreatedDate,CreatedBy")] SalaryType salaryType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salaryType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salaryType);
        }

        // GET: SalaryTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryType salaryType = db.SalaryTypes.Find(id);
            if (salaryType == null)
            {
                return HttpNotFound();
            }
            return View(salaryType);
        }

        // POST: SalaryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalaryType salaryType = db.SalaryTypes.Find(id);
            db.SalaryTypes.Remove(salaryType);
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
