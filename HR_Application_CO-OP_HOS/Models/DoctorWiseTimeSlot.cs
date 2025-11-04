using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("DoctorWiseTimeSlot")]
    public class DoctorWiseTimeSlot
    {
        [Key] public int ID { get; set; }
        public int? RelatedPartyID { get; set; }
        public int? TimeSlotID { get; set; }
        [StringLength(50)] public string Times { get; set; }
    }
}