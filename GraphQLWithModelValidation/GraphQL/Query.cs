using DataAnnotatedModelValidations;
using GraphQLWithModelValidation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

#pragma warning disable RCS1163 // Unused parameter.
        public Sample? GetSample(
            [MinLength(2)] string test,
            [Range(0, 10)] int count,
            [IgnoreModelValidation] Sample obj,
            Sample obj1,
            Sample obj2
        ) => obj;
#pragma warning restore RCS1163 // Unused parameter.
    }
}
