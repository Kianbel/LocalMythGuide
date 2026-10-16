using System.ComponentModel.DataAnnotations;

namespace LocalMythGuide.Models
{
    public class LoreSubmission
    {
        [Required(ErrorMessage = "Please provide the name of the legend.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "The story must be between 20 and 500 characters.")]
        public string Story { get; set; } = string.Empty;
    }
}