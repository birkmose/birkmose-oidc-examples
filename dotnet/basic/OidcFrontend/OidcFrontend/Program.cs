using HeimdallClient.Api;
using HeimdallClient.Model;
using Microsoft.Extensions.Options;
using OidcFrontend.Configuration;

// Helper method to create a public oidc client registration with Heimdall
async Task BootstrapOauth2Clients(IClientApi clientApi, PublicOidcClientConfig config)
{
    var foo = new Heimdall.HeimdallClient("http://127.0.0.1:8090", new HttpClient());
    var clients = await foo.ClientsAsync();
    await clientApi.CreateClientAsync(new ModelClient(
        clientId: config.ClientId,
        returnUris: config.ReturnUris,
        postLogoutRedirectUris: config.PostLogoutRedirectUris,
        clientSecrets: new List<string>()));
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Make configurations available for dependency injection
builder.Services.Configure<HeimdallConfig>(builder.Configuration.GetSection(nameof(HeimdallConfig)));
builder.Services.Configure<IdpConfig>(builder.Configuration.GetSection(nameof(IdpConfig)));
builder.Services.Configure<PublicOidcClientConfig>(builder.Configuration.GetSection(nameof(PublicOidcClientConfig)));

// Create configuration singleton for Heimdall backchannel api
builder.Services.AddSingleton(c =>
{
    var config = c.GetService<IOptions<HeimdallConfig>>().Value;

    return new HeimdallClient.Client.Configuration
    {
        BasePath = config.ServerRoot,
        ApiKey = new Dictionary<string, string>()
        {
            ["X-API-KEY"] = config.ApiKey,
        }
    };
});

// Register various backchannel apis
builder.Services.AddTransient<IAuthzApi, AuthzApi>();
builder.Services.AddTransient<IClientApi, ClientApi>();
builder.Services.AddTransient<ISessionApi, SessionApi>();

// Build app
var app = builder.Build();

// Create public client registration in Heimdall
var clientApi = app.Services.GetService<IClientApi>();
var publicOidcClientConfig = app.Services.GetService<IOptions<PublicOidcClientConfig>>().Value;
await BootstrapOauth2Clients(clientApi, publicOidcClientConfig);

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
