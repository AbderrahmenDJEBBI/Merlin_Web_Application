using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Merlin_web_Application.ViewModel
{
    public class Login
    {
        [Required(ErrorMessage = "Please enter UserName")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 5)]
        [RegularExpression(@"^([a-zA-Z0-9@*#]{5,15})$", ErrorMessage = "Password must contain: Minimum 5 characters atleast  1 Number ")]
        public string Password { get; set; }
    }
}