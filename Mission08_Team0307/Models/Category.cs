using System.ComponentModel.DataAnnotations;

//Category Model
namespace Mission08_Team0307.Models
{
    public class Category
    {
        //Category ID is primary key in this table.
        [Key]
        [Required]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
