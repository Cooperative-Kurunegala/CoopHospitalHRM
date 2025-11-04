using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HR_Application_CO_OP_HOS.Models
{
    public class HRMSContext : DbContext
    {
        public HRMSContext() : base("name=HRMSContext") { }

        // Core & lookups
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<DivisionMasterType> DivisionMasterTypes { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }
        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<CreditCardType> CreditCardTypes { get; set; }

        // Employee & payroll
        public virtual DbSet<EmployeeModel> Employees { get; set; }                    // RelatedParty
        public virtual DbSet<RelatedPartyType> RelatedPartyTypes { get; set; }
        public virtual DbSet<RelatedPartyBankAccount> RelatedPartyBankAccounts { get; set; }
        public virtual DbSet<SalaryModel> RelatedPartySalaries { get; set; }
        public virtual DbSet<SalaryModifier> SalaryModifiers { get; set; }
        public virtual DbSet<SalaryModifierType> SalaryModifierTypes { get; set; }
        public virtual DbSet<SalaryModifierMapping> SalaryModifierMappings { get; set; }
        public virtual DbSet<RelatedPartyDefaultSalaryModifier> RelatedPartyDefaultSalaryModifiers { get; set; }
        public virtual DbSet<RelatedPartySalaryBankAccountsMapping> RelatedPartySalaryBankAccounts { get; set; }
        public virtual DbSet<SalaryType> SalaryTypes { get; set; }
        public virtual DbSet<PayMonth> PayMonths { get; set; }
        public virtual DbSet<CurrentPayrollMonth> CurrentPayrollMonths { get; set; }

        // Attendance & roster
        public virtual DbSet<AttendanceData> AttendanceData { get; set; }
        public virtual DbSet<AttendanceRecords> AttendanceRecords { get; set; }
        public virtual DbSet<AttendanceTime> AttendanceTimes { get; set; }
        public virtual DbSet<AttendanceDetails> AttendanceDetails { get; set; }
        public virtual DbSet<AttendanceLastRecordDetail> AttendanceLastRecordDetails { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<RosterType> RosterTypes { get; set; }
        public virtual DbSet<RosterStatus> RosterStatuses { get; set; }

        // Billing / Orders / Payments
        public virtual DbSet<ChargeType> ChargeTypes { get; set; }
        public virtual DbSet<ChargeCategory> ChargeCategories { get; set; }
        public virtual DbSet<ChargeMaster> ChargeMasters { get; set; }
        public virtual DbSet<ChargeMasterPrice> ChargeMasterPrices { get; set; }
        public virtual DbSet<DivisionCharge> DivisionCharges { get; set; }
        public virtual DbSet<ChargeItemList> ChargeItemLists { get; set; }

        public virtual DbSet<RelatedPartyOrder> RelatedPartyOrders { get; set; }
        public virtual DbSet<RelatedPartyOrderDetail> RelatedPartyOrderDetails { get; set; }
        public virtual DbSet<RelatedPartyOrderPayments> RelatedPartyOrderPayments { get; set; }

        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PaymentCategory> PaymentCategories { get; set; }
        public virtual DbSet<PaymentSubCategory> PaymentSubCategories { get; set; }
        public virtual DbSet<BillFinalization> BillFinalizations { get; set; }
        public virtual DbSet<BankDeposit> BankDeposits { get; set; }
        public virtual DbSet<BatchPopup> BatchPopups { get; set; }

        // Channeling / OPD
        public virtual DbSet<ChannelingSquence> ChannelingSquences { get; set; }
        public virtual DbSet<ChannelingTimeSlot> ChannelingTimeSlots { get; set; }
        public virtual DbSet<OPDSquence> OPDSquences { get; set; }
        public virtual DbSet<OPDTimeSlot> OPDTimeSlots { get; set; }
        public virtual DbSet<DoctorWiseTimeSlot> DoctorWiseTimeSlots { get; set; }

        // App Settings & UI
        public virtual DbSet<AppSettings> AppSettings { get; set; }
        public virtual DbSet<AppSettingsDetail> AppSettingsDetails { get; set; }
        public virtual DbSet<MenuConfiguration> MenuConfigurations { get; set; }
        public virtual DbSet<SplashScreenItem> SplashScreenItems { get; set; }

        // Finance / bank / checks
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankBranch> BankBranches { get; set; }
        public virtual DbSet<CheckManagment> CheckManagments { get; set; }

        // System logs etc.
        public virtual DbSet<SystemLog> SystemLogs { get; set; }
        public virtual DbSet<LogDetails> LogDetails { get; set; }

        // Misc: Leave workflow
        public virtual DbSet<LeaveCategory> LeaveCategories { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }
        public virtual DbSet<LeaveStatus> LeaveStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Table name mapping (to keep exact SQL table names)
            modelBuilder.Entity<EmployeeModel>().ToTable("RelatedParty");
            modelBuilder.Entity<RelatedPartyBankAccount>().ToTable("RelatedPartyBankAccounts");
            modelBuilder.Entity<SalaryModel>().ToTable("RelatedPartySalary");
            modelBuilder.Entity<SalaryModifierMapping>().ToTable("RelatedPartySalaryModifierMapping");
            modelBuilder.Entity<RelatedPartyDefaultSalaryModifier>().ToTable("RelatedPartyDefaultSalaryModifiers");
            modelBuilder.Entity<RelatedPartySalaryBankAccountsMapping>().ToTable("RelatedPartySalaryBankAccountsMapping");
            modelBuilder.Entity<PayMonth>().ToTable("PayMonthMaster");
            modelBuilder.Entity<Division>().ToTable("DivisionMaster");
            modelBuilder.Entity<ChargeMasterPrice>().ToTable("ChargeMasterPrice");
            modelBuilder.Entity<BatchPopup>().ToTable("BatchPopup");
            modelBuilder.Entity<RelatedPartyOrder>().ToTable("RelatedPartyOrder");
            modelBuilder.Entity<RelatedPartyOrderDetail>().ToTable("RelatedPartyOrderDetail");
            modelBuilder.Entity<RelatedPartyOrderPayments>().ToTable("RelatedPartyOrderPayments");
            modelBuilder.Entity<PaymentDetails>().ToTable("PaymentDetails");
            modelBuilder.Entity<AppSettings>().ToTable("AppSettings");
            modelBuilder.Entity<AppSettingsDetail>().ToTable("AppSettingsDetail");
            modelBuilder.Entity<SplashScreenItem>().ToTable("SplashScreenItem");
            modelBuilder.Entity<AttendanceRecords>().ToTable("AttendanceRecords");
            modelBuilder.Entity<AttendanceData>().ToTable("AttendanceData");
            modelBuilder.Entity<AttendanceTime>().ToTable("AttendanceTime");
            modelBuilder.Entity<AttendanceDetails>().ToTable("AttendanceDetails");
            modelBuilder.Entity<AttendanceLastRecordDetail>().ToTable("AttendanceLastRecordDetail");
            modelBuilder.Entity<OPDSquence>().ToTable("OPDSquence");
            modelBuilder.Entity<OPDTimeSlot>().ToTable("OPDTimeSlot");
            modelBuilder.Entity<ChannelingSquence>().ToTable("ChannelingSquence");
            modelBuilder.Entity<ChannelingTimeSlot>().ToTable("ChannelingTimeSlot");
            modelBuilder.Entity<DoctorWiseTimeSlot>().ToTable("DoctorWiseTimeSlot");
            modelBuilder.Entity<ChargeCategory>().ToTable("ChargeCategory");
            modelBuilder.Entity<ChargeType>().ToTable("ChargeType");
            modelBuilder.Entity<DivisionCharge>().ToTable("DivisionCharge");
            modelBuilder.Entity<ChargeMaster>().ToTable("ChargeMaster");
            modelBuilder.Entity<OrderType>().ToTable("OrderType");
            modelBuilder.Entity<CreditCardType>().ToTable("CreditCardType");
            modelBuilder.Entity<BankDeposit>().ToTable("BankDeposit");
            modelBuilder.Entity<CheckManagment>().ToTable("CheckManagment");

            // PaymentDetails: We've added OrderID (FK) while preserving OrderNo (varchar reference)
            modelBuilder.Entity<PaymentDetails>()
                .HasOptional(pd => pd.RelatedOrder)
                .WithMany(o => o.PaymentDetails)
                .HasForeignKey(pd => pd.OrderID)
                .WillCascadeOnDelete(false);

            // ChargeMaster relationships
            modelBuilder.Entity<ChargeMaster>()
                .HasOptional(cm => cm.ChargeCategory)
                .WithMany(cc => cc.ChargeMasters)
                .HasForeignKey(cm => cm.ChargeCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChargeMasterPrice>()
                .HasRequired(p => p.ChargeMaster)
                .WithMany(cm => cm.Prices)
                .HasForeignKey(p => p.ChargeMasterID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<DivisionCharge>()
                .HasOptional(dc => dc.ChargeMaster)
                .WithMany(cm => cm.DivisionCharges)
                .HasForeignKey(dc => dc.ChargeMasterID)
                .WillCascadeOnDelete(false);

            // Orders
            modelBuilder.Entity<RelatedPartyOrderDetail>()
                .HasOptional(d => d.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(d => d.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelatedPartyOrderPayments>()
                .HasOptional(p => p.Order)
                .WithMany(o => o.Payments)
                .HasForeignKey(p => p.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelatedPartyOrderPayments>()
                .HasOptional(p => p.CreditCardType)
                .WithMany(c => c.OrderPayments)
                .HasForeignKey(p => p.CreditCardTypeID)
                .WillCascadeOnDelete(false);

            // Employee relations
            modelBuilder.Entity<RelatedPartyBankAccount>()
                .HasOptional(b => b.Employee)
                .WithMany(e => e.BankAccounts)
                .HasForeignKey(b => b.RelatedPartyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalaryModel>()
                .HasOptional(s => s.Employee)
                .WithMany(e => e.Salaries)
                .HasForeignKey(s => s.RelatedPartyID)
                .WillCascadeOnDelete(false);

            // Default values at DB level are usually better; EF migrations can create them explicitly.
            base.OnModelCreating(modelBuilder);
        }
    }
}