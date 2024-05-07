using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Models.User
{
    public class Client 
    {
        public int Id { get; set; } 
        [Range(30, 300)]
        public double? Weight { get; set; }
        [Range(120, 230)]
        public double? Height { get; set; }

        [StringLength(200)]
        public string? MoreHealthDetails { get; set; } = string.Empty;

        public ICollection<ClientCoach> clientCoach { get; set; } = new List<ClientCoach>();

        public Person PersonalDetails { get; set; } 
    }
}
