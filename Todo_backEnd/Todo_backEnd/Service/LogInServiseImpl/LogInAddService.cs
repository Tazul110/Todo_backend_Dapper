using Microsoft.Data.SqlClient;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Model.LogInTodoModel;
using Todo_backEnd.Repository.LogInRepositoryInterface;
using Todo_backEnd.Service.LogInServiseInterface;

namespace Todo_backEnd.Service.LogInServiseImpl
{
    public class LogInAddService : ILogInAddService
    {
        private readonly ILogInAdd _logInAdd;
        public LogInAddService(ILogInAdd logInAdd)
        {
             _logInAdd= logInAdd;
        }

        LogInResponse ILogInAddService.sLogIn_Add(SqlConnection connection, LogIn login)
        {
            return _logInAdd.LogIn_Add(connection, login);
        }
    }
}
