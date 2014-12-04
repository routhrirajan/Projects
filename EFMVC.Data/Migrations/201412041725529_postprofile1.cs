namespace EFMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postprofile1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PostProfile", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.PostProfile", "Gender", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.PostProfile", "FileName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostProfile", "FileName", c => c.String());
            AlterColumn("dbo.PostProfile", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.PostProfile", "Email", c => c.String(nullable: false));
        }
    }
}
