using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("Company")]
    public class Company
    {
        [Key] public int ID { get; set; }
        [StringLength(200)] public string CompanyName { get; set; }
    }
}