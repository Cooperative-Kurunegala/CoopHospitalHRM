using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("Location")]
    public class Location
    {
        [Key] public int ID { get; set; }
        [StringLength(500)] public string LocationName { get; set; }
        public int? OrderIndex { get; set; }
    }
}