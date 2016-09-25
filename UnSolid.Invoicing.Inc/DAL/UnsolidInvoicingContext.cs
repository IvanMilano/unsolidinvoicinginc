using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UnSolid.Invoicing.Inc.Migrations;
using UnSolid.Invoicing.Inc.Models;

namespace UnSolid.Invoicing.Inc.DAL
{
    public class UnsolidInvoicingContext : DbContext
    {
        public UnsolidInvoicingContext(): base("UnSolid.Invoicing.Inc")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<UnsolidInvoicingContext, Configuration>("UnSolid.Invoicing.Inc"));

            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceLine> InvoiceLines { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductUnit> ProductUnits { get; set; }

        public DbSet<OrgType> OrgTypes { get; set; }

        public DbSet<Models.System> System { get; set; }
    }
}