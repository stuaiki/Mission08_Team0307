using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Create new model called TaskEntry
namespace Mission08_Team0307.Models
{
    public class TaskEntry
    {
        //TaskId is Primary key
        [Key]
        [Required] //Required component
        public int TaskId { get; set; }

        [Required(ErrorMessage = "You need to put Task Name")] // required component and show message if it's invalid value
        public string Task { get; set; }

        public DateOnly? DueDate { get; set; } //nullable value

        [Required(ErrorMessage = "You need to select Quadrant")] // required component and show message if it's invalid value
        public string Quadrant { get; set; }

        [ForeignKey("CategoryId")]

        public int? CategoryId { get; set; } //nullable value
        public Category? Category { get; set; }

        public bool? Completed { get; set; } //nullable value
    }
}
