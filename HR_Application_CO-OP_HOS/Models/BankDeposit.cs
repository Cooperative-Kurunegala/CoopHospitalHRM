using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Application_CO_OP_HOS.Models
{
    [Table("BankDeposit")]
    public class BankDeposit
    {
        [Key] public int ID { get; set; }
        [Column(TypeName = "decimal")] public decimal? Pharmacy_Deposit { get; set; }
        [Column(TypeName = "decimal")] public decimal? Reception_Deposit { get; set; }
        public DateTime? DepositDatetime { get; set; }
        public int? CreatedBy { get; set; }
        [Column(TypeName = "decimal")] public decimal? Cheque_Deposit { get; set; }
        [Column(TypeName = "decimal")] public decimal? CashInHand { get; set; }
    }
}