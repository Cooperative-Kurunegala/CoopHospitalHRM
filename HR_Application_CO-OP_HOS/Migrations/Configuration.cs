namespace HR_Application_CO_OP_HOS.Migrations
{
    using HR_Application_CO_OP_HOS.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HR_Application_CO_OP_HOS.Models.HRMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(HRMSContext context)
        {
            context.OrderTypes.AddOrUpdate(
                o => o.OrderTypeCode,
                new OrderType { OrderTypeCode = "OPD", OrderTypeName = "OPD" },
                new OrderType { OrderTypeCode = "IPD", OrderTypeName = "IPD" }
            );

            context.PaymentTypes.AddOrUpdate(
                p => p.PaymentTypeCode,
                new PaymentType { PaymentTypeCode = 1, PaymentTypeName = "Cash" },
                new PaymentType { PaymentTypeCode = 2, PaymentTypeName = "Card" },
                new PaymentType { PaymentTypeCode = 3, PaymentTypeName = "M-Cash" }
            );

            context.ChargeTypes.AddOrUpdate(
                c => c.ChargeTypeName,
                new ChargeType { ChargeTypeName = "Lab" },
                new ChargeType { ChargeTypeName = "Radiology" }
            );

            context.SaveChanges();
        }

    }
}
