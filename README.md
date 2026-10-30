# LocalMythGuide

**LocalMythGuide** is an interactive web application that bridges cultural tourism with local folklore. Built with C# and Blazor, it serves as a digital archive where travelers can uncover the untold myths, ancient spirits, and legends hidden behind familiar landmarks across the Central Visayas region and beyond. 

The application features a mystical, dark-themed UI with gamified interactive elements, allowing users to explore local lore through a dynamic discovery board and contribute their own regional ghost stories.

## Features

* **Interactive Discovery Board:** A responsive grid of flip-cards that reveal short summaries and locations of local myths (e.g., The Legend of Maria Cacao, The Ghost Ship of Liloan).
* **Deep Lore Exploration:** Dedicated story pages featuring full folklore accounts, immersive imagery, and practical "Traveler's Insights" for visiting the real-world landmarks safely and respectfully.
* **Community Lore Archive:** A built-in submission portal with form validation where locals and tourists can document and share new legends.
* **Thematic UI/UX:** A highly stylized, responsive interface utilizing glassmorphism, dark overlays, custom typography (Playfair Display & Poppins), and interactive hover mechanics.

## Tech Stack

* **Framework:** .NET 8.0 / Blazor Interactive Server
* **Language:** C# 12
* **Styling:** Custom CSS, Bootstrap 5, Google Fonts
* **Architecture:** Component-based UI with Dependency Injection (Service Pattern)

## Project Structure

```text
LocalMythGuide/
├── Components/
│   ├── Layout/          # MainLayout, NavMenu, and thematic CSS
│   ├── Pages/           # Home (Discovery Board), StoryDetails, CommunityLore
│   ├── _Imports.razor   # Global using directives
│   ├── App.razor        # Root HTML structure
│   └── Routes.razor     # Blazor routing configuration
├── Models/
│   ├── Myth.cs          # Data model for folklore entries
│   └── LoreSubmission.cs# Form model with data annotations for community entries
├── Services/
│   └── MythService.cs   # In-memory data service supplying the myths
├── wwwroot/
│   └── app.css          # Global thematic styling and animations
├── Program.cs           # Application entry point and service registration
└── LocalMythGuide.csproj
```

## Getting Started

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
* Visual Studio 2022, JetBrains Rider, or VS Code with the C# Dev Kit

### Installation & Execution

1. **Clone the repository** (if applicable) or navigate to the project directory:
   ```bash
   cd LocalMythGuide
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

4. **View the app:**
   Open your browser and navigate to `http://localhost:5149` (or the port specified in your terminal).

## Available Lore

The current database highlights rich Philippine folklore, particularly focused on the Visayas region:
* **The Legend of Maria Cacao** (Mount Lantoy, Argao)
* **The White Agta** (Balete Trees, Central Visayas)
* **The Ghost Ship of Liloan** (Bagacay Point, Liloan)
* **Engkantos of the Falls** (Cambugahay Falls, Siquijor)
* **Sirenas of the Shoal** (Pescador Island, Moalboal)
* **The Sigbin in the Canes** (Sugarcane Estates, Negros)

## Contributing

To contribute to the codebase or add new features:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/NewLoreFeature`).
3. Commit your changes (`git commit -m 'Add interactive map component'`).
4. Push to the branch (`git push origin feature/NewLoreFeature`).
5. Open a Pull Request.

---
*Built to keep the whispers of the land alive.*
