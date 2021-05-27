namespace _12_GeneralStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPurchasedQuantitytoPurchaseQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "PurchaseQuantity", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "PurchasedQuantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "PurchasedQuantity", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "PurchaseQuantity");
        }
    }
}
