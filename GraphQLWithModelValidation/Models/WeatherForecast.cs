using System;

namespace GraphQLWithModelValidation.Models
{
    public class WeatherForecast
    {
        private int temperatureC;

        public DateTime Date { get; set; }

        public int TemperatureC
        {
            get { return temperatureC; }
            set
            {
                temperatureC = value;
                TemperatureF = 32 + (int)(TemperatureC / 0.5556);
            }
        }

        public int TemperatureF { get; set; }

        public string Summary { get; set; } = string.Empty;
    }
}
