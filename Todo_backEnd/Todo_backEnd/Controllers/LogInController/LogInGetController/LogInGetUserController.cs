using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Service.LogInServiseInterface;
using Todo_backEnd.Service.serviceImpl;
using Todo_backEnd.Service.serviceInterface;

namespace Todo_backEnd.Controllers.LogInController.LogInGetController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInGetUserController : ControllerBase
    {
        private readonly ILogInGetService _logInService;
        private readonly IConfiguration _configuration;

        public LogInGetUserController(IConfiguration configuration, ILogInGetService logInService)
        {
            _logInService = logInService;
            _configuration = configuration;
        }


        [HttpGet]
        [Route("GetAlluser")]
        public LogInResponse GetAlluser()
        {


            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("CrudConnection"));
            LogInResponse response = new LogInResponse();

            response = _logInService.Get(connection);
            return response;




        }


    }
}
