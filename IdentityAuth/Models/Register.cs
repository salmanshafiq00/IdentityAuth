using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using IdentityAuth.Utilities;

namespace IdentityAuth.Models
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "IsEmailExist", controller: "Account")]
        [ValidEmailDomain(allowDomain: "gmail.com", ErrorMessage ="Email Domain must be Gmail.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare(nameof(Password), ErrorMessage ="Password and ConfirmPassword doesn't match")]
        public string ConfirmPassword { get; set; }


    }
}
