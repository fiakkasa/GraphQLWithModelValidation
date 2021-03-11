using GraphQLWithModelValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLWithModelValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly string[] _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly Random _random = new();

        [HttpGet]
        public IAsyncEnumerable<WeatherForecast> Get() =>
            Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = _random.Next(-20, 55),
                Summary = _summaries[_random.Next(_summaries.Length)]
            }).ToAsyncEnumerable();
    }
}
