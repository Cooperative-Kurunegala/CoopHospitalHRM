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
    public class SalaryModifierTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: SalaryModifierTypes
        public ActionResult Index()
        {
            return View(db.SalaryModifierTypes.ToList());
        }

        // GET: SalaryModifierTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryModifierType salaryModifierType = db.SalaryModifierTypes.Find(id);
            if (salaryModifierType == null)
            {
                return HttpNotFound();
            }
            return View(salaryModifierType);
        }

        // GET: SalaryModifierTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalaryModifierTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SalaryModifierTypeName,Type,GroupsForPlaySlip,CreatedDate,CreatedBy,DigitalSign")] SalaryModifierType salaryModifierType)
        {
            if (ModelState.IsValid)
            {
                db.SalaryModifierTypes.Add(salaryModifierType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salaryModifierType);
        }

        // GET: SalaryModifierTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryModifierType salaryModifierType = db.SalaryModifierTypes.Find(id);
            if (salaryModifierType == null)
            {
                return HttpNotFound();
            }
            return View(salaryModifierType);
        }

        // POST: SalaryModifierTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SalaryModifierTypeName,Type,GroupsForPlaySlip,CreatedDate,CreatedBy,DigitalSign")] SalaryModifierType salaryModifierType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salaryModifierType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salaryModifierType);
        }

        // GET: SalaryModifierTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryModifierType salaryModifierType = db.SalaryModifierTypes.Find(id);
            if (salaryModifierType == null)
            {
                return HttpNotFound();
            }
            return View(salaryModifierType);
        }

        // POST: SalaryModifierTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalaryModifierType salaryModifierType = db.SalaryModifierTypes.Find(id);
            db.SalaryModifierTypes.Remove(salaryModifierType);
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
