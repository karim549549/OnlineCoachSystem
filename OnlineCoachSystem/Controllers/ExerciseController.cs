using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCoachingSystem.Repository;
using OnlineCoachingSystem.Repository.Dtos;
using OnlineCoachingSystem.Repository.Models.Plan;
using OnlineCoachingSystem.Repository.Models.User;
using System.Net;

namespace OnlineCoachSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IUnitOfWork _UnitOfWork;
        private ApiResponse response;
        private IMapper _mapper;
        public ExerciseController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            response = new ApiResponse();
            _mapper = mapper;
        }

        [HttpGet("GetAllExercises")]
        public async Task<ApiResponse> GetAllClients()
        {
            response.Result = await _UnitOfWork.Exercise.GetAllAsync();
            response.StatusCode = HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }

        [HttpPost("CreateExercies")]
        public async Task<ApiResponse> CreateExercise([FromForm] ExerciseDto Dto)
        {
        
            var Exercise = await _UnitOfWork.Exercise.FindEntityAsync(_mapper.Map<Exercise>(Dto));

            if (Exercise != null)
            {
                response.Result = Exercise;
                response.StatusCode = HttpStatusCode.Conflict;
                response.Message = new List<string> { $"{MagicStrings.AlreadyExists}" };
                return response;
            }
            response.Result = await _UnitOfWork.Exercise.AsyncAddRange(new List<Exercise> { Exercise });
            response.StatusCode = HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }
        [HttpDelete("DeleteExercise")]
        public async Task<ApiResponse> DeleteExercise(ExerciseDto Dto)
        {
  
            _UnitOfWork.Exercise.DeleteRange(new List<Exercise> { _mapper.Map<Exercise>(Dto) });
            response.StatusCode=HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }
    }
}
