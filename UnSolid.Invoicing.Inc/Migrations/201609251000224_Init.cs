namespace UnSolid.Invoicing.Inc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                        VatNumber = c.Int(),
                        Active = c.Boolean(nullable: false),
                        Email = c.String(),
                        StreetAddress = c.String(),
                        StreetZipCode = c.Int(nullable: false),
                        StreetCity = c.Int(nullable: false),
                        PostalAddress = c.String(),
                        PostalZipCode = c.Int(nullable: false),
                        PostalCity = c.Int(nullable: false),
                        Disccount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.InvoiceLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductId = c.Int(nullable: false),
                        InvoiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.InvoiceId);

            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Long(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Reference = c.String(),
                        DeliveryPlace = c.String(),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);

            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Number = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductUnits", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);

            CreateTable(
                "dbo.ProductUnits",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.OrgTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Systems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        OrgNumber = c.Int(nullable: false),
                        OrgTypeId = c.Int(nullable: false),
                        Email = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        ZipCode = c.Int(nullable: false),
                        City = c.String(),
                        Swift = c.String(),
                        Iban = c.String(),
                        Phone = c.Int(nullable: false),
                        Url = c.String(),
                        Maturity = c.Int(nullable: false),
                        UseVat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrgTypes", t => t.OrgTypeId, cascadeDelete: true)
                .Index(t => t.OrgTypeId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Systems", "OrgTypeId", "dbo.OrgTypes");
            DropForeignKey("dbo.InvoiceLines", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "UnitId", "dbo.ProductUnits");
            DropForeignKey("dbo.InvoiceLines", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Systems", new[] { "OrgTypeId" });
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropIndex("dbo.Invoices", new[] { "ContactId" });
            DropIndex("dbo.InvoiceLines", new[] { "InvoiceId" });
            DropIndex("dbo.InvoiceLines", new[] { "ProductId" });
            DropTable("dbo.Systems");
            DropTable("dbo.OrgTypes");
            DropTable("dbo.ProductUnits");
            DropTable("dbo.Products");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.Contacts");
        }
    }
}
