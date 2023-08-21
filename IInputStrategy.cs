using WeatherSystem.Models;

namespace WeatherSystem
{
    public interface IInputStrategy
    {
        public WeatherStateDTO? GetWeatherDTO(string input);
    }
}