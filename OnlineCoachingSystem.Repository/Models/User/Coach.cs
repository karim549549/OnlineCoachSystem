using OnlineCoachingSystem.Repository.Models.Plan;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Models.User
{
    public class Coach
    {
        public int Id { get; set; }

        public Person person { get; set; }  

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

        public ICollection<ClientCoach> clientCoach { get; set; } = new List<ClientCoach>();

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
