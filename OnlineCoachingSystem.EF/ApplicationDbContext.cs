using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCoachingSystem.Repository.Models;
using OnlineCoachingSystem.Repository.Models.User;
using OnlineCoachingSystem.Repository.Models.Plan;
namespace OnlineCoachingSystem.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Coach> Coachs { get; set; }

        public DbSet<ClientCoach> ClientCoach { get; set; }

        public DbSet<NeutrationPlan> NeutrationPlans { get; set; }

        public DbSet<Exercise> Exercises { get; set; }
    }
}
