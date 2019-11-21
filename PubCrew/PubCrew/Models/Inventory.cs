using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pubcrew.Models
{
    public class Inventory
    {
        [Key]
        public int inventoryId { get; set; }

        [Display(Name = "Product Name")]
        public string productName { get; set; }
        [Display(Name = "Product Description")]
        public string productDescription { get; set; }

        public int currentInventory { get; set; }

        [ForeignKey("Beverage")]
        public ICollection<Beverage> Beverages { get; set; }
        public int bevInventoryId { get; set; }

        [ForeignKey("Food")]
        public ICollection<Food> Foods { get; set; }
        public int foodInventoryId { get; set; }

        [ForeignKey("Amenities")]
        public ICollection<Amenity> Amenities { get; set; }
        public int amenitiesInventoryId { get; set; }


        [ForeignKey("Location")]
        public int locationId { get; set; }
        public Location Location { get; set; }

    }
}