namespace PubCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migthree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppUsers", "ApplicationId", c => c.String(maxLength: 128));
            AddColumn("dbo.AppUsers", "businessId", c => c.Int(nullable: false));
            AddColumn("dbo.AppUsers", "businessName", c => c.String());
            CreateIndex("dbo.AppUsers", "ApplicationId");
            CreateIndex("dbo.AppUsers", "businessId");
            AddForeignKey("dbo.AppUsers", "ApplicationId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AppUsers", "businessId", "dbo.Businesses", "BusinessId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppUsers", "businessId", "dbo.Businesses");
            DropForeignKey("dbo.AppUsers", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.AppUsers", new[] { "businessId" });
            DropIndex("dbo.AppUsers", new[] { "ApplicationId" });
            DropColumn("dbo.AppUsers", "businessName");
            DropColumn("dbo.AppUsers", "businessId");
            DropColumn("dbo.AppUsers", "ApplicationId");
        }
    }
}
