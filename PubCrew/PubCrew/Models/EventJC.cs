using Pubcrew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PubCrew.Models
{
    public class EventJC
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Event")]
        public int eventId { get; set; }
        public Event Event { get; set; }
        
        [Key, Column(Order = 1)]
        [ForeignKey("Location")]
        public int locationId { get; set; }
        public Location Location { get; set; }

    }
}