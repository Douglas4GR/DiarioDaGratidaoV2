using DiarioDaGratidaoV2.Client.Pages;
using DiarioDaGratidaoV2.Components;
using DiarioDaGratidaoV2.Context;
using DiarioDaGratidaoV2.Repositories;
using DiarioDaGratidaoV2.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<NotaContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<INotaRepository, NotaRepository>();

builder.Services.AddScoped<INotaRepository, NotaRepository>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseUrl").Value!)
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(DiarioDaGratidaoV2.Client._Imports).Assembly);

app.Run();
