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

// ✅ FIX: Remove generic type argument for IdentityRevalidatingAuthenticationStateProvider
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// ✅ FIX: Register UserManager & SignInManager
builder.Services.AddScoped<UserManager<FSDProject1User>>();
builder.Services.AddScoped<SignInManager<FSDProject1User>>();

// Configure authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

// Configure IdentityCore
builder.Services.AddIdentityCore<FSDProject1User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()  // ✅ Add roles if needed
    .AddEntityFrameworkStores<FSDProject1Context>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Configure email sender (mock implementation)
builder.Services.AddSingleton<IEmailSender<FSDProject1User>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

app.Run();
