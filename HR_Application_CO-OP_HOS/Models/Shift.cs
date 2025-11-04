using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("Shift")]
    public class Shift
    {
        [Key] public int ID { get; set; }
        public int? ShiftCode { get; set; }
        [StringLength(100)] public string ShiftDescription { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }

}