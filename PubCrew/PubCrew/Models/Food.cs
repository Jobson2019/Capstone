using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pubcrew.Models
{
    public class Food
    {
        [Key]
        public int foodId { get; set; }
        [Display(Name = "Food")]
        public string foodName { get; set; }

        [Display(Name = "Product Line Name")]
        public string foodProductLineName { get; set; }

        [Display(Name = "Expiration")]
        public string foodExpirationDate { get; set; }
        [Display(Name = "Quantity")]
        public int foodQuantity { get; set; }
        



    }
}