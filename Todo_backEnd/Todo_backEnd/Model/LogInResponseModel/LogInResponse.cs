using Todo_backEnd.Model.LogInTodoModel;
using Todo_backEnd.Model.TodoModel;

namespace Todo_backEnd.Model.LogInResponseModel
{
    public class LogInResponse
    {
        public int StatusCode { get; set; }
        public string? StatusMessage { get; set; }

        public LogIn? log_in { get; set; }

        public List<LogIn>? listLogIn { get; set; }
    }
}
