using BlazorWithRefit.Components;
using BlazorWithRefit.Contracts;
using BlazorWithRefit.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapGet("/api/weather-forecast", () =>
{
    var rng = new Random();
    var forecasts = Enumerable
        .Range(1, 5)
        .Select(x => new WeatherForecast(DateOnly.FromDateTime(DateTime.Now.AddDays(x)), rng.Next(-20, 55)))
        .Select(x => new WeatherForecastDto(x.Date, x.TemperatureC, x.Summary.ToString()))
        .ToArray();

    return forecasts;
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorWithRefit.Client._Imports).Assembly);

app.Run();
