using HeimdallClient.Api;
using HeimdallClient.Client;
using HeimdallClient.Model;
using Microsoft.Extensions.Options;
using OidcFrontend.Configuration;

async Task BootstrapOauth2Clients(IClientApi clientApi)
{
    var existingClients = await clientApi.ClientsAsync();
    // if (!existingClients.Any(c => c.ClientId == "42"))
    {
        await clientApi.CreateClientAsync(new ModelClient(
            clientId: "demo",
            returnUris: new List<string> { "http://localhost:3000/signin" },
            postLogoutRedirectUris: new List<string> { "http://localhost:3000/signout"}, 
            clientSecrets: new List<string>()));
    }
}
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<HeimdallConfig>(builder.Configuration.GetSection(nameof(HeimdallConfig)));
builder.Services.AddSingleton(c => {
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

builder.Services.AddTransient<IAuthzApi, AuthzApi>();
builder.Services.AddTransient<IClientApi, ClientApi>();
builder.Services.AddTransient<ISessionApi, SessionApi>();


var app = builder.Build();

var clientApi = app.Services.GetService<IClientApi>();
await BootstrapOauth2Clients(clientApi);

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
