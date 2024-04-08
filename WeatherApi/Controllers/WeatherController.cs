using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private static readonly Dictionary<string, Weather> _weatherData = new Dictionary<string, Weather>()
        {
            { "Trichy",  new Weather { City = "Trichy", Description = "Sunny", Temperature = 32.0, Humidity = 60, WindSpeed = 5.0 } },
            { "Madurai", new Weather { City = "Madurai", Description = "Partly Cloudy", Temperature = 28.5, Humidity = 70, WindSpeed = 3.0 } },
            { "Karur",   new Weather { City = "Karur", Description = "Clear", Temperature = 30.0, Humidity = 55, WindSpeed = 7.0 } },
            { "Coimbatore", new Weather { City = "Coimbatore", Description = "Cloudy", Temperature = 25.0, Humidity = 80, WindSpeed = 2.0 } },
            { "Chennai",  new Weather { City = "Chennai", Description = "Hazy", Temperature = 35.0, Humidity = 75, WindSpeed = 6.0 } },
            { "Kanyakumari", new Weather { City = "Kanyakumari", Description = "Rainy", Temperature = 27.0, Humidity = 90, WindSpeed = 10.0 } }
        };

        [HttpGet]
        public IActionResult GetAllWeather()
        {
            return Ok(_weatherData.Values);
        }

        [HttpGet("{city}")]
        public IActionResult GetWeather(string city)
        {
            if (_weatherData.ContainsKey(city))
            {
                return Ok(_weatherData[city]);
            }
            return NotFound("Weather data not found for the specified city.");
        }

        [HttpGet("{city}/details")]
        public IActionResult GetWeatherDetails(string city)
        {
            if (_weatherData.ContainsKey(city))
            {
                return Ok(_weatherData[city]);
            }
            return NotFound("Weather details not found for the specified city.");
        }
    }
}
