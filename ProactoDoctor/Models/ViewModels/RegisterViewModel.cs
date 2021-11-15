using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProactoDoctor.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { set; get; }
        [Required]
        [EmailAddress]
        public string Email { set; get; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be atleast {2} characters long.", MinimumLength =6)]
        public string Password { set; get; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password doesn't match.")]
        public string ConfirmPassword { set; get; }
        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
    }
}
