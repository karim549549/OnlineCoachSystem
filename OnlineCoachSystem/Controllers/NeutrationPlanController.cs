using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCoachingSystem.EF;
using OnlineCoachingSystem.Repository;
using OnlineCoachingSystem.Repository.Dtos;
using OnlineCoachingSystem.Repository.Models.Plan;
using OnlineCoachingSystem.Repository.Models.User;
using System.Net;

namespace OnlineCoachSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeutrationPlanController : ControllerBase
    {

        private readonly IUnitOfWork _UnitOfWork;
        private ApiResponse response;
        private readonly IMapper _mapper;

        public NeutrationPlanController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            response = new ApiResponse();
            _mapper = mapper;
        }

        [HttpGet("GetAllNeutrationPlans")]

        public async Task<ApiResponse> GetAllNeutrationPlans () {
            response.Result = await _UnitOfWork.NeutrationPlan.GetAllAsync();
            response.StatusCode = HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }
        [HttpPost("CreateNeutrationPlan")]
        public async Task<ApiResponse> CreateNeutrationPlan([FromForm] NeutrationPlanDto Dto)
        {

            var Plan = _UnitOfWork.NeutrationPlan.FindEntityAsync(_mapper.Map<NeutrationPlan>(Dto));
            if (Plan != null)
            {
                response.Result = Plan;
                response.StatusCode = HttpStatusCode.Conflict;
                response.Message = new List<string> { $"{MagicStrings.AlreadyExists}" };
                return response;
            }
            response.Result = await _UnitOfWork.NeutrationPlan.AsyncAddRange(new List<NeutrationPlan> {/*error*/ });
            response.StatusCode = HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }
    }
}
