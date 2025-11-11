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
    public class AdmissionTypesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: AdmissionTypes
        public ActionResult Index()
        {
            return View(db.AdmissionTypes.ToList());
        }

        // GET: AdmissionTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdmissionType admissionType = db.AdmissionTypes.Find(id);
            if (admissionType == null)
            {
                return HttpNotFound();
            }
            return View(admissionType);
        }

        // GET: AdmissionTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmissionTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AdmissionTypeName,AdmissionTypeDescription,AdmissionTypeSequence,AdmissionTypeCode")] AdmissionType admissionType)
        {
            if (ModelState.IsValid)
            {
                db.AdmissionTypes.Add(admissionType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admissionType);
        }

        // GET: AdmissionTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdmissionType admissionType = db.AdmissionTypes.Find(id);
            if (admissionType == null)
            {
                return HttpNotFound();
            }
            return View(admissionType);
        }

        // POST: AdmissionTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AdmissionTypeName,AdmissionTypeDescription,AdmissionTypeSequence,AdmissionTypeCode")] AdmissionType admissionType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admissionType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admissionType);
        }

        // GET: AdmissionTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdmissionType admissionType = db.AdmissionTypes.Find(id);
            if (admissionType == null)
            {
                return HttpNotFound();
            }
            return View(admissionType);
        }

        // POST: AdmissionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdmissionType admissionType = db.AdmissionTypes.Find(id);
            db.AdmissionTypes.Remove(admissionType);
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
