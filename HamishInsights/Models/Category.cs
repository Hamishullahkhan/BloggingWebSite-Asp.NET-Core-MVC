using System.ComponentModel.DataAnnotations;

namespace HamishInsights.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Category name is require")]
        [MaxLength(100, ErrorMessage = "The Category name exceed 100 characters")]
        public string Name { get; set; }


        public string? Description { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
