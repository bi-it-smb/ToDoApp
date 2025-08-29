using Microsoft.EntityFrameworkCore;
using ToDoApp.Components;
using ToDoApp.Data;
using ToDoApp.Services; // Namespace für deinen DbContext

var builder = WebApplication.CreateBuilder(args);

// --- 1️⃣ Connection String aus appsettings.json verwenden ---
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// --- 2️⃣ DbContext hinzufügen ---
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(10, 6, 12))));

// --- 3️⃣ Razor Components hinzufügen ---
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<TaskService>();

var app = builder.Build();

// --- 4️⃣ HTTP request pipeline ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
