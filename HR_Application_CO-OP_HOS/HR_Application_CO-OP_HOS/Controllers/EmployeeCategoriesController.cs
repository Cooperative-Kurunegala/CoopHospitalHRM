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
    public class EmployeeCategoriesController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: EmployeeCategories
        public ActionResult Index()
        {
            return View(db.EmployeeCategories.ToList());
        }

        // GET: EmployeeCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCategory employeeCategory = db.EmployeeCategories.Find(id);
            if (employeeCategory == null)
            {
                return HttpNotFound();
            }
            return View(employeeCategory);
        }

        // GET: EmployeeCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryID,CategoryName,Description")] EmployeeCategory employeeCategory)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeCategories.Add(employeeCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeCategory);
        }

        // GET: EmployeeCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCategory employeeCategory = db.EmployeeCategories.Find(id);
            if (employeeCategory == null)
            {
                return HttpNotFound();
            }
            return View(employeeCategory);
        }

        // POST: EmployeeCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryID,CategoryName,Description")] EmployeeCategory employeeCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeCategory);
        }

        // GET: EmployeeCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCategory employeeCategory = db.EmployeeCategories.Find(id);
            if (employeeCategory == null)
            {
                return HttpNotFound();
            }
            return View(employeeCategory);
        }

        // POST: EmployeeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeCategory employeeCategory = db.EmployeeCategories.Find(id);
            db.EmployeeCategories.Remove(employeeCategory);
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
