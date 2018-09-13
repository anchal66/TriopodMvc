using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TriopodMvc.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "Enter your Name")]
        [Required(ErrorMessage = "Enter name")]
        [StringLength(30)]
        public string Name { get; set; }

        [Display(Name = "Enter your Email Id")]
        [Required(ErrorMessage = "Enter Email")]
        [StringLength(30)]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Email format Invalid")]
        public string Email { get; set; }

        [Display(Name = "Enter your Phone Number")]
        [Required(ErrorMessage = "Enter Phone Number")]
        public long Number { get; set; }

        [Display(Name = "Enter your Email Id")]
        [Required(ErrorMessage = "Enter Email")]
        [StringLength(30)]
        public string Choice { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }
    }
}