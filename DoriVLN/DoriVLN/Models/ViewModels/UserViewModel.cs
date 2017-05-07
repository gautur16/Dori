using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoriVLN.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter an email address.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "This email address is not valid.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        [Display(Name = "Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Remember me?")]
        public bool rememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "This email address is not valid.")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [Display(Name = "Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Please confirm the password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        public string confirmPassword { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email")]
        public string email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string confirmPassword { get; set; }

        public string code { get; set; }
    }
}