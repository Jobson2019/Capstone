﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pubcrew.Models
{
    public class Beverage
    {
        [Key]
        public int beverageId { get; set; }
        [Display(Name = "Beverage Type")]
        public string bevType { get; set; }

        [Display(Name = "Brand Name")]
        public string brandName { get; set; }

        [Display(Name = "Product Line Name")]
        public string bevProductLineName { get; set; }
        [Display(Name = "Quantity")]
        public int bevQuantity { get; set; }
        







    }
}