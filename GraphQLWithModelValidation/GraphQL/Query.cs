using GraphQLWithModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLWithModelValidation.GraphQL
{
    public class Query
    {
        private readonly string[] _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly Random _random = new();

        public IEnumerable<WeatherForecast> GetForecasts() =>
            Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = _random.Next(-20, 55),
                Summary = _summaries[_random.Next(_summaries.Length)]
            });

        public Sample? GetSample(string test, int count, Sample obj, Sample obj1, Sample obj2) => obj;
    }
}
