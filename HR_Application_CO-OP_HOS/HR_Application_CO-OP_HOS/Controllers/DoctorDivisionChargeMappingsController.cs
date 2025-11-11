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
    public class DoctorDivisionChargeMappingsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: DoctorDivisionChargeMappings
        public ActionResult Index()
        {
            return View(db.DoctorDivisionChargeMappings.ToList());
        }

        // GET: DoctorDivisionChargeMappings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorDivisionChargeMapping doctorDivisionChargeMapping = db.DoctorDivisionChargeMappings.Find(id);
            if (doctorDivisionChargeMapping == null)
            {
                return HttpNotFound();
            }
            return View(doctorDivisionChargeMapping);
        }

        // GET: DoctorDivisionChargeMappings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorDivisionChargeMappings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DoctorID,DivisionChargeID,DivisionMasterID,DoctorCharge,HospitalCharge,WardDoctorCharge,TechnicianCharge")] DoctorDivisionChargeMapping doctorDivisionChargeMapping)
        {
            if (ModelState.IsValid)
            {
                db.DoctorDivisionChargeMappings.Add(doctorDivisionChargeMapping);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctorDivisionChargeMapping);
        }

        // GET: DoctorDivisionChargeMappings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorDivisionChargeMapping doctorDivisionChargeMapping = db.DoctorDivisionChargeMappings.Find(id);
            if (doctorDivisionChargeMapping == null)
            {
                return HttpNotFound();
            }
            return View(doctorDivisionChargeMapping);
        }

        // POST: DoctorDivisionChargeMappings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DoctorID,DivisionChargeID,DivisionMasterID,DoctorCharge,HospitalCharge,WardDoctorCharge,TechnicianCharge")] DoctorDivisionChargeMapping doctorDivisionChargeMapping)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorDivisionChargeMapping).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorDivisionChargeMapping);
        }

        // GET: DoctorDivisionChargeMappings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorDivisionChargeMapping doctorDivisionChargeMapping = db.DoctorDivisionChargeMappings.Find(id);
            if (doctorDivisionChargeMapping == null)
            {
                return HttpNotFound();
            }
            return View(doctorDivisionChargeMapping);
        }

        // POST: DoctorDivisionChargeMappings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorDivisionChargeMapping doctorDivisionChargeMapping = db.DoctorDivisionChargeMappings.Find(id);
            db.DoctorDivisionChargeMappings.Remove(doctorDivisionChargeMapping);
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
