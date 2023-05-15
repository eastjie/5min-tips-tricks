using _5MinBackend.Data;
using _5MinBackend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _5MinBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MyDbContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MyDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetWeatherForecasts()
    {
        return Ok(await _context.WeatherForecasts.ToListAsync());
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public async Task<ActionResult<WeatherForecast>> PostWeatherForecast([FromBody] WeatherForecast weatherForecast)
    {
        await _context.WeatherForecasts.AddAsync(weatherForecast);
        await _context.SaveChangesAsync();
        return Ok(weatherForecast);
    }
    
}
