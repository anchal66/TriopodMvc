using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TriopodMvc.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Display(Name = "Enter your Email Id")]
        [Required(ErrorMessage = "Enter First Name")]
        [StringLength(30)]
        public string FirstName { get; set; }


        [Display(Name = "Enter your Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        [StringLength(30)]
        public string LastName { get; set; }


        [Display(Name = "Enter your Number")]
        [Required(ErrorMessage = "Enter your contact number")]
        public long Number { get; set; }


        [Display(Name = "Enter your Email Id")]
        [Required(ErrorMessage = "Enter Email")]
        [StringLength(30)]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Email format Invalid")]
        public string Email { get; set; }


        [Display(Name = "Enter your Message")]
        [Required(ErrorMessage = "Enter Message")]
        [StringLength(3000)]
        public string Message { get; set; }

        public DateTime DateTime { get; set; }
    }
}