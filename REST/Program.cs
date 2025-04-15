using REST.Components;
using RESTDB.Data;
using Microsoft.EntityFrameworkCore;
using REST.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<GlobalState>();
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents(); // Razor components contain antiforgery

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseMySql(
		builder.Configuration.GetConnectionString("DefaultConnection"),
		new MySqlServerVersion(new Version(8, 0, 36)) // Update to match system
	));

var app = builder.Build();

// Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // Default HSTS value = 30 days, might be altered for production https://aka.ms/aspnetcore-hsts
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
