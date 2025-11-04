using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("MenuConfiguration")]
    public class MenuConfiguration
    {
        [Key] public int ID { get; set; }
        [StringLength(50)] public string MenuItemName { get; set; }
        [StringLength(1000)] public string MenuItemDescription { get; set; }
        public int? ParentMenuItemID { get; set; }
        public int? MenuLevel { get; set; }
        [StringLength(50)] public string MenuItemControlName { get; set; }
        [StringLength(100)] public string UIType { get; set; }
        public int? MenuTypeID { get; set; }
        public int? MenuTypeDetailID { get; set; }
        public int? SplashScreenItemID { get; set; }
        public int? OrderIndex { get; set; }
        public int? DivisionMasterID { get; set; }
        public int? ChargeTypeID { get; set; }
        public int? RelatedPartyTypeID { get; set; }
        public int? OrderTypeID { get; set; }
        public bool? IsSellWardPharmacyPrice { get; set; }
        public int? AdmissionTypeID { get; set; }
    }
}