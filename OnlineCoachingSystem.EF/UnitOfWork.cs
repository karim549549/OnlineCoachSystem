using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineCoachingSystem.EF.Implementation;
using OnlineCoachingSystem.Repository;
using OnlineCoachingSystem.Repository.Dtos;
using OnlineCoachingSystem.Repository.IRepositories;
using OnlineCoachingSystem.Repository.Models.Plan;
using OnlineCoachingSystem.Repository.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.EF
{
    public class UnitOfWork: IUnitOfWork
    {
        public IBaseRepository<Client,ClientDto> Client { get; private set; }

        public IBaseRepository<Coach, CoachDto> Coach { get; private set; }

        public IBaseRepository<NeutrationPlan,NeutrationPlanDto> NeutrationPlan { get; private set; }

        public IBaseRepository<Exercise,ExerciseDto> Exercise { get; private set; }

        private readonly ApplicationDbContext _DbContext;

        private readonly IMapper _mapper;

        public UnitOfWork(ApplicationDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;

            Client = new BaseRepository<Client, ClientDto>(_DbContext);
            Coach = new BaseRepository<Coach, CoachDto>(_DbContext);
            NeutrationPlan = new BaseRepository<NeutrationPlan, NeutrationPlanDto>(_DbContext);
            Exercise = new BaseRepository<Exercise, ExerciseDto>(_DbContext);
        }

        int IUnitOfWork.Complete()
        {
            return _DbContext.SaveChanges(); ;
        }

        void IDisposable.Dispose()
        {
            _DbContext.Dispose();
        }
    }
}
