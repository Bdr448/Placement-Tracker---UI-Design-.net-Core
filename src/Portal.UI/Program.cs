using Portal.UI.Components;
using Portal.UI.Services;
using BusinessLogic;
using BusinessLogic.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register all services
builder.Services.AddSingleton<DataProcessor>();
builder.Services.AddSingleton<AuthState>();
builder.Services.AddSingleton<AuthenticationService>();
builder.Services.AddSingleton<CompanyService>();
builder.Services.AddSingleton<ApplicationService>();
builder.Services.AddSingleton<NotificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run(); 
// ok np jo late thse evu lagse to tne kai dais 
// ohk 
// mane bau bhukh laagi chhe 
// same here 
// kaik lavy padse nasto
// ha pn ena maater niche javu padsse 
// na niche bi kai saar nthi hoto 
// toh evu hase toh mangai laisu blinkit and all
// yeaaaa 
// bas have thodi j var chhe
// ha pachi bhega j thaiye chie 
// yad aavyu mari jode chana padya chhe 
// bas toh toh best
// session  ma khasuuu
// yaaaaaa
// chalo byereeeeeeeee
// okiee tataaaaaaaa
// tataaaaaaaaaaaaa