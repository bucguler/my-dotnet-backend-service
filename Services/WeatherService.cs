using System;
using System.Collections.Generic;
using my_dotnet_backend_service.Models; // Corrected using directive to reference the WeatherForecast class

namespace my_dotnet_backend_service.Services
{
    public class WeatherService
    {
        public IEnumerable<WeatherForecast> GetForecast()
        {
            var rng = new Random();
            return new List<WeatherForecast>
            {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = rng.Next(-20, 55), Summary = "Sunny" },
                new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = rng.Next(-20, 55), Summary = "Cloudy" },
                new WeatherForecast { Date = DateTime.Now.AddDays(2), TemperatureC = rng.Next(-20, 55), Summary = "Rainy" }
            };
        }
    }
}