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
                },
                new Myth { 
                    Id = 3, 
                    Title = "The Ghost Ship of Liloan", 
                    Location = "Bagacay Point, Liloan", 
                    ShortSummary = "A spectral galleon that appears during heavy northern storms.", 
                    FullStory = "Fishermen in the northern town of Liloan have long passed down tales of a glowing, spectral Spanish galleon that materializes during severe typhoons. It silently glides past the historic Bagacay Point Lighthouse, warning locals of treacherous waters. Some say it is crewed by the restless souls of sailors who perished on the jagged reefs centuries ago.", 
                    PracticalInfo = "The Bagacay Point Lighthouse is a great historical spot to visit during the day. Enjoy the local rosquillos while looking out over the Mactan Channel.",
                    ImageUrl = "https://images.unsplash.com/photo-1478827217976-7214a0556393?q=80&w=800&auto=format&fit=crop"
                },
                new Myth { 
                    Id = 4, 
                    Title = "Engkantos of the Falls", 
                    Location = "Cambugahay Falls, Siquijor", 
                    ShortSummary = "Nature spirits that fiercely protect cascading turquoise waters.", 
                    FullStory = "Siquijor is widely known as an island of mysticism. The enchanting multi-tiered Cambugahay falls are said to be guarded by Engkantos (nature spirits). Locals believe that these spirits maintain the pristine turquoise color of the water, and disrespectful visitors might find themselves lost in the surrounding jungle or stricken with sudden ailments.", 
                    PracticalInfo = "Siquijor is accessible via ferry from neighboring islands. Always ask permission before swimming and avoid loud, disruptive noises.",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTK3gL2J0ZATxqxq7mhuiNHWIauRcG8O4HvTaqi8AoCG9op_SJvpBBsDUg&s=10"
                },
                new Myth { 
                    Id = 5, 
                    Title = "Sirenas of the Shoal", 
                    Location = "Pescador Island, Moalboal", 
                    ShortSummary = "Enchanting merfolk who herd the legendary sardine run.", 
                    FullStory = "Before Moalboal became a world-famous diving destination, old fishermen spoke of Sirenas (mermaids) that inhabited the deep underwater caverns around Pescador Island. They were believed to be the guardians of the famous sardine run, singing hypnotic melodies to herd the massive schools of fish and punishing those who used destructive fishing methods.", 
                    PracticalInfo = "Moalboal is world-renowned for freediving and scuba diving. Always practice responsible tourism—do not touch the sea turtles or the corals.",
                    ImageUrl = "https://images.unsplash.com/photo-1551244072-5d12893278ab?q=80&w=800&auto=format&fit=crop"
                },
                new Myth { 
                    Id = 6, 
                    Title = "The Sigbin in the Canes", 
                    Location = "Sugarcane Estates, Negros", 
                    ShortSummary = "A shadowy creature that walks backward, hiding in the tall crops.", 
                    FullStory = "The Sigbin is a nocturnal creature resembling a hornless goat with large, flapping ears and a long, whip-like tail. It is said to walk backward with its head lowered between its hind legs. Folklore suggests they hide in sugarcane fields during the day and are secretly kept as familiars by wealthy landowners to bring them immense prosperity.", 
                    PracticalInfo = "If traversing rural fields at night, stay on well-lit paths. Many sugar estates are private property, so always stick to official tourist routes.",
                    ImageUrl = "https://images.unsplash.com/photo-1500382017468-9049fed747ef?q=80&w=800&auto=format&fit=crop"
                }
            };
        }

        public Myth? GetMythById(int id) => GetMyths().FirstOrDefault(m => m.Id == id);
    }
}