using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TwitterCloneWeb.Models
{
    public class Person
    {
        [Required(ErrorMessage ="User Name is Required")]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        public int user_id { get; set; }

        [Required(ErrorMessage = "Full Name is Required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(50,ErrorMessage ="The Minimum length is{2}",MinimumLength =5)]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confrim Password is Required")]
        [DataType(DataType.Password)]
        [DisplayName("Confrim Password")]
        public string ConfrimPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "required")]
        [DisplayName("Email Address")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Joined Date")]
        public DateTime Joined { get; set; }

        public bool Active { get; set; }

    }
}