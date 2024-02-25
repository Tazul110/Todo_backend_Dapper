using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Model.LogInTodoModel;
using Todo_backEnd.Model.TodoModel;
using Todo_backEnd.Service.LogInServiseInterface;

namespace Todo_backEnd.Controllers.LogInController.LogInAddController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInAddController : ControllerBase
    {
        private readonly ILogInAddService _logInAddService;
        private readonly IConfiguration _configuration;

        public LogInAddController( IConfiguration configuration, ILogInAddService logInAddService)
        {
             _logInAddService= logInAddService;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("LogIn_Add")]
        public LogInResponse LogIn_Add(LogIn log_in)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("CrudConnection"));
            LogInResponse response = new LogInResponse();

            response = _logInAddService.sLogIn_Add(connection, log_in);
            return response;
        }
    }
}
