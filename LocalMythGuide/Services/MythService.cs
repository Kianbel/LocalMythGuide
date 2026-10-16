using LocalMythGuide.Models;

namespace LocalMythGuide.Services
{
    public class MythService
    {
        public List<Myth> GetMyths()
        {
            return new List<Myth>
            {
                new Myth { 
                    Id = 1, 
                    Title = "The Legend of Maria Cacao", 
                    Location = "Mount Lantoy, Argao", 
                    ShortSummary = "A mountain diwata who travels rivers in a golden ship.", 
                    FullStory = "According to local folklore, Maria Cacao is a diwata (fairy) who lives inside a cave in Mount Lantoy. She owns a massive cacao plantation and supposedly travels down the river in a golden ship to export her crops, causing the river to overflow and wash away bridges when she passes.", 
                    PracticalInfo = "Mount Lantoy is located in Argao. Visitors can hike the mountain, but local guides are required. Respect the natural surroundings to appease the spirits.",
                    ImageUrl = "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?q=80&w=800&auto=format&fit=crop" 
                },
                new Myth { 
                    Id = 2, 
                    Title = "The White Agta", 
                    Location = "Balete Trees, Central Visayas", 
                    ShortSummary = "A gentle giant residing in ancient trees holding centuries of secrets.", 
                    FullStory = "Unlike the fearsome kapre, the white Agta is often considered a guardian spirit of the ancient balete trees. Locals believe that asking permission before crossing their territory ensures safe passage through the dense forests.", 
                    PracticalInfo = "Never point directly at ancient trees when trekking. Simply say 'tabi-tabi po' (excuse me) when passing by.",
                    ImageUrl = "https://images.unsplash.com/photo-1448375240586-882707db888b?q=80&w=800&auto=format&fit=crop"
                }
            };
        }

        public Myth? GetMythById(int id) => GetMyths().FirstOrDefault(m => m.Id == id);
    }
}