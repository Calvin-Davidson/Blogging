using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    [DisplayName(displayName: "Some display name here")]
    public string? Summary { get; set; }
}