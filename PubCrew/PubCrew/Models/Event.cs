using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PubCrew.Models
{
    public class Event
    {
        [Key]
        public int eventId { get; set; }
        [Display(Name = "Event Name")]
        public string eventName { get; set; }
        [Display (Name = "Event Date")]
        public DateTime? eventDate { get; set; }
        [Display (Name = "Event Info")]
        public string eventInfo { get; set; }
    }
}