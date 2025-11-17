using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HR_Application_CO_OP_HOS.Models;
using HR_Application_CO_OP_HOS.Models.ViewModels;

namespace HR_Application_CO_OP_HOS.Controllers
{
    public class LeavesController : Controller
    {
        private HospitalHRDataEntities db = new HospitalHRDataEntities();

        // GET: Leaves
        public ActionResult Index()
        {
            var model = (from l in db.Leaves
                         join e in db.Employees on l.EmployeeID equals e.EmployeeID
                         join t in db.LeaveTypes on l.LeaveTypeID equals t.LeaveTypeID
                         select new LeaveIndexViewModel
                         {
                             LeaveID = l.LeaveID,
                             EmployeeFullName = e.FullName,
                             LeaveTypeName = t.LeaveTypeName,
                             StartDate = l.StartDate,
                             EndDate = l.EndDate,
                             TotalDays = l.TotalDays,
                             Status = l.Status
                         }).ToList();

            return View(model);
        }

        // GET: Leaves/Details/5
        // Replace the existing Details action with this implementation
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var vm = (from l in db.Leaves
                      join e in db.Employees on l.EmployeeID equals e.EmployeeID into ej
                      from e in ej.DefaultIfEmpty()
                      join t in db.LeaveTypes on l.LeaveTypeID equals t.LeaveTypeID into tj
                      from t in tj.DefaultIfEmpty()
                      join c in db.LeaveCategories on l.LeaveCategoryID equals c.LeaveCategoryID into cj
                      from c in cj.DefaultIfEmpty()
                      join ap in db.Employees on l.ApprovedBy equals ap.EmployeeID into apj
                      from ap in apj.DefaultIfEmpty()
                      join cb in db.Employees on l.CreatedBy equals cb.EmployeeID into cbj
                      from cb in cbj.DefaultIfEmpty()
                      where l.LeaveID == id.Value
                      select new HR_Application_CO_OP_HOS.Models.ViewModels.LeaveDetailsViewModel
                      {
                          LeaveID = l.LeaveID,
                          EmployeeFullName = e != null ? e.FullName : null,
                          LeaveTypeName = t != null ? t.LeaveTypeName : null,
                          LeaveCategoryName = c != null ? c.CategoryName : null,
                          Status = l.Status,
                          StartDate = l.StartDate,
                          EndDate = l.EndDate,
                          TotalDays = l.TotalDays,
                          MedicalCertificate = l.MedicalCertificate,
                          CertificatePath = l.CertificatePath,
                          Reason = l.Reason,
                          RejectionReason = l.RejectionReason,
                          ApprovedByFullName = ap != null ? ap.FullName : null,
                          ApprovedDate = l.ApprovedDate,
                          CreatedDate = l.CreatedDate,
                          CreatedByFullName = cb != null ? cb.FullName : null
                      }).FirstOrDefault();

            if (vm == null)
            {
                return HttpNotFound();
            }

            return View(vm);
        }

        // GET: Leaves/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leaves/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeaveID,EmployeeID,LeaveTypeID,LeaveCategoryID,StartDate,EndDate,TotalDays,Reason,MedicalCertificate,CertificatePath,Status,ApprovedBy,ApprovedDate,RejectionReason,CreatedDate,CreatedBy")] Leaf leaf)
        {
            if (ModelState.IsValid)
            {
                db.Leaves.Add(leaf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leaf);
        }

        // GET: Leaves/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leaf leaf = db.Leaves.Find(id);
            if (leaf == null)
            {
                return HttpNotFound();
            }
            return View(leaf);
        }

        // POST: Leaves/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeaveID,EmployeeID,LeaveTypeID,LeaveCategoryID,StartDate,EndDate,TotalDays,Reason,MedicalCertificate,CertificatePath,Status,ApprovedBy,ApprovedDate,RejectionReason,CreatedDate,CreatedBy")] Leaf leaf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leaf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leaf);
        }

        // GET: Leaves/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var vm = (from l in db.Leaves
                      join e in db.Employees on l.EmployeeID equals e.EmployeeID into ej
                      from e in ej.DefaultIfEmpty()
                      join t in db.LeaveTypes on l.LeaveTypeID equals t.LeaveTypeID into tj
                      from t in tj.DefaultIfEmpty()
                      join c in db.LeaveCategories on l.LeaveCategoryID equals c.LeaveCategoryID into cj
                      from c in cj.DefaultIfEmpty()
                      join ap in db.Employees on l.ApprovedBy equals ap.EmployeeID into apj
                      from ap in apj.DefaultIfEmpty()
                      join cb in db.Employees on l.CreatedBy equals cb.EmployeeID into cbj
                      from cb in cbj.DefaultIfEmpty()
                      where l.LeaveID == id.Value
                      select new HR_Application_CO_OP_HOS.Models.ViewModels.LeaveDetailsViewModel
                      {
                          LeaveID = l.LeaveID,
                          EmployeeFullName = e != null ? e.FullName : null,
                          LeaveTypeName = t != null ? t.LeaveTypeName : null,
                          LeaveCategoryName = c != null ? c.CategoryName : null,
                          Status = l.Status,
                          StartDate = l.StartDate,
                          EndDate = l.EndDate,
                          TotalDays = l.TotalDays,
                          MedicalCertificate = l.MedicalCertificate,
                          CertificatePath = l.CertificatePath,
                          Reason = l.Reason,
                          RejectionReason = l.RejectionReason,
                          ApprovedByFullName = ap != null ? ap.FullName : null,
                          ApprovedDate = l.ApprovedDate,
                          CreatedDate = l.CreatedDate,
                          CreatedByFullName = cb != null ? cb.FullName : null
                      }).FirstOrDefault();

            if (vm == null)
            {
                return HttpNotFound();
            }

            return View(vm);
        }

        // POST: Leaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Leaf leaf = db.Leaves.Find(id);
            db.Leaves.Remove(leaf);
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