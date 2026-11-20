using LocalMythGuide.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped(_ =>
{
    var url = builder.Configuration["Supabase:Url"]
        ?? throw new InvalidOperationException("Supabase:Url is missing");
    var key = builder.Configuration["Supabase:Key"]
        ?? throw new InvalidOperationException("Supabase:Key is missing");

    return new Supabase.Client(url, key, new Supabase.SupabaseOptions
    {
        AutoRefreshToken = false,
        AutoConnectRealtime = false
    });
});

builder.Services.AddScoped<LocalMythGuide.Services.MythService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();