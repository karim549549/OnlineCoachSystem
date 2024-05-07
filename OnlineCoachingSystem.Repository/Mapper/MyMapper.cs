using AutoMapper;
using OnlineCoachingSystem.Repository.Dtos;
using OnlineCoachingSystem.Repository.Models.Plan;
using OnlineCoachingSystem.Repository.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingSystem.Repository.Mapper
{
    public class MyMapper:Profile
    {
        public MyMapper()
        {
            CreateMap<NeutrationPlan, NeutrationPlanDto>().ReverseMap();
            CreateMap<ClientDto, Client>()
                     .ForMember(dest => dest.Id, opt => opt.Ignore()) // Assuming Id is auto-generated
                     .ForMember(dest => dest.clientCoach, opt => opt.Ignore()) // Ignore mapping for clientCoach
                     .ReverseMap(); //
            CreateMap<CoachDto, Coach>();
            CreateMap<IEnumerable<CoachDto>,IEnumerable<Coach>>().ReverseMap();  
            CreateMap<ExerciseDto, Exercise>().ReverseMap();
            
        }
    }
}
