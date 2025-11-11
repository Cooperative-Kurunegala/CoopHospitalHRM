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
    public class RelatedPartiesController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedParties
        public ActionResult Index()
        {
            var relatedParties = db.RelatedParties.Include(r => r.RelatedPartyType);
            return View(relatedParties.ToList());
        }

        // GET: RelatedParties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedParty relatedParty = db.RelatedParties.Find(id);
            if (relatedParty == null)
            {
                return HttpNotFound();
            }
            return View(relatedParty);
        }

        // GET: RelatedParties/Create
        public ActionResult Create()
        {
            ViewBag.RelatedPartyTypeID = new SelectList(db.RelatedPartyTypes, "ID", "RelatedPartyTypeName");
            return View();
        }

        // POST: RelatedParties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RegistrationNumber,RelatedPartyName,RelatedPartyAddress,RelatedPartyNIC,DateOfBirth,Gender,DivisionMasterID,RelatedPartyTypeID,DesignationID,RelatedPartyCategoryID,CompanyID,RegisteredDate,TelephoneNumberList,MobileNoList,DateofJoin,DateofResignation,UserName,RelatedPartyPassword,RelatedPartyRoleID,DefaultSplashScreenItemID,LocationID,Weight,Height,IsDivisionHead,BasicSalary,RelatedPartyEmail,IsActive,CompanyName,ContactPerson,DiscountAppliedDate,IsDiscountApplicable,DailyPaidAmount,ChannellingConsultantCharge,ChannellingHospitalCharge,Age,RelatedPartySubCategoryID,WardHospitalCharge,StaffID,MotherCompanyID,Designation,RoomID,BudgetAllowance,BOIAllowance,ManagementAllowance,UniformAllowance,TravelAllowance,ISresigned,AttendanceIncentive,RelatedPartyTitle,PerformanceIncentive,VendorId,OpeningBalance,OpeningBalanceDate,HostelFee,InTime,OutTime,IsSetforPayroll,PayeeTaxID,IsRosterAvailable,Initials,LastName,RosterType,RosterID")] RelatedParty relatedParty)
        {
            if (ModelState.IsValid)
            {
                db.RelatedParties.Add(relatedParty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RelatedPartyTypeID = new SelectList(db.RelatedPartyTypes, "ID", "RelatedPartyTypeName", relatedParty.RelatedPartyTypeID);
            return View(relatedParty);
        }

        // GET: RelatedParties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedParty relatedParty = db.RelatedParties.Find(id);
            if (relatedParty == null)
            {
                return HttpNotFound();
            }
            ViewBag.RelatedPartyTypeID = new SelectList(db.RelatedPartyTypes, "ID", "RelatedPartyTypeName", relatedParty.RelatedPartyTypeID);
            return View(relatedParty);
        }

        // POST: RelatedParties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RegistrationNumber,RelatedPartyName,RelatedPartyAddress,RelatedPartyNIC,DateOfBirth,Gender,DivisionMasterID,RelatedPartyTypeID,DesignationID,RelatedPartyCategoryID,CompanyID,RegisteredDate,TelephoneNumberList,MobileNoList,DateofJoin,DateofResignation,UserName,RelatedPartyPassword,RelatedPartyRoleID,DefaultSplashScreenItemID,LocationID,Weight,Height,IsDivisionHead,BasicSalary,RelatedPartyEmail,IsActive,CompanyName,ContactPerson,DiscountAppliedDate,IsDiscountApplicable,DailyPaidAmount,ChannellingConsultantCharge,ChannellingHospitalCharge,Age,RelatedPartySubCategoryID,WardHospitalCharge,StaffID,MotherCompanyID,Designation,RoomID,BudgetAllowance,BOIAllowance,ManagementAllowance,UniformAllowance,TravelAllowance,ISresigned,AttendanceIncentive,RelatedPartyTitle,PerformanceIncentive,VendorId,OpeningBalance,OpeningBalanceDate,HostelFee,InTime,OutTime,IsSetforPayroll,PayeeTaxID,IsRosterAvailable,Initials,LastName,RosterType,RosterID")] RelatedParty relatedParty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedParty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RelatedPartyTypeID = new SelectList(db.RelatedPartyTypes, "ID", "RelatedPartyTypeName", relatedParty.RelatedPartyTypeID);
            return View(relatedParty);
        }

        // GET: RelatedParties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedParty relatedParty = db.RelatedParties.Find(id);
            if (relatedParty == null)
            {
                return HttpNotFound();
            }
            return View(relatedParty);
        }

        // POST: RelatedParties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedParty relatedParty = db.RelatedParties.Find(id);
            db.RelatedParties.Remove(relatedParty);
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
