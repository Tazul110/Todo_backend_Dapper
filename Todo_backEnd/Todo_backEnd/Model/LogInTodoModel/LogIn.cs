using System.ComponentModel.DataAnnotations;

namespace Todo_backEnd.Model.LogInTodoModel
{
    public class LogIn
    {
        [Required(ErrorMessage = "Title is required")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? userEmail { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? userPassword { get; set; }

        
    }
}
