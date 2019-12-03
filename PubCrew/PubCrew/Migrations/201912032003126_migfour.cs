namespace PubCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migfour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beverages", "bevType", c => c.String());
            AlterColumn("dbo.Foods", "foodExpirationDate", c => c.String());
            DropColumn("dbo.Amenities", "inventoryAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Amenities", "inventoryAmount", c => c.Int(nullable: false));
            AlterColumn("dbo.Foods", "foodExpirationDate", c => c.DateTime());
            DropColumn("dbo.Beverages", "bevType");
        }
    }
}
