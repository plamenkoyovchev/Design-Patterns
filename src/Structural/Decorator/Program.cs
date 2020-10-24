using System;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var weatherService = new WeatherServiceConsoleLoggerDecorator(
                                        new WeatherService());

            Console.WriteLine(weatherService.GetCurrentWeather());
            Console.WriteLine(weatherService.GetWeatherForecast());
        }
    }
}
