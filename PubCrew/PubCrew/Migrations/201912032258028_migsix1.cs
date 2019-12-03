namespace PubCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migsix1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Amenities", "amQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Beverages", "bevQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Foods", "foodQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "foodQuantity");
            DropColumn("dbo.Beverages", "bevQuantity");
            DropColumn("dbo.Amenities", "amQuantity");
        }
    }
}
