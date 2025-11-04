using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("OPDSquence")]
    public class OPDSquence
    {
        [Key] public int ID { get; set; }
        public int? LocationID { get; set; }
        public int? DoctorID { get; set; }
        public DateTime? OPDDate { get; set; }
        public int? TimeSlotID { get; set; }
        public int? Sequence { get; set; }
        public bool? SquenceStatus { get; set; }
    }

}