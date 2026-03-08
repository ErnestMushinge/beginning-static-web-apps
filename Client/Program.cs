using Client;
using Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<BlogpostSummaryService>();
builder.Services.AddScoped<BlogpostService>();

//For Local Azure Function Connection
//builder.Services.AddScoped(sp =>
//new HttpClient
//{
//    BaseAddress =
//new Uri(
//builder.Configuration["API_Prefix"]
//??
//builder.HostEnvironment.BaseAddress
//)
//}
//);

await builder.Build().RunAsync();
