using System;

namespace Decorator
{
    public class WeatherServiceConsoleLoggerDecorator : IWeatherService
    {
        private readonly IWeatherService weatherService;
        public WeatherServiceConsoleLoggerDecorator(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        public string GetCurrentWeather()
        {
            Console.WriteLine("Getting current weather ... ");
            var weather = this.weatherService.GetCurrentWeather();

            return weather;
        }

        public string GetWeatherForecast()
        {
            Console.WriteLine("Getting weather forecast ... ");
            var forecast = this.weatherService.GetWeatherForecast();

            return forecast;
        }
    }
}