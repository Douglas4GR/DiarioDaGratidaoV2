using DiarioDaGratidaoV2.Client.Services;
using DiarioDaGratidaoV2.Shared.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<INotaRepository, NotaService>();
builder.Services.AddScoped<ICorRepository, CorService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();
