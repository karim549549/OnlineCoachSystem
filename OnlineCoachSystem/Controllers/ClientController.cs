using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCoachingSystem.EF;
using OnlineCoachingSystem.Repository.Dtos;
using OnlineCoachingSystem.Repository;
using System.Net;
using OnlineCoachingSystem.Repository.Models.User;
using AutoMapper;

namespace OnlineCoachSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {


        private readonly IUnitOfWork _UnitOfWork;
        private ApiResponse response;
        private IMapper _mapper;
        public ClientController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _UnitOfWork = unitOfWork;
            _mapper = mapper;
            response = new ApiResponse();
        }
        [HttpPost("CreateClient")]
        public async Task<ActionResult<ApiResponse>> CreateClient([FromForm] ClientDto Dto)
        {
      
            Client? client = await _UnitOfWork.Client.FindEntityAsync(_mapper.Map<Client>(Dto));

            if (client != null)
            {
                response.Result = client;
                response.StatusCode = HttpStatusCode.Conflict;
                response.Message = new List<string> { $"{MagicStrings.AlreadyExists}" };
                return response;
            }
            response.Result = await _UnitOfWork.Client.AsyncAddRange(new List<Client> { client });
            response.StatusCode = HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }
        [HttpGet("GetAllClients")]
        public async Task<ActionResult<ApiResponse>> GetAllClients()
        {
            response.Result=await _UnitOfWork.Client.GetAllAsync();
            response.StatusCode = HttpStatusCode.OK;
            response.Message = new List<string> { $"{MagicStrings.successful}" };
            return response;
        }

    }
}
