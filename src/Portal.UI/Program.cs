using Portal.UI.Components;
using BusinessLogic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register simple services from BusinessLogic
builder.Services.AddSingleton<DataProcessor>();

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
// i know 
// su karache
// ? kai nai docs kholi ne besi chhu
// loko aaya chhe tara lab ma bau ?
// haa avya chhe bdha seniour 
// saru kehvay 
// taame loko ketla vaage aaya aaje ?
// aaje hu ekli j aavi hti jay nthi AAJ 9 vaage avya
// km late aavano chhe ?
// naa e 2 divas leave par chhe ena kai dada nu besnu ke evu kai chhe barmu ke evu khbr nai 
// achha hamne nai khbr km k hamne ene evu kai kidhu nathi haal
// ene status mukyu htu 
// achha joi lais 
// atyare jatu rahyu hasheee
// vandho nai pachi kyarek 
// baki tare javama takleef hoy oth kehje muki jaiS
// hu ek var iskon pochi jav pachhi taklif nthi 
// tya sudhi nu j kau chhu 
// joiyeee 
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