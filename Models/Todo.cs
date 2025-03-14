using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill the task name field")]
        public string Taskname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please fill the date created field!")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
