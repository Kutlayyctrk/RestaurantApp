namespace RestaurantApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvoiceItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceID = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.InvoiceID)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceNumber = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentMethod = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        MeterialProductId = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableId = c.Int(nullable: false),
                        CustomerName = c.String(),
                        ReservationDate = c.DateTime(nullable: false),
                        NumberOfPeople = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Capacity = c.Int(nullable: false),
                        IsOccupied = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.StockTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        TranscationDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TransactionType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.Orders", "Table_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Table_Id");
            AddForeignKey("dbo.Orders", "Table_Id", "dbo.Tables", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockTransactions", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Shifts", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Reservations", "TableId", "dbo.Tables");
            DropForeignKey("dbo.Orders", "Table_Id", "dbo.Tables");
            DropForeignKey("dbo.Recipes", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Payments", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.InvoiceItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.InvoiceItems", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.StockTransactions", new[] { "ProductId" });
            DropIndex("dbo.Shifts", new[] { "StaffId" });
            DropIndex("dbo.Reservations", new[] { "TableId" });
            DropIndex("dbo.Recipes", new[] { "ProductId" });
            DropIndex("dbo.Payments", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "Table_Id" });
            DropIndex("dbo.InvoiceItems", new[] { "ProductId" });
            DropIndex("dbo.InvoiceItems", new[] { "InvoiceID" });
            DropColumn("dbo.Orders", "Table_Id");
            DropTable("dbo.StockTransactions");
            DropTable("dbo.Shifts");
            DropTable("dbo.Tables");
            DropTable("dbo.Reservations");
            DropTable("dbo.Recipes");
            DropTable("dbo.Payments");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceItems");
        }
    }
}
