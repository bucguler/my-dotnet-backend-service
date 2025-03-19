using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using my_dotnet_backend_service.Models; // Corrected using directive to reference the WeatherForecast class
using my_dotnet_backend_service.Services; // Corrected using directive to reference the WeatherService class

namespace my_dotnet_backend_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherForecastController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherService.GetForecast();
        }
    }
}