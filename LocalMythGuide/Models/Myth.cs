using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace LocalMythGuide.Models
{
    [Table("myths")]
    public class Myth : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; } = string.Empty;

        [Column("location")]
        public string Location { get; set; } = string.Empty;

        [Column("short_summary")]
        public string ShortSummary { get; set; } = string.Empty;

        [Column("full_story")]
        public string FullStory { get; set; } = string.Empty;

        [Column("practical_info")]
        public string PracticalInfo { get; set; } = string.Empty;

        [Column("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}