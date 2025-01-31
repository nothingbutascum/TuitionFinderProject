using FSDProject1.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FSDProject1.Data;
using FSDProject1.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Configure database context
builder.Services.AddDbContextFactory<FSDProject1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FSDProject1Context") ?? throw new InvalidOperationException("Connection string 'FSDProject1Context' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add Blazor services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();

// Register Identity services
builder.Services.AddScoped<UserManager<FSDProject1User>>();
builder.Services.AddScoped<SignInManager<FSDProject1User>>();

// Configure authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

// Configure IdentityCore with roles
builder.Services.AddIdentityCore<FSDProject1User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<FSDProject1Context>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
});

// Configure email sender (mock implementation)
builder.Services.AddSingleton<IEmailSender<FSDProject1User>, IdentityNoOpEmailSender>();

var app = builder.Build();

// ✅ Seed admin user and roles
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<FSDProject1User>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    await SeedAdminAsync(userManager, roleManager);
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

app.Run();

// ✅ Function to Seed Admin User and Role
async Task SeedAdminAsync(UserManager<FSDProject1User> userManager, RoleManager<IdentityRole> roleManager)
{
    string adminRole = "Admin";
    string adminEmail = "admin@example.com";
    string adminPassword = "Admin@123"; // Change this securely

    // Create Admin Role if it doesn't exist
    if (!await roleManager.RoleExistsAsync(adminRole))
    {
        await roleManager.CreateAsync(new IdentityRole(adminRole));
    }

    // Create Admin User if it doesn't exist
    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
        adminUser = new FSDProject1User { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
        await userManager.CreateAsync(adminUser, adminPassword);
        await userManager.AddToRoleAsync(adminUser, adminRole);
    }
}
