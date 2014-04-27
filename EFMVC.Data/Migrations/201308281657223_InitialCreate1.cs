namespace EFMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Description", c => c.String(maxLength: 140));
            AlterColumn("dbo.Expenses", "Transaction", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expenses", "Transaction", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
        }
    }
}
