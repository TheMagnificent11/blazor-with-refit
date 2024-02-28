# Blazor With Refit

## Purpose

Minimal repo using what appears to be the recommended way to use Refit with Blazor.

However, it doesn't work. The error is:

```
InvalidOperationException: Cannot provide a value for property 'WeatherApi' on type 'BlazorWithRefit.Client.Pages.Weather'. There is no registered service of type 'BlazorWithRefit.Client.IWeatherApi'.
```

## How to run

1. Clone the repo
2. Navigate to the repo directory
3. `dotnet run --project .\BlazorWithRefit\`
4. Open a browser and navigate to [https://localhost:7290](https://localhost:7290)
5. Click the "Weather" link in the nav bar

