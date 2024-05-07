using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Models.Plan
{
    public class NeutrationPlan
    {
        public int Id { get; set; }

        [StringLength(20)]
        [RegularExpression(@"^(?=.*[A-Z])[A-Za-z0-9]+$", ErrorMessage = "Name must contain at least one capital letter and consist of alphanumeric characters.")]
        public string Name { get; set; } = string.Empty;

        public int CoachId { get; set; }

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();

    }
}
