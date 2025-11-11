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
    public class RelatedPartyRolesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartyRoles
        public ActionResult Index()
        {
            return View(db.RelatedPartyRoles.ToList());
        }

        // GET: RelatedPartyRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyRole relatedPartyRole = db.RelatedPartyRoles.Find(id);
            if (relatedPartyRole == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyRole);
        }

        // GET: RelatedPartyRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartyRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RelatedPartyRoleName,RelatedPartyRoleDescription,RelatedPartyRoleCode")] RelatedPartyRole relatedPartyRole)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartyRoles.Add(relatedPartyRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartyRole);
        }

        // GET: RelatedPartyRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyRole relatedPartyRole = db.RelatedPartyRoles.Find(id);
            if (relatedPartyRole == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyRole);
        }

        // POST: RelatedPartyRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RelatedPartyRoleName,RelatedPartyRoleDescription,RelatedPartyRoleCode")] RelatedPartyRole relatedPartyRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartyRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartyRole);
        }

        // GET: RelatedPartyRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartyRole relatedPartyRole = db.RelatedPartyRoles.Find(id);
            if (relatedPartyRole == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartyRole);
        }

        // POST: RelatedPartyRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartyRole relatedPartyRole = db.RelatedPartyRoles.Find(id);
            db.RelatedPartyRoles.Remove(relatedPartyRole);
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
