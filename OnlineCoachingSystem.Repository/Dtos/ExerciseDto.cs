using OnlineCoachingSystem.Repository.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Dtos
{
    public class ExerciseDto
    {
        [StringLength(20)]
        [RegularExpression(@"^(?=.*[A-Z])[A-Za-z0-9]+$", ErrorMessage = "Name must contain at least one capital letter and consist of alphanumeric characters.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string? Description { get; set; } = string.Empty;
        public string WorkingMuscles { get; set; } = "Unknown";
        [StringLength(50)]
        public string VideoUrl { get; set; } = string.Empty;

        [AllowedValues("Hard", "Easy", "Extreme", "Moderate", "Challenging", "Very Hard", "Relaxed")]
        public string IntensityLevel { get; set; } = string.Empty;
    }
}
