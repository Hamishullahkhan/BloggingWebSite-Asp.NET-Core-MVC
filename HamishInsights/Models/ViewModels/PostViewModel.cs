using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HamishInsights.Models.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }

        [ValidateNever]
        [Display(Name = "Categories")]
        public IEnumerable<SelectListItem> Categories { get; set; }

        public IFormFile FeatureImage { get; set; }
    }
}
