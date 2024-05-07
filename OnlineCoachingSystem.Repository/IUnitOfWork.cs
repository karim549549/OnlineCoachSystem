using OnlineCoachingSystem.Repository.Dtos;
using OnlineCoachingSystem.Repository.IRepositories;
using OnlineCoachingSystem.Repository.Models.Plan;
using OnlineCoachingSystem.Repository.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineCoachingSystem.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IBaseRepository<Client,ClientDto> Client { get; }
        IBaseRepository<Coach,CoachDto> Coach { get; }
        IBaseRepository<NeutrationPlan,NeutrationPlanDto> NeutrationPlan { get; }
        IBaseRepository<Exercise,ExerciseDto> Exercise { get; }
        int Complete();
    }
}
