using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Models.User
{
    public class ClientCoach
    {
        public int Id { get; set; }

        public DateTime AddOn { get; } = DateTime.Now;

        //public NeutrationPlan Plan { get; set; }

        public int ClientId { get; set; }

        public int CoachId { get; set; }

        public Client Client { get; set; } = new Client();

        [AllowedValues("Active", "Terminated", "Pending")]
        public string State { get; set; } = string.Empty;

        public Coach Coach { get; set; } = new Coach();

        public int NeutrationPlanId { get; set; }
    }
}
