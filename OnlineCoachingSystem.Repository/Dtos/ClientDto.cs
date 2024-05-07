using OnlineCoachingSystem.Repository.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Dtos
{
    public class ClientDto
    {
        [Range(30, 300)]
        public double? Weight { get; set; }
        [Range(120, 230)]
        public double? Height { get; set; }

        [StringLength(200)]
        public string? MoreHealthDetails { get; set; } = string.Empty;

        public Person PersonalDetails { get; set; }

    }
}
