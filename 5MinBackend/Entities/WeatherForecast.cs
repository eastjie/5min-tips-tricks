namespace _5MinBackend.Entities;

public class WeatherForecast
{
    public Guid Id { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public WeatherForecast()
    {
        Id = Guid.NewGuid();
    }
}
