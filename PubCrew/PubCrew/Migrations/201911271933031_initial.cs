namespace PubCrew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Beverages", "inventoryId", "dbo.Inventories");
            DropForeignKey("dbo.Foods", "InventoryId", "dbo.Inventories");
            DropForeignKey("dbo.Inventories", "locationId", "dbo.Locations");
            DropForeignKey("dbo.Amenities", "inventoryId", "dbo.Inventories");
            DropForeignKey("dbo.Inventories", "AppUser_UserId", "dbo.AppUsers");
            DropIndex("dbo.Amenities", new[] { "inventoryId" });
            DropIndex("dbo.Inventories", new[] { "locationId" });
            DropIndex("dbo.Inventories", new[] { "AppUser_UserId" });
            DropIndex("dbo.Beverages", new[] { "inventoryId" });
            DropIndex("dbo.Foods", new[] { "InventoryId" });
            AddColumn("dbo.Amenities", "inventoryAmount", c => c.Int(nullable: false));
            DropColumn("dbo.Amenities", "inventoryId");
            DropColumn("dbo.Beverages", "inventoryId");
            DropColumn("dbo.Foods", "InventoryId");
            DropTable("dbo.Inventories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        inventoryId = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        productDescription = c.String(),
                        currentInventory = c.Int(nullable: false),
                        bevInventoryId = c.Int(nullable: false),
                        foodInventoryId = c.Int(nullable: false),
                        amenitiesInventoryId = c.Int(nullable: false),
                        locationId = c.Int(nullable: false),
                        AppUser_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.inventoryId);
            
            AddColumn("dbo.Foods", "InventoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Beverages", "inventoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Amenities", "inventoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Amenities", "inventoryAmount");
            CreateIndex("dbo.Foods", "InventoryId");
            CreateIndex("dbo.Beverages", "inventoryId");
            CreateIndex("dbo.Inventories", "AppUser_UserId");
            CreateIndex("dbo.Inventories", "locationId");
            CreateIndex("dbo.Amenities", "inventoryId");
            AddForeignKey("dbo.Inventories", "AppUser_UserId", "dbo.AppUsers", "UserId");
            AddForeignKey("dbo.Amenities", "inventoryId", "dbo.Inventories", "inventoryId", cascadeDelete: true);
            AddForeignKey("dbo.Inventories", "locationId", "dbo.Locations", "LocationId", cascadeDelete: true);
            AddForeignKey("dbo.Foods", "InventoryId", "dbo.Inventories", "inventoryId", cascadeDelete: true);
            AddForeignKey("dbo.Beverages", "inventoryId", "dbo.Inventories", "inventoryId", cascadeDelete: true);
        }
    }
}
