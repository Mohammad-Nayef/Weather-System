using WeatherSystem.Models;

namespace WeatherSystem
{
    public interface IWeatherInputStrategy
    {
        public WeatherStateDTO? GetWeatherDTO(string input);
    }
}