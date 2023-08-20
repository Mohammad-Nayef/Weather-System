using WeatherSystem.Models;

namespace WeatherSystem
{
    public interface IInputStrategy
    {
        public WeatherDTO? GetWeatherDTO(string input);
    }
}