namespace LocalMythGuide.Models
{
    public class Myth
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string ShortSummary { get; set; } = string.Empty;
        public string FullStory { get; set; } = string.Empty;
        public string PracticalInfo { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty; // <-- Add this line
    }
}