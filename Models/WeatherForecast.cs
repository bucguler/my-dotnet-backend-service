using System;

namespace my_dotnet_backend_service.Models
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; } = string.Empty; // Initialize with a default value
    }
}