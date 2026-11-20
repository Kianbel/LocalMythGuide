using LocalMythGuide.Models;

namespace LocalMythGuide.Services
{
    public class MythService
    {
        private readonly Supabase.Client _supabase;

        public MythService(Supabase.Client supabase)
        {
            _supabase = supabase;
        }

        public async Task<List<Myth>> GetMythsAsync()
        {
            var response = await _supabase.From<Myth>().Order("id", Supabase.Postgrest.Constants.Ordering.Ascending).Get();
            return response.Models;
        }

        public async Task<Myth?> GetMythByIdAsync(int id)
        {
            return await _supabase.From<Myth>().Where(m => m.Id == id).Single();
        }

        public async Task SubmitLoreAsync(LoreSubmission submission)
        {
            var myth = new Myth
            {
                Title = submission.Title,
                Location = submission.Location,
                ShortSummary = submission.Story.Length > 100
                    ? submission.Story.Substring(0, 100) + "..."
                    : submission.Story,
                FullStory = submission.Story,
                PracticalInfo = "Community-submitted legend. Always respect local customs when visiting.",
                ImageUrl = "https://images.unsplash.com/photo-1448375240586-882707db888b?q=80&w=800&auto=format&fit=crop"
            };

            await _supabase.From<Myth>().Insert(
                myth,
                new Supabase.Postgrest.QueryOptions
                {
                    Returning = Supabase.Postgrest.QueryOptions.ReturnType.Minimal
                });
        }
    }
}