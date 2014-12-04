namespace EFMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postprofile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostProfile",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Headline = c.String(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        TotalExperience = c.Int(nullable: false),
                        Mobile = c.Int(nullable: false),
                        Landline = c.Int(),
                        Email = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        FileName = c.String(),
                        FileURL = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.DesignationId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        DesignationName = c.String(),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                    })
                .PrimaryKey(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PostProfile", new[] { "LocationId" });
            DropIndex("dbo.PostProfile", new[] { "DesignationId" });
            DropIndex("dbo.PostProfile", new[] { "UserId" });
            DropForeignKey("dbo.PostProfile", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.PostProfile", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.PostProfile", "UserId", "dbo.Users");
            DropTable("dbo.Locations");
            DropTable("dbo.Designations");
            DropTable("dbo.PostProfile");
        }
    }
}
