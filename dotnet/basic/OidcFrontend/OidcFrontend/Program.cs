using Heimdall;
using Microsoft.Extensions.Options;
using OidcFrontend.Configuration;

// Helper method to create a public oidc client registration with Heimdall

async Task BootstrapOauth2Clients(PublicOidcClientConfig config, HeimdallClient client)
{
    var oidcClient = new Client
    {
        ClientId = config.ClientId,
        ReturnUris = config.ReturnUris,
        PostLogoutRedirectUris = config.PostLogoutRedirectUris,
    };
    try
    {
        await client.CreateClientAsync(oidcClient);
    }
    catch (HttpRequestException)
    {
        // Since this example is typically run using docker compose, the Heimdall container might
        // not be booted by the time we start the dotnet container - this is just a simple error handling of that potential race condition
        Console.WriteLine("Failed bootstraping OIDC clients - will retry in 2 seconds");
        Thread.Sleep(2000);
        await client.CreateClientAsync(oidcClient);
    }
}


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Make configurations available for dependency injection
builder.Services.Configure<HeimdallConfig>(builder.Configuration.GetSection(nameof(HeimdallConfig)));
builder.Services.Configure<IdpConfig>(builder.Configuration.GetSection(nameof(IdpConfig)));
builder.Services.Configure<PublicOidcClientConfig>(builder.Configuration.GetSection(nameof(PublicOidcClientConfig)));
builder.Services.AddHttpClient();

// Create HeimdallClient singleton
builder.Services.AddSingleton(c =>
{
    var client = c.GetService<HttpClient>();
    var config = c.GetService<IOptions<HeimdallConfig>>().Value;
    client.DefaultRequestHeaders.Add("X-API-KEY", config.ApiKey);
    var heimdallClient = new Heimdall.HeimdallClient(config.ServerRoot, client);
    return heimdallClient;
});


// Build app
var app = builder.Build();

// Create public client registration in Heimdall
var publicOidcClientConfig = app.Services.GetService<IOptions<PublicOidcClientConfig>>().Value;
var heimdallClient = app.Services.GetService<Heimdall.HeimdallClient>();
await BootstrapOauth2Clients(publicOidcClientConfig, heimdallClient);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
