using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$",
            ErrorMessage = "Password must be complex. It should contain a digit, a lowercase and an uppercase letter and it should be 4 to 8 characters long.")]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }
    }
}