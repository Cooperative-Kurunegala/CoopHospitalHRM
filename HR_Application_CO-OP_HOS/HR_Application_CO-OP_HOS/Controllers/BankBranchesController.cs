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
    public class BankBranchesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: BankBranches
        public ActionResult Index()
        {
            return View(db.BankBranches.ToList());
        }

        // GET: BankBranches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankBranch bankBranch = db.BankBranches.Find(id);
            if (bankBranch == null)
            {
                return HttpNotFound();
            }
            return View(bankBranch);
        }

        // GET: BankBranches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankBranches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BranchName,BankID,BranchCode,IsEnabled,CreatedDate,CreatedBy")] BankBranch bankBranch)
        {
            if (ModelState.IsValid)
            {
                db.BankBranches.Add(bankBranch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankBranch);
        }

        // GET: BankBranches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankBranch bankBranch = db.BankBranches.Find(id);
            if (bankBranch == null)
            {
                return HttpNotFound();
            }
            return View(bankBranch);
        }

        // POST: BankBranches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,BranchName,BankID,BranchCode,IsEnabled,CreatedDate,CreatedBy")] BankBranch bankBranch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankBranch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankBranch);
        }

        // GET: BankBranches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankBranch bankBranch = db.BankBranches.Find(id);
            if (bankBranch == null)
            {
                return HttpNotFound();
            }
            return View(bankBranch);
        }

        // POST: BankBranches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BankBranch bankBranch = db.BankBranches.Find(id);
            db.BankBranches.Remove(bankBranch);
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
