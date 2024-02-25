using Microsoft.Data.SqlClient;
using Todo_backEnd.Model.LogInResponseModel;

namespace Todo_backEnd.Repository.LogInRepositoryInterface
{
    public interface ILogInGet
    {
        public LogInResponse GetAlluser(SqlConnection connection);
    }
}
