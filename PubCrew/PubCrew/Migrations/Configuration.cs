namespace PubCrew.Migrations
{
    using Pubcrew.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pubcrew.Models.ApplicationDbContext>
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pubcrew.Models.ApplicationDbContext db)
        {
            db.Beverages.AddOrUpdate(b => b.beverageId,
            new Beverage() { beverageId = 1, bevType = "Whiskey", brandName = "Jameson", bevProductLineName = "Jamo Classic", bevQuantity = 3 },
            new Beverage() { beverageId = 2, bevType = "Gin", brandName = "Bombay", bevProductLineName = "Sapphire", bevQuantity = 0 },
            new Beverage() { beverageId = 3, bevType = "Vodka", brandName = "Tito's", bevProductLineName = "Flagship", bevQuantity = 5 }
            );

            db.Foods.AddOrUpdate(f => f.foodId,
            new Food() { foodId = 1, foodName = "White Bread", foodProductLineName = "Wonder Bread", foodExpirationDate = "12/25/2019", foodQuantity = 5 },
            new Food() { foodId = 2, foodName = "Ham", foodProductLineName = "Wonder Ham", foodExpirationDate = "12/23/2019", foodQuantity = 4 }
            );

            db.Amenities.AddOrUpdate(a => a.amenityId,
            new Amenity() { amenityId = 1, supplyName = "Toilet Paper", amProductLineName = "BigTP", amQuantity = 13 }
            );

             

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
