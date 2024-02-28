using BlazorWithRefit.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddRefitClient<IWeatherApi>();

var app = builder.Build();

await app.RunAsync();
