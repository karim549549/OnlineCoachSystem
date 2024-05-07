using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Dtos
{
    public class PersonDto
    {

        [RegularExpression(@"^(?=.*[A-Z])[A-Za-z0-9]+$", ErrorMessage = "Name must contain at least one capital letter and consist of alphanumeric characters.")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Must be in Range of 4 to 25 Charachter")]
        public string Username { get; set; }

        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public byte[]? ProfilePicture { get; set; }


        public string LiveIn { get; set; } = string.Empty;

        public string From { get; set; } = string.Empty;

        [AllowedValues("Male", "Female")]
        public string Gender { get; set; } = string.Empty;

        [Timestamp]
        public DateTime? BirthdayDate { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
