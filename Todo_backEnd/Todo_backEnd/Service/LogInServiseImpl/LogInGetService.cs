using Microsoft.Data.SqlClient;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Repository.LogInRepositoryInterface;
using Todo_backEnd.Service.LogInServiseInterface;

namespace Todo_backEnd.Service.LogInServiseImpl
{
    public class LogInGetService : ILogInGetService
    {
        private readonly ILogInGet _logInGet;

        public LogInGetService(ILogInGet logInGet)
        {
             _logInGet= logInGet;
        }

        public LogInResponse Get(SqlConnection connection)
        {
            return _logInGet.GetAlluser(connection);
        }
    }
}
