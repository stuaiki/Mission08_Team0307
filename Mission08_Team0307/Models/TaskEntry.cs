using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0307.Models
{
    public class TaskEntry
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "You need to put Task Name")]
        public string Task { get; set; }

        public DateOnly? DueDate { get; set; }

        [Required(ErrorMessage = "You need to select Quadrant")]
        public string Quadrant { get; set; }

        public string? Category { get; set; }

        public bool? Completed { get; set; }
    }
}
