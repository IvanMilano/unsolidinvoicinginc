using System.Collections.Generic;
using System.Data.Entity;
using UnSolid.Invoicing.Inc.Models;

namespace UnSolid.Invoicing.Inc.DAL
{
    public class UnSolidInitializer : DropCreateDatabaseIfModelChanges<UnsolidInvoicingContext>
    {
        protected override void Seed(UnsolidInvoicingContext context)
        {
            //var contacts = new List<Contact>
            //{
            //    new Contact
            //    {
            //        Name = "Ciber Norge",
            //        Active = true,
            //        Email = "info@ciber.com",
            //        Number = 1
            //    },
            //    new Contact
            //    {
            //        Name = "Microsoft As",
            //        Active = true,
            //        Email = "info@microsoft.no",
            //        Number = 2
            //    }
            //};

            //context.Contacts.AddRange(contacts);

            //var productUnits = new List<ProductUnit>
            //{
            //    new ProductUnit
            //    {
            //        Id = 1,
            //        Name = "Min",
            //    },
            //    new ProductUnit
            //    {
            //        Id = 2,
            //        Name = "Time"
            //    },
            //    new ProductUnit
            //    {
            //        Id = 3,
            //        Name = "Dag"
            //    }
            //};

            //context.ProductUnits.AddRange(productUnits);

            //var products = new List<Product>
            //{
            //    new Product
            //    {
            //        Name = "Programmerings-tjenester",
            //        Number = "2000",
            //        Description = "Salg av konsulent-tjenester innen programvare utvikling",
            //        Price = 1000,
            //        UnitId = 2
            //    },
            //    new Product
            //    {
            //        Name = "Konsulent-tjenester",
            //        Number = "2100",
            //        Description = "Salg av konsulent-tjenester inne it.",
            //        Price = 1250,
            //        UnitId = 2
            //    }
            //};

            //context.Products.AddRange(products);

            //var orgTypes = new List<OrgType>
            //{
            //    new OrgType
            //    {
            //        Id = 1,
            //        Name = "AS - Aksjeselskap"
            //    },
            //    new OrgType
            //    {
            //        Id = 2,
            //        Name = "ENK - Enkeltpersonforetak"
            //    },
            //    new OrgType
            //    {
            //        Id = 3,
            //        Name = "DA - Ansvarlig selskap med delt ansvar"
            //    }
            //};

            //context.OrgTypes.AddRange(orgTypes);

            //var system = new Models.System
            //{
            //    CompanyName = "UnSolid Invoicing Inc.",
            //    OrgNumber = 98179797,
            //    OrgTypeId = 1,
            //    Maturity = 14,
            //    UseVat = true
            //};

            //context.System.Add(system);

            //context.SaveChanges();
        }
    }
}