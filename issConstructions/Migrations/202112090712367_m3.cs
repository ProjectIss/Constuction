namespace issConstructions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseRequestTables", "Tax", c => c.String());
            AddColumn("dbo.PurchaseRequestTables", "TaxAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PurchaseRequestTables", "NetAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PurchaseRequestTables", "Rate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PurchaseRequestTables", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.PurchaseRequestTables", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PurchaseRequestTables", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PurchaseRequestTables", "productTax");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseRequestTables", "productTax", c => c.Int(nullable: false));
            AlterColumn("dbo.PurchaseRequestTables", "TotalAmount", c => c.String());
            AlterColumn("dbo.PurchaseRequestTables", "Amount", c => c.String());
            AlterColumn("dbo.PurchaseRequestTables", "Quantity", c => c.String());
            AlterColumn("dbo.PurchaseRequestTables", "Rate", c => c.String());
            DropColumn("dbo.PurchaseRequestTables", "NetAmount");
            DropColumn("dbo.PurchaseRequestTables", "TaxAmount");
            DropColumn("dbo.PurchaseRequestTables", "Tax");
        }
    }
}
