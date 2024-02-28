using BlazorWithRefit.Contracts;
using Refit;

namespace BlazorWithRefit.Client;

public interface IWeatherApi
{
    [Get("/api/weather-forecast")]
    Task<WeatherForecastDto[]> GetWeatherForecast(CancellationToken cancellationToken = default);
}
