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
            await _supabase.From<LoreSubmission>().Insert(
                submission,
                new Supabase.Postgrest.QueryOptions
                {
                    Returning = Supabase.Postgrest.QueryOptions.ReturnType.Minimal
                });
        }
    }
}