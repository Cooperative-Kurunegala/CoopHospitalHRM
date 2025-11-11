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
    public class RelatedPartySessionsController : Controller
    {
        private HREntities db = new HREntities();

        // GET: RelatedPartySessions
        public ActionResult Index()
        {
            return View(db.RelatedPartySessions.ToList());
        }

        // GET: RelatedPartySessions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySession relatedPartySession = db.RelatedPartySessions.Find(id);
            if (relatedPartySession == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySession);
        }

        // GET: RelatedPartySessions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatedPartySessions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EPF,PayMonth,PayYear,CalendarDay,DayTypeID,CheckInDateTime,CheckOutDateTime,ActualInDateTime,ActualOutDateTime,WorkedMinutes,EarlyInMinutes,LateInMinutes,EarlyOutMinutes,LateOutMinutes,OTMinutes,RelatedPartyID,CompanyID,AdmissionTypeID,AdmissionNumber,LocationID,ReceivedNurse,NurseInChargeAdditional,NurseInCharge,AssistanceNurse,RelatedPartyTyeID,IsHomeVisit,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsNurseInChargeAdditionalSatisfactory,IsNurseInChargeSatisfactory,IsAssistanceNurseSatisfactory,IsReceivedNurseSatisfactory,Consultant,NumberOfNoPayLeaveHours,NoPayleaveDate,IsOTPaid,HomeVisitNurse,LoginBalance,LogoutBalance,RelatedPartySessionNo,UserSessionDivisionMasterID,AppointmentDateTime,SessionStatus,MainConsultant,RoomID,BedID,BillTotal,InsuranceCompanyID,InsuranceCompanyBranchID,OldAdmissionNumber,AdmissionCategoryID,IsWithMeal,IsAirConditioned,VisitReason,Symtoms,Treatments,Comments,RelatedPartySessionTypeID,DrawerBalance,ExcessOrShortage,ActualCashBalance,TotalSales,TotalCancel,TotalReturns,CashBalace,ChannelSales,ScanSales,LabSales,XraySales,Drawer,ProcedureSales,NextSessionID,Discount,RecomendedHours,WorkedDivision,AttendanceStatus,IsRecommended,InvoiceNo,OverInDateTime,OverOutDateTime,RecomendedOTHours,IsSetBillNo,IsAdmissionIncentive,FinalBillTotal,RecomendedLateHours,RecomendedLieuHours,FriendshipBy,RecomendedFriendshipHours,RecomendedCoverdHours,RecomendedExcessHours,FriendshipTo,AdditionalInDateTime,AdditionalOutDateTime,IsOTApproved,ReasonsOfOT,TotalWorkedHours,RecommendHoursBy,RecommendOTHoursBy,TimeSlotID,AppointmentNo,HCGSales,ECGSales,TheatreSales,VoucherPayments,OPDSales,InvoiceSales,RecomendedDoubleOTHrs,IsPosted,IsCancelPosted,PapsmearSale,NoPayValue,LeaveAppliedValue,LateMinutes,ShiftID,ActualWorkedDepartment,ActualShiftID,LeaveStatus,AdditionalLeaveStatus,ActualLeaveStatus,ActualAdditionalLeaveStatus,LeaveCategoryID,LeaveTypeID,IsAttendanceRemoved,WeekDay,InLateCount,OutLateCount,InLateHalfDayDeductionCount,OutLateHalfDayDeductionCount,IsWorked,AdditionalShiftID,AdditionalActualShiftID,AdditionalCheckInDateTime,AdditionalCheckOutDateTime,IsShift,FinalLateCount,LeauLeaveDay,LeauLeaveValue,AdditionalActualCheckInDateTime,AdditionalActualCheckOutDateTime,IsAdditionalShift,AdditionalShiftRelatedOTMinutes,ActualOTHours,ActualWorkedHours")] RelatedPartySession relatedPartySession)
        {
            if (ModelState.IsValid)
            {
                db.RelatedPartySessions.Add(relatedPartySession);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedPartySession);
        }

        // GET: RelatedPartySessions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySession relatedPartySession = db.RelatedPartySessions.Find(id);
            if (relatedPartySession == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySession);
        }

        // POST: RelatedPartySessions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EPF,PayMonth,PayYear,CalendarDay,DayTypeID,CheckInDateTime,CheckOutDateTime,ActualInDateTime,ActualOutDateTime,WorkedMinutes,EarlyInMinutes,LateInMinutes,EarlyOutMinutes,LateOutMinutes,OTMinutes,RelatedPartyID,CompanyID,AdmissionTypeID,AdmissionNumber,LocationID,ReceivedNurse,NurseInChargeAdditional,NurseInCharge,AssistanceNurse,RelatedPartyTyeID,IsHomeVisit,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsNurseInChargeAdditionalSatisfactory,IsNurseInChargeSatisfactory,IsAssistanceNurseSatisfactory,IsReceivedNurseSatisfactory,Consultant,NumberOfNoPayLeaveHours,NoPayleaveDate,IsOTPaid,HomeVisitNurse,LoginBalance,LogoutBalance,RelatedPartySessionNo,UserSessionDivisionMasterID,AppointmentDateTime,SessionStatus,MainConsultant,RoomID,BedID,BillTotal,InsuranceCompanyID,InsuranceCompanyBranchID,OldAdmissionNumber,AdmissionCategoryID,IsWithMeal,IsAirConditioned,VisitReason,Symtoms,Treatments,Comments,RelatedPartySessionTypeID,DrawerBalance,ExcessOrShortage,ActualCashBalance,TotalSales,TotalCancel,TotalReturns,CashBalace,ChannelSales,ScanSales,LabSales,XraySales,Drawer,ProcedureSales,NextSessionID,Discount,RecomendedHours,WorkedDivision,AttendanceStatus,IsRecommended,InvoiceNo,OverInDateTime,OverOutDateTime,RecomendedOTHours,IsSetBillNo,IsAdmissionIncentive,FinalBillTotal,RecomendedLateHours,RecomendedLieuHours,FriendshipBy,RecomendedFriendshipHours,RecomendedCoverdHours,RecomendedExcessHours,FriendshipTo,AdditionalInDateTime,AdditionalOutDateTime,IsOTApproved,ReasonsOfOT,TotalWorkedHours,RecommendHoursBy,RecommendOTHoursBy,TimeSlotID,AppointmentNo,HCGSales,ECGSales,TheatreSales,VoucherPayments,OPDSales,InvoiceSales,RecomendedDoubleOTHrs,IsPosted,IsCancelPosted,PapsmearSale,NoPayValue,LeaveAppliedValue,LateMinutes,ShiftID,ActualWorkedDepartment,ActualShiftID,LeaveStatus,AdditionalLeaveStatus,ActualLeaveStatus,ActualAdditionalLeaveStatus,LeaveCategoryID,LeaveTypeID,IsAttendanceRemoved,WeekDay,InLateCount,OutLateCount,InLateHalfDayDeductionCount,OutLateHalfDayDeductionCount,IsWorked,AdditionalShiftID,AdditionalActualShiftID,AdditionalCheckInDateTime,AdditionalCheckOutDateTime,IsShift,FinalLateCount,LeauLeaveDay,LeauLeaveValue,AdditionalActualCheckInDateTime,AdditionalActualCheckOutDateTime,IsAdditionalShift,AdditionalShiftRelatedOTMinutes,ActualOTHours,ActualWorkedHours")] RelatedPartySession relatedPartySession)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedPartySession).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedPartySession);
        }

        // GET: RelatedPartySessions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedPartySession relatedPartySession = db.RelatedPartySessions.Find(id);
            if (relatedPartySession == null)
            {
                return HttpNotFound();
            }
            return View(relatedPartySession);
        }

        // POST: RelatedPartySessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedPartySession relatedPartySession = db.RelatedPartySessions.Find(id);
            db.RelatedPartySessions.Remove(relatedPartySession);
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
