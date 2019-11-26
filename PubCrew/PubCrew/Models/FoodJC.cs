using Pubcrew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PubCrew.Models
{
    public class FoodJC
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Food")]
        public int foodId { get; set; }
        public Food Food { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Inventory")]
        public int inventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}