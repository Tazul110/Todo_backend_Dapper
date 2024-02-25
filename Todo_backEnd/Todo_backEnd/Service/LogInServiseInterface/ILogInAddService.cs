using Microsoft.Data.SqlClient;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Model.LogInTodoModel;

namespace Todo_backEnd.Service.LogInServiseInterface
{
    public interface ILogInAddService
    {
        LogInResponse sLogIn_Add(SqlConnection connection, LogIn login);
    }
}
