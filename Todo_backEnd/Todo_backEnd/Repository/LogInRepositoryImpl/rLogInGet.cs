using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using Todo_backEnd.Model.LogInResponseModel;
using Todo_backEnd.Model.LogInTodoModel;
using Todo_backEnd.Model.TodoModel;
using Todo_backEnd.Repository.LogInRepositoryInterface;

namespace Todo_backEnd.Repository.LogInRepositoryImpl
{
    public class rLogInGet : ILogInGet
    {
        public LogInResponse GetAlluser(SqlConnection connection)
        {
            LogInResponse response = new LogInResponse();
            var lstUsers = connection.Query<LogIn>("SELECT * FROM Users").ToList();
            /*SqlDataAdapter da = new SqlDataAdapter("select * from Users", connection);
            DataTable dt = new DataTable();
            List<LogIn> lstUser = new List<LogIn>();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LogIn lg = new LogIn();

                    lg.userName = Convert.ToString(dt.Rows[i]["userName"]);
                    lg.userEmail = Convert.ToString(dt.Rows[i]["userEmail"]);
                    lg.userPassword = Convert.ToString(dt.Rows[i]["userPassword"]); 

                    lstUser.Add(lg);
                }*/

            if (lstUsers.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Data found";
                    response.listLogIn = lstUsers;
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "No Data found";
                    response.listLogIn = null;
                }
                
            
            return response;
            
        }


    }
}
