namespace UnSolid.Invoicing.Inc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class NewFields : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contacts", newName: "Contact");
            RenameTable(name: "dbo.InvoiceLines", newName: "InvoiceLine");
            RenameTable(name: "dbo.Invoices", newName: "Invoice");
            RenameTable(name: "dbo.Products", newName: "Product");
            RenameTable(name: "dbo.ProductUnits", newName: "ProductUnit");
            RenameTable(name: "dbo.OrgTypes", newName: "OrgType");
            RenameTable(name: "dbo.Systems", newName: "System");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.System", newName: "Systems");
            RenameTable(name: "dbo.OrgType", newName: "OrgTypes");
            RenameTable(name: "dbo.ProductUnit", newName: "ProductUnits");
            RenameTable(name: "dbo.Product", newName: "Products");
            RenameTable(name: "dbo.Invoice", newName: "Invoices");
            RenameTable(name: "dbo.InvoiceLine", newName: "InvoiceLines");
            RenameTable(name: "dbo.Contact", newName: "Contacts");
        }
    }
}
