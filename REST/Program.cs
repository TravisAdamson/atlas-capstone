using REST.Components;
using RESTDB.Data;
using Microsoft.EntityFrameworkCore;
using REST.Services;
using RESTDB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<UserState>();

builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseMySql(
		builder.Configuration.GetConnectionString("DefaultConnection"),
		new MySqlServerVersion(new Version(8, 0, 36)) // Update to match system
	));

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.User.RequireUniqueEmail = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders()
.AddDefaultUI();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login"; // ✅ This is the missing part
    options.AccessDeniedPath = "/AccessDenied";
});

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
