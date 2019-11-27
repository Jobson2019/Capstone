using Pubcrew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PubCrew.Models
{
    public class SpecialJC
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Special")]
        public int specialId { get; set; }
        public Special Special { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Location")]
        public int locationId { get; set; }
        public Location Location { get; set; }
    }
}