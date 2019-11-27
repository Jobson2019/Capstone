using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PubCrew.Models
{
    public class Special
    {
        [Key]
        public int specialId { get; set; }
        [Display(Name = "Special Name")]
        public string specialName { get; set; }


    }
}