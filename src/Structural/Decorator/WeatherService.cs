namespace Decorator
{
    public class WeatherService : IWeatherService
    {
        public string GetCurrentWeather()
        {
            return "Current Weather";
        }

        public string GetWeatherForecast()
        {
            return "Weather Forecast";
        }
    }
}