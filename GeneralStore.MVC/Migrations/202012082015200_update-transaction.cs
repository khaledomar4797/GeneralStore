namespace GeneralStore.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "DateOfTransaction", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "DateOfTransaction", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transactions", "Quantity");
        }
    }
}
