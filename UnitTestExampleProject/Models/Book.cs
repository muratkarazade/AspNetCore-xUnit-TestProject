using System.ComponentModel.DataAnnotations;

namespace ExampleAPI.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
