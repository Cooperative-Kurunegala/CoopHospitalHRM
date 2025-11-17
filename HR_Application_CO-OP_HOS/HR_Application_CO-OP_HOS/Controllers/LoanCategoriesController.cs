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
    public class LoanCategoriesController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: LoanCategories
        public ActionResult Index()
        {
            return View(db.LoanCategories.ToList());
        }

        // GET: LoanCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanCategory loanCategory = db.LoanCategories.Find(id);
            if (loanCategory == null)
            {
                return HttpNotFound();
            }
            return View(loanCategory);
        }

        // GET: LoanCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoanCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoanCategoryID,CategoryName,MaxAmount,InterestRate,MaxInstallments,IsActive")] LoanCategory loanCategory)
        {
            if (ModelState.IsValid)
            {
                db.LoanCategories.Add(loanCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanCategory);
        }

        // GET: LoanCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanCategory loanCategory = db.LoanCategories.Find(id);
            if (loanCategory == null)
            {
                return HttpNotFound();
            }
            return View(loanCategory);
        }

        // POST: LoanCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoanCategoryID,CategoryName,MaxAmount,InterestRate,MaxInstallments,IsActive")] LoanCategory loanCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanCategory);
        }

        // GET: LoanCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanCategory loanCategory = db.LoanCategories.Find(id);
            if (loanCategory == null)
            {
                return HttpNotFound();
            }
            return View(loanCategory);
        }

        // POST: LoanCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanCategory loanCategory = db.LoanCategories.Find(id);
            db.LoanCategories.Remove(loanCategory);
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
