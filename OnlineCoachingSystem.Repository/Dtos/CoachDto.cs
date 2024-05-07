using OnlineCoachingSystem.Repository.Models.Plan;
using OnlineCoachingSystem.Repository.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Dtos
{
    public class CoachDto 
    {
        [MaxLength(100)]
        public string Bio { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Experiences { get; set; } = string.Empty;
        [MaxLength(200)]
        public string? Degree { get; set; } = string.Empty;

        [Range(0, 5)]
        public int Rating { get; set; }
        [MaxLength(1000)]
        public byte[]? BeforePhoto { get; set; }

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
