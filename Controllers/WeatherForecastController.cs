using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using my_dotnet_backend_service.Models;
using my_dotnet_backend_service.Services;

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
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            var forecasts = _weatherService.GetForecast();
            return Ok(forecasts);
        }
    }
}