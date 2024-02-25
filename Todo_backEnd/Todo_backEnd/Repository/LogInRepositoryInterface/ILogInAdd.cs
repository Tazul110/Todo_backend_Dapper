using Microsoft.Data.SqlClient;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Model.LogInTodoModel;
using Todo_backEnd.Model.ResponseModel;
using Todo_backEnd.Model.TodoModel;

namespace Todo_backEnd.Repository.LogInRepositoryInterface
{
    public interface ILogInAdd
    {
        LogInResponse LogIn_Add(SqlConnection connection, LogIn login);
    }
}
