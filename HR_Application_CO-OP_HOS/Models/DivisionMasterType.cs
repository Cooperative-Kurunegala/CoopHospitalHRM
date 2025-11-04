using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("DivisionMasterType")]
    public class DivisionMasterType
    {
        [Key] public int ID { get; set; }
        [StringLength(150)] public string DivisionMasterTypeName { get; set; }
        public int? DivisionMasterID { get; set; }
        [StringLength(500)] public string DivisionMasterTypeDescription { get; set; }
        public int? ParentDivisionMasterTypeID { get; set; }
    }
}