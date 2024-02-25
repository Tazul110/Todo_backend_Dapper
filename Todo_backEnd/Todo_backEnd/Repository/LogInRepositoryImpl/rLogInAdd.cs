using Dapper;
using Microsoft.Data.SqlClient;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Model.LogInTodoModel;
using Todo_backEnd.Model.ResponseModel;
using Todo_backEnd.Model.TodoModel;
using Todo_backEnd.Repository.LogInRepositoryInterface;

namespace Todo_backEnd.Repository.LogInRepositoryImpl
{
    public class rLogInAdd : ILogInAdd
    {
        public LogInResponse LogIn_Add(SqlConnection connection, LogIn login)
        {
            LogInResponse response = new LogInResponse();

            int i = connection.Execute("INSERT INTO Users (userName, userEmail, userPassword) VALUES (@userName, @userEmail, @userPassword)", login);

            /*SqlCommand cmd = new SqlCommand("INSERT INTO Users (userName, userEmail, userPassword) VALUES (@userName, @userEmail, @userPassword)", connection);

            cmd.Parameters.AddWithValue("@userName", login.userName);
            cmd.Parameters.AddWithValue("@userEmail", login.userEmail);
            cmd.Parameters.AddWithValue("@userPassword", login.userPassword);
            
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();*/

            if (i > 0)
            {

                response.StatusCode = 200;
                response.StatusMessage = "Todo added.";
                response.log_in = login;

            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data inserted";


            }
            return response;
        }
    }
}
