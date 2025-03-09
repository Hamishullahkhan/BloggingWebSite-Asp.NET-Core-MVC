using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HamishInsights.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title is Require")]
        [MaxLength(400, ErrorMessage = "The Title cannot Exceed 400 characters ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Content is Require")]
        public string Content { get; set; }

        [Required(ErrorMessage = "The Author is Require")]
        [MaxLength(100, ErrorMessage = "The Name Cannot Exceed 100 Characters ")]
        public string Author { get; set; }

        [ValidateNever]
        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        [ValidateNever]
        public int CategoryId { get; set; }

        [ValidateNever]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ValidateNever]
        public ICollection<Comment> Comments { get; set; }

    }
}
