using System.ComponentModel.DataAnnotations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace LocalMythGuide.Models
{
    [Supabase.Postgrest.Attributes.Table("lore_submissions")]
    public class LoreSubmission : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide the name of the legend.")]
        [Column("title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Column("location")]
        public string Location { get; set; } = string.Empty;

        [Required]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "The story must be between 20 and 500 characters.")]
        [Column("story")]
        public string Story { get; set; } = string.Empty;
    }
}