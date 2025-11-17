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
    public class PerformanceAppraisalsController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: PerformanceAppraisals
        public ActionResult Index()
        {
            return View(db.PerformanceAppraisals.ToList());
        }

        // GET: PerformanceAppraisals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerformanceAppraisal performanceAppraisal = db.PerformanceAppraisals.Find(id);
            if (performanceAppraisal == null)
            {
                return HttpNotFound();
            }
            return View(performanceAppraisal);
        }

        // GET: PerformanceAppraisals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerformanceAppraisals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AppraisalID,EmployeeID,AppraisalDate,AppraisalPeriod,OverallRating,RatingScale,Strengths,AreasForImprovement,Goals,AppraisedBy,NextAppraisalDate,Remarks")] PerformanceAppraisal performanceAppraisal)
        {
            if (ModelState.IsValid)
            {
                db.PerformanceAppraisals.Add(performanceAppraisal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(performanceAppraisal);
        }

        // GET: PerformanceAppraisals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerformanceAppraisal performanceAppraisal = db.PerformanceAppraisals.Find(id);
            if (performanceAppraisal == null)
            {
                return HttpNotFound();
            }
            return View(performanceAppraisal);
        }

        // POST: PerformanceAppraisals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AppraisalID,EmployeeID,AppraisalDate,AppraisalPeriod,OverallRating,RatingScale,Strengths,AreasForImprovement,Goals,AppraisedBy,NextAppraisalDate,Remarks")] PerformanceAppraisal performanceAppraisal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(performanceAppraisal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(performanceAppraisal);
        }

        // GET: PerformanceAppraisals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerformanceAppraisal performanceAppraisal = db.PerformanceAppraisals.Find(id);
            if (performanceAppraisal == null)
            {
                return HttpNotFound();
            }
            return View(performanceAppraisal);
        }

        // POST: PerformanceAppraisals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PerformanceAppraisal performanceAppraisal = db.PerformanceAppraisals.Find(id);
            db.PerformanceAppraisals.Remove(performanceAppraisal);
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
