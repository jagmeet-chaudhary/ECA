using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECA.Web.ViewModel
{
    public class LoginViewModel 
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50,ErrorMessage = "Length of {0} should not exceed {2} characters ")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Length of {0} should not exceed {2} characters ")]
        [Display(Name = "Last Name")]
        public string  LastName { get; set; }


        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Length of {0} should not exceed {2} characters ")]
        [EmailAddress]
        public string Email { get; set; }
    }
}