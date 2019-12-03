using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pubcrew.Models
{
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Middle Name")]
        public string middleName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("Business")]
        public int businessId { get; set; }
        public string businessName { get; set; }
        public Business Business { get; set; }



    }
}