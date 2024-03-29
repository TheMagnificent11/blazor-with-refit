﻿namespace BlazorWithRefit.Contracts;

public record WeatherForecastDto(DateOnly Date, int TemperatureC, string Summary)
{
    public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);
}
